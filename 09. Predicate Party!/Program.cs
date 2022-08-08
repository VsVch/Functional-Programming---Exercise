using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> peolple = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();
            while (input != "Party!")
            {
                string[] cmd = input.Split();
                string method = cmd[0];
                string operation = cmd[1];
                string value = cmd[2];

                if (method == "Double")
                {
                    List<string> result = peolple.FindAll(GetPredicate(operation, value));

                    if (!result.Any())
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    int index = peolple.FindIndex(GetPredicate(operation, value));
                    peolple.InsertRange(index, result);
                }
                else peolple.RemoveAll(GetPredicate(operation, value));

                input = Console.ReadLine();
            }

            Action<List<string>> print = DeterminePrint(peolple);
            print(peolple);
        }

        private static Action<List<string>> DeterminePrint(List<string> guests)
        {
            if (guests.Any()) return x => Console.WriteLine($"{string.Join(", ", x)} are going to the party!");
            else return x => Console.WriteLine("Nobody is going to the party!");
        }

        private static Predicate<string> GetPredicate(string operation, string value)
        {
            if (operation == "StartsWith") return x => x.StartsWith(value);
            if (operation == "EndsWith") return x => x.EndsWith(value);
            return x => x.Length == int.Parse(value);
        }
    }
}
