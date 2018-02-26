using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] oddLines = File.ReadAllLines(@"..\..\Input.txt");
            for(int i=0;i<oddLines.Length;i +=2)
            {
                File.AppendAllText(@"..\..\Output.txt", oddLines[i] + "\r\n");
            }
        }
    }
}
