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

        /*crud usuario*/
        public Usuario getUsuario(String nombreLogin) {
            Usuario u=null;
            query = "select * from usuario where nombre_login='" + nombreLogin + "'";
            conexion.ejecutar(query);

            if (conexion.rs.Read()){
                u = new Usuario();
                u.Id = Convert.ToInt32(conexion.rs[0]);
                u.NombreLogin = conexion.rs[1].ToString();
                u.Contraseña = conexion.rs[2].ToString();
                u.Privilegio = Convert.ToInt32(conexion.rs[3]);
            }

            conexion.cerrar();
            return u;
        }

        public Cliente getCliente(int idUsuario)
        {
            Cliente c = null;
            query = "select*from cliente where usuario=" + idUsuario + "";
            conexion.ejecutar(query);

            if (conexion.rs.Read()) {
                c = new Cliente();
                c.Id = Convert.ToInt32(conexion.rs[0]);
                c.Rut = conexion.rs[1].ToString();
                c.NombreCompleto = conexion.rs[2].ToString();
                c.Direccion = conexion.rs[3].ToString();
                c.Ciudad = conexion.rs[4].ToString();
                c.Correo = conexion.rs[5].ToString();
                c.FechaNacimiento = conexion.rs[6].ToString();
                c.Usuario = Convert.ToInt32(conexion.rs[7]);
            }

            conexion.cerrar();
            return c;
        }

        public Ejecutivo getEjecutivo(int idUsuario)
        {
            Ejecutivo e = null;
            query = "select*from ejecutivo where usuario=" + idUsuario + "";
            conexion.ejecutar(query);
            if (conexion.rs.Read())
            {
                e = new Ejecutivo();
                e.Id = Convert.ToInt32(conexion.rs[0]);
                e.Nombre = conexion.rs[1].ToString();
                e.Rut = conexion.rs[2].ToString();
                e.Usuario = Convert.ToInt32(conexion.rs[3]);
            }

            conexion.cerrar();
            return e;
        }

        public List<Ejecutivo> getEjecutivos() {
            List<Ejecutivo> ejecutivos = new List<Ejecutivo>();
            query = "select*from ejecutivo";
            conexion.ejecutar(query);

            Ejecutivo e;
            while (conexion.rs.Read()) {
                e = new Ejecutivo();
                e.Id = Convert.ToInt32(conexion.rs[0]);
                e.Rut = conexion.rs[1].ToString();
                e.Nombre = conexion.rs[2].ToString();
                e.Usuario = Convert.ToInt32(conexion.rs[3]);
                ejecutivos.Add(e);
            }

            conexion.cerrar();
            return ejecutivos;
        }

        /*crud administrador*/
        public Administrador getAdministrador(int idUsuario) {
            Administrador a= null;
            query = "select*from administrador where usuario="+idUsuario+"";
            conexion.ejecutar(query);
            if (conexion.rs.Read()) {
                a = new Administrador();
                a.Id = Convert.ToInt32(conexion.rs[0]);
                a.Nombre = conexion.rs[1].ToString();
                a.Rut= conexion.rs[2].ToString();
                a.Usuario= Convert.ToInt32(conexion.rs[3]);
            }

            conexion.cerrar();
            return a;
        }



        /*crear el crud de las tablas*/

        /*crud cliente*/
        public void registrarCliente(Cliente cliente)
        {
            
        }

        /*crud cuentas*/


        /*crud privilegio*/

        /*crud ciudad*/
        public void actualizarCiudad(Ciudad c) {
            query = "update ciudad set nombre='"+c.Nombre+"' where id='"+c.Id+"'";
            conexion.ejecutar(query);
        }

        public void crearCiudad(String nombre) {
            query = "insert into ciudad values('"+nombre+"')";
            conexion.ejecutar(query);
        }

        public List<Ciudad> getCiudades() {
            List<Ciudad> ciudades = new List<Ciudad>();
            query = "select*from ciudad";
            conexion.ejecutar(query);

            Ciudad c;
            while (conexion.rs.Read()) {
                c = new Ciudad();
                c.Id = Convert.ToInt32(conexion.rs[0]);
                c.Nombre = conexion.rs[1].ToString();
                ciudades.Add(c);
            }

            conexion.cerrar();
            return ciudades;
        }
    }
}
