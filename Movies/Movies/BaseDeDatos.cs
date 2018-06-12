using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    class BaseDeDatos
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

        public List<Pelicula> GetPeliculas()
        {
            return peliculas;
        }

        public List<Actor> GetActores()
        {
            return actores;
        }

        public List<Productor> GetProductores()
        {
            return productores;
        }

        public List<Director> GetDirectores()
        {
            return directores;
        }

        public List<Estudio> GetEstudios()
        {
            return estudios;
        }

    }
}
