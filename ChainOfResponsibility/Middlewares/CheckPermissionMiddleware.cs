using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Middlewares
{
    internal class CheckPermissionMiddleware : Middleware
    {
        public override bool Check(string _email, string _password)
        {
            if (_email.Equals("caue@master.com.br"))
            {
                Console.WriteLine("Seja bem vindo administrador");
                return true;
            }

            Console.WriteLine("Seja bem vindo");

            return CheckNext(_email, _password);
        }
    }
}
