using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DaoSucursal
    {
        AccesoDatos ds = new AccesoDatos("BDSucursales");
        public DataTable getTablaSucursal()
        {
            DataTable tabla = ds.ObtenerTabla("Categoria", "SELECT Id_Sucursal, NombreSucursal AS Nombre, DescripcionSucursal AS Descripcion, DescripcionProvincia AS Provincia, DireccionSucursal AS Direccion FROM Sucursal INNER JOIN Provincia ON Sucursal.Id_ProvinciaSucursal = Provincia.Id_Provincia");
            return tabla;
        }

        
        public int agregarRegistro(Sucursal sucursal)
        {
            SqlCommand comando = new SqlCommand();
            armarParametrosSucursalAgregar(ref comando, sucursal);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAgregarSucursal");
        }

        /*public int eliminarRegistro(Sucursal sucursal)
        {
            SqlConnection conexion = getConexion();
            String consulta = $"Delete from Sucursal Where Id_Sucursal={sucursal.IdSucursal}";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            int filasAfectadas = comando.ExecuteNonQuery();
            return filasAfectadas;

        }*/

        private void armarParametrosSucursalAgregar(ref SqlCommand Comando, Sucursal sucursal)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@NOMBRESUC", SqlDbType.VarChar);
            SqlParametros.Value = sucursal.Nombre;
            SqlParametros = Comando.Parameters.Add("@DESCRIPCIONSUCURSAL", SqlDbType.VarChar);
            SqlParametros.Value = sucursal.Descripcion;
            SqlParametros = Comando.Parameters.Add("@IDPROVINCIASUCURSAL", SqlDbType.Int);
            SqlParametros.Value = sucursal.IdProvincia;
            SqlParametros = Comando.Parameters.Add("@DIRECCIONSUCURSAL", SqlDbType.Int);
            SqlParametros.Value = sucursal.Direccion;
        }
    }
}
