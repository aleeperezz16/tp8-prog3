using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAO;

namespace Negocio
{
    class ManejoDeSurcursales
    {
        AccesoDatos Conexion;

        public ManejoDeSurcursales() { }

        public bool agregarSucursal(Sucursal sucursal)
        {
            int cantidadFilas=0;
            String consulta = $"Select * from Sucursales WHERE NombreSucursal LIKE '{sucursal.Nombre}'";

            if (!Conexion.existe(consulta))
            {
                cantidadFilas = Conexion.agregarRegistro(sucursal);
            }
            if (cantidadFilas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool eliminarSucursal(Sucursal sucursal)
        {
            int cantidadFilas = 0;
            string consulta = $"Select * From Sucursal Where IdSucursal= '{sucursal.IdSucursal}'";
            if (!Conexion.existe(consulta))
            {
                cantidadFilas = Conexion.eliminarRegistro(sucursal);
            }
            if (cantidadFilas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
