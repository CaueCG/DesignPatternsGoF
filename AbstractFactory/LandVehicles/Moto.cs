using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.LandVehicles
{
    internal class Moto : ILandVehicles
    {
        public void GetCarga()
        {
            Console.WriteLine("Pegamos a encomenda");
        }

        public void StartRoute()
        {
            GetCarga();
            Console.WriteLine("Iniciando a entrega de moto");
        }
    }
}
