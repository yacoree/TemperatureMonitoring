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
        }
    }
}
