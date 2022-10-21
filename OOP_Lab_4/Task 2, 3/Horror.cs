using System;
namespace OOP_Lab_4
{
    public class Horror : ClassB
    {
        readonly public string Genre = "Horror";
        public Horror(string gameName, int year)
        {
            Name = gameName;
            ReleaseDate = year;
        }
        public Horror(string gameName, int year, string descryption)
        {
            Name = gameName;
            ReleaseDate = year;
            Descryption = descryption;
        }
        public void PrintInfoGenre()
        {
            Console.WriteLine($"Name of the game is: {Name}");
            Console.WriteLine($"Year of release: {ReleaseDate}");
            Console.WriteLine($"Genre of the game: {Genre}");
            Console.WriteLine($"{Descryption}");
        }
    }
}
