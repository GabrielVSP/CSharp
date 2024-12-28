namespace ex015
{

    class Dashboard
    {

        static void Main()
        {

            Product product = new Product();

            Console.WriteLine("Entre os dados do produto");

            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            int qnt = int.Parse(Console.ReadLine());

            Console.WriteLine(product.Set(name, price, qnt));
            Console.WriteLine("Quantidade de produtos a ser adicionada no estoque: ");

            Console.WriteLine(product.AddQnt(int.Parse(Console.ReadLine())));

            Console.WriteLine("Quantidade de produtos a ser removido do estoque: ");

            Console.WriteLine(product.RemoveQnt(int.Parse(Console.ReadLine())));

        }



    }

}