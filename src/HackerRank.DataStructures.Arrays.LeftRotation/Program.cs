using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank.DataStructures.Arrays.LeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = Result.RotateLeft(d, arr);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
    
    public class Result
    {

        /*
         * Complete the 'rotateLeft' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER d
         *  2. INTEGER_ARRAY arr
         */

        public static List<int> RotateLeft(int d, List<int> arr)
        {
            var result = new List<int>(arr);

            for (var i = 0; i < d; i++)
            {
                // save the most left item
                var mostLeft = result[0];
                for (var index = 0; index < result.Count - 1; index++)
                {
                    result[index] = result[index + 1];
                }

                result[result.Count - 1] = mostLeft;
            }

            return result;
        }

    }
}