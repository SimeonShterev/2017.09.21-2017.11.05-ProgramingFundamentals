using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = { "Ivan", "ivanivan@abv.bg", "Petar Ivanov", "petartudjarov@abv.bg", "Mike Tyson", "myke@gmail.us", "stop" };
            File.WriteAllLines(@"..\..\Input.txt", inputArray);
            string input = File.ReadAllText(@"..\..\Input.txt");
            Dictionary<string, string> namesEmails = new Dictionary<string, string>();
            List<string> data = input.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            int count = 0;
            while (data[count]!="stop")
            {
                if (count % 2 == 0)
                {
                    namesEmails[data[count]] = string.Empty;
                }
                if (count % 2 != 0)
                {
                    namesEmails[data[count - 1]] = data[count];
                    string[] uselessEmails = data[count].Split('.');
                     if (uselessEmails.Last() == "us" || uselessEmails.Last() == "uk")
                    {
                        namesEmails.Remove(data[count - 1]);
                    }
                }
                count++;
            }
            foreach (var item in namesEmails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
                File.AppendAllText(@"..\..\Output.txt", $"{item.Key} -> {item.Value}" + "\r\n");
            }
        }
    }
}
