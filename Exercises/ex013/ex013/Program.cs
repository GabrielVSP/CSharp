namespace Math {

    class TriangleMath
    {

        static void Main()
        {

            Triangle x = new Triangle();
            Triangle y = new Triangle();

            Console.WriteLine("Entre com as medidas do triângulo X:");

            x.a = double.Parse(Console.ReadLine());
            x.b = double.Parse(Console.ReadLine());
            x.c = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y:");

            y.a = double.Parse(Console.ReadLine());
            y.b = double.Parse(Console.ReadLine());
            y.c = double.Parse(Console.ReadLine());

            double areaX = Area(x);
            double areaY = Area(y);

            Console.WriteLine($"Área de X: {areaX}");
            Console.WriteLine($"Área de Y: {areaY}");

            Console.WriteLine($"Maior área: " + (areaX > areaY ? "Área de X" : "Área de Y") );

        }

        private static double Area(Triangle tri)
        {

            double p = (tri.a + tri.b + tri.c) / 2;
            double area = System.Math.Sqrt(
                p * (p - tri.a) * (p - tri.b) * (p - tri.c)
                );

            return area;

        }


    }
}