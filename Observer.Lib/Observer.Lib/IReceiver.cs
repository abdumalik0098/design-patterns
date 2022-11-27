using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Lib
{
    public interface IReceiver
    {
        void UpdateState(float temp, float wind);
        void ToReact();
        string GetStringData();
    }
}
