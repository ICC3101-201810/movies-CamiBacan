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
    }
}
