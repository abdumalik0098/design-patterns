using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibDrink
{
    public abstract class Dobavka: Drink
    {
        protected Drink drink;
        /*public Drink SetToDrink
        {
            set { drink = value; }
        }*/
        public void SetToDrink(Drink drink)
        {
            this.drink = drink;
        }
    }
}
