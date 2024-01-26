using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KasaFiskalna.Produkt;

namespace KasaFiskalna
{
    internal interface IKasa
    {
        public void StartTransaction();
        public void End();

        public Product addItem(String code);
    }
}
