using ArenaRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_ArenaRPG_Base
{
    internal class Supay: SerMitologico, IMagico //Chubi
    {
        public Supay()
        {
            Nombre = "Supay";
            Vida = 300;
        }
        public int Mana { get; set; } = 100;
      

        // Constructor de la clase que inicializa la propiedad de la interfa
        public override void Atacar()
        {
           Console.WriteLine("Supay ataca con su tridente.");
        }

          void IMagico.LanzarHechizo()
        {
            Console.WriteLine("Supay invoca fuego del inframundo!");
            Mana = Mana - 20;
        }
    }

}
