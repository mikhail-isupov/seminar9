using System;

namespace Seminar8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            if (args.Length == 0) Console.WriteLine("Введите номер задачи в качестве параметра командной строки.");
            else switch(args[0])
            {
                case "64": task64(); break;
                case "66": task66(); break;
                case "68": task68(); break;
                default: Console.WriteLine("Такой задачи нет"); break;
            }
        }

        static void task64()
        {
            int m = 1; int n = 10;
            ListNumbers(m, n);
        }

        static void ListNumbers(int minNum, int maxNum)
        {
            if (minNum <= maxNum)
            {
                Console.Write($"{minNum} ");
                ListNumbers(minNum + 1, maxNum);
            }
        }

        static void task66()
        {
            Console.WriteLine("Введите начальное значение");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите конечное значение");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} = " + SumOfProgression(m,n));
        }

        static int SumOfProgression(int m, int n)
        {
            return (m + n) * (Math.Abs(n - m) + 1) / 2;
        }

        static void task68()
        {
            Console.WriteLine("Введите значение m");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение n");
            int n = int.Parse(Console.ReadLine());

            if (m < 0 || n < 0) Console.WriteLine("Функция не определена для отрицательных аргументов");
            else Console.WriteLine($"Значение функции Аккермана A({m},{n}) = " + Akkerman(m,n));
        }

        static int Akkerman(int m, int n)
        {
            if (m == 0) return (n + 1);

            if (n == 0) return Akkerman(m - 1, 1);

            return Akkerman(m - 1, Akkerman(m, n - 1) );
        
        }



    }
}