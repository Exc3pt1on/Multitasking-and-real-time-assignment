using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_1
{
    internal class Sensor
    {
        // Class for analog and digital sensors
        // Made by Kim Langvannskås
        // Last modified 27.01.2024

        double dVal;
        int sId;
        Random rSenVal;
        bool sDigital;
        int sampleRate;
        int maxDigits;
        public Sensor(int id, bool digital, int SampleRate = 1050, int ADC_ConverterBits = 28)
        {
            // Initializing a sensor
            sId = id;
            rSenVal = new Random(id);
            dVal = 1F;
            sDigital = digital;
            sampleRate = SampleRate;
            maxDigits = (int)Math.Pow(2, ADC_ConverterBits) - 1;
        }
        public int GetSampleRate()
        {
            return sampleRate;
        }
        public void UpdateValue()
        {
            // Updates value
            double nextVal = rSenVal.NextDouble();
            if (sDigital) 
            { 
                if (nextVal < 0.5) { dVal = 0; }
                else { dVal = 1; }
            }
            else
            {
                dVal += (nextVal * 0.2 - 0.1);
                if (dVal < 0.0) { dVal = 0.0; }
                else if (dVal > 3.3){ dVal = 3.3; }
                dVal = Math.Round(dVal / 3.3 * maxDigits);
            }
        }
        public double GetValue()
        {
            // Returns a new value for the sensor
            return dVal;
        }
        public int GetSensId()
        {
            // Returns id tag of sensor
            return sId;
        }
        public string GetName()
        {
            string name;
            if (sDigital)
            {
                name = "Digital" + sId.ToString();
            }
            else { name = "Analog" + sId.ToString(); }
            return name;
        }
    }
}
