using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank.DataStructures.HourGlassSum
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < 6; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.HourglassSum(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

    public class Result
    {

        /*
         * Complete the 'hourglassSum' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int HourglassSum(List<List<int>> arr)
        {
            var result = 0;

            for (int i = 0; i < arr.Count - 2; i++)
            {
                
            }

            return result;
        }

        /// <summary>
        /// summarizes 3x3 array:
        /// a b c
        ///   d
        /// e f g
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static int SumHourGlass3x3(List<List<int>> arr)
        {
            var result = 0;

            result += arr[0].Sum(i => i);
            result += arr[1][1];
            result += arr[2].Sum(i => i);

            return result;
        }

        private static List<List<int>> Get3x3Array(List<List<int>> arr, int row, int col)
        {

        }

    }
}
