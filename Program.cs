using System;

namespace Adventure
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Adventure Game!\nWelcome weary traveler");
            Console.WriteLine("You are about to enter the headquarters of your arch nemesis");
            Console.WriteLine("Can your find the key hidden in their lair");

            string playerName;
            Console.WriteLine("Before we begin, what is your name?\n");
            playerName = Console.ReadLine();
            Console.WriteLine($"Hello {playerName}, Good Luck beating your arch nemesis");

        }
    }
}