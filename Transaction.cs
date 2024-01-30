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
        private List<Transaction> historyTransactions;    //database
        public Receipt GetReceipt()
        {
            return receipt;
        }

        public Product addItem(String productCode, BaseOfProducts baseof)
        {
           return baseof.FindByCodeProduct(productCode);
        }

        public void End()
        {
            historyTransactions.Add(this);
        }
        public void StartTransaction()
        {
            receipt = new Receipt();
        }
    }
}
    
