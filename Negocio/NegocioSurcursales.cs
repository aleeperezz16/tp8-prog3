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
    public class NegocioSurcursales
    {
        

        public NegocioSurcursales() { }

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
        public bool eliminarSucursal(int idSucursal)
        {
            DaoSucursal dao = new DaoSucursal();
            return dao.eliminarRegistro(idSucursal) == 1;
        }

        public bool ExisteSucursal(int IdSucursal)
        {
            DaoSucursal dao = new DaoSucursal();
            return dao.ExisteSucursal(IdSucursal);
        }

    }
}
