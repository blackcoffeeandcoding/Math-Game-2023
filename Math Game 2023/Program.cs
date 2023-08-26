var date = DateTime.UtcNow;

string name = GetName();

Menu(name);

string GetName()
{
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine();
    return name;
}
void Menu(string name)
{
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek} This is your math game. That's great that you're working on improving yourself\n");
    Console.WriteLine(@$"What game would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division 
Q - Quit the program");
    Console.WriteLine("-----------------------------------------");

    var gameSelected = Console.ReadLine();

    switch (gameSelected.Trim().ToLower())
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
        case "q":
            Console.WriteLine("Goodbyte");
            Environment.Exit(1);
            break;
        default: // basically is final else (default statement if nothing selected)
            Console.WriteLine("Invalid input");
            Environment.Exit(1);
            break;
    }
}

// Methods
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

void AdditionGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    int firstNumber = random.Next(1, 9);
    int secondNumber = random.Next(1, 9);

    Console.WriteLine($"{firstNumber} + {secondNumber}");
    var result = Console.ReadLine();

    if (int.Parse(result) == firstNumber + secondNumber)
    {
        Console.WriteLine("Your answer was correct!");
    }
    else
    {
        Console.WriteLine("Your answer was incorrect.");
    }
}


