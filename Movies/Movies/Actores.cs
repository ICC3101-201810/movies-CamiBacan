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
    }
}
