using System;
using System.Collections.Generic;

namespace ConsoleProgram1

{
    class Program
    {
        static void Main()
        {
            double x;
            double y;
            double z;

            Console.WriteLine("Введите стороны треугольника (без отрицательных чисел и 0)");
            Console.WriteLine();
            Console.Write("Введите сторону x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону z: ");
            z = Convert.ToDouble(Console.ReadLine());

            if (x <= 0)
            {
                Console.WriteLine("Одна из сторон <= 0");
                Console.WriteLine("Введите другие числа.");
            }
            if (y <= 0)
            {
                Console.WriteLine("Одна из сторон <= 0");
                Console.WriteLine("Введите другие числа.");
            }
            if (z <= 0)
            {
                Console.WriteLine("Одна из сторон <= 0");
                Console.WriteLine("Введите другие числа.");
            }

            List<double> value = new List<double>() { x, y, z };
            value.Sort();

            // Проверка на ограничения
            if ((value[0] + value[1]) <= value[2])
            {
                Console.WriteLine("Сумма двух сторон меньше третьей стороны");
                Console.WriteLine("Введите другие числа.");
            }
            else 
                Console.WriteLine();

            // Определяю вид треугольника
            if (x != y && y != z && x != z)
                Console.WriteLine("Треугольник разносторонний");
            if (x == y && y == z && x == z)
                Console.WriteLine("Треугольник равносторонний");
            else if (x == y)
                Console.WriteLine("Треугольник равнобедренный");
            if (x == z)
                Console.WriteLine("Треугольник равнобедренный");
            if (y == z)
                Console.WriteLine("Треугольник равнобедренный");
            else Console.WriteLine("Треугольник не может существовать");

            // Определяю площадь треугольника
            double p = (x + y + z) / 2;
            double S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            Console.WriteLine($"Площадь треугольника S = {S}");

            // Определяю вид треугольника (какие углы)
        }
    }
}