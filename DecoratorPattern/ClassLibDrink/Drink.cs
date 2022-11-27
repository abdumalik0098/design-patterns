using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibDrink
{
    public abstract class Drink
    {
        protected string name;
        protected double temprature;
        protected double price;

        public abstract double GetTemprature();
        public abstract double GetPrice();

    }
}
