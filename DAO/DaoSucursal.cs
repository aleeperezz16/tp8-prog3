using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;
using DAO;

namespace DAO
{
    public class DaoSucursal
    {
        private AccesoDatos _dataBase = new AccesoDatos("BDSucursales");
        public DaoSucursal()
        {

        }
        public DataTable GetSucursales(int idSucursal)
        {
            string consulta = "SELECT Id_Sucursal, NombreSucursal AS Nombre, DescripcionSucursal AS Descripcion, DescripcionProvincia AS Provincia, DireccionSucursal AS Direccion FROM Sucursal INNER JOIN Provincia ON Sucursal.Id_ProvinciaSucursal = Provincia.Id_Provincia";

            if (idSucursal > 0)
                consulta += $" WHERE Id_Sucursal = {idSucursal}";
            
            return _dataBase.ObtenerTabla("Sucursales", consulta);
        }
        public DataTable GetProvincias()
        {
            return _dataBase.ObtenerTabla("Provincia", "SELECT * FROM Provincia");
        }
        
        public bool ExisteSucursal(int idSucursal)
        {
            return _dataBase.HayDatos($"SELECT Id_Sucursal FROM Sucursal WHERE Id_Sucursal = {idSucursal}");
        }

        public int AgregarRegistro(Sucursal sucursal)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosSucursalAgregar(ref comando, sucursal);
            return _dataBase.EjecutarProcedimientoAlmacenado(ref comando, "spAgregarSucursal");
        }

        public int EliminarRegistro(int idSucursal)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosSucursalEliminar(ref comando, idSucursal);
            return _dataBase.EjecutarProcedimientoAlmacenado(ref comando, "spEliminarSucursal");
        }

        private void ArmarParametrosSucursalAgregar(ref SqlCommand cmd, Sucursal sucursal)
        {
            SqlParameter sqlParams = cmd.Parameters.Add("@NOMBRESUC", SqlDbType.VarChar);
            sqlParams.Value = sucursal.Nombre;

            sqlParams = cmd.Parameters.Add("@DESCRIPCIONSUCURSAL", SqlDbType.VarChar);
            sqlParams.Value = sucursal.Descripcion;

            sqlParams = cmd.Parameters.Add("@IDPROVINCIASUCURSAL", SqlDbType.Int);
            sqlParams.Value = sucursal.IdProvincia;

            sqlParams = cmd.Parameters.Add("@DIRECCIONSUCURSAL", SqlDbType.VarChar);
            sqlParams.Value = sucursal.Direccion;
        }

        private void ArmarParametrosSucursalEliminar(ref SqlCommand comando, int id)
        {
            SqlParameter sqlParams = comando.Parameters.Add("@IDSUCURSAL", SqlDbType.Int);
            sqlParams.Value = id;
        }

        /*
        CREATE PROCEDURE [dbo].[spAgregarSucursal]
        (
	        @NOMBRESUC VARCHAR(100),
	        @DESCRIPCIONSUCURSAL VARCHAR(100),
	        @IDPROVINCIASUCURSAL INT,
	        @DIRECCIONSUCURSAL VARCHAR(100)
        )
        AS
	        INSERT INTO Sucursal (NombreSucursal, DescripcionSucursal, Id_ProvinciaSucursal, DireccionSucursal) 
	        VALUES (@NOMBRESUC, @DESCRIPCIONSUCURSAL, @IDPROVINCIASUCURSAL, @DIRECCIONSUCURSAL)
        GO

        CREATE PROCEDURE [dbo].[spEliminarSucursal]
        (
	        @IDSUCURSAL INT
        )
        AS
	        DELETE FROM Sucursal WHERE Id_Sucursal = @IDSUCURSAL
        GO
        */
    }
}
