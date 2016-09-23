using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using proyectoBanco.model;
namespace proyectoBanco.bd
{
    class Data
    {
        private Conexion conexion;
        private Cliente cliente;
        private String query;

        public Data()
        {
            conexion = new Conexion("banco");
        }

        public Boolean existeUsuario(String user) {
            Boolean existe = false;
            query = "select count(*) from usuario where nombre_login='"+user+"'";
            conexion.ejecutar(query);

            if (conexion.rs.Read()) {
                existe = Convert.ToBoolean(conexion.rs[0]);
            }

            conexion.cerrar();
            return existe;
        }

        public Boolean login(String user, String pass) {
            Boolean acceso = false;
            query = "select count(*) from usuario where nombre_login='"+user+"' and contraseña='"+pass+"'";
            conexion.ejecutar(query);

            if (conexion.rs.Read())
            {
                acceso = Convert.ToBoolean(conexion.rs[0]);
            }

            conexion.cerrar();

            return acceso;
        }



        /*crear el crud de las tablas*/

        /*crud cliente*/
        public void registrarCliente(Cliente cliente)
        {
            
        }


        /*crud usuario*/


        /*crud cuentas*/


        /*crud privilegio*/
    }
}
