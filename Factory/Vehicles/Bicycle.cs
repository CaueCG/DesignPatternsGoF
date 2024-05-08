using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Vehicles
{
    internal class Bicycle : IVehicles
    {
        public void GetCarga()
        {
            Console.WriteLine("Carga coletada de bicicleta...");
        }

        public void StartRoute()
        {
            GetCarga();
            Console.WriteLine("Iniciando pedalada...");
        }
    }
}
