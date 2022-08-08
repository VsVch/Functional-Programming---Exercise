using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());
            List<int> numbers = Enumerable.Range(1, endNum).ToList();
            int[] listDev = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<Predicate<int>> predicates = new List<Predicate<int>>();
            foreach (int n in listDev) predicates.Add(x => x % n == 0);
            foreach (int n in numbers)
            {
                bool isDev = true;
                foreach (Predicate<int> pred in predicates)
                {
                    if (!pred(n))
                    {
                        isDev = false;
                        break;
                    }
                }

                if (isDev) Console.Write($"{n} ");
            }
        }
    }
}
