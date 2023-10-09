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

        string consulta = "SELECT Id_Sucursal, NombreSucursal AS Nombre, DescripcionSucursal AS Descripcion, DescripcionProvincia AS Provincia, DireccionSucursal AS Direccion FROM Sucursal INNER JOIN Provincia ON Sucursal.Id_ProvinciaSucursal = Provincia.Id_Provincia";
        
        /* //Prueba para el ddl
        string consulta = "SELECT S.Id_Sucursal, " +
            "S.NombreSucursal AS Nombre, " +
            "S.DescripcionSucursal AS Descripcion," +
            "S.Id_ProvinciaSucursal , " +
            "P.DescripcionProvincia AS Provincia, " +
            "S.DescripcionSucursal AS Direccion FROM Sucursal S " +
            "INNER JOIN Provincia P ON S.Id_ProvinciaSucursal = P.Id_Provincia";*/

        public DataTable getSucursales()
        {
            DataTable tabla = ds.ObtenerTabla("Sucursal", consulta);
            return tabla;
        }
        public DataTable getProvincias()
        {
            DataTable tabla = ds.ObtenerTabla("Provincia", "SELECT * from provincia");
        
            return tabla;
        }
        public DataTable getSucursal(int IdSucursal)
        {
            //Sucursal sucursal = new Sucursal();
            DataTable tabla = ds.ObtenerTabla("Sucursal", consulta + " where Id_Sucursal="+IdSucursal);
            /*sucursal.IdSucursal = IdSucursal;
            sucursal.Nombre = tabla.Rows[0][1].ToString();
            sucursal.Descripcion = tabla.Rows[0][2].ToString();
            sucursal.IdProvincia = Convert.ToInt32(tabla.Rows[0][3].ToString());
            sucursal.Direccion = tabla.Rows[0][4].ToString();*/
            return tabla;
        }


        public int agregarRegistro(Sucursal sucursal)
        {
            SqlCommand comando = new SqlCommand();
            armarParametrosSucursalAgregar(ref comando, sucursal);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAgregarSucursal");
        }

        public int eliminarRegistro(Sucursal sucursal)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosSucursalEliminar(ref comando, sucursal);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spEliminarSucursal");
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
            SqlParametros = Comando.Parameters.Add("@DIRECCIONSUCURSAL", SqlDbType.VarChar);
            SqlParametros.Value = sucursal.Direccion;
        }

        private void ArmarParametrosSucursalEliminar(ref SqlCommand Comando, Sucursal sucursal)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDSUCURSAL", SqlDbType.Int);
            SqlParametros.Value = sucursal.IdSucursal;
        }

        /*
        CREATE PROCEDURE[dbo].[spAgregarSucursal]
        (
        @NOMBRESUC VARCHAR(100),
		@DESCRIPCIONSUCURSAL VARCHAR(100),
		@IDPROVINCIASUCURSAL INT,
		@DIRECCIONSUCURSAL VARCHAR(100)
        )
        AS
        INSERT INTO Sucursal(NombreSucursal, DescripcionSucursal, Id_ProvinciaSucursal, DireccionSucursal) 
		VALUES(@NOMBRESUC,@DESCRIPCIONSUCURSAL,@IDPROVINCIASUCURSAL,@DIRECCIONSUCURSAL)
        RETURN

        */

        /*
       CREATE PROCEDURE[dbo].[spEliminarSucursal]
        (
        @IDSUCURSAL VARCHAR(100)
        )
		AS
        DELETE Sucursal WHERE Id_Sucursal = @IDSUCURSAL
        RETURN
        */
    }
}
