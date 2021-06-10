using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> games = new MyDictionary<int, string>();

            games.Add(1 ,"Spider-Man");
            games.Add(2, "Monster Hunter World");
            games.Add(3, "Fifa2021");
            games.Add(4, "Resident Evil 8");
            games.Add(5, "Call of Duty");


            Console.WriteLine("All games you have played: " + games.Count);

            foreach (var game in games.Values)
            {
                Console.WriteLine(game);
            }
        }
    }
}
