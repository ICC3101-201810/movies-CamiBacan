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
    public partial class PerfilEstudios : Form
    {
        public PerfilEstudios(Estudio e)
        {
            label_tipo.Text = "Estudio:";
            InitializeComponent();
            listView_estudios.Items.Add("Nombre: " + e.GetNombre());
            listView_estudios.Items.Add("Direccion: " + e.GetDireccion());
            listView_estudios.Items.Add("Fecha de apertura: " + e.GetFechaApertura());
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
