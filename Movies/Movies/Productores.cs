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
    public partial class Productores : Form
    {
        private IDBer listener;
        public Productores(object sender)
        {
            InitializeComponent();
            if (sender is IDBer)
            {
                listener = (IDBer)sender;
            }
            foreach(Productor p in listener.GetBaseDeDatos().GetProductores())
            {
                listBox_productores.Items.Add(p.GetNombre() + " " + p.GetApellido());
            }
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Productores_Load(object sender, EventArgs e)
        {

        }

        private void listBox_productores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(listBox_productores.Text.ToString()))
            {
                MessageBox.Show("No seleccionaste nada!");
            }
            else
            {
                foreach (Productor p in listener.GetBaseDeDatos().GetProductores())
                {
                    if (listBox_productores.SelectedItem.ToString() == p.GetNombre() + " " + p.GetApellido())
                    {
                        PerfilPersonas perfilPersonas = new PerfilPersonas(listener, p, p.GetNombre() + " " + p.GetApellido());
                        perfilPersonas.ShowDialog();
                        Hide();
                        Show();
                    }
                }
            }
        }
    }
}
