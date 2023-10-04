using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AccesoDatos
    {
        public string Ruta { get; set; }
        public AccesoDatos()
        {

        }

        public AccesoDatos(string baseDeDatos)
        {
            Ruta = $"Data Source=localhost\\sqlexpress; Initial Catalog={baseDeDatos}; Integrated Security=True";
        }
    }
}
