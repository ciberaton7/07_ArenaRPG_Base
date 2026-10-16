using ArenaRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_ArenaRPG_Base
{
    internal abstract class  Jukumari : SerMitologico //Isaias
    {
        /* - En el constructor de la clase, asígnale el Nombre = "Oso Jukumari" y Vida = 200.
- El IDE te pedirá que implementes el método abstracto. Usa 'override' en el método Atacar() para que imprima en consola: "El Jukumari da un zarpazo */
        public Jukumari()
        {
            Nombre = "Oso Jukumari";
            Vida = 200;
        }
        public override void Atacar()
        {
           Console.WriteLine("El Jukumari da un zarpazo");
        }
    }
}
