using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
namespace proyectoBanco.bd

{
    class Conexion
    {
        public SqlConnection con;
        public SqlCommand sen;
        public SqlDataReader rs;

        public Conexion(String bd)
        {
            con = new SqlConnection(
                    //"Data Source=LAB-315-PC\\SQLEXPRESS;" + //autenticacion de windows
                    "Data Source=localhost;" + //localhost
                    "Initial Catalog=" + bd + "; " +
                    "Integrated Security=True;"
                );
        }

        public void ejecutar(String query)
        {
            con.Open();
            sen = new SqlCommand(query, con);

            if (query.Contains("select"))
            {
                rs = sen.ExecuteReader();
            }
            else
            { //insert, update
                sen.ExecuteNonQuery();
                cerrar();
            }
        }

        public void cerrar()
        {
            con.Close();
        }
    }
}