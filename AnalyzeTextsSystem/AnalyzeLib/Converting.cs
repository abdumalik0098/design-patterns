using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnalyzeLib
{
    public class Converting
    {
        public string[] Texts { get; set; }

        public Converting()
        {
            Texts = new Scaner().TextsFromFiles();
        }
        
        public Dictionary<int, string[]> ToWords()
        {
            var dicwords = new Dictionary<int, string[]>();

            for (int i = 0; i < Texts.Length; i++)
            {
                Texts[i] = Texts[i].ToLower();
                string[] words = Texts[i].Split(new char[] { ' ' });
                
                for (int j = 0; j < words.Length; j++)
                {
                    words[j] = words[j].TrimEnd(new char[] { '!', ',' });
                }
                dicwords.Add(i, words);
            }
            return dicwords;
        }
        
    }
}
