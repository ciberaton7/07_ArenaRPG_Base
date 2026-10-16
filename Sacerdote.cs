using ArenaRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_ArenaRPG_Base
{
    internal class Sacerdote : SerMitologico, ICurador
    {
        public Sacerdote()
        {
            Nombre = "Sacerdote Andino";
            Vida = 100;
        }

        public override void Atacar()
        {
            Console.WriteLine("El sacerdote golpea con su báculo.");
        }

        public void CurarAliado()
        {
            Console.WriteLine("El sacerdote recita un mantra y cura 50 puntos de vida.");
        }
    }
}
