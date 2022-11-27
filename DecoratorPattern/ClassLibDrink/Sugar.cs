using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibDrink
{
    public class Sugar : Dobavka
    {
        public int AmountSpoon { get; set; }
        public Sugar(int countSpoon)
        {
            AmountSpoon = countSpoon;
        }
        public Sugar() : this(3) { }
        public override double GetPrice()
        {
            return (drink.GetPrice() + (AmountSpoon*3));
        }

        public override double GetTemprature()
        {
            return drink.GetTemprature()+2;
        }
    }
}
