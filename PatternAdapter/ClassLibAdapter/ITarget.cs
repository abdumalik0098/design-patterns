using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibAdapter
{
    internal interface ITarget
    {
        void ModifVolume(double dV);
        double GetDp(int T1, int T2);
        string Passport();
    }
}
