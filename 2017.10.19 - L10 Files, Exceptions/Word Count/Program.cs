using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllText(@"..\..\text.txt").ToLower().Split(new char[] { '-', ',', ' ', '.', '?', '\'' }, StringSplitOptions.RemoveEmptyEntries);
            string[] words = File.ReadAllText(@"..\..\words.txt").ToLower().Split(' ');
            Dictionary<string, int> countwords = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                string key = words[i];
                countwords.Add(key, 0);
            }
            foreach (var word in text)
            {
                if (countwords.ContainsKey(word))
                {
                    countwords[word]++;
                }
            }
            File.WriteAllText(@"..\..\Output.txt", "");
            foreach (var item in countwords.OrderByDescending(v => v.Value))
            {
                File.AppendAllText(@"..\..\Output.txt", ($"{ item.Key} - {item.Value}" + "\r\n"));
            }
        }
    }
}
