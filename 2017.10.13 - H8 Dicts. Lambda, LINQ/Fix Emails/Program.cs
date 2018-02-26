using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> namesEmails = new Dictionary<string, string>();
            List<string> data = new List<string>();
            int count = 1;
            while(input!="stop")
            {
                data.Add(input);
                if(count%2!=0)
                {
                    namesEmails[data[count - 1]] = string.Empty;
                }
                if(count%2==0)
                {
                    namesEmails[data[count - 2]] = data[count - 1];
                    string[] uselessEmails = input.Split('.');
                    if(uselessEmails.Last()=="us" || uselessEmails.Last()=="uk")
                    {
                        namesEmails.Remove(data[count - 2]);
                    }
                }
                input = Console.ReadLine();
                count++;
            }
            foreach (var item in namesEmails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
