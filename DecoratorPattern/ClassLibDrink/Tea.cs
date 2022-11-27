using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibDrink
{
    public class Tea : Drink
    {
        public string Type { get; set; }
        public int AmountLeaves { get; set; }
        public Tea(string name, double temp, double price, string type, int countLeaves)
        {
            base.name = name;
            base.price = price;
            base.temprature = temp;
            Type = type;
            AmountLeaves = countLeaves;
        }
        public Tea() : this("Green", 34.6, 99, "Super", 5) { }

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
