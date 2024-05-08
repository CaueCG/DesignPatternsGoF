using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Vehicles
{
    internal class Moto : IVehicles
    {
        public void GetCarga()
        {
            Console.WriteLine("Pegamos a encomenda");
        }

        public void StartRoute()
        {
            GetCarga();
            Console.WriteLine("Iniciando a entrega");
        }
    }
}
