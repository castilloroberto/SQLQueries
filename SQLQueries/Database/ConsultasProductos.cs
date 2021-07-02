using SQLQueries.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLQueries.Database
{
    public class ConsultasProductos:Conexion
    {
        public bool InsertProductos()
        {
            return true;
        }

        public DataTable GetProductos()
        {
            using (var conexion = GetConexion())
            {
                conexion.Open();
                DataTable dataTable = new DataTable();

                SqlCommand query = new SqlCommand("Select * from v_Productos", conexion);
                SqlDataReader dataReader = query.ExecuteReader();
                dataTable.Load(dataReader);

                dataReader.Close();
                conexion.Close();

                return dataTable;
                //return dataTable.AsEnumerable().ToList<dynamic>();
                
                 
            }
        }
    }
}
