using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using DAO;

namespace Negocio
{
    public class ManejoDeSurcursales
    {
        AccesoDatos Conexion;

        public ManejoDeSurcursales() { }

        public DataTable ObtenerSucursales(int idSucursal = 0)
        {
            string consulta = "SELECT Id_Sucursal, NombreSucursal AS Nombre, DescripcionSucursal AS Descripcion, DescripcionProvincia AS Provincia, DireccionSucursal AS Direccion" +
                "FROM Sucursal INNER JOIN Provincia ON Sucursal.Id_ProvinciaSucursal = Provincia.Id_Provincia";

            if (idSucursal > 0)
                consulta += $" WHERE Id_Sucursal = {idSucursal}";

            return Conexion.ObtenerTabla("Sucursales", consulta);
        }

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
