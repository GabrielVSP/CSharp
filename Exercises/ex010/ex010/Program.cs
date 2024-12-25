class ForLoop
{

      static void  Main()
    {

        Console.WriteLine("Quantos números você irá digitar?");
        
        int n = int.Parse(Console.ReadLine());
        float sum = 0;
        
        for(int i = 1; i <= n; i++)
        {

            Console.WriteLine($"Valor #{i}:");
            float num = float.Parse(Console.ReadLine());

            sum += num;

        }

        Console.WriteLine($"A soma dos valores é: {sum}");

    }

}