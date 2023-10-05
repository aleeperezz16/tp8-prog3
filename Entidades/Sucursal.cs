using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdHorario { get; set; }
        public int IdProvincia { get; set; }
        public string Direccion { get; set; }
        public string UrlImagen { get; set; }

        public Sucursal()
        {

        }

        public Sucursal(string nombre, string descripcion, int idHorario, int idProvincia, string direccion, string urlImagen)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            IdHorario = idHorario;
            IdProvincia = idProvincia;
            Direccion = direccion;
            UrlImagen = urlImagen;
        }
    }
}
