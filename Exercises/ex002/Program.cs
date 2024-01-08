using System;

namespace ex002
{
    class Program
    {
        static void Main()
        {

            int num; //Declaration
            num = 2; //Initialization

            int num1 = 13;

            string name = "drive";
            int age = 16;
            double height = 1.75;
            bool isMarried = false;
            char symbol = '+';

            String username = symbol + name;

            Console.WriteLine(num + num1);

            Console.WriteLine($"Your name is {name}");
            Console.WriteLine($"Your age is {age}");
            Console.WriteLine($"Your height is {height}m");
            Console.WriteLine("Married: " + isMarried);
            Console.WriteLine("Your symbol is: " + symbol);

            Console.WriteLine($"Username: {username}");

            //Console.ReadKey()

        }
    }
}