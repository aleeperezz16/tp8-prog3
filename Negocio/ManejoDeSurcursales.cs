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
        

        public ManejoDeSurcursales() { }

        public DataTable ObtenerSucursales()
        {
            DaoSucursal dao = new DaoSucursal();
            return dao.getTablaSucursal();
        }

        public bool agregarSucursal(Sucursal sucursal)
        {
            DaoSucursal dao = new DaoSucursal();
            int cantFilas = 0;

           
            /*if (dao.existeCategoría(cat) == false)
            {
                
            }*/
            cantFilas = dao.agregarRegistro(sucursal);

            if (cantFilas == 1)
                return true;
            else
                return false;
        }
        /*public bool eliminarSucursal(Sucursal sucursal)
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
        }*/
    }
}
