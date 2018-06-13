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
    public partial class Estudios : Form
    {
        private IDBer listener;
        public Estudios(object sender)
        {
            InitializeComponent();
            if (sender is IDBer)
            {
                listener = (IDBer)sender;
            }
            foreach(Estudio e in listener.GetBaseDeDatos().GetEstudios())
            {
                listBox_estudios.Items.Add(e.GetNombre());
            }
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox_estudios_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Estudio es in listener.GetBaseDeDatos().GetEstudios())
            {
                if (listBox_estudios.SelectedItem.ToString() == es.GetNombre())
                {
                    PerfilEstudios perfilEstudios = new PerfilEstudios(listener, es, es.GetNombre());
                    perfilEstudios.ShowDialog();
                    Hide();
                    Show();
                }
            }
        }
    }
}
