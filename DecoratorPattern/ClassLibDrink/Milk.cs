using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibDrink
{
    public class Milk : Dobavka
    {
        public int Amount { get; set; }
        public int Fatty { get; set; }

        public Milk(int amount, int fatty, double price)
        {
            Amount = amount;
            Fatty = fatty;
            base.price = price;
        }
        public Milk() : this(1, 32, 70) { }
        public override double GetPrice()
        {
            return drink.GetPrice() + price;
        }

        public override double GetTemprature()
        {
            return drink.GetTemprature() / Amount;
        }
    }
}
