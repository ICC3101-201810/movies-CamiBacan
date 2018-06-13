using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    abstract public class Persona
    {
        string Nombre;
        string Apellido;
        string FechaDeNacimiento;
        string Biografia;

        public Persona(string nombre, string apellido, string fechaDeNacimiento, string biografia)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaDeNacimiento = fechaDeNacimiento;
            Biografia = biografia;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public string GetApellido()
        {
            return Apellido;
        }

        public string GetCumpleanos()
        {
            return FechaDeNacimiento;
        }

        public string GetBiografia()
        {
            return Biografia;
        }


    }
}
