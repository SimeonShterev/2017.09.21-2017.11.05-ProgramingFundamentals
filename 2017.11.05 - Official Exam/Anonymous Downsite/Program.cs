using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberOfSites = long.Parse(Console.ReadLine());
            long securityKeys = long.Parse(Console.ReadLine());
            decimal totalLoss = 0.0m;
            BigInteger securityTokens = 1;
            for (int i = 0; i < numberOfSites; i++)
            {
                securityTokens *= securityKeys;
            }
            for (int i = 0; i < numberOfSites; i++)
            {
                string[] input = Console.ReadLine().Split(' ').Select(tokens => tokens.Trim()).ToArray();
                string siteName = input[0];
                long siteVisits = long.Parse(input[1]);
                decimal loss = decimal.Parse(input[2]);
                totalLoss = totalLoss + ((decimal)siteVisits * (decimal)loss);
                Console.WriteLine(siteName);
            }
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {securityTokens}");
        }
    }
}
