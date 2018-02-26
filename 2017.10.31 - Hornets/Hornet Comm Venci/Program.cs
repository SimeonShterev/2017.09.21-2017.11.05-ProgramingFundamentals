using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Comm_Venci
{
    class Program
    {
        static void Main(string[] args)
        {
            string massagePattern = @"^(\d+) <-> ([0-9a-zA-Z]+)$";
            string broadCastPattern = @"^(\D+) <-> ([0-9a-zA-Z]+)$";
            List<string> broadcastList = new List<string>();
            List<string> massageList = new List<string>();
            while(true)
            {
                string input = Console.ReadLine();
                if(input=="Hornet is Green")
                {
                    break;
                }
                Match matchMassage = Regex.Match(input, massagePattern);
                Match matchBroadcast = Regex.Match(input, broadCastPattern);
                if(matchMassage.Success)
                {
                    char[] recipientch = matchMassage.Groups[1].Value.ToCharArray();
                    Array.Reverse(recipientch);
                    string recipient = new string(recipientch);
                    string massage = matchMassage.Groups[2].Value;
                    massageList.Add(recipient + " -> " + massage);
                }
                if(matchBroadcast.Success)
                {
                    char[] frequencych = matchBroadcast.Groups[2].Value.ToCharArray();
                    SwitchLetterCasing(frequencych);
                    string frequency = new string(frequencych);
                    string broadcastMassage = matchBroadcast.Groups[1].Value;
                    broadcastList.Add(frequency + " -> " + broadcastMassage);
                }
            }
            if(broadcastList.Count!=0)
            {
                Console.WriteLine("Broadcasts:");
                Console.WriteLine(string.Join("\n", broadcastList));
            }
            else
            {
                Console.WriteLine("Broadcasts:");
                Console.WriteLine("None");
            }
            if (massageList.Count != 0)
            {
                Console.WriteLine("Messages:");
                Console.WriteLine(string.Join("\n", massageList));
            }
            else
            {
                Console.WriteLine("Messages:");
                Console.WriteLine("None");
            }
        }

        static void SwitchLetterCasing(char[] frequency)
        {
            for (int i = 0; i < frequency.Length; i++)
            {
                if(frequency[i]>='A' && frequency[i]<='Z')
                {
                    frequency[i] = (char)(frequency[i] + 32);
                    continue;
                }
                if (frequency[i] >= 'a' && frequency[i] <= 'z')
                {
                    frequency[i] = (char)(frequency[i] - 32);
                }
            }
        }
    }
}
