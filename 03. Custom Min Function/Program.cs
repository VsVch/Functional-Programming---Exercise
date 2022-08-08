using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> printex = x => Console.WriteLine(x);
            Func<int[], int> min = x =>
            {
                int minValue = int.MaxValue;
                foreach (int n in x)
                {
                    if (n <= minValue) {minValue = n;}
                }
                return minValue;
            };
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            printex(min(nums));
        }
    }
}
