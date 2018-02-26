using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"..\..\Input.txt");
            for(int i=0;i<lines.Length;i++)
            {
                File.AppendAllText(@"..\..\Output.txt", (i+1) + ". " + lines[i] + "\r\n");
            }
        }
    }
}
