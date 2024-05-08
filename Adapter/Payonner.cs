using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Payonner : IPayonnerPayment
    {
        private Token token;

        public Token AuthTOken()
        {
            return new Token();
        }

        public void ReceivePayment()
        {
            token = AuthTOken();
            Console.WriteLine("Recebendo pagamento Payonner");
        }

        public void SendPayment()
        {
            token = AuthTOken();
            Console.WriteLine("Enviando pagamento Payonner");
        }
    }
}
