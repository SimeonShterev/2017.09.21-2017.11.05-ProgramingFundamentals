using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
            string text = Console.ReadLine();
            string replaced = string.Empty;
            int count = 0;
            while(count!=bannedWords.Length)
            {
                replaced = text.Replace(bannedWords[count], new string('*', bannedWords[count].Length));
                text = replaced;
                count++;
            }
            Console.WriteLine(replaced);
        }
    }
}
