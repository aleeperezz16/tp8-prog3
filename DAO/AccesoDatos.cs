using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace DAO
{
    public class AccesoDatos
    {
        public string Ruta { get; set; }
        public AccesoDatos()
        {

        }

        public AccesoDatos(string baseDeDatos)
        {
            Ruta = $"Data Source=localhost\\sqlexpress; Initial Catalog={baseDeDatos}; Integrated Security=True";

        }

        private SqlConnection getConexion()
        {
            SqlConnection cn = new SqlConnection(this.Ruta);
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private SqlDataAdapter getAdaptador(String consultaSql, SqlConnection cn)
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(consultaSql, cn);
                return adaptador;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private SqlDataReader getDataReader(String Consulta)
        {
            SqlConnection Conexion = getConexion();
            SqlCommand cmd = new SqlCommand(Consulta, Conexion);
            SqlDataReader datos = cmd.ExecuteReader();
            return datos;
        }

        public DataTable getTablaSucursales()
        {
            DataTable tabla = ObtenerTabla("Sucursal", "Select Id_Sucursal,NombreSucursal as Nombre, DescripcionSucursal as Descripcion, DescripcionProvincia ,DireccionSucursal  from Sucursal INNER JOIN Provincia ON Id_Provincia=Id_ProvinciaSucursal");
            return tabla;
        }
        public DataTable ObtenerTabla(String NombreTabla, String consulta)
        {
            DataSet ds = new DataSet();
            SqlConnection Conexion = getConexion();
            SqlDataAdapter adp = getAdaptador(consulta, Conexion);
            adp.Fill(ds, NombreTabla);
            Conexion.Close();
            return ds.Tables[NombreTabla];
        }


        public Boolean existe(String consulta)
        {
            Boolean estado = false;
            SqlConnection Conexion = getConexion();
            SqlDataReader datos = getDataReader(consulta);
            if (datos.Read())
            {
                estado = true;
            }
            return estado;
        }

        public int agregarRegistro(Sucursal sucursal)
        {          

            String Consulta = "INSERT INTO Sucursal (NombreSucursal,DescripcionSucursal,Id_ProvinciaSucursal,DireccionSucursal) " +
                $"VALUES  ({sucursal.Nombre},{sucursal.Descripcion},{sucursal.IdProvincia},{sucursal.Direccion})";
            SqlConnection Conexion = getConexion();

            SqlCommand comando = new SqlCommand(Consulta,Conexion);   

            return comando.ExecuteNonQuery();
            
        }

        public int eliminarRegistro(Sucursal sucursal)
        {
            SqlConnection conexion = getConexion();
            String consulta =$"Delete from Sucursal Where Id_Sucursal={sucursal.IdSucursal}";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            int filasAfectadas = comando.ExecuteNonQuery();
            return filasAfectadas;

        }

    }
}
