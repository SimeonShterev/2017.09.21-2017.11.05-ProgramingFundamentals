using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= num; rows++)
            {
                for (int columns = 1; columns <= rows; columns++)
                {
                    Console.Write(rows + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
