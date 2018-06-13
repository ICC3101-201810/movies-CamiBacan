using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    public interface IDBer
    {
        BaseDeDatos GetBaseDeDatos();
    }
}
