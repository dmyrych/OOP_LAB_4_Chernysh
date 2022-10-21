using System;
namespace OOP_Lab_4
{
    public class ClassB
    {
        public string Name;
        public int ReleaseDate;
        public string Descryption;

        public ClassB()
        {

        }

        public ClassB(string gameName, int year)
        {
            Name = gameName;
            ReleaseDate = year;
        }
        public ClassB(string gameName, int year, string descryption)
        {
            Name = gameName;
            ReleaseDate = year;
            Descryption = descryption;
        }

        public void PrintInfo(string gameName, int year, string descryption)
        {
            Console.WriteLine($"Name of the game is: {gameName}");
            Console.WriteLine($"Year of release: {year}");
            Console.WriteLine($"{descryption}");
        }
        public void PrintInfo(string gameName, int year)
        {
            Console.WriteLine($"Name of the game is: {gameName}");
            Console.WriteLine($"Year of release: {year}");
        }

    }
}
