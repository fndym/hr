using System;

namespace minmax
{
    class Solution
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] data = ConvertToNumericSet(input);

            MinMax minMax = new MinMax(data);

            Console.Write(minMax.ToString());
        }

        static int[] ConvertToNumericSet(string[] stringInput)
        {
            int[] result = new int[stringInput.Length];
            for (int i = 0; i < stringInput.Length; i++)
            {
                Int32.TryParse(stringInput[i], out result[i]);
            }

            return result;
        }
    }

    public class MinMax
    {
        private int[] rawData;
        private Int64 minTotal;
        private Int64 maxTotal;

        public MinMax(int[] dataSet)
        {
            this.rawData = dataSet;
            this.CalculateMinMax();
        }

        public Int64 GetMinTotal() 
        {
            return this.minTotal;
        }

        public Int64 GetMaxTotal()
        {
            return this.maxTotal;
        }

        public override string ToString()
        {
            return this.GetMinTotal().ToString() + " " + this.GetMaxTotal().ToString();
        }

        private void CalculateMinMax()
        {
            int runningMin = this.rawData[0];
            int runningMax = this.rawData[0];
            Int64 sum = 0;

            for(int i = 0; i < this.rawData.Length; i++)
            {
                int current = this.rawData[i];
                if (runningMin > current)
                {
                    runningMin = current;
                }

                if (runningMax < current)
                {
                    runningMax = current;
                }

                sum += current;
            }

            this.maxTotal = sum - runningMin;
            this.minTotal = sum - runningMax;
        }
    }
}
