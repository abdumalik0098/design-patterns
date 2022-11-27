using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Lib
{
    public interface IMeteoStation
    {
        void AddReceiver();
        void RemoveReceiver(int index);
        void SendDataToReceiver();
        string GetInfoAboutReceiver(int index);
        string GetStrData();
    }
}
