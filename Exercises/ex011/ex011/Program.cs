class OddOrEven
{

    static void Main()
    {

        Console.WriteLine("Escolha um número entre 1 e 1000");
        int num = int.Parse(Console.ReadLine());

        if (num > 1000 || num < 1) throw new Exception("O valor não atende aos requisistos");

        for(int i = 1; i <= num; i++)
        {

            if (i % 2 != 0) Console.WriteLine(i);

        }

    }

}