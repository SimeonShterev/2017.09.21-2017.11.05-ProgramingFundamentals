using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> data = new List<string>();
            for (int i = 0; i < n ; i++)
            {
                data.Add(Console.ReadLine());
            }
            string[] extensionPlusRoot = Console.ReadLine().Split(new string[] { " in " }, StringSplitOptions.RemoveEmptyEntries);
            string extension = "." + extensionPlusRoot[0];
            string root = extensionPlusRoot[1] + "\\";
            Dictionary<string, int> namePlusSize = new Dictionary<string, int>();
            for (int i = 0; i < data.Count; i++)
            {
                string[] pathPlusSize = data[i].Split(';');
                string filePath = pathPlusSize[0];
                int fileSize = int.Parse(pathPlusSize[1]);
                if(filePath.StartsWith(root) && filePath.EndsWith(extension))
                {
                    string fileName = filePath.Substring(filePath.LastIndexOf('\\') + 1);
                    namePlusSize[fileName] = fileSize;
                }
            }
            var orderedDict = namePlusSize.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            if(namePlusSize.Count()!=0)
            {
                foreach (var file in orderedDict)
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB ");
                }
            }
            else
                Console.WriteLine("No");
        }
    }
}
