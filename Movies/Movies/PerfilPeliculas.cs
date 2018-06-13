using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies
{
    public partial class PerfilPeliculas : Form
    {
        private IDBer listener;
        public PerfilPeliculas(object sender, Pelicula pelicula, string nombre)
        {
            InitializeComponent();
            if (sender is IDBer)
            {
                listener = (IDBer)sender;
            }
            if (pelicula is Pelicula)
            {
                label_tipo.Text = "Peliculas:";
                label_nombre.Text = nombre;
                listView_peliculas.Items.Add("-------------Informacion: ---------");
                listView_peliculas.Items.Add("Nombre: " + pelicula.GetNombre());
                listView_peliculas.Items.Add("Director" + pelicula.GetDirector().GetNombre() + " " + pelicula.GetDirector().GetApellido());
                listView_peliculas.Items.Add("Estudio: " + pelicula.GetEstudio().GetNombre());
                listView_peliculas.Items.Add("Fecha de estreno: " + pelicula.GetFechaEstreno());
                listView_peliculas.Items.Add("Descripción: " + pelicula.GetDescripcion());
                listView_peliculas.Items.Add("Presupuesto: " + pelicula.GetPresupuesto());
                listView_peliculas.Items.Add("-------------Personas involucradas: ---------");
                foreach(PeliculaProductor pp in listener.GetBaseDeDatos().GetPeliculaProductores())
                {
                    if (pelicula == pp.GetPelicula())
                    {
                        listView_peliculas.Items.Add("Productor " + pp.GetProductor().GetNombre() + " " + pp.GetProductor().GetApellido());
                    }
                }
                foreach(PeliculaActor pa in listener.GetBaseDeDatos().GetPeliculaActores())
                {
                    if (pelicula == pa.GetPelicula())
                    {
                        listView_peliculas.Items.Add("Actor " + pa.GetActor().GetNombre() + " " + pa.GetActor().GetApellido());
                    }
                }
                
            }
        
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
