using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    public class BaseDeDatos
    {
        List<Pelicula> peliculas;
        List<Actor> actores;
        List<Productor> productores;
        List<Director> directores;
        List<Estudio> estudios;

        public BaseDeDatos()
        {
            peliculas = new List<Pelicula>();
            actores = new List<Actor>();
            productores = new List<Productor>();
            directores = new List<Director>();
            estudios = new List<Estudio>();
        }

        internal List<Pelicula> GetPeliculas()
        {
            return peliculas;
        }

        internal List<Actor> GetActores()
        {
            return actores;
        }

        internal List<Productor> GetProductores()
        {
            return productores;
        }

        internal List<Director> GetDirectores()
        {
            return directores;
        }

        internal List<Estudio> GetEstudios()
        {
            return estudios;
        }

    }
}
