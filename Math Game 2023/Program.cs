using Math_Game_2023;
using static System.Formats.Asn1.AsnWriter;

var menu = new Menu();

var games = new List<string>();


string name = Helpers.GetName();
var date = DateTime.UtcNow; // gets the current time



menu.ShowMenu(name, date);
