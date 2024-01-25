using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaFiskalna.Produkt
{
    internal class BazaProduktow
    {
        private HashSet<Produkt> produkty;

        public BazaProduktow()                                  //możliwe pobranie z bazy danych.
        {
            produkty=new HashSet<Produkt>();
            produkty.Add(new Produkt("0001", "Banan/kg", 4.0));
            produkty.Add(new Produkt("0042", "Chleb", 4.25));
            produkty.Add(new Produkt("5024", "Jabłko/kg", 3.0));

        }

        public void dodajProdukt(Produkt produkt)
        {
            produkty
        }
    }
    
}
