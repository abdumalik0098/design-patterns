using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AnalyzeLib
{
    public class Scaner
    {
        public string Path { get; set; }
        public Scaner()
        {
            Path = Directory.GetCurrentDirectory() + "\\src\\";
        }
        public string[] TextsFromFiles()
        {
            string[] Listfiles = Directory.GetFiles(Path);
            string[] textfile = new string[Listfiles.Length];
            for (int i = 0; i < Listfiles.Length; i++)
            {
                using (FileStream fstream = File.OpenRead(Listfiles[i]))
                {
                    byte[] buffer = new byte[fstream.Length];
                    fstream.Read(buffer, 0, buffer.Length);
                    textfile[i] = Encoding.Default.GetString(buffer);
                   // textfile[i] = textfile[i].ToLower();
                    Console.WriteLine($"Текст из файла {i}: {textfile[i]}");
                    Console.WriteLine(new String('-',20));
                }

            }
            return textfile;
        }
    }
}
