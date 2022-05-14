using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальное значение хп");
            int maxHealth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите текущее значение хп");
            int currentHealth = Convert.ToInt32(Console.ReadLine());
            string userInput = "";
            Console.Clear();

            while (userInput != "exit")
            {
                CraeteBar(currentHealth, maxHealth, ConsoleColor.Red);
                Console.SetCursorPosition(0, 2);
                Console.Write("Введите число на которое изменится текущее количество хп");
                currentHealth += Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Что бы выйти введите exit, чтобы продолжить введите что угодно");
                userInput = Console.ReadLine();
                Console.Clear();
            }
        }

        static void CraeteBar(int value, int maxValue, ConsoleColor color)
        {
            int xPosition = 0;
            int yPosition = 0;
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += ' ';
            }

            Console.SetCursorPosition(xPosition, yPosition);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;
            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += ' ';
            }

            Console.Write(bar + ']');
        }
    }
}