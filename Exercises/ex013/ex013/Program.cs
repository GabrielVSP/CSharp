namespace Math {

    class Triangle
    {

        static void Main()
        {

            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo X:");

            xA = double.Parse(Console.ReadLine());
            xB = double.Parse(Console.ReadLine());
            xC = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y:");

            yA = double.Parse(Console.ReadLine());
            yB = double.Parse(Console.ReadLine());
            yC = double.Parse(Console.ReadLine());

            double areaX = Area(xA, xB, xC);
            double areaY = Area(yA, yB, yC);

            Console.WriteLine($"Área de X: {areaX}");
            Console.WriteLine($"Área de Y: {areaY}");

            Console.WriteLine($"Maior área: " + (areaX > areaY ? "Área de X" : "Área de Y") );

        }

        private static double Area(double a, double b, double c)
        {

            double p = (a + b + c) / 2;
            double area = System.Math.Sqrt(
                p * (p - a) * (p - b) * (p - c)
                );

            return area;

        }


    }
}