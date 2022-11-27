namespace Observer.Lib
{
    public class Station:IMeteoStation
    {
        List<IReceiver> Receivers { get; set; }
        public float Temprature { get; set; }
        public float SpeedWind { get; set; }

        public void AddReceiver()
        {
            IReceiver receiver = new EmergencyStation();
            Receivers.Add(receiver);
        }

        public void RemoveReceiver(int index)
        {
            if (index >= 0 && index < Receivers.Count)
            {
                Receivers.RemoveAt(index);
            }
        }

        public void SendDataToReceiver()
        {
            foreach (IReceiver receiver in Receivers)
            {
                receiver.UpdateState(Temprature, SpeedWind);
            }
        }

        public string GetInfoAboutReceiver(int index)
        {
            string result;
            result = Receivers[index].GetStringData();
            return result;
        }

        public string GetStrData()
        {
            return String.Format($"Temprature: {Temprature}/n" +
                $"Speed Wind: {SpeedWind}/n");
        }


    }
}