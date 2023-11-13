using static System.Formats.Asn1.AsnWriter;

string? name = GetName();
var date = DateTime.UtcNow; // gets the current time

Menu(name);

void DivisionGame(string message)
{
    var score = 0; 

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();

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
}

void MultiplicationGame(string message)
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
        var result = Console.ReadLine(); // asks for user input

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
}

void SubtractionGame(string message)
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
        var result = Console.ReadLine(); // asks for user input

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
}

void AdditionGame(string message) // void doesn't return anything
{
    Console.Clear();
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
        Console.WriteLine("Your answer was correct! Type any key to move on to the next question");
            score++;
            Console.ReadLine();

    } else
    {
        Console.WriteLine("Your answer was incorrect. Type any key to move on to the next question");
            Console.ReadLine();
        }

      if(i == 4)
        {
            Console.WriteLine($"Game over! Your final score is {score}. Press any key to go back to the main menu.");
            Console.ReadLine();
        }
    }

}

int[] GetDivisionNumbers() // [] square brackets == array
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

void Menu(string? name)
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

            |   A - Addition Game        |
            |   S - Subtraction Game     |  
            |   M - Multiplication Game  |  
            |   D - Division Game        |  
            |   Q - Quit the program     |");    
        

        var selectedGame = Console.ReadLine(); // stores the user input for the selected game


        switch (selectedGame.Trim().ToLower())
        {
            case "a":
                AdditionGame("Addition game");
                break;
            case "s":
                SubtractionGame("Subtraction game");
                break;
            case "m":
                MultiplicationGame("Multiplication game");
                break;
            case "d":
                DivisionGame("Division game");
                break;

            case "q":
                Console.WriteLine("Thanks. Bye!");
                isGameOn = false;
                Environment.Exit(1);
                break;
            default:   // same as the final else statement
                Console.WriteLine("Invalid input");
                Environment.Exit(1);
                break;

        } 
    } while (isGameOn);

}

string GetName()
{
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine(); // stores the user input in the variable name
    return name;
}