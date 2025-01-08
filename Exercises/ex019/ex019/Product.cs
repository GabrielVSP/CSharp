using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex019
{
    internal class Product
    {

        private string name;
        private double price;
        private int qnt;

        public Product(string name, double price, int qnt)
        {

            this.name = name;
            this.price = price;
            this.qnt += qnt;

        }

        public string Set(string name, double price, int qnt = 0)
        {
            this.name = name;
            this.price = price;
            this.qnt += qnt;

            return $"Dados do produto: {this.name}, R${this.price}, {this.qnt} unidades, Total: R${GetTotalValue()}";

        }

        public double GetTotalValue()
        {

            return price * qnt;

        }

        public string AddQnt(int qnt)
        {

            if (qnt <= 0) throw new Exception("Valor deve ser maior que zero");

            return this.Set(this.name, this.price, qnt);

        }

        public string RemoveQnt(int qnt)
        {

            if (qnt <= 0) throw new Exception("Valor deve ser maior que zero");

            return this.Set(this.name, this.price, qnt * -1);

        }

        public override string ToString() {

            return $"Dados do produto: {this.name}, R${this.price}, {this.qnt} unidades, Total: R${GetTotalValue()}";

        }

    }
}
