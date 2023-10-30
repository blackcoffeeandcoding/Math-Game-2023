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

if (selectedGame.Trim() == "a") // Trim removes white spaces 
{
    Console.WriteLine("Addition game selected");
} else if (selectedGame.Trim() == "s")
{
    Console.WriteLine("Subtraction game selected");
} else if (selectedGame.Trim() == "m")
{
    Console.WriteLine("Multiplication game selected");
} else if (selectedGame.Trim() == "d")
{
    Console.WriteLine("Division game selected");
} else
{
    Console.WriteLine("Goodbye");
    Environment.Exit(1);
}

