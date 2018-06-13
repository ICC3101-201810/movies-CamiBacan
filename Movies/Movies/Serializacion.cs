using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Movies
{
    [Serializable]
    static class Serializacion
    {
        public static void Cargar(BaseDeDatos bd)
        {
            using (Stream stream = File.Open(@"..\..\data\DataActores.bin", FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                List<Actor> actores = (List<Actor>)binaryFormatter.Deserialize(stream);
                foreach (Actor a in actores)
                {
                    bd.GetActores().Add(a);
                }
            }
            using (Stream stream = File.Open(@"..\..\data\DataPeliculas.bin", FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                List<Pelicula> peliculas = (List<Pelicula>)binaryFormatter.Deserialize(stream);
                foreach (Pelicula p in peliculas)
                {
                    bd.GetPeliculas().Add(p);
                }
            }
            using (Stream stream = File.Open(@"..\..\data\DataDirectores.bin", FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                List<Director> directores = (List<Director>)binaryFormatter.Deserialize(stream);
                foreach (Director d in directores)
                {
                    bd.GetDirectores().Add(d);
                }
            }
            using (Stream stream = File.Open(@"..\..\data\DataProductores.bin", FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                List<Productor> productores = (List<Productor>)binaryFormatter.Deserialize(stream);
                foreach (Productor a in productores)
                {
                    bd.GetProductores().Add(a);
                }
            }
            using (Stream stream = File.Open(@"..\..\data\DataEstudios.bin", FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                List<Estudio> estudios= (List<Estudio>)binaryFormatter.Deserialize(stream);
                foreach (Estudio a in estudios)
                {
                    bd.GetEstudios().Add(a);
                }
            }
            using (Stream stream = File.Open(@"..\..\data\DataPeliculaActores.bin", FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                List<PeliculaActor> peliculaActores = (List<PeliculaActor>)binaryFormatter.Deserialize(stream);
                foreach (PeliculaActor a in peliculaActores)
                {
                    bd.GetPeliculaActores().Add(a);
                }
            }
            using (Stream stream = File.Open(@"..\..\data\DataPeliculaProductores.bin", FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                List<PeliculaProductor> peliculaProductores = (List<PeliculaProductor>)binaryFormatter.Deserialize(stream);
                foreach (PeliculaProductor a in peliculaProductores)
                {
                    bd.GetPeliculaProductores().Add(a);
                }
            }
        }

        public static void Guardar(BaseDeDatos bd)
        {
            using (Stream stream = File.Open(@"..\..\data\DataActores.bin", FileMode.Create))
            {
                List<Actor> actores = bd.GetActores();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, actores);
                stream.Close();
            }
            using (Stream stream = File.Open(@"..\..\data\DataPeliculas.bin", FileMode.Create))
            {
                List<Pelicula> peliculas = bd.GetPeliculas();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, peliculas);
                stream.Close();
            }
            using (Stream stream = File.Open(@"..\..\data\DataDirectores.bin", FileMode.Create))
            {
                List<Director> directores = bd.GetDirectores();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, directores);
                stream.Close();
            }
            using (Stream stream = File.Open(@"..\..\data\DataProductores.bin", FileMode.Create))
            {
                List<Productor> productores = bd.GetProductores();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, productores);
                stream.Close();
            }
            using (Stream stream = File.Open(@"..\..\data\DataEstudios.bin", FileMode.Create))
            {
                List<Estudio> estudios = bd.GetEstudios();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, estudios);
                stream.Close();
            }
            using (Stream stream = File.Open(@"..\..\data\DataPEliculaActores.bin", FileMode.Create))
            {
                List<PeliculaActor> peliculaActores = bd.GetPeliculaActores();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, peliculaActores);
                stream.Close();
            }
            using (Stream stream = File.Open(@"..\..\data\DataPeliculaProductores.bin", FileMode.Create))
            {
                List<PeliculaProductor> peliculaProductores = bd.GetPeliculaProductores();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, peliculaProductores);
                stream.Close();
            }
        }
    }
}
