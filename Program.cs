using System;

namespace Самсотійна №1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Автор: Дейко Влад");
            Console.WriteLine("Варіант: 4");

            int N;

            // Повторне введення
            while (true)
            {
                Console.Write("Введіть натуральне число N: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out N) && N >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Помилка! Ведіть коректне число");
                }
            }
            Console.WriteLine($"\nПрості числа від 0 до {N}:");
            for (int i = 0; i <= N; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine(); 
        }

        // Метод перевірки на просте число
        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}



