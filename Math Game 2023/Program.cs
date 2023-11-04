Console.WriteLine("Please type your name");
var name = Console.ReadLine(); // stores the user input in the variable name
var date = DateTime.UtcNow; // gets the current time

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

if (selectedGame.Trim().ToLower() == "a") // Trim removes white spaces AND forces input to lower case letter
{
    AdditionGame("Addition game selected");
} else if (selectedGame.Trim().ToLower() == "s")
{
    SubtractionGame("Subtraction game selected");
} else if (selectedGame.Trim().ToLower() == "m")
{
    MultiplicationGame("Multiplication game selected");
} else if (selectedGame.Trim().ToLower() == "d")
{
    DivisionGame("Division game selected");
} else if (selectedGame.Trim().ToLower() == "q")
{
    Console.WriteLine("Quitting game...");
} else 
{
    Console.WriteLine("Goodbye");
    Environment.Exit(1);
}


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


