using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    public class PeliculaProductor
    {
        Pelicula Pelicula;
        Productor Productor;

        public PeliculaProductor(Pelicula pelicula, Productor productor)
        {
            Pelicula = pelicula;
            Productor = productor;
        }

        public Pelicula GetPelicula()
        {
            return Pelicula;
        }

        public Productor GetProductor()
        {
            return Productor;
        }
    }
}
