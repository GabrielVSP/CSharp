using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex016
{
    internal class Worker
    {

        private string name;
        private double bruteWage;
        private double taxes;

        public void Set(string name, double wage, double taxes)
        {
            this.name = name;
            this.bruteWage = wage;
            this.taxes = taxes;

        }

        public double LiquidWage()
        {

            return bruteWage - taxes;

        }

        public double IncreaseWage(double percent )
        {

            return LiquidWage() * (1 + percent/100);

        }

    }
}
