using AbstractFactory.LandVehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    internal class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando ventos para voo do drone...");
        }

        public void GetCarga()
        {
            Console.WriteLine("Capturando carga com o drone...");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCarga();
            Console.WriteLine("Iniciando decolagem drone...");
        }
    }
}
