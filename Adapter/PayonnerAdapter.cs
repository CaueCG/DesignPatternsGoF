using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class PayonnerAdapter : IPaypalPayment
    {
        private Payonner payonner;
        public PayonnerAdapter(Payonner _payonner)
        {
            payonner = _payonner;
        }

        public Token AuthToken()
        {
            return payonner.AuthTOken();
        }

        public void PaylPalReceive()
        {
            payonner.ReceivePayment();
        }

        public void PayPalPayment()
        {
            payonner.SendPayment();
        }
    }
}
