namespace ex016
{

    class CalcImposto
    {

        static void Main()
        {

            Worker worker = new Worker();

            Console.WriteLine("Digite os dados do funcionário");

            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Salário bruto: ");
            double wage = double.Parse(Console.ReadLine());

            Console.Write("Impostos: ");
            double taxes = double.Parse(Console.ReadLine());

            worker.Set(name, wage, taxes);
            Console.WriteLine($"Dados do funcionário: {name}, R${worker.LiquidWage()}");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double percent = double.Parse(Console.ReadLine());

            Console.WriteLine($"Dados atualizados: {name}, R${worker.IncreaseWage(percent)}");

        }

    }

}