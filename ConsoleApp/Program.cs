using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 2
            Console.WriteLine("введите значени а и b");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int summ = 0;
            Console.Write(" четные числа: ");
            if (a < b)
            {
                for (int i = a + 1; i < b; i++)
                {
                    summ += i;
                    if (i % 2 == 1)
                    {
                        Console.Write($"{i},");
                    }
                }
                Console.WriteLine($"\n Сумма между a и b: {summ}\n");

            }
            else Console.WriteLine($"a не должен быть меньше чем b");


            //Задание 3
            Console.WriteLine("Прямоугольник ");
            int lenght = 18, width = 5;
            for (int j = 0; j < width; j++)
            {
                for (int i = 0; i < lenght; i++)
                {
                    if (j == 0 || j == width - 1) Console.Write("*");
                    else if (i == 0 || i == lenght - 1) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("Прямоугольный треугольник");
            int i1 = 0, i2 = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (j == i1 || j == i2) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.Write("\n");
                i2 += 3;
            }
            for (int l = 0; l < 21; l++)
            {
                Console.Write("*");
            }

            Console.WriteLine("\n Равносторонний треугольник \n");
            int a1 = 7, a2 = 7;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    if (j == a1 || j == a2) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.Write("\n");
                a1++;
                a2--;
            }
            for (int l = 0; l < 15; l++)
            {
                Console.Write("*");
            }


            Console.WriteLine("\n Ромб \n");
            int b1 = 7, b2 = 7;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    if (j == b1 || j == b2) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.Write("\n");
                b2++;
                b1--;
            }
            int c1 = 0, c2 = 14;
            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j <= 14; j++)
                {
                    if (j == c1 || j == c2) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.Write("\n");
                c1++;
                c2--;
            }
            Console.Write("\n");


            //Задание 4
            double s = 1000;
            Console.Write("Введите процент 0<P<25 p= ");
            double p = Convert.ToDouble(Console.ReadLine());
            double k = 0;
            if (0 < p && p < 25)
            {
                while (true)
                {
                    if (s > 1100)
                    {
                        break;
                    }
                    else
                    {
                        k += 1;
                        s = s + s * p / 100;
                        Console.WriteLine($"Через {k} месяц вклад будет равен {s}  рублей.");
                    }

                }
            }
        }
    }
}
