
namespace Math_Game_2023
{
    internal class Menu
    {
        GameEngine gameEngine = new();
       internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Hello {name}. It's {date}. This is a math game to test your skills.");
            Console.WriteLine("\n");


            var isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine("   _____  _  _     __  __       _   _        _____                      \r\n  / ____|| || |_  |  \\/  |     | | | |      / ____|                     \r\n | |   |_  __  _| | \\  / | __ _| |_| |__   | |  __  __ _ _ __ ___   ___ \r\n | |    _| || |_  | |\\/| |/ _` | __| '_ \\  | | |_ |/ _` | '_ ` _ \\ / _ \\\r\n | |___|_  __  _| | |  | | (_| | |_| | | | | |__| | (_| | | | | | |  __/\r\n  \\_____||_||_|   |_|  |_|\\__,_|\\__|_| |_|  \\_____|\\__,_|_| |_| |_|\\___|");
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine(@$"Please choose the game you'd like to play from the options below

            |   V - View Previous Games  |
            |   A - Addition Game        |
            |   S - Subtraction Game     |  
            |   M - Multiplication Game  |  
            |   D - Division Game        |  
            |   Q - Quit the program     |");


                var selectedGame = Console.ReadLine(); // stores the user input for the selected game


                switch (selectedGame.Trim().ToLower())
                {
                    case "v":
                        Helpers.GetGames();
                        break;
                    case "a":
                        gameEngine.AdditionGame("Addition game");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("Subtraction game");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                       gameEngine.DivisionGame("Division game");
                        break;

                    case "q":
                        Console.WriteLine("Thanks. Bye!");
                        isGameOn = false;
                        Environment.Exit(1);
                        break;
                    default:   // same as the final else statement
                        Console.WriteLine("Invalid input");
                        break;

                }
            } while (isGameOn);

        }
    }
}
