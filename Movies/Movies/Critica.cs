using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    public class Critica
    {
        string NombreEmisor;
        string Mensaje;

        public Critica(string nombreEmisor, string mensaje)
        {
            NombreEmisor = nombreEmisor;
            Mensaje = mensaje;
        }

        public string GetNombre()
        {
            return NombreEmisor;
        }
        public string GetMensaje()
        {
            return Mensaje;
        }
    }

}
