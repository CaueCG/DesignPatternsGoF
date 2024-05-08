using AbstractFactory.LandVehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    internal class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos no helicóptero");
        }

        public void GetCarga()
        {
            Console.WriteLine("Passageiros a bordo no helicóptero, inciando as élices");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCarga();
            Console.WriteLine("Iniciando decolagem no helicóptero");
        }
    }

}
