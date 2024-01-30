using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaFiskalna.Payment
{
    internal interface IPayment
    {
        public Boolean isPaymentSuccessful(Transaction transaction);
    }
}
