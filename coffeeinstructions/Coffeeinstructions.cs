using System;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Coffee Machine!");
            Console.WriteLine("Please select a coffee type:");
            Console.WriteLine("1. Espresso");
            Console.WriteLine("2. Americano");
            Console.WriteLine("3. Cappuccino");
            Console.WriteLine("4. Latte");

            int choice = GetUserChoice();

            BrewCoffee(choice);

            Console.WriteLine("Your coffee is ready! Enjoy!");
        }

        static int GetUserChoice()
        {
            int choice;
            while (true)
            {
                Console.Write("Enter your choice (1-4): ");
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 4)
                {
                    break;
                }
                Console.WriteLine("Invalid choice, please try again.");
            }
            return choice;
        }

        static void BrewCoffee(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Brewing Espresso...");
                    break;
                case 2:
                    Console.WriteLine("Brewing Americano...");
                    break;
                case 3:
                    Console.WriteLine("Brewing Cappuccino...");
                    break;
                case 4:
                    Console.WriteLine("Brewing Latte...");
                    break;
                default:
                    Console.WriteLine("Unknown coffee type!");
                    break;
            }

            SimulateBrewingProcess();
        }

        static void SimulateBrewingProcess()
        {
            Console.WriteLine("Starting the brewing process...");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(500);  // Simulates brewing time
            }
            Console.WriteLine();
        }
    }
}
