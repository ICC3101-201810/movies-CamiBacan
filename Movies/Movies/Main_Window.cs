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
    public partial class Main_Window : Form
    {
        private IDBer listener;
        public Main_Window(object sender)
        {
            InitializeComponent();
            if (sender is IDBer)
            {
                listener = (IDBer)sender;
            }
        }

        private void Main_Window_Load(object sender, EventArgs e)
        {

        }

        private void textBox_SearchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_peliculas_Click(object sender, EventArgs e)
        {
            Peliculas peliculas = new Peliculas(listener);
            peliculas.ShowDialog();
            Hide();
            Show();
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            Serializacion.Guardar(listener.GetBaseDeDatos());
            Close();
        }

        private void button_actores_Click(object sender, EventArgs e)
        {
            Actores actores = new Actores(listener);
            actores.ShowDialog();
            Hide();
            Show();
        }

        private void button_directores_Click(object sender, EventArgs e)
        {
            Directores directores = new Directores(listener);
            directores.ShowDialog();
            Hide();
            Show();
        }

        private void Productores_Click(object sender, EventArgs e)
        {
            Productores productores = new Productores(listener);
            productores.ShowDialog();
            Hide();
            Show();
        }

        private void button_estudios_Click(object sender, EventArgs e)
        {
            Estudios estudios = new Estudios(listener);
            estudios.ShowDialog();
            Hide();
            Show();

        }
    }
}
