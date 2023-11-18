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
        const int MODE_SENDLIGHT = 3;

        static int curMode;

        private System.Threading.Semaphore sm = new System.Threading.Semaphore(1, 1);

        private static SerialComms uartComms;
        private static string strRfidDetected = "";

        Pin lightPin = Pin.AnalogPin1;
        Pin PirMotionSensorPin = Pin.DigitalPin2;
        Pin buzzerPin = Pin.DigitalPin3;
        IButtonSensor button = DeviceFactory.Build.ButtonSensor(Pin.DigitalPin7);
        ILed ledRed = DeviceFactory.Build.Led(Pin.DigitalPin5);
        ILed ledGreen = DeviceFactory.Build.Led(Pin.DigitalPin6);

        int lightAdcValue = 800;
        int iPrevAdcValue = 800, iReadAdcValue, iDiff = 0;

        int sensorLightAdcValue;
        private bool buttonPressed = false;
        private bool prevButtonStatus = false;

        private bool lightDark = false;
        private bool prevLightDark = false;


        DataComms dataComms;
        string strDataReceived = "";

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


        private void Sleep(int NoOfMs)
        {
            Task.Delay(NoOfMs).Wait();

        }

        static void UartDataHandler(object sender, SerialComms.UartEventArgs e)
        {
            strRfidDetected = e.data;
            Debug.WriteLine("Card detected: " + strRfidDetected);
        }

        private void StartUart()
        {
            uartComms = new SerialComms();
            uartComms.UartEvent += new SerialComms.UartEventDelegate(UartDataHandler);

        }

        private void activateBuzzer(Pin pin, byte val)
        {
            sm.WaitOne();
            DeviceFactory.Build.GrovePi().AnalogWrite(pin, val);
            sm.Release();
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

        private void handleModeNormal()
        {

            ChangeLEDState(ledGreen, SensorStatus.On);

            Sleep(200);
            if (!strRfidDetected.Equals(""))
            {
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
                ChangeLEDState(ledRed, SensorStatus.Off);

            }
            strRfidDetected = "";

            if (buttonPressed == true)
            {
                buttonPressed = false;
                motionDetected = false;

                ChangeLEDState(ledGreen, SensorStatus.Off);
                curMode = MODE_ALARM;

                Debug.WriteLine("Entering MODE_ALARM");

                
            }
            if (strDataReceived.Equals("SENDLIGHT"))
            {
                curMode = MODE_SENDLIGHT;
                Debug.WriteLine("===Entering mode sendlight===");
            }
            strDataReceived = "";
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

        private void handleModeSendLight()
        {
            //Sleep(300);
            sensorLightAdcValue = getLight();
            Debug.WriteLine("Sensor light = " + sensorLightAdcValue);

            if (sensorLightAdcValue <= 100)
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

            if (strDataReceived.Equals("STOPLIGHT"))
            {
                strDataReceived = "";
                curMode = MODE_NORMAL;

            }
            strDataReceived = "";
            
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

        private int GetLightValue(Pin pin)
        {
            sm.WaitOne();
            int value = DeviceFactory.Build.GrovePi().AnalogRead(pin);
            sm.Release();
            return value;
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

            initComms();
            StartUart();

            Debug.WriteLine(strDataReceived);
            startButtonMonitoring();
            startMotionMonitoring();

            curMode = MODE_NORMAL;
            Debug.WriteLine("=== Entering MODE_NORMAL ===");

            while (true)
            {
                Sleep(300);

                

                if (curMode == MODE_NORMAL)
                {
                    handleModeNormal();
                }
                else if (curMode == MODE_ALARM)
                {
                    handleModeAlarm();
                }
                else if (curMode == MODE_SENDLIGHT)
                {
                    handleModeSendLight();
                }
                else
                {
                    Debug.WriteLine("Error: Invalid Mode!");
                }
            }

        }
    }
}
