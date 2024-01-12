using System;

namespace program
{
    class Program
    {

        static void Main()
        {

            double x = 3;
            double nx = Math.Pow(x, 2);

            Random rand = new Random();

            Console.WriteLine("=====NÚMEROS ALEATÓRIOS=====");

            Console.WriteLine(rand.Next(-5, 10));
            Console.WriteLine(rand.NextDouble());

            Console.WriteLine("=====MÉTODOS MATEMÁTICOS=====");

            Console.WriteLine(nx);
            Console.WriteLine(Math.Sqrt(x));
            Console.WriteLine(Math.Abs(-x));
            Console.WriteLine(Math.Round(3.8));
            Console.WriteLine(Math.Ceiling(3.14));
            Console.WriteLine(Math.Floor(3.14));
            Console.WriteLine(Math.Max(1, 5));
            Console.WriteLine(Math.Min(1, 5));

        }

    }

}