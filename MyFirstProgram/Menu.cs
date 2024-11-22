using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    
    internal class Menu
    {

        GameEngine gameEngine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Hello {name.ToUpper()}, it's date {date.DayOfYear}. This is your math's game. That's great that you're working on improving yourself\n");
            Console.WriteLine("Press any key to show menu");
            Console.ReadLine();
            Console.WriteLine("\n");

            var isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@" What game would you like to play today? Choose from the options below:
            V - View previous Games
            A - Addition
            S - Subtraction
            M - Multiplication
            D - Division
            Q - Quit the program");

                Console.WriteLine("--------------------------------------");


                var gameselected = Console.ReadLine();

                switch (gameselected.Trim().ToLower())
                {

                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        gameEngine.AdditionGame("Addition Game");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("Subtraction Game");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication Game");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division Game");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        Environment.Exit(1);
                        break;

                }

            } while (isGameOn);




        }
    }
}
