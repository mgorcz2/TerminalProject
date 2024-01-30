using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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
        public void RemoveSelectedProducts(ListView listView)
        {
            foreach (ListViewItem selectedItem in listView.SelectedItems)
            {
                string productName = selectedItem.SubItems[0].Text;
                Product productToRemove = items.FirstOrDefault(p => p.getName().Equals(productName, StringComparison.OrdinalIgnoreCase));

                if (productToRemove != null)
                {
                    items.Remove(productToRemove);
                }
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
    }

}
