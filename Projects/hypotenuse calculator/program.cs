double op;
double adj;

Console.WriteLine("=======CÁLCULO DE HIPOTENUSA========");
Console.WriteLine("-Digite o cateto oposto");

op = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("-Digite o cateto adjacente");

adj =  Convert.ToDouble(Console.ReadLine());

double hip = (op*op) + (adj*adj);

Console.WriteLine($"A hipotenusa desse triângulo é: {Math.Round(Math.Sqrt(hip))}");

