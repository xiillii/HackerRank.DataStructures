using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank.DataStructures.DynamicArray.LastAnswer
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int q = Convert.ToInt32(firstMultipleInput[1]);

            List<List<int>> queries = new List<List<int>>();

            for (int i = 0; i < q; i++)
            {
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            List<int> result = Result.DynamicArray(n, queries);

            textWriter.WriteLine(string.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
    
    public class Result
    {

        /*
         * Complete the 'dynamicArray' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. 2D_INTEGER_ARRAY queries
         */

        public static List<int> DynamicArray(int n, List<List<int>> queries)
        {
            var result = new List<int>();
            var lastAnswer = 0;
            var arr = new List<int>[n];

            for (var index = 0; index < arr.Length; index++)
            {
                arr[index] = new List<int>();
            }

            foreach (var query in queries)
            {
                var idx = (query[1] ^ lastAnswer) % n;
                switch (query[0])
                {
                    case 1:
                        
                        arr[idx].Add(query[2]);
                        break;
                    case 2:
                        var idy = query[2] % arr[idx].Count;
                        lastAnswer = arr[idx][idy];
                        result.Add(lastAnswer);
                        break;
                }
            }
            
            return result;
        }

    }
}