namespace ex014
{

    class CalcSalary
    {

           static void Main()
        {

            Worker a = new Worker();
            Worker b = new Worker();

            Console.WriteLine("Dados do primeiro funcionário:");

            a.name = Console.ReadLine();
            a.salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");

            b.name = Console.ReadLine();
            b.salary = double.Parse(Console.ReadLine());

            Console.WriteLine("A média dos salários é: " + (a.salary + b.salary) / 2);

        }

    }

}