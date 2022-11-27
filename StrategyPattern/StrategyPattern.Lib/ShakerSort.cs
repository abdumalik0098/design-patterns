using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Lib
{
    public class ShakerSort : ISort
    {
        //метод обмена элементов
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        public void GetSortNumbers(int[] arr)
        {
            for (var i = 0; i < arr.Length / 2; i++)
            {
                var swapFlag = false;
                //проход слева направо
                for (var j = i; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        swapFlag = true;
                    }
                }

                //проход справа налево
                for (var j = arr.Length - 2 - i; j > i; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        Swap(ref arr[j - 1], ref arr[j]);
                        swapFlag = true;
                    }
                }

                //если обменов не было выходим
                if (!swapFlag)
                {
                    break;
                }
            }

            Console.WriteLine("\nShaker Sort: ");

            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
