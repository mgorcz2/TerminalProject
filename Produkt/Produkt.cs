using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaFiskalna.Produkt
{
    internal class Produkt
    {
        private string kod;
        private string nazwa;
        private double price;




        public Produkt(string kod, string nazwa, double price)
        {
            this.kod = kod;
            this.nazwa = nazwa;
            this.price = price;
        }

        public override string ToString()
        {
            return kod + " " + nazwa + " " + price;
        }
    }
}
