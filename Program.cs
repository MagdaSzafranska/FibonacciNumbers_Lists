using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Magda", "Anielka", "Felix" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello, {name.ToUpper()}!");
            }
            Console.WriteLine();

            names.Add("Magda");
            names.Add("Bill");
            names.Remove("Anielka");

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }

            Console.WriteLine();
            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
            Console.WriteLine($"The list has {names.Count} people in it.\n");

            // IndexOf

            #region IndexOf tests
            var index = names.IndexOf("Felipe");

            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            index = names.IndexOf("Not Found");

            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }
            #endregion

            var fibonacciNumbers = new List<int> { 1, 1 };

            //var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            //var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            for (int i = 0; i < 18; i++)
            {
                //fibonacciNumbers.Add(previous + previous2);
                fibonacciNumbers.Add(fibonacciNumbers[fibonacciNumbers.Count - 1] + fibonacciNumbers[fibonacciNumbers.Count - 2]);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nFirst {0} Fibonacci numbers: ", fibonacciNumbers.Count);
            foreach (var item in fibonacciNumbers)
            {
                Console.Write(" " + item);
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
