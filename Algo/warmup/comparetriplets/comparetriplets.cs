using System;

namespace CompareTriplets
{
    class Solution
    {
        static void Main(String[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);

            Score scoreA = new Score(a0, a1, a2);
            Score scoreB = new Score(b0, b1, b2);

            Console.Write(scoreA.Compare(scoreB));
            Console.Write(" ");
            Console.Write(scoreB.Compare(scoreA));
        }
    }
}
