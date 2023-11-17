﻿
namespace Math_Game_2023
{
    internal class Helpers
    {
        static List<string> games = new(); //initilizes as empty
        internal static void AddToHistory(int score, string gameType)
        {
            games.Add($"{DateTime.Now} - {gameType}: Score = {score} points");
        }

       internal static int[] GetDivisionNumbers() // [] square brackets == array
        {
            var random = new Random();
            var firstNumber = random.Next(0, 99);
            var secondNumber = random.Next(0, 99);


            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

       internal static void GetGames()
        {
            Console.Clear();
            Console.WriteLine("\r\n   _____                        _    _ _     _                   \r\n  / ____|                      | |  | (_)   | |                  \r\n | |  __  __ _ _ __ ___   ___  | |__| |_ ___| |_ ___  _ __ _   _ \r\n | | |_ |/ _` | '_ ` _ \\ / _ \\ |  __  | / __| __/ _ \\| '__| | | |\r\n | |__| | (_| | | | | | |  __/ | |  | | \\__ \\ || (_) | |  | |_| |\r\n  \\_____|\\__,_|_| |_| |_|\\___| |_|  |_|_|___/\\__\\___/|_|   \\__, |\r\n                                                            __/ |\r\n                                                           |___/ \r\n");
            Console.WriteLine("------------------------------------------------------------------------");
            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadLine();
        }
    }
}
