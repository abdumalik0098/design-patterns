using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Lib
{
    public class ConcreteClassB: TemplateMethodArray
    {
        public override int SearchIndex(double[] arr)
        {
            double max = arr[0];
            int len = arr.Length;
            int lenpol = len / 2 + 1;
            for (int i = 0; i < lenpol; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
                if (max < arr[len - 1 - i])
                {
                    max = arr[i];
                }
            }
            int res = Array.IndexOf(arr, max);
            return res;
        }

        public override double SearchResult(double[] arr, double c)
        {
            int start = 0;
            double result = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < c)
                {
                    start = i;
                    break;
                }
            }
            for (int j = start; j < arr.Length; j++)
            {
                result *= arr[j];
            }

            return result;
        }
    }
}
