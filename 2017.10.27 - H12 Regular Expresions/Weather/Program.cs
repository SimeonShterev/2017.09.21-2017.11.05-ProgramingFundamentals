 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Z]{2})([0-9]{1,2}\.[0-9]{1,2})([a-zA-Z]+)\|";
            string sentance = Console.ReadLine();
            Dictionary<string, double> citiesTemp = new Dictionary<string, double>();
            Dictionary<string, string> citiesWeatherType = new Dictionary<string, string>();
            while(sentance!="end")
            {
                Regex regex = new Regex(pattern);
                if (regex.IsMatch(sentance))
                {
                    Match match = regex.Match(sentance);
                    string city = match.Groups[1].Value;
                    double temp = double.Parse(match.Groups[2].Value);
                    string weahterType = match.Groups[3].Value;
                    citiesTemp[city] = temp;
                    citiesWeatherType[city] = weahterType;
                }
                sentance = Console.ReadLine();
            }
            
            foreach (var city in citiesTemp.OrderBy(x=>x.Value))
            {
                Console.WriteLine($"{city.Key} => {city.Value:f2} => {citiesWeatherType[city.Key]}");
            }
        }
    }
}
