using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ex017
{
    internal class Calculator
    {
        static public double pi = 3.14159;

        static public double Circle(double radius)
        {

            return 2 * pi * radius;

        }

        static public double Volume(double radius) 
        { 

            return (4 * pi * Math.Pow(radius, 3))/3;
        
        }

    }
}
