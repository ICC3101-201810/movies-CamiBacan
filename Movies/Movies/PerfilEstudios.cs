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
    public partial class PerfilEstudios : Form
    {
        private IDBer listener;
        public PerfilEstudios(object sender, Estudio e, string nombre)
        {
            InitializeComponent();
            if (sender is IDBer)
            {
                listener = (IDBer)sender;
            }
            label_tipo.Text = "Estudio:";
            label_nombre.Text = nombre;
            listView_estudios.Items.Add("-------------Informacion: ---------");
            listView_estudios.Items.Add("Nombre: " + e.GetNombre());
            listView_estudios.Items.Add("Direccion: " + e.GetDireccion());
            listView_estudios.Items.Add("Fecha de apertura: " + e.GetFechaApertura());
            listView_estudios.Items.Add("-------------Peliculas involucradas: ---------");
            foreach(Pelicula p in listener.GetBaseDeDatos().GetPeliculas())
            {
                if (p.GetEstudio().GetNombre() == e.GetNombre())
                {
                    listView_estudios.Items.Add(p.GetNombre());
                }
            }
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView_estudios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_tipo_Click(object sender, EventArgs e)
        {

        }
    }
}
