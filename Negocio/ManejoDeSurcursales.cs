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

        public DataTable ObtenerProvincias()
        {
            DaoSucursal dao = new DaoSucursal();
            return dao.getProvincias();
        }
        public DataTable ObtenerSucursales()
        {
            DaoSucursal dao = new DaoSucursal();
            return dao.getSucursales();
        }
        public DataTable ObtenerSucursal(int id)
        {
            DaoSucursal dao = new DaoSucursal();
            return dao.getSucursal(id);
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
        public bool eliminarSucursal(Sucursal sucursal)
        {
            DaoSucursal dao = new DaoSucursal();
            int cantidadFilas = 0;
            /*if (!Conexion.existe(consulta))
            {
                
            }*/
            cantidadFilas = dao.eliminarRegistro(sucursal);
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
