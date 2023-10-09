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
    public class NegocioSucursales
    {
        private DaoSucursal dao = new DaoSucursal();
        public NegocioSucursales() 
        {
        }
        public DataTable ObtenerProvincias()
        {
            return dao.GetProvincias();
        }
        public DataTable ObtenerSucursales(int id = 0)
        {
            return dao.GetSucursales(id);
        }
        
        public bool AgregarSucursal(Sucursal sucursal)
        {
            return dao.AgregarRegistro(sucursal) == 1;
        }
        public bool EliminarSucursal(int idSucursal)
        {
            return dao.EliminarRegistro(idSucursal) == 1;
        }
        public bool ExisteSucursal(int id)
        {
            return dao.ExisteSucursal(id);
        }

    }
}
