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
    public partial class Bienvenida : Form, IDBer
    {
        Timer timer = new Timer();
        BaseDeDatos bd;
        public Bienvenida()
        {
            InitializeComponent();
            bd = new BaseDeDatos();
            Serializacion.Cargar(bd);

            /*Director directorEnredados = new Director("Director de Tangled", "p", "04/08/1987", "seco");
            Director directorMulan = new Director("Barry", "Cook", "01/07/1960", "Gallo bacán, hizo Mulan, un 7.");
            Estudio disneyStudios = new Estudio("DisneyStudios", "Disney", "07/05/1872");
            Pelicula pelicula1 = new Pelicula("Mulan", directorMulan, "04/09/1992", "Best película", "9876543234567 MUSD$", disneyStudios);
            Pelicula pelicula2 = new Pelicula("Enredados", directorEnredados, "2012", "best pelicula", "mucha plata", disneyStudios);
            Productor productor1 = new Productor("Nombreproductor1", "Apellidoproductor1", "Cumpleanosproductor1", "Biografiproductor1");
            Actor actor1 = new Actor("Cameron", "Díaz", "01/01/01", "Es un pez.");
            Actor mulan = new Actor("Mulan", "Fa", "09876", "salvo a china, cuatica.");
            Director director1 = new Director("James", "Cameron", "01/01/01", "No es un pez.");
            PeliculaActor peliculaActor = new PeliculaActor(pelicula1, mulan);
            PeliculaProductor peliculaProductor = new PeliculaProductor(pelicula2, productor1);

            bd.GetDirectores().Add(directorEnredados); bd.GetEstudios().Add(disneyStudios);
            bd.GetDirectores().Add(directorMulan); bd.GetPeliculas().Add(pelicula1); bd.GetProductores().Add(productor1);
            bd.GetPeliculas().Add(pelicula2); bd.GetActores().Add(actor1); bd.GetDirectores().Add(director1);
            bd.GetPeliculaActores().Add(peliculaActor); bd.GetPeliculaProductores().Add(peliculaProductor);*/
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

        private void button1_Click(object sender, EventArgs e)
        {
            Serializacion.Guardar(bd);
            Close();
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
