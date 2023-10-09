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

        public SqlConnection getConexion()
        {
            SqlConnection cn = new SqlConnection(this.Ruta);
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public SqlDataAdapter getAdaptador(String consultaSql, SqlConnection cn)
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(consultaSql, cn);
                return adaptador;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public SqlDataReader getDataReader(String Consulta)
        {
            SqlConnection Conexion = getConexion();
            SqlCommand cmd = new SqlCommand(Consulta, Conexion);
            SqlDataReader datos = cmd.ExecuteReader();
            return datos;
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

        public int EjecutarProcedimientoAlmacenado(SqlCommand Comando, String NombreSP)
        {
            int FilasCambiadas;
            SqlConnection Conexion = getConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = Comando;
            cmd.Connection = Conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreSP;
            FilasCambiadas = cmd.ExecuteNonQuery();
            Conexion.Close();
            return FilasCambiadas;
        }

    }
}
