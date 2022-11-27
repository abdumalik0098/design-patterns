using ClassLibDrink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkApp
{
    internal class Program
    {
        static void PrintData(Drink drink)
        {
            //Console.WriteLine($"Name:");
            Console.WriteLine($"Price {drink.GetPrice()}");
            Console.WriteLine($"Temprature {drink.GetTemprature()}");
            Console.WriteLine(new String('*',25));
        }

        static void TestDecorator()
        {
            Drink tea = new Tea();
            Console.WriteLine("Tea:");
            PrintData(tea);

            Dobavka sugar = new Sugar();
            sugar.SetToDrink(tea);
            Console.WriteLine("Tea with sugar:");
            PrintData(sugar);

            Drink coffee = new Coffee();
            Console.WriteLine("Coffee:");
            PrintData(coffee);

            Dobavka milk = new Milk();
            sugar.SetToDrink(coffee);
            milk.SetToDrink(sugar);

            Console.WriteLine("Coffee with milk and sugar:");
            PrintData(milk);
            
        }
        static void Main(string[] args)
        {
            TestDecorator();
            Console.ReadKey();
        }
    }
}
