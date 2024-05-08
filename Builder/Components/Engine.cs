using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Components
{
    internal class Engine
    {
        private int power { get; set; }
        public Engine(int _power)
        {
            power = _power;
        }
    }
}
