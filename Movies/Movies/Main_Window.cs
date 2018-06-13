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
            Close();
        }
    }
}
