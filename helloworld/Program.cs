using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?: ");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.WriteLine($"{Environment.NewLine}Press any key to exit...");
        }
    }
}
