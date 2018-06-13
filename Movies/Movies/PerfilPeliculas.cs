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
        public PerfilPeliculas(Pelicula pelicula)
        {
            label_tipo.Text = "Peliculas";
            InitializeComponent();
            listView_peliculas.Items.Add("Nombre: " + pelicula.GetNombre());
            listView_peliculas.Items.Add("Director" + pelicula.GetDirector().GetNombre() + " " + pelicula.GetDirector().GetApellido());
            listView_peliculas.Items.Add("Estudio: " + pelicula.GetEstudio().GetNombre());
            listView_peliculas.Items.Add("Fecha de estreno: " +  pelicula.GetFechaEstreno());
            listView_peliculas.Items.Add("Descripción: " + pelicula.GetDescripcion());
            listView_peliculas.Items.Add("Presupuesto: " + pelicula.GetPresupuesto());
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
