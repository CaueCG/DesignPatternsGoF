﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class PayPal : IPaypalPayment
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void PaylPalReceive()
        {
            Console.WriteLine("Recebendo pagamentos com PayPal");
        }

        public void PayPalPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamentos com PayPal");
        }
    }
}
