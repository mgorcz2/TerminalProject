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
            totalPrice += item.getPrice();
        }
        public void RemoveLast()
        {
            
            if (items.Count > 0)
            {
                items.RemoveAt(items.Count - 1);
                totalPrice -= items.ElementAt(items.Count - 1).getPrice();
            }
        }

        public double getTotalPrice()
        {
            return totalPrice;
        }
        public override string ToString()
        {
            StringBuilder s1 = new StringBuilder();
            s1.Append(date+Environment.NewLine);
            foreach (var el in items)
            {
                s1.Append(el.getName() + ":    " + el.getPrice() + "zł" + Environment.NewLine);
            }

            s1.Append("           Łączna kwota:"+this.getTotalPrice());
            return s1.ToString();
        }
    }

}
