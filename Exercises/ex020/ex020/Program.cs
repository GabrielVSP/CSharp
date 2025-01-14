using ex020;

namespace ex020
{

    class Dashboard
    {

        static void Main()
        {

            Console.WriteLine("Entre os dados do produto");

            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            int qnt = int.Parse(Console.ReadLine());

            Product product = new Product(name, price, qnt);

            product.Name = "a";

            Console.WriteLine(product);
            Console.WriteLine("Quantidade de produtos a ser adicionada no estoque: ");

            Console.WriteLine(product.AddQnt(int.Parse(Console.ReadLine())));

            Console.WriteLine("Quantidade de produtos a ser removido do estoque: ");

            Console.WriteLine(product.RemoveQnt(int.Parse(Console.ReadLine())));

        }

    }

}