using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Middlewares
{
    public abstract class Middleware
    {
        private Middleware next;
        public Middleware LinkWith(Middleware _next)
        {
            next = _next;
            return next;
        }

        public abstract Boolean Check(string _email, string _password);
        protected Boolean CheckNext(string _email, string _password)
        {
            if (next == null)
                return true;

            return next.Check(_email, _password);
        }
    }
}
