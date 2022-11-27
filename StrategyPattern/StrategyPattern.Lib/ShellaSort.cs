using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Lib
{
    public class ShellaSort : ISort
    {
        //метод для обмена элементов
        static void Swap(ref int a, ref int b)
        {
            var t = a;
            a = b;
            b = t;
        }
        public void GetSortNumbers(int[] arr)
        {
            //расстояние между элементами, которые сравниваются
            var d = arr.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < arr.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (arr[j - d] > arr[j]))
                    {
                        Swap(ref arr[j], ref arr[j - d]);
                        j = j - d;
                    }
                }

                d = d / 2;
            }

            Console.WriteLine("\nShell Sort: ");

            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
