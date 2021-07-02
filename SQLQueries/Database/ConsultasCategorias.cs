using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLQueries.Database
{
    public class ConsultasCategorias:Conexion
    {


        public bool InsertarCategoria(string categoria)
        {
            using (var conexion = GetConexion())
            {
                conexion.Open();

                SqlCommand query = new SqlCommand("sp_insertcategoria",conexion);
                query.CommandType = CommandType.StoredProcedure;
                query.Parameters.AddWithValue("@categoria",categoria);
                bool res = query.ExecuteNonQuery() > 0;
                conexion.Close();

                return res;
            }
        }
        public DataTable GetCategorias()
        {
            using (var conexion = GetConexion())
            {
                conexion.Open();
                DataTable dataTable = new DataTable();
                SqlCommand query = new SqlCommand("Select * from Categories", conexion);
                SqlDataReader dataReader = query.ExecuteReader();
                dataTable.Load(dataReader);
                dataReader.Close();
                conexion.Close();

                return dataTable;
            }
        }
    }
}
