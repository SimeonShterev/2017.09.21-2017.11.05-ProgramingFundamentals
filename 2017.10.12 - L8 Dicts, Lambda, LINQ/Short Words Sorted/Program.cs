using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().ToLower()
                .Split(new char[] { ' ', ',', '.', '(', ')', ']', '[', '"', '\\', '/', '!', '?', '\'' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var result = text.Distinct().Where(word => word.Length < 5).OrderBy(x => x);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
