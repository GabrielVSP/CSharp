class InOut
{

    static void Main()
    {

        Console.WriteLine("Quantos números você irá digitar?");
        int n = int.Parse(Console.ReadLine());

        int[] interval = [10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20];

        for (int i = 0; i < n; i++)
        {

            Console.WriteLine($"Valor #{i}");
            int num = int.Parse(Console.ReadLine());

            if (interval.Contains(num))
            {

                Console.WriteLine($"{num} in");

            } else
            {
                Console.WriteLine($"{num} out");

            }
           
        }

    }
}