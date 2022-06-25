using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureMonitoring
{
    class TemperatureSensorReport
    {
        DateTime startOfMeasurement;
        int[] temperature;

        public TemperatureSensorReport(string startOfMeasurement, string temperature)
        {
            this.startOfMeasurement = DateTime.ParseExact(startOfMeasurement, "dd.M.yyyy H:mm", null);
            string[] t = temperature.Split(" ");
            this.temperature = new int[t.Length];
            for (int i = 0; i < t.Length; i++)
            {
                this.temperature[i] = Int32.Parse(t[i]);
            }
        }

        public Dictionary<DateTime, int> GetReport()
        {
            Dictionary<DateTime, int> report = new Dictionary<DateTime, int>();
            for (int i = 0; i < temperature.Length; i++)
            {
                var j = startOfMeasurement.AddMinutes(10 * i);
                report.Add(j, temperature[i]);
            }
            return report;
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
