using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLQueries.Database
{
    public class Conexion
    {


        protected SqlConnection GetConexion() => new SqlConnection(GetString());  

        private  string GetString()
        {

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"localhost\SQLEXPRESS";
            builder.InitialCatalog = "northwind";
            builder["Trusted_Connection"] = true;
            return builder.ConnectionString;
        }




    }
}
