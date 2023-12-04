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
        const int MODE_RFID = 4;

        static int curMode;

        private System.Threading.Semaphore sm = new System.Threading.Semaphore(1, 1);

        private static SerialComms uartComms;
        private static string strRfidDetected = "";

        Pin lightPin = Pin.AnalogPin1;
        Pin potPin = Pin.AnalogPin1;

        Pin PirMotionSensorPin = Pin.DigitalPin2;
        Pin buzzerPin = Pin.DigitalPin3;
        IButtonSensor button = DeviceFactory.Build.ButtonSensor(Pin.DigitalPin7);
        ILed ledRed = DeviceFactory.Build.Led(Pin.DigitalPin5);
        ILed ledGreen = DeviceFactory.Build.Led(Pin.DigitalPin6);
        Pin tempPin = Pin.AnalogPin0;
        Pin waterPin = Pin.AnalogPin2;
        IUltrasonicRangerSensor sensor = DeviceFactory.Build.UltraSonicSensor(Pin.DigitalPin8);

        double temp = 23;

        double sensorTemp;

        int lightAdcValue = 800;
        int iPrevAdcValue = 800, iReadAdcValue, iDiff = 0;

        int sensorLightAdcValue;
        private bool buttonPressed = false;
        private bool prevButtonStatus = false;

        private bool motionDetected = false;
        string motionData;

        private bool lightDark = false;
        private bool prevLightDark = false;

        private int distance = 400;
        int sensorDistance;

        const double EFSR = 5;
        const int N = 1023;

        DataComms dataComms;
        string strDataReceived = "";

        private SensorStatus GetLEDState(ILed led)
        {
            sm.WaitOne();
            SensorStatus sensorState = led.CurrentState;
            sm.Release();
            return sensorState;
        }

        private int getDistance()
        {
            sm.WaitOne();
            int distanceRead = sensor.MeasureInCentimeters();
            sm.Release();
            if (distanceRead < 400 && distanceRead > 0)
            {
                distance = distanceRead;
            }
            return distance;
        }

        private void ChangeLEDState(ILed led, SensorStatus targetState)
        {
            sm.WaitOne();
            led.ChangeState(targetState);
            sm.Release();
        }

        private int ReadPotValue(Pin pin)
        {
            sm.WaitOne();
            int val = DeviceFactory.Build.GrovePi().AnalogRead(pin);
            sm.Release();
            return val;
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


        int adcValue = 0;
        double Q = 0.0;
        double sensorVoltage = 0.0;

        private void handleModeNormal()
        {

            motionDetected = false;

            Sleep(200);
            if (!strRfidDetected.Equals(""))
            {
                activateBuzzer(buzzerPin, 60);
                ChangeLEDState(ledGreen, SensorStatus.On);
                ChangeLEDState(ledRed, SensorStatus.Off);
                Debug.WriteLine("one card is detected.");
                Debug.WriteLine("can you figure out how to check for a specific card? \n");
                Sleep(200);
                ChangeLEDState(ledGreen, SensorStatus.Off);
                ChangeLEDState(ledRed, SensorStatus.On);
                activateBuzzer(buzzerPin, 0);
                Sleep(200);
                ChangeLEDState(ledRed, SensorStatus.Off);

            }
            strRfidDetected = "";
            sensorMoistureAdcValue = getMoisture();
            Debug.WriteLine("Moisture is " + sensorMoistureAdcValue.ToString());
            sendDataToWindows("Moisture= " + sensorMoistureAdcValue.ToString());

            adcValue = ReadPotValue(potPin);
            Debug.WriteLine("Pot ADC = " + adcValue);

            Q = EFSR / N;
            sensorVoltage = adcValue * Q;
            Debug.WriteLine("Voltage= " + sensorVoltage.ToString("n2") + "V");
            sendDataToWindows("Voltage=" + sensorVoltage.ToString("n2"));

            sensorTemp = getTemp();
            Debug.WriteLine("Temp in degrees Celsius is " + sensorTemp.ToString("N2"));
            sendDataToWindows("Temp= " + sensorTemp.ToString("N2"));

            sensorDistance = getDistance();
            Debug.WriteLine("Sensor distance = " + sensorDistance);
            sendDataToWindows("Distance= " + sensorDistance);
            if (sensorDistance < 30)
            {
                Debug.WriteLine("There is object nearby");
            }
            


            // ChangeLEDState(ledGreen, SensorStatus.Off);
            Sleep(300);

            if (strRfidDetected == "")
            {
                if (motionDetected == true)
                {
                    motionData = "Motion detected";
                    sendDataToWindows("Motion=" + motionData);
                    sendDataToWindows("Alert=" + " detected");

                    Debug.WriteLine("Found Movement!");
                    Debug.WriteLine("=== Entering alarm mode ===");
                    ChangeLEDState(ledGreen, SensorStatus.On);
                    //Sleep(1000);

                    motionDetected = false;

                    curMode = MODE_ALARM;
                }
            }

            else
            {
                Sleep(500);
            }
           

            if (buttonPressed == true)
            {
                buttonPressed = false;


                ChangeLEDState(ledGreen, SensorStatus.Off);
                curMode = MODE_ALARM;
                motionData = "No motion detected";
                sendDataToWindows("Motion=" + motionData);
                Debug.WriteLine("Entering MODE_ALARM");

            }

            if (strDataReceived.Equals("SENDLIGHT"))
            {
                ChangeLEDState(ledGreen, SensorStatus.Off);
                curMode = MODE_SENDLIGHT;
                Debug.WriteLine("===Entering mode sendlight===");
            }

            if (strDataReceived.Equals("SCANRFID"))
            {
                curMode = MODE_RFID;
                Debug.WriteLine("===Entering mode handle RFID===");
            }

            strDataReceived = "";
        }

        private void handleModeAlarm()
        {
            //activateBuzzer(buzzerPin, 120);
            ChangeLEDState(ledGreen, SensorStatus.Off);
            ChangeLEDState(ledRed, SensorStatus.On);
            Sleep(1000);
            //activateBuzzer(buzzerPin, 0);
            ChangeLEDState(ledRed, SensorStatus.Off);
            Sleep(1000);

            if (buttonPressed == true)
            {
                motionDetected = false;
                ChangeLEDState(ledGreen, SensorStatus.On);
                motionData = "No motion detected";
                sendDataToWindows("Motion=" + motionData);
                Debug.WriteLine("=== Entering normal mode ===");
                buttonPressed = false;
                curMode = MODE_NORMAL;

            }
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

        private void handleRFIDdata()
        {
            ChangeLEDState(ledGreen, SensorStatus.On);

            Sleep(200);
            if (!strRfidDetected.Equals(""))
            {
                sendDataToWindows("RFID= " + strRfidDetected);
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

            if (strDataReceived == "STOPRFID")
            {
                handleModeNormal();
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


        

        private int ReadTempADC(Pin pin)
        {
            sm.WaitOne();
            int val = DeviceFactory.Build.GrovePi().AnalogRead(pin);
            sm.Release();
            return val;
        }

        private double getTemp()
        {
            int adcValue;
            double tempCalculated = 0, R;

            adcValue = ReadTempADC(tempPin);

            int B = 4250, R0 = 100000;
            R = 100000 * (1023.0 - adcValue) / adcValue;
            tempCalculated = 1 / (Math.Log(R / R0) / B + 1 / 298.15) - 273.15;

            if (!Double.IsNaN(tempCalculated) && tempCalculated > 15 && tempCalculated < 40)
            {
                temp = tempCalculated;
            }

            return temp;

        }

        int moistureAdcValue = 1023;

        private int sensorMoistureAdcValue;

        private int getMoisture()
        {
            int adcValue;

            sm.WaitOne();
            adcValue = DeviceFactory.Build.GrovePi().AnalogRead(waterPin);
            sm.Release();
            if (adcValue <= 1023)
            {
                moistureAdcValue = adcValue;
            }
            return 1023 - moistureAdcValue;

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

            ChangeLEDState(ledGreen, SensorStatus.On);

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
                else if (curMode == MODE_RFID)
                {
                    handleRFIDdata();
                }
                else
                {
                    Debug.WriteLine("Error: Invalid Mode!");
                }
            }

        }
    }
}
