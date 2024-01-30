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

        public List<Product> getItems()
        {
            return items;
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
                totalPrice -= items.ElementAt(items.Count - 1).getPrice();
                items.RemoveAt(items.Count - 1);
            }
        }

        public double getTotalPrice()
        {
            return totalPrice;
        }

        public DateTime getDate()
        {
            return date;
        }
        private int GetStringWidth(string text)
        {
            using (Graphics graphics = Graphics.FromImage(new Bitmap(1, 1)))
            {
                SizeF size = graphics.MeasureString(text, new Font("Arial", 12));
                return (int)size.Width;
            }
        }
        public override string ToString()
        {
            StringBuilder s1 = new StringBuilder();
            s1.Append(date+Environment.NewLine);
            foreach (var el in items)
            {
                string itemName = el.getName().PadRight(30-el.getName().Length);
                string itemPrice = el.getPrice().ToString(format:"C2");
                s1.AppendLine($"{itemName}{itemPrice}");
            }

            s1.Append("        Łączna kwota do zapłaty: "+this.getTotalPrice()+"zł");
            return s1.ToString();
        }
    }

}
