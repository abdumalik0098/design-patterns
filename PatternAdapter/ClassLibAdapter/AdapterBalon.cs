using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibAdapter
{
    public class AdapterBalon : Balon, ITarget
    {
        
        public AdapterBalon(double volume, double mass, double molar) : base(volume, mass, molar)
        {
        }
      
        public void ModifVolume(double dV)
        {
           this.Volume = dV*2;
        }
        public double GetDp(int T1, int T2)
        {
            double sum = 0;
            for (int i = 0; i < T2-T1; i++)
            {
               sum += this.GetPressure(T1+i);
            }
            return sum;
        }


        public string Passport()
        {
            return this.ToString();
        }
    }
}
