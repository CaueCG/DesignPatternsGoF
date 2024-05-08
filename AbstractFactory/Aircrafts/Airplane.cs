using AbstractFactory.LandVehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    internal class Airplane : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos...Ventos à 25km");
        }

        public void GetCarga()
        {
            Console.WriteLine("Passageiros a bordo, voô autorizado");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCarga();
            Console.WriteLine("Iniciando decolagem");
        }
    }

}
