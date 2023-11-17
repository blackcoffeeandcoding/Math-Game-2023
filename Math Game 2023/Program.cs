using Math_Game_2023;
using static System.Formats.Asn1.AsnWriter;

var menu = new Menu();

var games = new List<string>();


string name = GetName();
var date = DateTime.UtcNow; // gets the current time



menu.ShowMenu(name, date);




string GetName()
{
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine(); // stores the user input in the variable name
    return name;
}