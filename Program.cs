using System;

namespace ConsoleApp1
{
    public class Program
    {
        // Метод для обчислення периметра та площі
        public static (double P, double S) CalculateTriangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            // Відстані між точками (довжини сторін)
            double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

            double pPerimeter = a + b + c;
            double semiP = pPerimeter / 2;
            double area = Math.Sqrt(semiP * (semiP - a) * (semiP - b) * (semiP - c));

            return (pPerimeter, area);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть x1:");
            double x1 = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Введіть y1:");
            double y1 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Введіть x2:");
            double x2 = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Введіть y2:");
            double y2 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Введіть x3:");
            double x3 = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Введіть y3:");
            double y3 = double.Parse(Console.ReadLine()!);

            var result = CalculateTriangle(x1, y1, x2, y2, x3, y3);

            Console.WriteLine($"Периметр P = {result.P}");
            Console.WriteLine($"Площа S = {result.S}");
        }
    }
}