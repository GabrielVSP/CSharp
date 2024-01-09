using System;

namespace program
{
    class Program
    {

        const double pi = 3.14159;

        static void Main()
        {

            double x = 22.17;
            int y = 134;
            int z = 266;

            string sign = "$";
            char symbol = Convert.ToChar(sign);

            string boolean = "true";
            string data = "12";

            Console.WriteLine(Convert.ToInt32(x));
            Console.WriteLine(Convert.ToDouble(y) + 0.1d);
            Console.WriteLine(Convert.ToString(z) + Convert.ToString(z).GetType());
            Console.WriteLine(symbol.GetType());
            Console.WriteLine(Convert.ToBoolean(boolean).GetType());
            Console.WriteLine(Convert.ToInt32(data).GetType());

            //Console.WriteLine(Convert.ToInt32(x).GetType());
            //Console.WriteLine(pi);

        }

    }

}