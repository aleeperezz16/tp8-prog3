using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
        public int IdSucursal { get => IdSucursal;}
        public string Nombre { get => Nombre; set => Nombre = value;}
        public string Descripcion { get => Descripcion; set => Descripcion = value;}
        public int IdProvincia { get => IdProvincia; set => IdProvincia = value;}
        public string Direccion { get => Direccion; set => Direccion = value;}
        public string UrlImagen { get => UrlImagen; set => UrlImagen = value;}

        public Sucursal()
        {

        }

        public Sucursal(string nombre, string descripcion, int idProvincia, string direccion, string urlImagen)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            IdProvincia = idProvincia;
            Direccion = direccion;
            UrlImagen = urlImagen;
        }
    }
}
