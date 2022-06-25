using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureMonitoring
{
    class Fish
    {
        string KindOfFish;
        int MaxStorageTemperature;
        int TimeExceededMaxTemperature;
        int MinStorageTemperature;
        int TimeExceededMinTemperature;
        bool isMinValue = false;
        int currentViolationMaxTem = 0;
        int currentViolationMinTem = 0;


        public Fish(string KindOfFish, int MaxStorageTemperature, int TimeExceededMaxTemperature)
        {
            this.KindOfFish = KindOfFish;
            this.MaxStorageTemperature = MaxStorageTemperature;
            this.TimeExceededMaxTemperature = TimeExceededMaxTemperature;
        }

        public Fish(string KindOfFish, int MaxStorageTemperature, int TimeExceededMaxTemperature,
            int MinStorageTemperature, int TimeExceededMinTemperature)
        {
            this.KindOfFish = KindOfFish;
            this.MaxStorageTemperature = MaxStorageTemperature;
            this.TimeExceededMaxTemperature = TimeExceededMaxTemperature;
            this.MinStorageTemperature = MinStorageTemperature;
            this.TimeExceededMinTemperature = TimeExceededMinTemperature;
            isMinValue = true;
        }

        public string CreateREport(TemperatureSensorReport tsReport)
        {
            string res = "";
            string resMin = "";
            string resMax = "";
            Dictionary<DateTime, int> TemperatureReport = tsReport.GetReport();
            foreach (var i in TemperatureReport)
            {
                if (i.Value > MaxStorageTemperature)
                {
                    currentViolationMaxTem += 10;
                    resMax += $"{i.Key}\t {i.Value}\t {MaxStorageTemperature}\t {i.Value - MaxStorageTemperature}\n";
                }
                else if (isMinValue && i.Value < MinStorageTemperature)
                {
                    currentViolationMinTem += 10;
                    resMin += $"{i.Key}\t {i.Value}\t {MinStorageTemperature}\t {i.Value - MinStorageTemperature}\n";
                }
            }
            if (currentViolationMaxTem > TimeExceededMaxTemperature || currentViolationMinTem > TimeExceededMinTemperature)
            {
                int time = currentViolationMaxTem > TimeExceededMaxTemperature ? currentViolationMaxTem : currentViolationMinTem;
                string MinMax = currentViolationMaxTem > TimeExceededMaxTemperature ? "максимально" : "минимально";
                res += $"Порог {MinMax} допустимой температуры превышен на {time} минут.\n";
                res += $"Время\t\t\t Факт\t Норма\t Отклонение\n";
                res += currentViolationMaxTem > TimeExceededMaxTemperature ? resMax : resMin; 
            }
            return res;
        }
    }
}
