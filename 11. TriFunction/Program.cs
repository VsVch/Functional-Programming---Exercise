using System;
using System.Linq;

namespace _11._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Func<string, int, bool> isBig = (s, n) => s.Sum(x => x) >= n;
            Func<string[], int, Func<string, int, bool>, string> getNames = (arr, n, func) => arr.Where(x => func(x, n)).FirstOrDefault();


            //Func<string, int, bool> isBigger = (s, n) => s.Sum(x => x) >= n;
            //Func<string[], int, Func<string, int, bool>, string> getName =
            //    (arr, n, func) => arr.Where(x => func(x, n)).FirstOrDefault();
            //Console.WriteLine(getName(names, n, isBigger));
            Console.WriteLine(getNames(names, n , isBig));
        }
    }
}