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
        public void registrarUsuario(Usuario usu)
        {
            query = "insert into usuario values('"+usu.NombreLogin+"','"+usu.Contraseña+"','"+usu.Privilegio+"') ";
            conexion.ejecutar(query);
        }

        public void crearUsuario(String nombreCompleto) {
            String[] vectorNombre = nombreCompleto.Split(' ');
            String nombre, apellido, usuario;
            nombre = vectorNombre[0];
            apellido = vectorNombre[1];
            usuario = nombre.ElementAt(0).ToString() + apellido;
            usuario = usuario.ToLower();

            //si existe usuario con mismo nombre--->agregar un 1
            //si no---->insert.
        }

        public int generarDatosUsuario(String nombreCompleto)
        {
            String[] vectorNombre = nombreCompleto.Split(' ');
            String nombre, apellido, usuario;
            nombre = vectorNombre[0];
            apellido = vectorNombre[1];
            usuario = nombre.ElementAt(0).ToString()+apellido;
            usuario = usuario.ToLower();

            Boolean existe = false;
            int cont = 0;
            String usuariofinal=usuario;
            while (true)
            {
                query = "select * from usuario where nombre_login ='" + usuariofinal + "'";
                conexion.ejecutar(query);
                if (conexion.rs.Read())
                {
                    existe = true;
                    break;
                }
                else
                {
                    cont++;
                    usuariofinal = usuario + cont;
                }                
            }
            String contraseña = generadorClave();          

            return 0;
        }

        private string generadorClave()
        {
            int cont = 0, limite = 12;
            String contraseñaFinal="";
            while (cont < limite)
            {
                Random ran = new Random(33 - 166);
                contraseñaFinal += Convert.ToChar(ran).ToString();
            }
            return "";
        }

        public void actualizarUsuario(Usuario usu)
        {
            query = "update usuario set nombre_login='"+usu.NombreLogin+"', contraseña='"+usu.Contraseña+"' where id='"+usu.Id+"'";
            conexion.ejecutar(query);
        }

        /*inicio de sesion*/
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
        /*crud cliente*/
        public void RegistrarCliente(Cliente cliente)
        {
            query = "insert into cliente values ('"+cliente.Rut+ "','"+cliente.NombreCompleto+ 
                "','"+cliente.Direccion+ "','"+cliente.Ciudad+ "','"+cliente.Correo+ "','"+cliente.FechaNacimiento+
                "','"+cliente.Usuario+"')";
            conexion.ejecutar(query);
        }

        public void actualizarCliente(Cliente cliente)
        {
            query = "update cliente set rut='"+cliente.Rut+ "',nombre_completo='"+cliente.NombreCompleto+
                "',direccion='"+cliente.Direccion+ "',ciudad='"+cliente.Ciudad+ "', correo='"+cliente.Correo+
                "',fecha_nacimiento='"+cliente.FechaNacimiento+ "',usuario='"+cliente.Usuario+
                "' where id='"+cliente.Id+"'";
            conexion.ejecutar(query);
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


        /*crud ejecutivo*/
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



        

        /*crud cuentas*/
        /*true =1/false=0*/
        public void registrarCuenta(Cuenta cuenta)
        {
            query = "insert into cuenta values('"+cuenta.NumCuenta+ "','"+cuenta.Cliente
                + "','"+cuenta.Saldo+ "','"+cuenta.FechaCreacion+ "','"+cuenta.Ejecutivo+"','1')";
            conexion.ejecutar(query);
        }
        public void desabilitarCuenta(int numCuenta)
        {
            query = "update cuenta set activo='0' where num_cuenta='"+numCuenta+"'";
            conexion.ejecutar(query);
        }

        public void actualizarCuenta(Cuenta cuenta)
        {
            query = "update cuenta set saldo='"+cuenta.Saldo+
                "' where num_cuenta='"+cuenta.NumCuenta+"'";
            conexion.ejecutar(query);

        }



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

        public void crearEjecutivo(Ejecutivo e) {
            query = "insert into ejecutivo values('"+e.Nombre+"','"+e.Rut+"',"+e.Usuario+")";
            conexion.ejecutar(query);
        }

        public void actualizarEjecutivo(Ejecutivo e) {
            query = "update ejecutivo set nombre='"+e.Nombre+"', rut='"+e.Rut+"', usuario='"+e.Usuario+"' where id='"+e.Rut+"'";
            conexion.ejecutar(query);
        }

        public Transferencia getTransferencia(String id) {
            Transferencia t=null;
            query = "select*from transferencia where id="+id+"";
            conexion.ejecutar(query);
            if (conexion.rs.Read()) {
                t = new Transferencia();
                t.Id = Convert.ToInt32(conexion.rs[0]);
                t.Monto = conexion.rs[1].ToString();
                t.Fecha = conexion.rs[2].ToString();
                t.CuentaOrigen = Convert.ToInt32(conexion.rs[3]);
                t.CuentaDestino = Convert.ToInt32(conexion.rs[4]);
                t.Comentario = conexion.rs[5].ToString();
            }

            conexion.cerrar();
            return t;
        }

        public Cuenta getCuenta(String id) {
            Cuenta c = null;
            query = "select*from cuenta where id='"+id+"'";
            conexion.ejecutar(query);

            if (conexion.rs.Read()) {
                c = new Cuenta();
                c.Id = Convert.ToInt32(conexion.rs[0]);
                c.NumCuenta = Convert.ToInt32(conexion.rs[1]);
                c.Cliente = Convert.ToInt32(conexion.rs[2]);
                c.Saldo = Convert.ToInt32(conexion.rs[3]);
                c.FechaCreacion = conexion.rs[4].ToString();
                c.Ejecutivo = Convert.ToInt32(conexion.rs[5]);
            }

            conexion.cerrar();
            return c;
        }

        public TarjetaTranferencia getTarjeta() {
            TarjetaTranferencia t= null;
            query = "select*from tarjeta_tranferencia";
            conexion.ejecutar(query);

            if (conexion.rs.Read()) {
                t = new TarjetaTranferencia();
                t.Id = Convert.ToInt32(conexion.rs[0]);
                t.Numeros = conexion.rs[1].ToString();
                t.Cuenta = Convert.ToInt32(conexion.rs[2]);
            }

            conexion.cerrar();
            return t;
        }        
    }
}
