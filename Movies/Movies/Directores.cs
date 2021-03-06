﻿using System;
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

        private void listBox_directores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(listBox_directores.Text.ToString()))
            {
                MessageBox.Show("No seleccionaste nada!");
            }
            else
            {
                foreach (Director d in listener.GetBaseDeDatos().GetDirectores())
                {
                    if (listBox_directores.SelectedItem.ToString() == d.GetNombre() + " " + d.GetApellido())
                    {
                        PerfilPersonas perfilPersonas = new PerfilPersonas(listener, d, d.GetNombre() + " " + d.GetApellido());
                        perfilPersonas.ShowDialog();
                        Hide();
                        Show();
                    }
                }
            }
        }
    }
}
