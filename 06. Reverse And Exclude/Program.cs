using System;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> reverse = x =>
            {
                int start = 0;
                int end = x.Length - 1;
                while (start < end)
                {
                    (x[start], x[end]) = (x[end], x[start]);
                    start++;
                    end--;
                }
            };

            Action<int[]> printex = x =>
            {
                reverse(x);
                Console.WriteLine(string.Join(" ", x));
            };

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            Func<int, bool> isDev = x => x % n != 0;
            nums = nums.Where(x => isDev(x)).ToArray();
            printex(nums);
        }
    }
}
