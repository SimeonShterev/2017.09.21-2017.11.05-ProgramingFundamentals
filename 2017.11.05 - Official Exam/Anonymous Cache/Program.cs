using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();
            List<string> dictKeys = new List<string>();
            while (true)
            {
                List<string> input = Console.ReadLine().Split(new string[] { " -> ", " | " }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
                if (input[0] == "thetinggoesskrra")
                    break;
                if (input.Count == 1)
                {
                    string dataSet = input[0];
                    dictKeys.Add(dataSet);
                    if (!data.ContainsKey(dataSet))
                    {
                        data.Add(dataSet, new List<string>());
                    }
                }
                else
                {
                    string dataKey = input[0];
                    string dataSize = input[1];
                    string dataSet = input[2];
                    if (!data.ContainsKey(dataSet))
                    {
                        data.Add(dataSet, new List<string>());
                        data[dataSet].Add(dataKey);
                        data[dataSet].Add(dataSize);

                    }
                    else
                    {
                        data[dataSet].Add(dataKey);
                        data[dataSet].Add(dataSize);
                    }

                }
            }
            Console.WriteLine();
            Dictionary<string, List<string>> dataCopy = new Dictionary<string, List<string>>(data);
            List<string> keysToRemove = new List<string>();
            dictKeys = dictKeys.Distinct().ToList();
            for (int i = 0; i < dictKeys.Count; i++)
            {
                dataCopy.Remove(dictKeys[i]);
            }
            foreach (var item in dataCopy)
            {
                keysToRemove.Add(item.Key);
            }
            for (int i = 0; i < keysToRemove.Count; i++)
            {
                data.Remove(keysToRemove[i]);
            }
            long biggestSum = 0L;
            List<string> highestValue = new List<string>();
            if(data.Count==0)
            {
                return;
            }
            foreach (var item in data)
            {
                long sum = 0L;
                for (int i = 1; i < item.Value.Count; i += 2)
                {
                    sum += long.Parse(item.Value[i]);
                }
                if (sum > biggestSum)
                {
                    StringBuilder sb = new StringBuilder();
                    biggestSum = sum;
                    sb.Append(item.Key + " ");
                    sb.Append(biggestSum + " ");
                    for (int i = 0; i < item.Value.Count; i++)
                    {
                        sb.Append(item.Value[i] + " ");
                    }
                    highestValue.Add(sb.ToString());
                }
            }
            List<string> result = highestValue[highestValue.Count - 1].Split(' ').Select(x => x.Trim()).ToList();
            result.RemoveAll(x => x == "");
            Console.WriteLine($"Data Set: {result[0]}, Total Size: {result[1]}");
            for (int i = 2; i < result.Count; i+=2)
            {
                Console.WriteLine($"$.{result[i]}");
            }
        }
    }
}

