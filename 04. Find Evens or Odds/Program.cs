using System;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string oddEven = Console.ReadLine();

            Action<int> print = x => Console.Write($"{x} ");
            Predicate<int> check = GetPredicate(oddEven);
            for (int i = range[0]; i <= range[1]; i++)
            {
                if (check(i)) print(i);
            }
        }

        private static Predicate<int> GetPredicate(string oddEven)
        {
            if (oddEven == "odd") 
                return x => x % 2 != 0;
            else return x => x % 2 == 0;
        }
    
    }
}
