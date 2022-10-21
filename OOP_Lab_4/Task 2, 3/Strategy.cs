using System;
namespace OOP_Lab_4
{
    public class Strategy : ClassB
    {
        readonly public string Genre = "Shooter";
        public Strategy(string gameName, int year)
        {
            Name = gameName;
            ReleaseDate = year;
        }
        public Strategy(string gameName, int year, string descryption)
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
