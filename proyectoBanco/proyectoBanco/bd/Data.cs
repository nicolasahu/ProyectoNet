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
    /*Oficial*/
    class Data
    {
        private Conexion conexion;
        private Cliente cliente;
        private String query;
        private Random random;

        public Data()
        {
            conexion = new Conexion("banco");
            random = new Random();
        }

        /*-------------------------crud usuario-----------------------------*/
        public void registrarUsuario(Usuario usu)
        {
            query = "insert into usuario values('"+usu.NombreLogin+"','"+usu.Contraseña+"','"+usu.Privilegio+"') ";
            conexion.ejecutar(query);
        }

        /*Oficial*/
        public String generarNombreUsuario(String nombreCompleto) {
            String[] vectorNombre = nombreCompleto.Split(' ');
            String nombre, apellido, usuario;
            nombre = vectorNombre[0];
            apellido = vectorNombre[1];
            usuario = nombre.ElementAt(0).ToString() + apellido;
            usuario = usuario.ToLower();

            query = "select count(*) from usuario where nombre_login like '%"+usuario+"%'";
            conexion.ejecutar(query);

            String n = "";
            if (conexion.rs.Read()) {
                n = conexion.rs[0].ToString();
            }

            if (n!="0") {
                usuario = usuario + n;
            }

            conexion.cerrar();
            return usuario;
        }

        public int generarNombreUsuario2(String nombreCompleto)
        {
            String[] vectorNombre = nombreCompleto.Split(' ');
            String nombre, apellido, usuario;
            nombre = vectorNombre[0];
            apellido = vectorNombre[1];
            usuario = nombre.ElementAt(0).ToString() + apellido;
            usuario = usuario.ToLower();

            Boolean existe = false;
            int cont = 0;
            String usuariofinal = usuario;
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
            String contraseña = generarClave();

            return 0;
        }

        private string generarClave()
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

        /*oficial*/
        public string generarClave2()
        {
            int cont = 0, limite = 12;
            String contraseñaFinal = "";
            int caracter;
            String carac;
            while (cont < limite)
            {

                if (cont < 3)
                {
                    if (cont == 0)
                    {
                        /*letra*/
                        carac = GenerarLetra();
                        contraseñaFinal += carac;

                    }
                    else if (cont == 2)
                    {
                        /*numero*/
                        carac = GenerarNumero().ToString();
                        contraseñaFinal += carac;

                    }
                    else if (cont == 1
                        )
                    {
                        /*simbolo*/
                        carac = GenerarSimbolo();
                        contraseñaFinal += carac;

                    }
                }
                else
                {
                    caracter = random.Next(1, 4);
                    if (caracter == 1)
                    {
                        /*letra*/
                        carac = GenerarLetra();
                        contraseñaFinal += carac;

                    }
                    else if (caracter == 2)
                    {
                        /*numero*/
                        carac = GenerarNumero().ToString();
                        contraseñaFinal += carac;

                    }
                    else if (caracter == 3)
                    {
                        /*simbolo*/
                        carac = GenerarSimbolo();
                        contraseñaFinal += carac;

                    }
                }


                cont++;
            }
            return contraseñaFinal;
        }

        public void actualizarUsuario(Usuario usu)
        {
            query = "update usuario set nombre_login='"+usu.NombreLogin+"', contraseña='"+usu.Contraseña+"' where id='"+usu.Id+"'";
            conexion.ejecutar(query);
        }

        /*Login*/
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

        /*Obtener ultimo id creado*/
        public int getIDUduario() {
            int id=0;
            query = "select count(*) from usuario";
            if (conexion.rs.Read()) {
                id = Convert.ToInt32(conexion.rs[0]);
            }

            conexion.cerrar();
            return id;
        }

        /*rango letras codigo ascuii 97-122*/
        public String GenerarLetra()
        {

            int numletra = random.Next(97, 123);
            String letra = Convert.ToChar(numletra).ToString();
            return letra;
        }
        /*rango numeros 1-9*/
        public int GenerarNumero()
        {

            int num; ;
            return num = random.Next(1, 10);
        }
        /*rango simbolo codigo ascuii 33-47*/
        public String GenerarSimbolo()
        {


            int numsimbolo = random.Next(33, 48);
            String simbolo = Convert.ToChar(numsimbolo).ToString();
            return simbolo;
        }        

        /*----------------------------------crud cliente------------------*/
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

        public Cliente getClientePorRut(String rut) {
            Cliente c = null;
            query = "select*from cliente where rut='"+rut+"'";
            conexion.ejecutar(query);

            if (conexion.rs.Read()) {
                c = new model.Cliente();
                c.Rut = conexion.rs[1].ToString();
            }

            conexion.cerrar();
            return c;
        }


        /*-----------------------crud ejecutivo---------------------------*/
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

        public void crearEjecutivo(Ejecutivo e)
        {
            query = "insert into ejecutivo values('" + e.Nombre + "','" + e.Rut + "'," + e.Usuario + ")";
            conexion.ejecutar(query);
        }

        public void actualizarEjecutivo(Ejecutivo e)
        {
            query = "update ejecutivo set nombre='" + e.Nombre + "', rut='" + e.Rut + "', usuario='" + e.Usuario + "' where id='" + e.Rut + "'";
            conexion.ejecutar(query);
        }


        /*----------------------crud administrador------------------------*/


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
               

        /*.......................crud cuentas............................*/
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

        public Cuenta getCuenta(String id)
        {
            Cuenta c = null;
            query = "select*from cuenta where id='" + id + "'";
            conexion.ejecutar(query);

            if (conexion.rs.Read())
            {
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

        public String generarNumeroCuenta() {
            Boolean disponible=false;
            String numeros = null;
            while (!disponible) {                
                int contador = 0;
                int n = 0;
                while (contador < 5)
                {
                    n = random.Next(9);
                    while (n == 0)
                    {
                        n = random.Next(9);
                    }

                    numeros = numeros + n.ToString();
                    contador++;
                }

                query = "select count(*) from cuenta where num_cuenta='"+numeros+"'";
                conexion.ejecutar(query);

                if (conexion.rs.Read()) {
                    disponible = (bool)conexion.rs[0];
                    conexion.cerrar();
                }

                conexion.cerrar();
            }

            return numeros;


        }
        
        /*-----------------------crud tarjeta---------------------------*/
        public void RegistrarTarjetaTranferenciaCliente(int idCuenta)
        {
            query = "insert into tarjeta_tranferencia values('" + generarTarjeta() + "','" + idCuenta + "')";
            conexion.ejecutar(query);
        }

        public String generarTarjeta()
        {

            int cont = 0, limite = 50;
            String tarjeta = "";
            int num;
            while (cont < limite)
            {
                if (cont != 49)
                {
                    num = random.Next(01, 99);
                    if (num > 10)
                    {
                        tarjeta += num + "-";
                    }
                    else
                    {
                        tarjeta += "0" + num + "-";
                    }

                }
                else
                {
                    num = random.Next(01, 99);
                    if (num > 10)
                    {
                        tarjeta += num + "-";
                    }
                    else
                    {
                        tarjeta += "0" + num;
                    }
                }
                cont++;

            }

            return tarjeta;
        }

        public TarjetaTranferencia getTarjeta()
        {
            TarjetaTranferencia t = null;
            query = "select*from tarjeta_tranferencia";
            conexion.ejecutar(query);

            if (conexion.rs.Read())
            {
                t = new TarjetaTranferencia();
                t.Id = Convert.ToInt32(conexion.rs[0]);
                t.Numeros = conexion.rs[1].ToString();
                t.Cuenta = Convert.ToInt32(conexion.rs[2]);
            }

            conexion.cerrar();
            return t;
        }

        /*-------------------------crud ciudad--------------------------*/
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

        /*-------------------------crud transferencia-------------------*/
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

        //realizar transferencia

    }
}
