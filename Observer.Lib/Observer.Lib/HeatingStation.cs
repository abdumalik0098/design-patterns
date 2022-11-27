using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Lib
{
    public class HeatingStation : IReceiver
    {
        public float CurrentTemp { get; set; }
        public float MinTempForHeating { get; set; }
        public float TempHeating { get; set; }

        public HeatingStation()
        {
            MinTempForHeating = 5;
            TempHeating = 10;
        }

        public HeatingStation(float minTempForHeating, float tempHeating)
        {
            MinTempForHeating = minTempForHeating;
            TempHeating = tempHeating;
        }

        public void UpdateState(float temp, float wind)
        {
            CurrentTemp = temp;
        }

        public void ToReact()
        {
            if (CurrentTemp <= MinTempForHeating)
            {
                TempHeating += 10;
            }
        }

        public string GetStringData()
        {
            return String.Format($"Current Temprature: {CurrentTemp}/n" +
                $"Min Temp For Heating: {MinTempForHeating}/n" +
                $"Temp Heating: {TempHeating}/n");
        }
    }
}
