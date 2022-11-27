using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Lib
{
    public class EmergencyStation : IReceiver
    {
        public float CurrentSpeedWind { get; set; }
        public float MaxSpeedWindStorm { get; set; }
        public Enum WindStatus { get; set; }
        public enum Status
        {
            Calmly,
            Storm
        }

        public EmergencyStation()
        {
            MaxSpeedWindStorm = 35.6F;
            WindStatus = Status.Calmly;
        }

        public EmergencyStation(float maxSpeedWindStorm, Enum windStatus)
        {
            MaxSpeedWindStorm = maxSpeedWindStorm;
            WindStatus = windStatus;
        }

        public void UpdateState(float temp, float wind)
        {
            CurrentSpeedWind = wind;
        }

        public void ToReact()
        {
            if (CurrentSpeedWind == MaxSpeedWindStorm)
            {
                WindStatus = Status.Storm;
            }
        }

        public string GetStringData()
        {
            return String.Format($"Max Speed Wind: {MaxSpeedWindStorm}/n" +
                $"Current Speed Wind: {CurrentSpeedWind}/n" +
                $"Status: {WindStatus}/n");
        }
    }
}
