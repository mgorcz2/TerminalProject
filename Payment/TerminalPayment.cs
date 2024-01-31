using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaFiskalna.Payment
{
    internal class TerminalPayment:IPayment
    {
        public bool isPaymentSuccessful(Transaction transaction)
        {
            if (connectWithTerminal())
            {
                if (terminalAnswer())
                {
                    MessageBox.Show("Operacja na kwotę " + transaction.GetReceipt().getTotalPrice().ToString("C2") +
                                    " udała się");
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool connectWithTerminal()//virtual
        {
            //checking our connection with terminal
            return true;
        }

        public bool terminalAnswer()//virtual
        {
            //if payment succesfull terminal gonna return true
            return true;
        }
    }
}
