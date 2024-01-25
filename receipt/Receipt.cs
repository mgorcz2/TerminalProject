using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KasaFiskalna.Produkt;

namespace KasaFiskalna.receipt
{
    internal class Receipt
    {
        private List<Product> items;
        private double totalPrice;
        private DateTime date;

        public Receipt()
        {
            items=new List<Product>();
            totalPrice = 0;
            date = DateTime.Now;
        }

        public void AddProduct(Product item)
        {
            items.Add(item);
            totalPrice = totalPrice + item.getPrice();
        }
        public void RemoveProduct(Product item)
        {
            items.RemoveAll(p => p == item);
        }
        public override string ToString()
        {
            StringBuilder s1 = new StringBuilder();
            foreach (var el in items)
            {
                s1.Append(el.ToString() + Environment.NewLine);
            }
            return s1.ToString();
        }
    }

}
