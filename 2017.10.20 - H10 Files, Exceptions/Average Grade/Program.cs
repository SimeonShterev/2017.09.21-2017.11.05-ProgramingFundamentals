using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> data = new List<string>();
            string name = string.Empty;
            List<double> grades = new List<double>();
            double averageGrade = 0;
            List<string> names = new List<string>();
            List<double> avGrades = new List<double>();
            for (int i = 0; i < n; i++)
            {
                data = Console.ReadLine().Split(' ').ToList();
                name = data[0];
                for (int j = 1; j< data.Capacity; j++)
                {
                    grades.Add(double.Parse(data[j]));
                }
                averageGrade = grades.Average();
                if(averageGrade>=5.00)
                {
                    names.
                }
                grades.Clear();
            }
            
        }
    }
}
