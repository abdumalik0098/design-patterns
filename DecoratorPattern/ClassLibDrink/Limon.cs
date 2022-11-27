using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibDrink
{
    public class Limon : Dobavka
    {
        public int AmountDolek { get; set; }
        public Limon(int amountDolek)
        {
            AmountDolek = amountDolek;

        }
        public Limon() : this(2) { }
        public override double GetPrice()
        {
            return (drink.GetPrice() + (AmountDolek * 5));
        }

        public override double GetTemprature()
        {
            return drink.GetTemprature()-4;
        }
    }
}
