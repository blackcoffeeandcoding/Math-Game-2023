
using Math_Game_2023.Models;

namespace Math_Game_2023
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>
        {
        new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
        new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
        new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
        new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
        new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
        new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
        new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
        new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
        new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },
        };

        internal static void AddToHistory(int gameScore,  GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });
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

       internal static void PrintGames() // This displays the game history stored in the games list 
        {
            var gamesToPrint = games.Where(x => x.Date == new DateTime(2023, 12, 01)).OrderByDescending( x => x.Score);

            Console.Clear();
            Console.WriteLine("\r\n   _____                        _    _ _     _                   \r\n  / ____|                      | |  | (_)   | |                  \r\n | |  __  __ _ _ __ ___   ___  | |__| |_ ___| |_ ___  _ __ _   _ \r\n | | |_ |/ _` | '_ ` _ \\ / _ \\ |  __  | / __| __/ _ \\| '__| | | |\r\n | |__| | (_| | | | | | |  __/ | |  | | \\__ \\ || (_) | |  | |_| |\r\n  \\_____|\\__,_|_| |_| |_|\\___| |_|  |_|_|___/\\__\\___/|_|   \\__, |\r\n                                                            __/ |\r\n                                                           |___/ \r\n");
            Console.WriteLine("------------------------------------------------------------------------");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: Your final score was {game.Score} points");
            }
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadLine();
        }
    }
}
