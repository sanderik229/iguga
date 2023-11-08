using System;

namespace Igra2
{
    internal class Program
    {
        static void Main()
        {
            Actions();
        }

        static void UgadaiChislo()
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 100);
            Console.WriteLine("Попробуй угадай: ");
            while (true)
            {
                int gnumber = Convert.ToInt32(Console.ReadLine());
                if (gnumber < number)
                {
                    Console.WriteLine("Больше! ");
                }
                else if (gnumber > number)
                {
                    Console.WriteLine("Меньше!! ");
                }
                else if (gnumber == number)
                {
                    Console.WriteLine("Красаваааа!!!");
                    break;
                }
            }
        }

        static void umnojenietab()
        {
            int size = 10;
            int[,] multiplicationTable = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    multiplicationTable[i, j] = (i + 1) * (j + 1);
                }
            }
            Console.WriteLine("Таблица умножения:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{multiplicationTable[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        static void Delitel()
        {
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Все делители числа {number}:");
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static void Actions()
        {
            while (true)
            {
                Console.WriteLine("1) Игра угадай число");
                Console.WriteLine("2) Таблица умножения");
                Console.WriteLine("3) Найти делители числа");
                Console.WriteLine("4) Выйти из программы");
                Console.WriteLine("Введите действие: ");
                int action = Convert.ToInt32(Console.ReadLine());
                if (action == 1)
                {
                    UgadaiChislo();
                }
                else if (action == 2)
                {
                    umnojenietab();
                }
                else if (action == 3)
                {
                    Delitel();
                }
                else if (action == 4)
                {
                    break;
                }
            }
        }
    }
}