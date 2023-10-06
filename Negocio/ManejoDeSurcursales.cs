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

        public void agregarSucursal(Sucursal sucursal)
        {
            String consulta = $"Select * from Sucursales WHERE NombreSucursal LIKE '{sucursal.Nombre}'";

            if (!Conexion.existe(consulta))
            {
                if (Conexion.agregarRegistro(sucursal) != 0)
                {
                    //label: agregado con exito
                }
                else
                {
                    //label: no se pudo agregar
                }
            }
            else
            {
                //label: ya existe la sucursal
            }
        }
    }
}
