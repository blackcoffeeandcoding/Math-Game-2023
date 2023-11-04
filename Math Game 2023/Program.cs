Console.WriteLine("Please type your name");
var name = Console.ReadLine(); // stores the user input in the variable name
var date = DateTime.UtcNow; // gets the current time

Menu(name, date);

void DivisionGame(string message)
{
    Console.WriteLine(message);
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);
}

void AdditionGame(string message) // void doesn't return anything
{
    Console.WriteLine(message);
}

void Menu(string? name, DateTime date)
{
    Console.WriteLine("------------------------------------");
    Console.WriteLine($"Hello {name}. It's {date}. This is a math game to test your skills.");
    Console.WriteLine("\n");
    Console.WriteLine(@$"Please choose the game you'd like to play from the options below
A - Addition Game
S - Subtraction Game
M - Multiplication Game
D - Division Game
Q - Quit the program");
    Console.WriteLine("------------------------------------");

    var selectedGame = Console.ReadLine(); // stores the user input for the selected game


    switch (selectedGame.Trim().ToLower())
    {
        case "a":
            AdditionGame("Addition game selected");
            break;
        case "s":
            SubtractionGame("Subtraction game selected");
            break;
        case "m":
            MultiplicationGame("Multiplication game selected");
            break;
        case "d":
            DivisionGame("Division game selected");
            break;
        default:   // same as the final else statement
            Console.WriteLine("Invalid input");
            Environment.Exit(1);
            break;

    }
}