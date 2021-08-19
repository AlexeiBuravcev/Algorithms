using System;

namespace ConsoleApp
{
    public class Program
    {
        // Naive method to find a pair in an array with a given sum
        public static void FindPair(int[] A, int target)
        {
            // consider each element except the last
            for (var i = 0; i < A.Length - 1; i++)
            {
                // start from the i'th element until the last element
                for (var j = i + 1; j < A.Length; j++)
                {
                    // if the desired sum is found, print it
                    if (A[i] + A[j] == target)
                    {
                        Console.WriteLine("Pair found (" + A[i].ToString() + ", " + A[j].ToString() + ")");
                        return;
                    }
                }
            }
            // we reach here if the pair is not found
            Console.WriteLine("Pair not found");
        }

        public static void Main(String[] args)
        {
            int[] arr = {8 , 7 , 2 , 5 , 3 , 1};
            var target = 10;
            FindPair(arr, target);
            Console.ReadKey();
        }
    }
}