﻿

using MyFirstProgram.Models;

namespace MyFirstProgram
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;

          
            for (int i = 0; i < 2; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                
                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);



                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("You answer was correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("You answer is incorrect.");
                }

                if (i == 1)
                {
                    Console.WriteLine($"Game Over. Your final score is {score}. Pres any key to go back to the main menu ");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Addition);


        }

        internal void SubtractionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);
                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("You answer was correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("You answer is incorrect.");
                }

                if (i == 4) Console.WriteLine($"Game Over. Your final score is {score} ");
            }

            Helpers.AddToHistory(score, GameType.Subtraction);
        }

        internal void MultiplicationGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 2; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);
                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("You answer was correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("You answer is incorrect.");
                }

                if (i == 4) Console.WriteLine($"Game Over. Your final score is {score} ");
            }

            Helpers.AddToHistory(score, GameType.Multiplication);
        }

        internal void DivisionGame(string message)
        {

            var score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);


                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine($"Your answer was correct. Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Your answer was incorrect.");
                    Console.ReadLine();
                }

                if (i == 1) Console.WriteLine($"Game over. Your final score is {score}");
            }
            Helpers.AddToHistory(score, GameType.Division);
        }

    }
}
