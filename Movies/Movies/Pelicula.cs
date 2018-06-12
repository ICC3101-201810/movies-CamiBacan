using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    class Pelicula
    {
        string nombre;
        Director director;
        string fechaEstreno;
        string descripcion;
        string presupuesto;
        Estudio estudio;
        
        public Pelicula(string Nombre, Director Director,
            string estreno, string Descripcion, string Presupuesto, Estudio Estudio)
        {
            nombre = Nombre;
            director = Director;
            fechaEstreno = estreno;
            descripcion = Descripcion;
            presupuesto = Presupuesto;
            estudio = Estudio;
        }


    }
}
