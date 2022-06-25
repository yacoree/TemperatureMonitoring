using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureMonitoring
{
    class TemperatureSensorReport
    {
        DateTime startOfMeasurement;
        int[] temperature;

        public TemperatureSensorReport(string startOfMeasurement, int[] temperature)
        {
            this.startOfMeasurement = DateTime.ParseExact(startOfMeasurement, "dd.M.yy H:mm:ss", null);
            this.temperature = temperature;
        }

        public override string ToString()
        {
            string temperatures = "";
            for (int i = 0; i < temperature.Length; i++)
            {
                temperatures += temperature[i];
            }
            return $"{startOfMeasurement} - {temperatures}";
        }
    }
}
