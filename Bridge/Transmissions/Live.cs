using Bridge.Platforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Transmissions
{
    internal class Live : ITransmission
    {
        protected IPlatform platform;
        public Live(IPlatform _platform)
        {
            platform = _platform;
        }
        public void Broadcasting()
        {
            Console.WriteLine($"Iniciando a transmissão na {platform}");
        }

        public void Result()
        {
            Console.WriteLine("*** ONLINE LIVE ***");
        }
    }
}
