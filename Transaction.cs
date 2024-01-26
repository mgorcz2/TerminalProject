using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KasaFiskalna.Produkt;
using KasaFiskalna.receipt;

namespace KasaFiskalna
{
    internal class Transaction : IKasa
    {
        private Receipt receipt;
        private BaseOfProducts baseofproducts;
        public Receipt GetReceipt()
        {
            return receipt;
        }

        public BaseOfProducts GetBaseOfProducts()
        {
            return baseofproducts;
        }
        public Product addItem(String productCode)
        {
           return this.GetBaseOfProducts().Find(productCode);
        }

        public void End()
        {
            throw new NotImplementedException();
        }
        public void StartTransaction()
        {
            receipt = new Receipt();
            baseofproducts= new BaseOfProducts();
        }
    }
}
    
