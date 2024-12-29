namespace ex018
{

    class MainClass
    {

        static void Main()
        {

            Console.Write("Qual é a cotação do dólar? ");
            double quota = double.Parse(Console.ReadLine());

            Console.Write("Quantos doláres você quer comprar? ");
            double ammount = double.Parse(Console.ReadLine());

            Console.WriteLine($"Valor a ser pago em reais: {CurrencyConverter.Convert(ammount, quota):F1}");

        }

        

    }

}