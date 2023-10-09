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

        private SqlConnection GetConexion()
        {
            try
            {
                SqlConnection cn = new SqlConnection(Ruta);
                cn.Open();
                return cn;
            }
            catch
            {
                return null;
            }
        }

        private SqlDataAdapter GetAdaptador(string consultaSql, SqlConnection cn)
        {
            try
            {
                return new SqlDataAdapter(consultaSql, cn);
            }
            catch
            {
                return null;
            }
        }
        private SqlDataReader GetDataReader(string consulta, SqlConnection cn)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                return cmd.ExecuteReader();
            }
            catch
            {
                return null;
            }
        }
        public DataTable ObtenerTabla(string nombreTabla, string consulta)
        {
            try
            {
                DataSet ds = new DataSet();

                SqlConnection cn = GetConexion();
                SqlDataAdapter adp = GetAdaptador(consulta, cn);

                adp.Fill(ds, nombreTabla);
                cn.Close();

                return ds.Tables[nombreTabla];
            }
            catch
            {
                return null;
            }
        }
        public int EjecutarProcedimientoAlmacenado(ref SqlCommand cmd, string procedimiento)
        {
            try
            {
                SqlConnection cn = GetConexion();

                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedimiento;
                
                int filas = cmd.ExecuteNonQuery();
                cn.Close();
                
                return filas;
            }
            catch
            {
                return 0;
            }
        }

        public bool HayDatos(string consulta)
        {
            SqlConnection cn = GetConexion();
            SqlDataReader data = GetDataReader(consulta, cn);
            bool hayDatos = data.Read();
            cn.Close();

            return hayDatos;
        }
    }
}
