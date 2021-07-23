using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank.DataStructures.ReverseArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            var arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            var res = Result.ReverseArray(arr);

            textWriter.WriteLine(string.Join(" ", res));

            textWriter.Flush();
            textWriter.Close();
        }

        
    }

    public class Result
    {

        /*
         * Complete the 'reverseArray' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY a as parameter.
         */

        public static List<int> ReverseArray(List<int> a)
        {
            if (a == null)
                return null;
            var result = new List<int>();

            foreach (var item in a)
            {
                result.Insert(0, item);
            }

            return result;
        }

    }
}
