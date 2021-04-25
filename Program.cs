using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare and initialze variable
            int favoriteNumber = 5;

            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favoriteNumber)
            {
                Console.WriteLine("too low");

            }
            else if (userInput > favoriteNumber)
            {
                Console.WriteLine("too high");
            }

            else
            {
                Console.WriteLine("Nevermind");
            }

            Console.WriteLine("What is your favorite school subject?");
            string favSubject = Console.ReadLine();

            switch (favSubject)
            {
                case "Math":
                    Console.WriteLine("Math is one of my favorite subjects too!");
                    break;
                case "History":
                    Console.WriteLine("History depends on who writes it.");
                    break;
                case "Art":
                    Console.WriteLine("I love art the best too.");
                    break;
                case "Psychology":
                    Console.WriteLine("Psychology is a little intimidating.");
                    break;
                default:
                    Console.WriteLine("Hmm that's interesting.");
                    break;
            }

        }
    }
}
