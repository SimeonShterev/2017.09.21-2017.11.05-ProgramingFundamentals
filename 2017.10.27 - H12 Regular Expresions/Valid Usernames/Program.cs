using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Za-z]\w{2,24}\b";
            string text = Console.ReadLine();
            MatchCollection matches = Regex.Matches(text, pattern);
            int lenghtOf2users = 0;
            int bestLenght = 0;
            string previousUser = string.Empty;
            string nextUser = string.Empty;
            string bestUser1 = string.Empty;
            string bestUser2 = string.Empty;
            foreach (Match match in matches)
            {
                previousUser = nextUser;
                nextUser = match.ToString();
                lenghtOf2users = previousUser.Length + nextUser.Length;
                if(bestLenght<lenghtOf2users)
                {
                    bestUser1 = previousUser;
                    bestUser2 = nextUser;
                    bestLenght = lenghtOf2users;
                }
            }
            Console.WriteLine(bestUser1);
            Console.WriteLine(bestUser2);
        }
    }
}
