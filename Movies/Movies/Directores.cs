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
    public partial class Directores : Form
    {
        private IDBer listener;
        public Directores(object sender)
        {
            InitializeComponent();
            if (sender is IDBer)
            {
                listener = (IDBer)sender;
            }
            foreach(Director d in listener.GetBaseDeDatos().GetDirectores())
            {
                listBox_directores.Items.Add(d.GetNombre() + " " + d.GetApellido());
            }
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
