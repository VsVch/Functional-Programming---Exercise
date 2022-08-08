using System;

namespace E01.ActionPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string[] names = Console.ReadLine().Split();
           
            Action<string[]> printex = y => Console.WriteLine(string.Join(Environment.NewLine, y));
            printex(names);
        }
    }
}