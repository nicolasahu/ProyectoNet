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

        public Boolean login(String user, String pass) {
            Boolean acceso = false;
            


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
