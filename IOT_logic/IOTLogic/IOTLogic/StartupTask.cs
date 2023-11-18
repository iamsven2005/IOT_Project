using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using Windows.ApplicationModel.Background;

// The Background Application template is documented at http://go.microsoft.com/fwlink/?LinkID=533884&clcid=0x409
using System.Diagnostics;
using System.Threading.Tasks;
using GrovePi;
using GrovePi.Sensors;


namespace IOTLogic
{
    public sealed class StartupTask : IBackgroundTask
    {

        const int MODE_NORMAL = 1;
        const int MODE_ALARM = 2;
        const int MODE_SCAN = 3;
        const int MODE_SENDLIGHT = 4;
        const int MODE_SENDBUTTON = 5;
        static int curMode;
        string strDataReceived = "";

        private System.Threading.Semaphore sm = new System.Threading.Semaphore(1, 1);

        private static SerialComms uartComms;
        private static string strRfidDetected = "";

        Pin PirMotionSensorPin = Pin.DigitalPin2;
        Pin buzzerPin = Pin.DigitalPin3;
        IButtonSensor button = DeviceFactory.Build.ButtonSensor(Pin.DigitalPin7);
        ILed ledRed = DeviceFactory.Build.Led(Pin.DigitalPin5);
        ILed ledGreen = DeviceFactory.Build.Led(Pin.DigitalPin6);
        Pin lightPin = Pin.AnalogPin1;

        DataComms dataComms;

        int lightAdcValue = 800;
        int iPrevAdcValue = 800, iReadAdcValue, iDiff = 0;

        int sensorLightAdcValue;
        private bool buttonPressed = false;
        private bool prevButtonStatus = false;

        private bool lightDark = false;
        private bool prevLightDark = false;

        public void commsDataReceive(string dataReceived)
        {
            strDataReceived = dataReceived;
            Debug.WriteLine("Data Received: " + strDataReceived);
        }

        private void sendDataToWindows(string strDataOut)
        {
            try
            {
                dataComms.sendData(strDataOut);
                Debug.WriteLine("Sending Msg: " + strDataOut);
            }
            catch (Exception)
            {
                Debug.WriteLine("ERROR. Did you forget to initComms()?");
            }
        }

        private void initComms()
        {
            dataComms = new DataComms();
            dataComms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsDataReceive);
        }

        


        private SensorStatus GetLEDState(ILed led)
        {
            sm.WaitOne();
            SensorStatus sensorState = led.CurrentState;
            sm.Release();
            return sensorState;
        }

        private void ChangeLEDState(ILed led, SensorStatus targetState)
        {
            sm.WaitOne();
            led.ChangeState(targetState);
            sm.Release();
        }

        private int GetLightValue(Pin pin)
        {
            sm.WaitOne();
            int value = DeviceFactory.Build.GrovePi().AnalogRead(pin);
            sm.Release();
            return value;
        }


        private int getLight()
        {
            iReadAdcValue = GetLightValue(lightPin);
            // Debug.WriteLine(iReadAdcValue);

            if (iPrevAdcValue > iReadAdcValue)
            {
                iDiff = iPrevAdcValue - iReadAdcValue;
            }
            else
            {
                iDiff = iReadAdcValue - iPrevAdcValue;
            }

            if (iDiff < 100)
            {
                lightAdcValue = iReadAdcValue;
            }

            lightAdcValue = iReadAdcValue;
            // Debug.WriteLine(lightAdcValue);

            return lightAdcValue;
        }

        private void handleModeSendLight()
        {
            if (sensorLightAdcValue <= 200)
            {
                lightDark = true;
            }
            else
            {
                lightDark = false;
            }

            if (prevLightDark != lightDark)
            {
                sendDataToWindows("LIGHT= " + sensorLightAdcValue);

            }
            prevLightDark = lightDark;

            if (strDataReceived.Equals("SENDBUTTON"))
            {
                curMode = MODE_SENDBUTTON;
                Debug.WriteLine("===Entering MODE_SENDBUTTON===");

            }
            strDataReceived = "";
        }




        private void Sleep(int NoOfMs)
        {
            Task.Delay(NoOfMs).Wait();

        }


        private void activateBuzzer(Pin pin, byte val)
        {
            sm.WaitOne();
            DeviceFactory.Build.GrovePi().AnalogWrite(pin, val);
            sm.Release();
        }



        private void StartUart()
        {
            
            uartComms = new SerialComms();
            uartComms.UartEvent += new SerialComms.UartEventDelegate(UartDataHandler);
            Debug.WriteLine(new SerialComms.UartEventDelegate(UartDataHandler) + "==");
            
        }

        string[] rfid_array = new string[1];

        static string extractRFIDdata(string rfid)
        {
            Debug.WriteLine("RFID: " + rfid);
            
            return rfid;
        }


        static void UartDataHandler(object sender, SerialComms.UartEventArgs e)
        {
            strRfidDetected = e.data;
            extractRFIDdata(strRfidDetected);
            Debug.WriteLine("Card detected: " + strRfidDetected);

        }



        private void soundBuzzer()
        {
            activateBuzzer(buzzerPin, 60);
            ChangeLEDState(ledRed, SensorStatus.Off);
            Sleep(80);
            activateBuzzer(buzzerPin, 120);
            ChangeLEDState(ledRed, SensorStatus.On);
            Sleep(80);
            activateBuzzer(buzzerPin, 60);
            ChangeLEDState(ledRed, SensorStatus.Off);
            Sleep(80);
            activateBuzzer(buzzerPin, 120);
            ChangeLEDState(ledRed, SensorStatus.On);
            Sleep(80);
            activateBuzzer(buzzerPin, 0);
            ChangeLEDState(ledRed, SensorStatus.Off);
            Sleep(2000);

        }

