namespace ex017
{

    class Radius
    {

        static void Main()
        {

            Console.WriteLine("Digite o raio do círculo");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"Valor da cincurferência: {Calculator.Circle(radius):F2}");
            Console.WriteLine($"Volume da esfera: {Calculator.Volume(radius):F2}");
            Console.WriteLine($"Valor de PI: {Calculator.pi}");

        }

    }

}