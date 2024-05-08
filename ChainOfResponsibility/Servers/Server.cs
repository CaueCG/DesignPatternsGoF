using ChainOfResponsibility.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Servers
{
    public class Server
    {
        private Dictionary<string, string> users = new Dictionary<string, string>();
        private Middleware middleware;

        public void SetMiddleware(Middleware _middleware)
        {
            middleware = _middleware;
        }

        public Boolean Login(string _email, string _password)
        {
            if (middleware.Check(_email, _password))
            {
                Console.WriteLine("Usuário logado com sucesso");
                Console.WriteLine("Seja bem vindo ");
                return true;
            }

            return false;
        }

        public void RegisterUser(string _email, string _password)
        {
            users[_email] = _password;
        }

        public Boolean HasEmail(string _email)
        {
            return users.ContainsKey(_email);
        }

        public Boolean IsValidPassword(string _email, string _password)
        {
            string value = "";

            users.TryGetValue(_email, out value);

            return _password == value;
        }
    }
}
