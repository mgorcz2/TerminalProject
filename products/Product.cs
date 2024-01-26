using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaFiskalna.Produkt
{
    internal class Product
    {
        private string code;
        private string name;
        private double price;




        public Product(string code, string name, double price)
        {
            this.code = code;
            this.name=name;
            this.price = price;
        }

        public string getCode()
        {
            return code;
        }

        internal string getName()
        {
            return name;
        }

        internal double getPrice()
        {
            return price;
        }

        public override string ToString()
        {
            return code + " " + name + " " + price;
        }
    }
}
