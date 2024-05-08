using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Platforms
{
    internal class Twitch : IPlatform
    {
        public Twitch()
        {
            ConfigureRMTP();
            Console.WriteLine("Twitch: Transmissão iniciada");
        }
        public void AuthToken()
        {
            Console.WriteLine("Twitch: autorizando aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Twitch: configurando servido RMTP");
        }
    }
}
