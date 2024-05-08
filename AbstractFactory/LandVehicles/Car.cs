using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.LandVehicles
{
    internal class Car : ILandVehicles
    {
        public void GetCarga()
        {
            Console.WriteLine("Pegamos os passageiros, estamos prontos");
        }

        public void StartRoute()
        {
            GetCarga();
            Console.WriteLine("Iniciando o trajeto de carro");
        }
    }
}
