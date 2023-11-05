string? name = GetName();
var date = DateTime.UtcNow; // gets the current time

Menu(name);

void DivisionGame(string message)
{
    Console.WriteLine(message);
}

void MultiplicationGame(string message)
{
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
        var result = Console.ReadLine(); // asks for user input

        if (int.Parse(result) == firstNumber * secondNumber) // since console.readline returns a String we must parse it to an Integer
        {
            Console.WriteLine("Your answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect.");
        }

        if (i == 4)
        {
            Console.WriteLine($"Game over! Your final score is {score}");
        }
    }
}

void SubtractionGame(string message)
{
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
        var result = Console.ReadLine(); // asks for user input

        if (int.Parse(result) == firstNumber - secondNumber) // since console.readline returns a String we must parse it to an Integer
        {
            Console.WriteLine("Your answer was correct!");
            score++;

        }
        else
        {
            Console.WriteLine("Your answer was incorrect.");
        }

        if (i == 4)
        {
            Console.WriteLine($"Game over! Your final score is {score}");
        }
    }
}

void AdditionGame(string message) // void doesn't return anything
{
    Console.WriteLine(message);

    var random = new Random();
    var score = 0;
    int firstNumber;
    int secondNumber;



    for(int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

    Console.WriteLine($"{firstNumber} + {secondNumber}");
    var result = Console.ReadLine(); // asks for user input

    if(int.Parse(result) == firstNumber  + secondNumber) // since console.readline returns a String we must parse it to an Integer
    {
        Console.WriteLine("Your answer was correct!");
            score++;

    } else
    {
        Console.WriteLine("Your answer was incorrect.");
    }

      if(i == 4)
        {
            Console.WriteLine($"Game over! Your final score is {score}");
        }
    }

}

void Menu(string? name)
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

string GetName()
{
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine(); // stores the user input in the variable name
    return name;
}