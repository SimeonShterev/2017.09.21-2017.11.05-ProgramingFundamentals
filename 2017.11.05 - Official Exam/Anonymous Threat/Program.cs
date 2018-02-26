using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split(' ').Select(tokens => tokens.Trim()).ToList();
            while(true)
            {
                List<string> cmd = Console.ReadLine().Split(' ').Select(tokens => tokens.Trim()).ToList();
                if (cmd[0] == "3:1")
                    break;
                string mergeDevide = cmd[0];

                if(mergeDevide == "merge")
                {
                    int startIndex = int.Parse(cmd[1]);
                    int endIndex = int.Parse(cmd[2]);
                    MergeTokens(startIndex, endIndex, data);
                }
                if(mergeDevide == "divide")
                {
                    int index = int.Parse(cmd[1]);
                    int portions = int.Parse(cmd[2]);
                    DivideToken(index, portions, data);
                }
            }
            Console.WriteLine(string.Join(" ", data));

        }

        private static void DivideToken(int index, int portions, List<string> data)
        {
            string tokenToDivide = data[index];
            int count = tokenToDivide.Length;
            if(count%portions==0)
            {
                int lengthOfPieces = count / portions;
                for (int i = 0; i < portions; i++)
                {
                    StringBuilder pieces = new StringBuilder();
                    for (int j = 0; j < lengthOfPieces; j++)
                    {
                        pieces.Append(tokenToDivide[j]);
                    }
                    for (int j = 0; j < lengthOfPieces; j++)
                    {
                        tokenToDivide = tokenToDivide.Substring(1);
                    }
                    data.Insert(index + i, pieces.ToString());
                }
                data.RemoveAt(index + portions);
            }
            else
            {
                int left = count % portions;
                int lengthOfPieces = count / portions;
                for (int i = 0; i < portions; i++)
                {
                    StringBuilder pieces = new StringBuilder();
                    for (int j = 0; j < lengthOfPieces; j++)
                    {
                        pieces.Append(tokenToDivide[j]);
                    }
                    for (int j = 0; j < lengthOfPieces; j++)
                    {
                        tokenToDivide = tokenToDivide.Substring(1);
                    }
                    if(i==portions-1)
                    {
                        
                        pieces.Append(tokenToDivide);
                    }
                    data.Insert(index + i, pieces.ToString());
                }
                data.RemoveAt(index + portions);
            }
        }

        private static void MergeTokens(int startIndex, int endIndex, List<string> data)
        {
            if (startIndex < 0)
                startIndex = 0;
            if (endIndex >= data.Count)
                endIndex = data.Count - 1;
            if (startIndex >= data.Count)
                return;
            if (endIndex < 0)
                return;
            StringBuilder mergedTokens = new StringBuilder();
            for (int i = startIndex; i <= endIndex; i++)
            {
                mergedTokens.Append(data[i]);
            }
            for (int i = endIndex; i >= startIndex; i--)
            {
                data.RemoveAt(i);
            }
            data.Insert(startIndex, mergedTokens.ToString());
        }
    }
}
