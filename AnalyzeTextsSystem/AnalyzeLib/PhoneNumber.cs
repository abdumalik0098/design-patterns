using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnalyzeLib
{
    public class PhoneNumber
    {
        public void SearchPhoneNumber(Dictionary<int, string[]> mydicwords)
        {
            string pattern = @"\d{1}-\d{3}-\d{3}-\d{2}-\d{2}";

            foreach (var item in mydicwords)
            {
                Console.WriteLine($"File {item.Key}:");
                for (int i = 0; i < item.Value.Length; i++)
                {
                    if (Regex.IsMatch(item.Value[i], pattern, RegexOptions.IgnoreCase))
                    {
                        Console.WriteLine(item.Value[i]);
                    }
                }
               
            }
        }
    }
}
