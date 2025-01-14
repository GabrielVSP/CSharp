using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ex020
{
    internal class Product
    {

        private string _name;
        private double _price;
        public int _qnt { get; private set; }

        public Product(string name, double price, int qnt)
        {

            this._name = name;
            this._price = price;
            this._qnt += qnt;

        }

        public Product(string name, double price)
        {

            this._name = name;
            this._price = price;

        }

        public string Name
        {
            get { return _name; }
            set {
                if (!string.IsNullOrEmpty(value) && value.Length > 1)
                {
                    this._name = value;
                }
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0) { this._price = value; }
            }
        }

        //public void SetName(string name)
        //{

        //    if(!string.IsNullOrEmpty(name) && name.Length > 1)
        //    {
        //        this._name = name;
        //    }

        //}

        public string Set(string name, double price, int qnt = 0)
        {
            this._name = name;
            this._price = price;
            this._qnt += qnt;

            return $"Dados do produto: {this._name}, R${this._price}, {this._qnt} unidades, Total: R${GetTotalValue()}";

        }

        public double GetTotalValue()
        {

            return _price * _qnt;

        }

        public string AddQnt(int qnt)
        {

            if (qnt <= 0) throw new Exception("Valor deve ser maior que zero");

            return this.Set(this._name, this._price, qnt);

        }

        public string RemoveQnt(int qnt)
        {

            if (qnt <= 0) throw new Exception("Valor deve ser maior que zero");

            return this.Set(this._name, this._price, qnt * -1);

        }

        public override string ToString()
        {

            return $"Dados do produto: {this._name}, R${this._price}, {this._qnt} unidades, Total: R${GetTotalValue()}";

        }

    }
}
