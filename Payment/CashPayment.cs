using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaFiskalna.Payment
{
    internal class CashPayment : IPayment
    {
        public bool isPaymentSuccessful(Transaction transaction)
        {
            DialogResult result = MessageBox.Show("Czy transakcja gotówką na "+transaction.GetReceipt().getTotalPrice().ToString("C2")+" przebiegła domyślnie?", "STAN PŁATNOŚCI", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
    }
}
