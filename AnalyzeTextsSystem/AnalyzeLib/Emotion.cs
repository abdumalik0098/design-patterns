using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyzeLib
{
    public class Emotion
    {
        public string[] Positive = new string[]
        {
            "well",
            "deal",
            "quickly",
            "carefully"
        };
        public string[] Negative = new string[]
        {
            "disgusting",
            "rudeness",
            "cold",
            "bad"
        };

        public void IsEmotion(Dictionary<int, string[]> mydicwords)
        {
            
            foreach (var item in mydicwords)
            {
                int CountPos = 0;
                int CountNeg = 0;
                string res;
                for (int i = 0; i < item.Value.Length; i++)
                {
                    for (int j = 0; j < Positive.Length; j++)
                    {
                        if (Positive[j] == item.Value[i])
                        {
                            CountPos++;
                        }
                        else if (Negative[j] == item.Value[i])
                        {
                            CountNeg++;
                        }
                    }
                }
                if (CountPos>CountNeg)
                {
                    res = "POSITIVE";
                }
                else if (CountNeg > CountPos)
                {
                    res = "Negative";
                }
                else
                {
                    res = "Noun";
                }
                Console.WriteLine($"File {item.Key}: Positive {CountPos} and Negative {CountNeg}" +
                    $"  - is {res}");
            }
        }
    }
}
