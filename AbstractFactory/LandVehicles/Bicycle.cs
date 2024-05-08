using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.LandVehicles
{
    internal class Bicycle : ILandVehicles
    {
        public void GetCarga()
        {
            Console.WriteLine("Capturando encomenda de bicicleta...");
        }

        public void StartRoute()
        {
            GetCarga();
            Console.WriteLine("Iniciando pedalada...");
        }
    }
}
