using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KasaFiskalna.Produkt
{
    internal class BaseOfProducts                           //it should be data from database, but I use instance to test the program
    {
        private static BaseOfProducts instance;
        private HashSet<Product> products;
        private String shopName;
        private String shopAddress;

        public static BaseOfProducts Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BaseOfProducts();
                }
                return instance;
            }
        }
        public BaseOfProducts()
        {
            products = new HashSet<Product>();
            products.Add(new Product("0001", "Banan", 4.0));
            products.Add(new Product("0002", "Komoda", 4.25));
            products.Add(new Product("0002", "Stół", 210.99));
            products.Add(new Product("0003", "Talerz", 3.5));
            products.Add(new Product("0004", "Kubek", 1));
            products.Add(new Product("5025", "Ławka", 3.0));
        }

        public HashSet<Product> GetProducts()
        {
            return products;
        }
        public void AddProduct(Product product)
        {
            products.Add(new Product(product.getCode(), product.getName(), product.getPrice()));
        }

        public void SetShopName(string shopName)
        {
            this.shopName = shopName == null ? "" : shopName;
        }

        public void SetShopAddress(string shopAddress)
        {
            this.shopAddress = shopAddress == null ? "" : shopAddress;
        }
        public void RemoveProduct(string code)
        {
            products.RemoveWhere(p=>p.getCode().Equals(code));
        }

        public Product FindByCodeProduct(string code)
        {
            return products.FirstOrDefault(p => p.getCode().Equals(code));
        }

        public string RandomCode()
        {
            Random random = new Random();
            int randomCode = random.Next(1000,10000);
            while (FindByCodeProduct(randomCode.ToString()) != null)
            {
                randomCode = random.Next(1000, 10000);
            }
            return randomCode.ToString();
        }

        public Product FindByNameProduct(string name)
        {
            return products.FirstOrDefault(p => p.getName().Equals(name,StringComparison.OrdinalIgnoreCase));
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
