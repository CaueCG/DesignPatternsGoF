using Bridge.Platforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Transmissions
{
    internal class AdvancedLive : Live
    {
        public AdvancedLive(IPlatform _platform) : base(_platform)
        {

        }

        public void Subtitles()
        {
            Console.WriteLine("Legendas ativadas na transmissão");
        }

        public void Comments()
        {
            Console.WriteLine("Comentários liberados na Live");
        }
    }
}
