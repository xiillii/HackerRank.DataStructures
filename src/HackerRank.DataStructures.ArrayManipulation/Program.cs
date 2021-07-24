using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank.DataStructures.ArrayManipulation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            var firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            var n = Convert.ToInt32(firstMultipleInput[0]);

            var m = Convert.ToInt32(firstMultipleInput[1]);

            var queries = new List<List<int>>();

            for (var i = 0; i < m; i++)
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList()
                    .Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());

            var result = Result.ArrayManipulation(n, queries);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

    public class Result
    {
        /*
         * Complete the 'arrayManipulation' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. 2D_INTEGER_ARRAY queries
         */

        public static long ArrayManipulation(int n, List<List<int>> queries)
        {
            var result = 0L;
            var arr = new long[n + 2];
            
            foreach (var query in queries)
            {
                var a = query[0];
                var b = query[1];
                var k = query[2];
                arr[a] += k;
                arr[b + 1] -= k;
            }

            result = GetMax(arr);
            return result;
        }

        private static long GetMax(long[] arr)
        {
            var max = long.MinValue;
            long sum = 0;

            foreach (var t in arr)
            {
                sum += t;
                max = Math.Max(max, sum);
            }

            return max;
        }
    }
}