using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnalyzeTextsSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FacadeLayer textapp = new FacadeLayer();
            textapp.EmotionInText();
            Console.WriteLine(new String('-',30));
            Console.WriteLine("Search phone numbers:");
            textapp.PhoneNumsInText();
            
            Console.ReadKey();
        }
    }
}
