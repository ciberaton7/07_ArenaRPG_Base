using ArenaRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_ArenaRPG_Base
{
    internal class Duende : SerMitologico, IRecompensable //Cristhoper
    {
        public Duende()
        {
            Nombre = "Duende Ladron";
            Vida = 50;
        }
        public override void Atacar()
        {
            Console.WriteLine("El duende lanza una piedra!");
        }
        void IRecompensable.SoltarBotin()
        {
            Console.WriteLine("El duende soltó 15 monedas de oro.");
        }
    }
}
