using System;

namespace Program
{
    class Input
    {

        static void Main()
        {
            string name;
            int age;

            Console.WriteLine("Qual seu nome?");

            name = Console.ReadLine();

            Console.WriteLine("E sua idade?");

            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Olá, {name}, você tem {age} anos");

        }

    }

}