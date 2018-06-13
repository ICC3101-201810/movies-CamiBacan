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
    public partial class Bienvenida : Form, IDBer
    {
        Timer timer = new Timer();
        BaseDeDatos bd;

        public Bienvenida()
        {
            InitializeComponent();
            bd = new BaseDeDatos();

            Director directorEnredados = new Director("Director de Tangled", "p", "04/08/1987", "seco");
            Director directorMulan = new Director("Barry", "Cook", "01/07/1960", "Gallo bacán, hizo Mulan, un 7.");
            Estudio disneyStudios = new Estudio("DisneyStudios", "Disney", "07/05/1872");
            Pelicula pelicula1 = new Pelicula("Mulan", directorMulan, "04/09/1992", "Best película", "9876543234567 MUSD$", disneyStudios);
            Pelicula pelicula2 = new Pelicula("Enredados", directorEnredados, "2012", "best pelicula", "mucha plata", disneyStudios);

            bd.GetDirectores().Add(directorEnredados); bd.GetEstudios().Add(disneyStudios);
            bd.GetDirectores().Add(directorMulan); bd.GetPeliculas().Add(pelicula1);
                                                   bd.GetPeliculas().Add(pelicula2);
        }

        public BaseDeDatos GetBaseDeDatos()
        {
            return bd;
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {
            /*timer.Interval = 5000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();*/
            Main_Window main_Window = new Main_Window(this);
            main_Window.ShowDialog();
        }
        /*void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            Main_Window main_Window = new Main_Window(this);
            main_Window.ShowDialog();
            //timer.Tick -= new EventHandler(timer_Tick);
            Close();
        }*/
    }
}
