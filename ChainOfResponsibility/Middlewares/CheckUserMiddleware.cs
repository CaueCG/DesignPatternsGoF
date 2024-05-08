using ChainOfResponsibility.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Middlewares
{
    internal class CheckUserMiddleware : Middleware
    {
        private Server server;
        public CheckUserMiddleware(Server _server) {
            server = _server;
        }

        public override bool Check(string _email, string _password)
        {
            if(!server.HasEmail(_email))
            {
                Console.WriteLine("Email inválido");
                return false;
            }

            if(server.IsValidPassword(_email, _password))
            {
                Console.WriteLine("Email e senha inválidos");
                return false;
            }

            return CheckNext(_email, _password);
        }
    }
}
