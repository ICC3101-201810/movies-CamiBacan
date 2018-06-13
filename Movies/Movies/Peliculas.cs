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
    [Serializable]
    public partial class Peliculas : Form
    {
        private IDBer listener;
        public Peliculas(object sender)
        {
            InitializeComponent();
            if(sender is IDBer)
            {
                listener = (IDBer)sender;
            }

            if (listener.GetBaseDeDatos().GetPeliculas() != null)
            {
                foreach (Pelicula p in listener.GetBaseDeDatos().GetPeliculas())
                {
                    listBox_peliculas.Items.Add(p.GetNombre());
                }
            }
            else
            {
                MessageBox.Show("No hay películas en la base de datos!");
            }

            
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox_peliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Pelicula p in listener.GetBaseDeDatos().GetPeliculas())
            {
                if (listBox_peliculas.SelectedItem.ToString() == p.GetNombre())
                {
                    PerfilPeliculas perfilPeliculas = new PerfilPeliculas(listener, p, p.GetNombre());
                    perfilPeliculas.ShowDialog();
                    Hide();
                    Show();
                }                
            }
        }
    }
}
