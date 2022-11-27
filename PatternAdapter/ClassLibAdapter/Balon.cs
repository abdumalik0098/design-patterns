using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibAdapter
{
    public class Balon
    {
        public double Volume { get; set; }
        public double Mass { get; set; }
        public double Molar { get; set; }

        public Balon(double volume, double mass, double molar)
        {
            Volume = volume;
            Mass = mass;
            Molar = molar;
        }

        public double GetPressure(int T)
        {
            double P = T + 273;
            return P;
        }
        public double AmmountOfMatter()
        {
            double n = Mass / Molar;
            return n;
        }
        public override string ToString()
        {
            return string.Format($"Molar: {Molar}\n" +
                $"Mass: {Mass}\n" +
                $"Volume: {Volume} \n" +
                $"");
        }
    }
}
