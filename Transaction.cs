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
        public Receipt GetReceipt()
        {
            return receipt;
        }

        public Product addItem(String productCode, BaseOfProducts baseof)
        {
           return baseof.Find(productCode);
        }

        public void End()
        {
            throw new NotImplementedException();
        }
        public void StartTransaction()
        {
            receipt = new Receipt();
        }
    }
}
    
