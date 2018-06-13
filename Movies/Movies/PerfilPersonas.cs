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
    public partial class PerfilPersonas : Form
    {
        private IDBer listener;
        public PerfilPersonas(object sender, Persona persona, string nombre)
        {
            InitializeComponent();
            label_nombre.Text = nombre;
            if (sender is IDBer)
            {
                listener = (IDBer)sender;
            }

            if(persona is Actor)
            {
                label_tipoPersona.Text = "Actor:";
                listView1.Items.Add("Nombre: " + persona.GetNombre() + " " + persona.GetApellido());
                listView1.Items.Add("Fecha de nacimiento: " + persona.GetCumpleanos());
                listView1.Items.Add("Biografia: " + persona.GetBiografia());
            }
            else if (persona is Productor)
            {
                label_tipoPersona.Text = "Productor:";
                listView1.Items.Add("Nombre: " + persona.GetNombre() + " " + persona.GetApellido());
                listView1.Items.Add("Fecha de nacimiento: " + persona.GetCumpleanos());
                listView1.Items.Add("Biografia: " + persona.GetBiografia());
            }
            else if (persona is Director)
            {
                label_tipoPersona.Text = "Director:";
                listView1.Items.Add("Nombre: " + persona.GetNombre() + " " + persona.GetApellido());
                listView1.Items.Add("Fecha de nacimiento: " + persona.GetCumpleanos());
                listView1.Items.Add("Biografia: " + persona.GetBiografia());
            }         
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label_tipoPersona_Click(object sender, EventArgs e)
        {

        }

        private void label_nombre_Click(object sender, EventArgs e)
        {

        }
    }
}
