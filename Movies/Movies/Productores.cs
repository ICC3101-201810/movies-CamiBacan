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
            foreach(Productor p in listener.GetBaseDeDatos().GetProductores())
            {
                if(listBox_productores.SelectedItem.ToString() == p.GetNombre() + " " + p.GetApellido())
                {
                    MessageBox.Show("Nombre: " + p.GetNombre() + " " + p.GetApellido() + "\nFecha de nacimiento: " + p.GetCumpleanos()
                        + "\nBiografia: " + p.GetBiografia(), p.GetNombre() + " " + p.GetApellido(), MessageBoxButtons.OK);
                }
            }
        }
    }
}