        private string GetButtonState(IButtonSensor btn)
        {
            sm.WaitOne();
            string buttonState = button.CurrentState.ToString();
            sm.Release();
            return buttonState;

        }

        

       

        private async void startButtonMonitoring()
        {
            await Task.Delay(100);
            while (true)
            {
                Sleep(100);
                string buttonState = GetButtonState(button);

                if (buttonState.Equals("On"))
                {
                    Sleep(100);
                    buttonState = GetButtonState(button);
                    if (buttonState.Equals("On"))
                    {
                        buttonPressed = true;
                    }
                }

            }
        }


        private bool motionDetected = false;

        private async void startMotionMonitoring()
        {
            await Task.Delay(100);
            while (true)
            {
                Sleep(100);
                sm.WaitOne();
                string motionState = DeviceFactory.Build.GrovePi().DigitalRead(PirMotionSensorPin).ToString();
                sm.Release();

                if (motionState.Equals("1"))
                {
                    motionDetected = true;
                    Task.Delay(3000).Wait();
                }
            }
        }

        private void handleModeNormal()
        {
            strDataReceived = "";

            ChangeLEDState(ledGreen, SensorStatus.On);

           
                if (sensorLightAdcValue <= 200)
                {
                    lightDark = true;
                }
                else
                {
                    lightDark = false;
                }

                if (prevLightDark != lightDark)
                {
                    sendDataToWindows("LIGHT= " + sensorLightAdcValue);

                }
                prevLightDark = lightDark;

                if (strDataReceived.Equals("SENDBUTTON"))
                {
                    curMode = MODE_SENDBUTTON;
                    Debug.WriteLine("===Entering MODE_SENDBUTTON===");

                }
                strDataReceived = "";

                Sleep(200);
                if (!strRfidDetected.Equals(""))
                {
                    
                    strRfidDetected = "";
                    activateBuzzer(buzzerPin, 60);
                    ChangeLEDState(ledGreen, SensorStatus.On);
                    ChangeLEDState(ledRed, SensorStatus.Off);
                    Debug.WriteLine("One Card is detected.");
                    Debug.WriteLine("Can you figure out how to check for a specific card? \n");
                    Sleep(200);
                    ChangeLEDState(ledGreen, SensorStatus.Off);
                    ChangeLEDState(ledRed, SensorStatus.On);
                    activateBuzzer(buzzerPin, 0);
                    Sleep(200);
                    ChangeLEDState(ledGreen, SensorStatus.On);
                    ChangeLEDState(ledRed, SensorStatus.Off);
                }


                if (strDataReceived.Equals("SCANRFID"))
                {
                    curMode = MODE_SCAN;
                    Debug.WriteLine("RFID scan mode active....");
                }

                strDataReceived = "";


                if (buttonPressed == true)
                {
                    buttonPressed = false;
                    // motionDetected = false;

                    curMode = MODE_ALARM;
                    ChangeLEDState(ledGreen, SensorStatus.Off);

                    Debug.WriteLine("Entering MODE_ALARM");
                    
                }

           

        }

        private void handleModeScan()
        {
            Debug.WriteLine("RFID scan mode active....");
            if (!strRfidDetected.Equals(""))
            {

                strRfidDetected = "";
                activateBuzzer(buzzerPin, 60);
                ChangeLEDState(ledGreen, SensorStatus.On);
                ChangeLEDState(ledRed, SensorStatus.Off);
                Debug.WriteLine("One Card is detected.");
                Debug.WriteLine("Can you figure out how to check for a specific card? \n");
                Sleep(200);
                ChangeLEDState(ledGreen, SensorStatus.Off);
                ChangeLEDState(ledRed, SensorStatus.On);
                activateBuzzer(buzzerPin, 0);
                Sleep(200);
                ChangeLEDState(ledGreen, SensorStatus.On);
                ChangeLEDState(ledRed, SensorStatus.Off);
                sendDataToWindows("RFID= " + strRfidDetected);

            }
            else
            { 
                if (strDataReceived.Equals("STOPRFID"))
                {
                    curMode = MODE_NORMAL;
                }
            }
    }


        private void handleModeAlarm()
        {
            soundBuzzer();


            if (!strRfidDetected.Equals(""))
            {
                curMode = MODE_NORMAL;
                Debug.WriteLine("Entering MODE_NORMAL");
            }
            strRfidDetected = "";
        }

        public void Run(IBackgroundTaskInstance taskInstance)
        {
            // 
            // TODO: Insert code to perform background work
            //
            // If you start any asynchronous methods here, prevent the task
            // from closing prematurely by using BackgroundTaskDeferral as
            // described in http://aka.ms/backgroundtaskdeferral
            //



            StartUart();

            startButtonMonitoring();
            startMotionMonitoring();

            curMode = MODE_NORMAL;
            Debug.WriteLine("=== Entering MODE_NORMAL ===");

            while (true)
            {
                initComms();
                Sleep(300);

                if (curMode == MODE_NORMAL)
                {
                    handleModeNormal();
                }
                else if (curMode == MODE_ALARM)
                {
                    handleModeAlarm();
                }
                else if (curMode == MODE_SCAN)
                {
                    handleModeScan();
                }
                else
                {
                    Debug.WriteLine("Error: Invalid Mode!");
                }
            }

        }
    }
}
