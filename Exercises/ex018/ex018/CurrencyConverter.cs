using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex018
{
    internal class CurrencyConverter
    {

        static private double IOF = 0.06;

        static public double Convert(double value, double quota)
        {

            return (value * quota) * (1 + IOF);

        }

    }
}
