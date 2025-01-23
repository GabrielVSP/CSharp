double? sum = 0;

Console.WriteLine("Quantas alturas você quer calcular?");
int n = int.Parse(Console.ReadLine());

double[] heights = new double[n];

for (int c = 0; c < n; c++)
{
    Console.Write($"Altura #{c}: ");
    double height = double.Parse(Console.ReadLine());

    heights[c] = height;

}

for (int i = 0; i < heights.Length; i++)
{

    sum += heights[i];

}

Console.WriteLine($"Altura média: {sum / heights.Length:F2}");