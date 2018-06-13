using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    [Serializable]
    public class PeliculaActor
    {
        Pelicula Pelicula;
        Actor Actor;
        //List<PeliculaActor> peliculaActores;

        public PeliculaActor(Pelicula pelicula, Actor actor)
        {
            Pelicula = pelicula;
            Actor = actor;
            //peliculaActores = new List<PeliculaActor>();
        }

        /*public List<PeliculaActor> GetPeliculaActores()
        {
            return peliculaActores;
        }*/

        public Pelicula GetPelicula()
        {
            return Pelicula;
        }
        public Actor GetActor()
        {
            return Actor;
        }
    }
}
