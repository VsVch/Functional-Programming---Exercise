using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int wordLenght = int.Parse(Console.ReadLine());
            Action<string[]> printex = x => Console.WriteLine(string.Join(Environment.NewLine, x));
            Predicate<string> isCorrectLength = x => x.Length <= wordLenght;

            string[] names = Console.ReadLine().Split().Where(x => isCorrectLength(x)).ToArray();
            printex(names);
        }
    }
}
