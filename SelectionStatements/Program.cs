using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var favNumber = 999;

            Console.WriteLine("What is my favorite number? There is a chance it's below 1,000.");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput == favNumber)
            {
                Console.WriteLine("Nice! You got it!");
            }
            else if (userInput < favNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("Nevermind.");
                Console.ReadLine();
            }
            Console.WriteLine("What's your favorite subject?");
            var response = Console.ReadLine();

            switch (response)
            {
                case "Math":
                    Console.WriteLine("Math is cool!");
                    break;
                case "English":
                    Console.WriteLine("English is okay.");
                    break;
                case "Gym":
                    Console.WriteLine("Gym is for sure the best!");
                    break;
                case "History":
                    Console.WriteLine("I think history is kind of okay.");
                    break;
                case "Lunch":
                    Console.WriteLine("Yes! Lunch all day");
                    break;
                default:
                    Console.WriteLine("I've never heard of that one at all!");
                    break;

                    Console.ReadLine();
            }
        }       
    }
}