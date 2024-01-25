using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KasaFiskalna.Produkt
{
    internal class BaseOfProducts
    {
        private HashSet<Product> products;

        public BaseOfProducts()                                                             //possibly values from database
        {
            products=new HashSet<Product>();
            products.Add(new Product("0001", "Banan/kg", 4.0));
            products.Add(new Product("0042", "Chleb", 4.25));
            products.Add(new Product("5024", "Jabłko/kg", 3.0));
        }
        public void AddProduct(Product product)
        {
            products.Add(new Product(product.getCode(), product.getName(), product.getPrice()));
        }

        public void RemoveProduct(string code)
        {
            products.RemoveWhere(p=>p.getCode().Equals(code));
        }

        public Product Find(string code)
        {
            return products.FirstOrDefault(p => p.getCode().Equals(code));
        }

        public override string ToString()
        {
            StringBuilder s1 = new StringBuilder();
            foreach (var el in products)
            {
                s1.Append(el+Environment.NewLine);
            }
            return s1.ToString();
        }
    }
    
}
