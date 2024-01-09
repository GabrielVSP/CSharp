using System;

namespace Calculator
{

    class Calculator
    {
        static void Main()
        {

            int num1;
            int num2;
            char op;

            Console.WriteLine("======== CALCULADORA =========");
            Console.WriteLine("Digite um número");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro número");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Selecione uma operação: [+, -, *, /]");

            op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {

                case '+':

                    Console.WriteLine($"O resultado de {num1} + {num2} é: {num1 + num2}");
                    break;

                case '-':

                    Console.WriteLine($"O resultado de {num1} - {num2} é: {num1 - num2}");
                    break;

                case '*':

                    Console.WriteLine($"O resultado de {num1} × {num2} é: {num1 * num2}");
                    break;

                case '/':

                    Console.WriteLine($"O resultado de {num1} ÷ {num2} é: {num1 / num2}");
                    break;
            }

        }

    }

}