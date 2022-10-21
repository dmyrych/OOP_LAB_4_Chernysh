using System;
namespace OOP_Lab_4
{
    public class SomeClass
    {
        public void Debug(int a, string b)
        {
            string typeOne = a.GetType().ToString();
            string typeTwo = b.GetType().ToString();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Значення змінної а - {a}");
            Console.WriteLine($"Тип змінної a {typeOne}");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Значення змінної b - {b}");
            Console.WriteLine($"Тип змінної b {typeTwo}");

            Console.ResetColor();
        }
    }
}
