using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaFiskalna.Payment
{
    internal class CashPayment : IPayment
    {
        public bool isPaymentSuccessful()
        {
            throw new NotImplementedException();
        }

        public void processPayment(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
