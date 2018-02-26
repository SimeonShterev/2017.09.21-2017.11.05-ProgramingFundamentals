using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new char[] { '.', ',', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> sortedPalindromes = new List<string>();
            foreach (var word in text)
            {
                int count = 0;
                word.ToCharArray();
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == word[word.Length - 1 - i])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (count == word.Length)
                {
                    if(!sortedPalindromes.Contains(word))
                    sortedPalindromes.Add(word);
                }
            }
            sortedPalindromes.Sort();
            Console.WriteLine(string.Join(", ", sortedPalindromes));
        }
    }
}
