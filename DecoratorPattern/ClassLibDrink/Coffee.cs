using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibDrink
{
    public class Coffee : Drink
    {
        public string Type { get; set; }
        public int Amount { get; set; }
        public Coffee(string name, double temp, double price, string type, int count)
        {
            base.name = name;
            base.temprature = temp;
            base.price = price;
            Type = type;
            Amount = count;
        }
        public Coffee():this("Latte", 36, 140, "x2", 11){}

        public override double GetPrice()
        {
            return price;
        }

        public override double GetTemprature()
        {
            return temprature;
        }
    }
}
