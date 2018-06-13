using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    [Serializable]
    public class Estudio
    {
        string Nombre;
        string Direccion;
        string FechaApertura;

        public Estudio(string nombre, string direccion, string fechaApertura)
        {
            Nombre = nombre;
            Direccion = direccion;
            FechaApertura = fechaApertura;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public string GetDireccion()
        {
            return Direccion;
        }

        public string GetFechaApertura()
        {
            return FechaApertura;
        }
    }
}
