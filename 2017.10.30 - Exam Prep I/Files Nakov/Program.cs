using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Files_Nakov
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> allFiles = new List<string>();
            for (int i = 0; i < n; i++)
            {
                allFiles.Add(Console.ReadLine());
            }
            string filters = Console.ReadLine();
            string[] filterTokens = Regex.Split(filters, " in ");
            string filterExtension = "." + filterTokens[0];
            string filterRoot = filterTokens[1] + "\\";
            Dictionary<string, double> fileSize = new Dictionary<string, double>();
            foreach (var file in allFiles)
            {
                var filePlusSize = file.Split(';');
                var size = double.Parse(filePlusSize[1]);
                var path = filePlusSize[0];
                if (path.StartsWith(filterRoot) && path.EndsWith(filterExtension))
                {
                    var tokens = path.Split('\\');
                    var filename = tokens[tokens.Length - 1];
                    fileSize[filename] = size;
                }
            }
            var sortedOutputFiles = fileSize.OrderByDescending(fs => fs.Value).ThenBy(fs => fs.Key);
            foreach (var fs in sortedOutputFiles)
            {
                Console.WriteLine($"{fs.Key} - {fs.Value} KB ");
            }
            if (sortedOutputFiles.Count() == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
