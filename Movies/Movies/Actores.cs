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
    public partial class Actores : Form
    {
        private IDBer listener;
        public Actores(object sender)
        {
            InitializeComponent();
            if(sender is IDBer)
            {
                listener = (IDBer)sender;
            }
            foreach(Actor a in listener.GetBaseDeDatos().GetActores())
            {
                listBox_actores.Items.Add(a.GetNombre() + " " + a.GetApellido());
            }
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox_actores_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Actor a in listener.GetBaseDeDatos().GetActores())
            {
                if (listBox_actores.SelectedItem.ToString() == a.GetNombre() + " " + a.GetApellido())
                {
                    PerfilPersonas perfilPersonas = new PerfilPersonas(listener, a, a.GetNombre() + " " + a.GetApellido());
                    perfilPersonas.ShowDialog();
                    Hide();
                    Show();
                }
            }
        }
    }
}
