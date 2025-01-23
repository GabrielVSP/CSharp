using ex024;

Console.WriteLine("Quantos produtos quer adicionar?");
int n = int.Parse(Console.ReadLine());
Product[] products = new Product[n];

double sum = 0;

for (int i = 0; i < n; i++)
{

    Console.WriteLine($"#{i + 1}");

    Console.Write("Nome do produto: ");
    string name = Console.ReadLine();

    Console.Write("Preço do produto: ");
    double price = double.Parse(Console.ReadLine());

    Console.WriteLine("=============");

    sum += price;

    products[i] = new Product(name, price);
}

Console.WriteLine($"Preço médio: {(sum / n):F2}");