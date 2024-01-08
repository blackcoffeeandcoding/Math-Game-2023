
using Math_Game_2023.Models;

namespace Math_Game_2023
{
    internal class GameEngine
    {
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

                if (int.Parse(result) == firstNumber / secondNumber) // since console.readline returns a String we must parse it to an Integer
                {
                    Console.WriteLine("Your answer was correct! Type any key to move on to the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key to move on to the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over! Your final score is {score}");
                }
            }

            Helpers.AddToHistory(score, GameType.Division);
        }

       internal void MultiplicationGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;



            for (int i = 0; i < 10; i++)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber) // since console.readline returns a String we must parse it to an Integer
                {
                    Console.WriteLine("Your answer was correct! Type any key to move on to the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key to move on to the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over! Your final score is {score}");
                }
            }

            Helpers.AddToHistory(score, GameType.Multiplication);
        }

       internal void SubtractionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;



            for (int i = 0; i < 10; i++)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber) // since console.readline returns a String we must parse it to an Integer
                {
                    Console.WriteLine("Your answer was correct! Type any key to move on to the next question");
                    score++;
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key to move on to the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over! Your final score is {score}");
                }
            }

            Helpers.AddToHistory(score, GameType.Subtraction);
        }

        internal void AdditionGame(string message) 
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 10; i++)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine(); // asks for user input

                result = Helpers.ValidateResult(result); 

                if (int.Parse(result) == firstNumber + secondNumber) // since console.readline returns a String we must parse it to an Integer
                {
                    Console.WriteLine("Your answer was correct! Type any key to move on to the next question");
                    score++;
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key to move on to the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over! Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Addition);

        }
    }
}
