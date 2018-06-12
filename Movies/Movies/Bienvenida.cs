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
    public partial class Bienvenida : Form
    {
        Timer timer = new Timer();

        public Bienvenida()
        {
            InitializeComponent();
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {
            timer.Interval = 5000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            Main_Window main_Window = new Main_Window();
            main_Window.Show();
            //timer.Tick -= new EventHandler(timer_Tick);
            Close();
        }
    }
}
