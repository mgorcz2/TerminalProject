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
        private Receipt r1;
        private BaseOfProducts b1;
        public Receipt GetReceipt()
        {
            return r1;
        }

        public BaseOfProducts GetBaseOfProducts()
        {
            return b1;
        }
        public void addItem()
        {
            throw new NotImplementedException();
        }

        public void End()
        {
            throw new NotImplementedException();
        }
        public void Start()
        {
            r1 = new Receipt();
            b1= new BaseOfProducts();
        }
    }
}
    
