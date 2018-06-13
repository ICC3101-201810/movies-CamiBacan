using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    public class Actor : Persona
    {
        public Actor(string nombre, string apellido, string cumpleanos, string biografia) : base(nombre, apellido, cumpleanos, biografia)
        {

        }
    }
}
