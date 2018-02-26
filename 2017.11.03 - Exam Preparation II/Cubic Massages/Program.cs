using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace Cubic_Massages
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> validMassages = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Over!")
                    break;
                int m = int.Parse(Console.ReadLine());
                string pattern = $@"(^\d+)([a-zA-Z]{{{m}}})([^a-zA-Z]*$)";
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string nonLetters = match.Groups[1].Value + match.Groups[3].Value;
                    List<int> indeces = new List<int>();
                    MakeListOfIndeces(indeces, nonLetters);
                    string massage = match.Groups[2].Value;
                    StringBuilder verificationCode = new StringBuilder();
                    GenerateVerificationCode(massage, indeces, verificationCode);
                    validMassages.Add(massage);
                    validMassages.Add(verificationCode.ToString());
                }
                else
                    continue;
            }
            for (int i = 0; i < validMassages.Count; i += 2)
            {
                string massage = validMassages[i];
                string validationCode = validMassages[i + 1];
                Console.WriteLine($"{massage} == {validationCode}");
            }
        }

        static void GenerateVerificationCode(string massage, List<int> indeces, StringBuilder verificationCode)
        {
            for (int i = 0; i < indeces.Count; i++)
            {
                int index = indeces[i];
                if (index < 0 || index >= massage.Length)
                {
                    verificationCode.Append(" ");
                }
                else
                {
                    verificationCode.Append(massage[index]);
                }
            }
        }

        static void MakeListOfIndeces(List<int> indeces, string nonLetters)
        {
            MatchCollection matchNums = Regex.Matches(nonLetters, "\\d");
            foreach (Match matchNum in matchNums)
            {
                int digit = int.Parse(matchNum.ToString());
                indeces.Add(digit);
            }
        }
    }
}
