using System;

namespace UtopianTree
{
    class Solution
    {
        private static readonly int springGrowthFactor = 2;
        private static readonly int summerGrowthFactor = 1;
        private static readonly int startingLength = 1;

        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            int[] results = new int[t];
            for (int i = 0; i < t; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                results[i] = CalculateGrowth(startingLength, n);
            }

            OutputResults(results, Console.WriteLine);
        }

        public static int CalculateGrowth(int startingLength, int growthCycles)
        {
            int totalLength = startingLength;

            for (int i = 1; i <= growthCycles; i++)
            {
                if (i % 2 > 0)
                {
                    totalLength = totalLength * springGrowthFactor;
                }
                else
                {
                    totalLength += summerGrowthFactor;
                }
            }

            return totalLength;
        }

        private static void OutputResults(int[] result, Action<string> output)
        {
            if (result == null)
            {
                return;
            }

            for (int i = 0; i < result.Length; i++)
            {
                output(result[i].ToString());
            }
        }
    }
}
