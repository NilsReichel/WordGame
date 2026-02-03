using WordGame.Core;

Console.WriteLine("Willkommen zum WordGame");
Console.WriteLine("Drücken Sie ENTER, um zu beenden.");

Game game = new Game();

string word = "START";

while (word != "")
{
    Console.Write("Wort: ");
    word = Console.ReadLine();

    if (word != "")
    {
        bool result = game.Add(word);


        if (result == true)
        {
            Console.WriteLine("Super!");
            Console.WriteLine("Aktuelle Kette: " + game.Get);
        }
        else
        {
            Console.WriteLine("Oje, das war falsch");
            Console.WriteLine("Aktuelle Kette: " + game.Get);
        }
    }
}