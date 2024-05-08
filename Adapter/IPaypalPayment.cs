using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal interface IPaypalPayment
    {
        Token AuthToken();
        void PayPalPayment();
        void PaylPalReceive();
    }
}
