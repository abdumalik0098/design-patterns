using ClassLibAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAdapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Balon balon = new Balon(12.3, 15.5, 87.2);
            Console.WriteLine(balon.ToString());
            Console.WriteLine("Давление в балоне " + balon.GetPressure(24));
            Console.WriteLine("Количество вещества " + balon.AmmountOfMatter());
            Console.WriteLine(new String('-',15));

            AdapterBalon adapterBalon = new AdapterBalon(12.7, 15.5, 82.2);
            Console.WriteLine("Изменение давление в балоне " + adapterBalon.GetDp(23,30));
            adapterBalon.ModifVolume(adapterBalon.Volume);
            Console.WriteLine("Изменение объема в балоне " + adapterBalon.Volume);
            Console.WriteLine(adapterBalon.Passport());


            Console.ReadKey();
        }
    }
}
