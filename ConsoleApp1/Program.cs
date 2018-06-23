using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

// Produce a random number
// Get a number from the user
// Compare the 2 numbers
// Keep track of the number of guesses


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
            Menu();
        }

        public static void PlayAgain()
        {
            Console.WriteLine("Do you want to play again? Y/n ");
            string again = Console.ReadLine();
            if (again == "y")
            { 
                Console.Clear();
                Menu();
            }
            else
            {
                System.Environment.Exit(0);
            }
        }

        public static void Start()
        {
            Console.WriteLine("Welcome to the number guessing game. Please enter your name: ");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hello " + name + ", please choose from one of the following options.\r\n");
        
        }

        public static void Menu()
        {
            Console.WriteLine("Press 1 to start the game, or press 2 to quit");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Clear();
                Game();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Sorry, I did not recognise that!\r\n");
                Menu();
               
            }
        }

        public static void Game()
        {
            int numberGuesses = 0;
            Random random = new Random();
            int number = random.Next(0, 10);
            Console.WriteLine("I have chosen a random number between 1 and 10. You have 3 guesses to get it correct. Goodluck!\r\n");
            do
            {
                Console.WriteLine("Enter your guess: ");
                int guess;

                bool userguess = int.TryParse(Console.ReadLine(), out guess);

                if (userguess)
                {
                    if (guess == number)
                    {
                        numberGuesses++;
                        Console.Clear();
                        Console.WriteLine("Well done, you guessed it in {0} guesses! My number was {1}!", numberGuesses, number);
                        PlayAgain();
                    }
                    else
                    {
                        Console.WriteLine("{0} was wrong!", guess);
                        numberGuesses++;
                    }
                }
                else
                {
                    Console.WriteLine("I'm sorry, I didn't understand that. Please make sure you enter a number.\r\n");
                    Game();
                }

            }
            while (numberGuesses < 3);
            if (numberGuesses == 3)
            {
                Console.Clear();
                Console.WriteLine("Sorry, you lost. The correct number was {0}", number);
                PlayAgain();
            }















        }

    
    }

}
