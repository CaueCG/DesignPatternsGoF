using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Vehicles
{
    internal class Car : IVehicles
    {
        public void GetCarga()
        {
            Console.WriteLine("Pegamos os passageiros");
        }

        public void StartRoute()
        {
            GetCarga();
            Console.WriteLine("Iniciamos o trajeto");
        }
    }
}
