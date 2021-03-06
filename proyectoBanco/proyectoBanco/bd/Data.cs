﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Net;
using System.Net.Mail;
using System.Data;
using System.Data.SqlClient;
using proyectoBanco.model;
namespace proyectoBanco.bd
{
    /*Oficial*/
    class Data
    {
        private Conexion conexion;
        private Conexion1 conexion1;
        private Cliente cliente;
        private String query;
        private Random random;

        public Data()
        {
            conexion = new Conexion("banco");
            conexion1 = new Conexion1("banco");
            random = new Random();
        }

        /*-------------------------crud usuario-----------------------------*/
        public void registrarUsuario(Usuario usu)
        {
            query = "insert into usuario values('" + usu.NombreLogin + "','" + usu.Contraseña + "','" + usu.Privilegio + "') ";
            conexion.ejecutar(query);
        }

        public List<Cuenta> getCuentas(Ejecutivo e)
        {
            List<Cuenta> cuentas = new List<Cuenta>();
            query = "select*from cuenta where ejecutivo=" + e.Id + "";
            conexion.ejecutar(query);

            /*
             *  private int id;
                private int numCuenta;
                private int cliente;
                private int saldo;
                private String fechaCreacion;
                private int ejecutivo;
                private Boolean activo;
            */

            Cuenta c;
            while (conexion.rs.Read()) {
                c = new Cuenta();
                c.Id = Convert.ToInt16(conexion.rs[0]);
                c.NumCuenta = conexion.rs[1].ToString();
                c.Cliente = Convert.ToInt16(conexion.rs[2]);
                c.Saldo = conexion.rs[3].ToString();
                c.FechaCreacion = conexion.rs[4].ToString();
                c.Ejecutivo = Convert.ToInt16(conexion.rs[5]);
                c.Activo = bool.Parse(conexion.rs[6].ToString());
                cuentas.Add(c);
            }

            conexion.cerrar();
            return cuentas;
        }
        /*Oficial*/
        public String generarNombreUsuario(String nombreCompleto) {
            String[] vectorNombre = nombreCompleto.Split(' ');
            String nombre, apellido, usuario;
            nombre = vectorNombre[0];
            apellido = vectorNombre[1];
            usuario = nombre.ElementAt(0).ToString() + apellido;
            usuario = usuario.ToLower();

            query = "select count(*) from usuario where nombre_login like '%" + usuario + "%'";
            conexion.ejecutar(query);

            String n = "";
            if (conexion.rs.Read()) {
                n = conexion.rs[0].ToString();
            }

            if (n != "0") {
                usuario = usuario + n;
            }

            conexion.cerrar();
            return usuario;
        }

        //public int generarNombreUsuario2(String nombreCompleto)
        //{
        //    String[] vectorNombre = nombreCompleto.Split(' ');
        //    String nombre, apellido, usuario;
        //    nombre = vectorNombre[0];
        //    apellido = vectorNombre[1];
        //    usuario = nombre.ElementAt(0).ToString() + apellido;
        //    usuario = usuario.ToLower();

        //    Boolean existe = false;
        //    int cont = 0;
        //    String usuariofinal = usuario;
        //    while (true)
        //    {
        //        query = "select * from usuario where nombre_login ='" + usuariofinal + "'";
        //        conexion.ejecutar(query);
        //        if (conexion.rs.Read())
        //        {
        //            existe = true;
        //            break;
        //        }
        //        else
        //        {
        //            cont++;
        //            usuariofinal = usuario + cont;
        //        }
        //    }
        //    String contraseña = generarClave();

        //    conexion.cerrar();
        //    return 0;
        //}

        //public string generarClave()
        //{
        //    int cont = 0, limite = 12;
        //    String contraseñaFinal="";
        //    while (cont < limite)
        //    {
        //        Random ran = new Random(33 - 166);
        //        contraseñaFinal += Convert.ToChar(ran).ToString();
        //    }
        //    return "";
        //}

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
            query = "update usuario set nombre_login='" + usu.NombreLogin + "', contraseña='" + usu.Contraseña + "' where id='" + usu.Id + "'";
            conexion.ejecutar(query);
        }

        /*Login*/
        public Usuario getUsuario(String nombreLogin) {
            Usuario u = null;
            query = "select * from usuario where nombre_login='" + nombreLogin + "'";
            conexion.ejecutar(query);

            if (conexion.rs.Read()) {
                u = new Usuario();
                u.Id = Convert.ToInt32(conexion.rs[0]);
                u.NombreLogin = conexion.rs[1].ToString();
                u.Contraseña = conexion.rs[2].ToString();
                u.Privilegio = Convert.ToInt32(conexion.rs[3]);
            }

            conexion.cerrar();
            return u;
        }

        public void cambiarContraseñaUsuario(Usuario user) {
            query = "update usuario set contraseña='"+user.Contraseña+"' where id="+user.Id;
            Console.WriteLine(query);
            conexion.ejecutar(query);
        }

        public Usuario getUsuarioPorID(int idUsuario) {
            Usuario user = new Usuario();
            query = "select*from usuario where id=" + idUsuario;
            conexion.ejecutar(query);

            if (conexion.rs.Read()) {
                user.Id = idUsuario;
                user.NombreLogin = conexion.rs[1].ToString();
                user.Contraseña = conexion.rs[2].ToString();
                user.Privilegio = Convert.ToInt32(conexion.rs[3]);
            }

            conexion.cerrar();
            return user;
        }

        /*Obtener ultimo id creado*/
        public int getIDUduario() {
            int id=0;
            query = "select count(*) from usuario";
            conexion.ejecutar(query);

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
            int numsimbolo = random.Next(35, 38);
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

        public Cliente getClientePorUsuario(int idUsuario)
        {
            Cliente c = null;
            query = "select*from cliente where usuario=" + idUsuario + "";
            Console.Write(query);
            conexion.ejecutar(query);

            if (conexion.rs.Read()) {
                c = new Cliente();
                c.Id = Convert.ToInt32(conexion.rs[0]);
                c.Rut = conexion.rs[1].ToString();
                c.NombreCompleto = conexion.rs[2].ToString();
                c.Direccion = conexion.rs[3].ToString();
                c.Ciudad = Convert.ToInt32(conexion.rs[4]);
                c.Correo = conexion.rs[5].ToString();
                c.FechaNacimiento = conexion.rs[6].ToString();
                c.Usuario = Convert.ToInt32(conexion.rs[7]);
            }

            conexion.cerrar();
            return c;
        }

        public Cliente getClientePorID(int idCliente)
        {
            Cliente c = null;
            query = "select*from cliente where id="+idCliente;
            Console.WriteLine(query);
            conexion1.ejecutar(query);

            if (conexion1.rs.Read())
            {
                c = new Cliente();
                c.Id = Convert.ToInt32(conexion1.rs[0]);
                c.Rut = conexion1.rs[1].ToString();
                c.NombreCompleto = conexion1.rs[2].ToString();
                c.Direccion = conexion1.rs[3].ToString();
                c.Ciudad = Convert.ToInt32(conexion1.rs[4]);
                c.Correo = conexion1.rs[5].ToString();
                c.FechaNacimiento = conexion1.rs[6].ToString();
                c.Usuario = Convert.ToInt32(conexion1.rs[7]);
            }

            conexion1.cerrar();
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

        public List<Cliente> getClientesSinCuenta() {
            List<Cliente> clientes = new List<Cliente>();
            query = "select*from cliente where id not in (select cliente from cuenta where cuenta.cliente is not null)";
            conexion.ejecutar(query);

            Cliente c;
            while (conexion.rs.Read()) {
                c = new Cliente();
                c.Id = Convert.ToInt32(conexion.rs[0]);
                c.Rut = conexion.rs[1].ToString();
                c.NombreCompleto = conexion.rs[2].ToString();
                c.Direccion = conexion.rs[3].ToString();
                c.Ciudad = Convert.ToInt32(conexion.rs[4]);
                c.Correo = conexion.rs[5].ToString();
                c.FechaNacimiento = conexion.rs[6].ToString();
                c.Usuario = Convert.ToInt32(conexion.rs[7]);
                clientes.Add(c);
            }

            conexion.cerrar();
            return clientes;
        }


        /*-----------------------crud ejecutivo---------------------------*/
        public Ejecutivo getEjecutivo(int idUsuario)
        {
            Ejecutivo e = null;
            query = "select*from ejecutivo where usuario="+idUsuario;
            Console.WriteLine(query);
            conexion.ejecutar(query);

            if (conexion.rs.Read())
            {
                e = new Ejecutivo();
                e.Id = Convert.ToInt32(conexion.rs[0]);//id
                e.Nombre = conexion.rs[2].ToString();//rut
                e.Rut = conexion.rs[1].ToString();//nombre
                e.Correo = conexion.rs[3].ToString();//nombre
                e.Usuario = Convert.ToInt32(conexion.rs[4]);//usuario
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
                e.Correo = conexion.rs[3].ToString();
                e.Usuario = Convert.ToInt32(conexion.rs[4]);
                ejecutivos.Add(e);
            }

            conexion.cerrar();
            return ejecutivos;
        }

        public void crearEjecutivo(Ejecutivo e)
        {
            query = "insert into ejecutivo values('"+e.Rut+"','"+e.Nombre+ "','" + e.Correo + "', " + e.Usuario+")";
            conexion.ejecutar(query);
        }

        public void actualizarEjecutivo(Ejecutivo e)
        {
            query = "update ejecutivo set nombre='" + e.Nombre + "', rut='" + e.Rut + "', usuario='" + e.Usuario + "' where id='" + e.Id + "'";
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
                a.Usuario= Convert.ToInt32(conexion.rs[4]);
            }

            conexion.cerrar();
            return a;
        }

        public int getcuentasPorMes(int mes)
        {
            int cont = 0;
            query = "select count(*)from cuenta " +
                    "where fecha_creacion like '2016-" + mes + "-%'";
            conexion.ejecutar(query);
            while (conexion.rs.Read())
            {
                cont = Convert.ToInt32(conexion.rs[0]);
            }
            conexion.cerrar();
            return cont;
        }


        /*.......................crud cuentas............................*/

        public int getIDCuenta()
        {
            int id = 0;
            query = "select count(*) from cuenta";
            conexion.ejecutar(query);

            if (conexion.rs.Read())
            {
                id = Convert.ToInt32(conexion.rs[0]);
            }

            conexion.cerrar();
            return id;
        }

        /*true =1/false=0*/
        public void registrarCuenta(Cuenta cuenta)
        {
            query = "insert into cuenta values('"+cuenta.NumCuenta+ "','"+cuenta.Cliente
                + "','"+cuenta.Saldo+ "', getDate() ,'"+cuenta.Ejecutivo+"','1')";
            
            conexion.ejecutar(query);
            int idCuenta = getIDCuenta();
            RegistrarTarjetaTranferenciaCliente(idCuenta);

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
                c.NumCuenta = conexion.rs[1].ToString();
                c.Cliente = Convert.ToInt32(conexion.rs[2]);
                c.Saldo = conexion.rs[3].ToString();
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
                while (contador < 5){
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

                int bit;
                if (conexion.rs.Read()) {
                    bit = Convert.ToInt32(conexion.rs[0]);
                    if (bit == 0)
                    {
                        disponible = true;
                    }
                    else {
                        disponible = false;
                    }
                }

                conexion.cerrar();
            }

            return numeros;
        }

        public Cuenta getCuentaPorCliente(Cliente cliente) {
            Cuenta cuenta =null;

            query = "select*from cuenta where cliente="+cliente.Id;
            conexion.ejecutar(query);

            if (conexion.rs.Read()) {
                cuenta = new Cuenta();
                cuenta.Id = Convert.ToInt32(conexion.rs[0]);
                cuenta.NumCuenta = conexion.rs[1].ToString();
                cuenta.Cliente = Convert.ToInt32(conexion.rs[2]);
                cuenta.Saldo = conexion.rs[3].ToString();
                cuenta.FechaCreacion = conexion.rs[4].ToString();
                cuenta.Ejecutivo = Convert.ToInt32(conexion.rs[5]);
            }

            conexion.cerrar();
            return cuenta;
        }

        public String generarSaldo(Cliente c)
        {
            String saldo=null;
            int edad = getEdad(c);

            if (edad < 30)
            {
                saldo = "30000";
            }
            else {
                saldo = "10000";
            }

            return saldo;
        }

        private int getEdad(Cliente c)
        {
            int edad=0;

            query = "select DATEDIFF(YEAR, '"+c.FechaNacimiento+"', GETDATE())";
            conexion.ejecutar(query);

            if (conexion.rs.Read()) {
                edad = Convert.ToInt32(conexion.rs[0]);
            }

            conexion.cerrar();
            return edad;
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
                    if (num >= 10)
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
                    if (num >= 10)
                    {
                        tarjeta += num + "";
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

        public TarjetaTranferencia getTarjeta(int idCuenta)
        {
            TarjetaTranferencia t = null;
            query = "select*from tarjeta_tranferencia where cuenta='" + idCuenta + "'";
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

        public Boolean verificarCodigoTarjeta(char columna, char fila, int num, int idCuenta)
        {
            Boolean existe = false;
            TarjetaTranferencia t = getTarjeta(idCuenta);
            String[] vectornumeros = t.Numeros.Split('-');

            if (columna.Equals('a'))
            {
                if (fila == 1)
                {
                    if (vectornumeros[0] == num.ToString())
                    {
                        existe = true;
                    }

                }
                else if (fila == 2)
                {
                    if (vectornumeros[10] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 3)
                {
                    if (vectornumeros[20] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 4)
                {
                    if (vectornumeros[30] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 5)
                {
                    if (vectornumeros[40] == num.ToString())
                    {
                        existe = true;
                    }
                }
            }
            else if (columna.Equals('b'))
            {
                if (fila == 1)
                {
                    if (vectornumeros[1] == num.ToString())
                    {
                        existe = true;
                    }

                }
                else if (fila == 2)
                {
                    if (vectornumeros[11] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 3)
                {
                    if (vectornumeros[21] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 4)
                {
                    if (vectornumeros[31] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 5)
                {
                    if (vectornumeros[41] == num.ToString())
                    {
                        existe = true;
                    }
                }
            }
            else if (columna.Equals('c'))
            {
                if (fila == 1)
                {
                    if (vectornumeros[2] == num.ToString())
                    {
                        existe = true;
                    }

                }
                else if (fila == 2)
                {
                    if (vectornumeros[12] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 3)
                {
                    if (vectornumeros[22] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 4)
                {
                    if (vectornumeros[32] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 5)
                {
                    if (vectornumeros[42] == num.ToString())
                    {
                        existe = true;
                    }
                }
            }
            else if (columna.Equals('d'))
            {
                if (fila == 1)
                {
                    if (vectornumeros[3] == num.ToString())
                    {
                        existe = true;
                    }

                }
                else if (fila == 2)
                {
                    if (vectornumeros[13] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 3)
                {
                    if (vectornumeros[23] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 4)
                {
                    if (vectornumeros[33] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 5)
                {
                    if (vectornumeros[43] == num.ToString())
                    {
                        existe = true;
                    }
                }
            }
            else if (columna.Equals('e'))
            {
                if (fila == 1)
                {
                    if (vectornumeros[4] == num.ToString())
                    {
                        existe = true;
                    }

                }
                else if (fila == 2)
                {
                    if (vectornumeros[14] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 3)
                {
                    if (vectornumeros[24] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 4)
                {
                    if (vectornumeros[34] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 5)
                {
                    if (vectornumeros[44] == num.ToString())
                    {
                        existe = true;
                    }
                }
            }
            else if (columna.Equals('f'))
            {
                if (fila == 1)
                {
                    if (vectornumeros[5] == num.ToString())
                    {
                        existe = true;
                    }

                }
                else if (fila == 2)
                {
                    if (vectornumeros[15] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 3)
                {
                    if (vectornumeros[25] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 4)
                {
                    if (vectornumeros[35] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 5)
                {
                    if (vectornumeros[45] == num.ToString())
                    {
                        existe = true;
                    }
                }
            }
            else if (columna.Equals('g'))
            {
                if (fila == 1)
                {
                    if (vectornumeros[6] == num.ToString())
                    {
                        existe = true;
                    }

                }
                else if (fila == 2)
                {
                    if (vectornumeros[16] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 3)
                {
                    if (vectornumeros[26] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 4)
                {
                    if (vectornumeros[36] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 5)
                {
                    if (vectornumeros[46] == num.ToString())
                    {
                        existe = true;
                    }
                }
            }
            else if (columna.Equals('h'))
            {
                if (fila == 1)
                {
                    if (vectornumeros[7] == num.ToString())
                    {
                        existe = true;
                    }

                }
                else if (fila == 2)
                {
                    if (vectornumeros[17] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 3)
                {
                    if (vectornumeros[27] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 4)
                {
                    if (vectornumeros[37] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 5)
                {
                    if (vectornumeros[47] == num.ToString())
                    {
                        existe = true;
                    }
                }
            }
            else if (columna.Equals('i'))
            {
                if (fila == 1)
                {
                    if (vectornumeros[8] == num.ToString())
                    {
                        existe = true;
                    }

                }
                else if (fila == 2)
                {
                    if (vectornumeros[18] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 3)
                {
                    if (vectornumeros[28] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 4)
                {
                    if (vectornumeros[38] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 5)
                {
                    if (vectornumeros[48] == num.ToString())
                    {
                        existe = true;
                    }
                }
            }
            else if (columna.Equals('j'))
            {
                if (fila == 1)
                {
                    if (vectornumeros[9] == num.ToString())
                    {
                        existe = true;
                    }

                }
                else if (fila == 2)
                {
                    if (vectornumeros[19] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 3)
                {
                    if (vectornumeros[29] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 4)
                {
                    if (vectornumeros[39] == num.ToString())
                    {
                        existe = true;
                    }
                }
                else if (fila == 5)
                {
                    if (vectornumeros[49] == num.ToString())
                    {
                        existe = true;
                    }
                }
            }

            return existe;

        }

        public String mostarTarjetaCorreo(int idCuenta)
        {
            String tabla="";
            TarjetaTranferencia t = getTarjeta(idCuenta);
            
            String[] vectornumeros = t.Numeros.Split('-');
            int cont=1;
            tabla = "<table BORDER=1>";
            for (int i = 0; i < 6; i++)
            {
                
                if (i == 0){
                    tabla += "<tr>" +
                        "<td>  </td>" +
                        "<td>A</td>" +
                        "<td>B</td>" +
                        "<td>C</td>" +
                        "<td>D</td>" +
                        "<td>E</td>" +
                        "<td>F</td>" +
                        "<td>G</td>" +
                        "<td>H</td>" +
                        "<td>I</td>" +
                        "<td>J</td>" +
                        "</tr>";
                }
                else if(i == 1){
                    
                    tabla += "<tr>" +
                        "<td>1</td>" +
                        "<td>" + vectornumeros[0] + "</td>" +
                        "<td>" + vectornumeros[1] + "</td>" +
                        "<td>" + vectornumeros[2] + "</td>" +
                        "<td>" + vectornumeros[3] + "</td>" +
                        "<td>" + vectornumeros[4] + "</td>" +
                        "<td>" + vectornumeros[5] + "</td>" +
                        "<td>" + vectornumeros[6] + "</td>" +
                        "<td>" + vectornumeros[7] + "</td>" +
                        "<td>" + vectornumeros[8] + "</td>" +
                        "<td>" + vectornumeros[9] + "</td>" +
                        "</tr>";
                }
                else if (i == 2)
                {
                    tabla += "<tr>" +
                        "<td>2</td>" +
                        "<td>" + vectornumeros[10] + "</td>" +
                        "<td>" + vectornumeros[11] + "</td>" +
                        "<td>" + vectornumeros[12] + "</td>" +
                        "<td>" + vectornumeros[13] + "</td>" +
                        "<td>" + vectornumeros[14] + "</td>" +
                        "<td>" + vectornumeros[15] + "</td>" +
                        "<td>" + vectornumeros[16] + "</td>" +
                        "<td>" + vectornumeros[17] + "</td>" +
                        "<td>" + vectornumeros[18] + "</td>" +
                        "<td>" + vectornumeros[19] + "</td>" +
                        "</tr>";

                }
                else if (i == 3)
                {
                    tabla += "<tr>" +
                        "<td>3</td>" +
                        "<td>" + vectornumeros[20] + "</td>" +
                        "<td>" + vectornumeros[21] + "</td>" +
                        "<td>" + vectornumeros[22] + "</td>" +
                        "<td>" + vectornumeros[23] + "</td>" +
                        "<td>" + vectornumeros[24] + "</td>" +
                        "<td>" + vectornumeros[25] + "</td>" +
                        "<td>" + vectornumeros[26] + "</td>" +
                        "<td>" + vectornumeros[27] + "</td>" +
                        "<td>" + vectornumeros[28] + "</td>" +
                        "<td>" + vectornumeros[29] + "</td>" +
                        "</tr>";

                }
                else if (i == 4)
                {
                    tabla += "<tr>" +
                        "<td>4</td>" +
                        "<td>" + vectornumeros[30] + "</td>" +
                        "<td>" + vectornumeros[31] + "</td>" +
                        "<td>" + vectornumeros[32] + "</td>" +
                        "<td>" + vectornumeros[33] + "</td>" +
                        "<td>" + vectornumeros[34] + "</td>" +
                        "<td>" + vectornumeros[35] + "</td>" +
                        "<td>" + vectornumeros[36] + "</td>" +
                        "<td>" + vectornumeros[37] + "</td>" +
                        "<td>" + vectornumeros[38] + "</td>" +
                        "<td>" + vectornumeros[39] + "</td>" +
                        "</tr>";
                }
                else if (i == 5)
                {
                    tabla += "<tr>" +
                        "<td>5</td>" +
                        "<td>" + vectornumeros[40] + "</td>" +
                        "<td>" + vectornumeros[41] + "</td>" +
                        "<td>" + vectornumeros[42] + "</td>" +
                        "<td>" + vectornumeros[43] + "</td>" +
                        "<td>" + vectornumeros[44] + "</td>" +
                        "<td>" + vectornumeros[45] + "</td>" +
                        "<td>" + vectornumeros[46] + "</td>" +
                        "<td>" + vectornumeros[47] + "</td>" +
                        "<td>" + vectornumeros[48] + "</td>" +
                        "<td>" + vectornumeros[49] + "</td>" +
                        "</tr>";
                }


            }
            tabla += "</table>";
            return tabla;
            
        }

        public String retornarClaveTranferencia()
        {
            String letra, numero;
            letra = GenerarLetraCodigo();
            numero = GenerarNumeroCodigo().ToString();


            return letra + numero;
        }

        /*generar codigo*/
        public String GenerarLetraCodigo()
        {

            int numletra = random.Next(97, 107);
            String letra = Convert.ToChar(numletra).ToString();
            return letra;
        }
        /*rango numeros 1-9*/
        public int GenerarNumeroCodigo()
        {

            int num; ;
            return num = random.Next(1, 6);
        }
        /*-------------------------CRUD CORREO--------------------------*/

        public void enviarMensaje(String correoEmisor, String clave, String correoReceptor, String asunto, String mensaje)
        {
            SmtpClient cliente = new SmtpClient();
            cliente.Host = "Banco.com";
            cliente.Port = 465;
            cliente.EnableSsl = false;
            cliente.UseDefaultCredentials = false;
            cliente.Credentials = new NetworkCredential(correoEmisor, clave);

            MailMessage correo = new MailMessage();
            correo.To.Add(new MailAddress(correoEmisor));
            correo.From = new MailAddress(correoReceptor);
            correo.Subject = asunto;
            correo.Body = "<h1>bienvenido a este banco</h1>";//mensaje
            correo.IsBodyHtml = true;
            correo.Priority = MailPriority.Normal;

            cliente.Send(correo);
            correo.Dispose();
        }

        public CorreoNuevaCuenta getCorreoCuenta()
        {
            query = "exec correoNuevaCuenta";
            conexion.ejecutar(query);

            CorreoNuevaCuenta correo = new CorreoNuevaCuenta();

            if (conexion.rs.Read()) {
                correo.NumeroCuenta = conexion.rs[0].ToString();
                correo.Saldo_Actual = conexion.rs[1].ToString();
                correo.NombreUsuario = conexion.rs[2].ToString();
                correo.Contrasennia = conexion.rs[3].ToString();
                correo.NombreEjecutivo = conexion.rs[4].ToString();
                correo.Tarjeta = conexion.rs[5].ToString();
                correo.DireccionCorreo = conexion.rs[6].ToString();
            }

            conexion.cerrar();
            return correo;
        }

        public CorreoTransferencia getCorreoTransferencia(Transferencia trans) {
            CorreoTransferencia correo = new CorreoTransferencia();
            query = "exec correoTransferencia "+trans.Id;
            conexion.ejecutar(query);

            Cliente clienteOrigen=new Cliente();
            Cliente clienteDestino = new Cliente();
            if (conexion.rs.Read()) {
                clienteOrigen = getClientePorID(Convert.ToInt32(conexion.rs[1]));
                clienteDestino = getClientePorID(Convert.ToInt32(conexion.rs[2]));
                correo.MontoTransferencia = conexion.rs[3].ToString();
                correo.NumeroCuenta_origen = conexion.rs[4].ToString();
                correo.NumeroCuenta_destino = conexion.rs[4].ToString();
                correo.Comentario_Transferencia = conexion.rs[5].ToString();
                correo.NombreCliente_origen = clienteOrigen.NombreCompleto;
                correo.NombreCliente_destino = clienteDestino.NombreCompleto;
                correo.RutCliente_origen = clienteOrigen.Rut;
                correo.RutCliente_destino = clienteDestino.Rut;
                correo.DireccionCliente_origen = clienteOrigen.Correo;
                correo.DireccionCliente_destino = clienteDestino.Correo;
            }

            conexion.cerrar();            
            return correo;
        }

        /*-------------------------crud ciudad--------------------------*/
        public void actualizarCiudad(Ciudad c) {
            query = "update ciudad set nombre='"+c.Nombre+"' where id="+c.Id;
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
        public void realizarTransferencia(Transferencia trans) {
            //query = "insert into transferencia values('"+trans.Monto+"', getDate(), "+trans.CuentaOrigen+", "+trans.CuentaDestino+", "+trans.Tipo+", '"+trans.Comentario+"')";
            query = "exec realizarTransferencia '"+trans.Monto+"' , "+trans.CuentaOrigen+" ,"+trans.CuentaDestino+" , "+trans.Tipo+" , '"+trans.Comentario+"'";
            Console.WriteLine(query);
            conexion.ejecutar(query);
        }


        /*------------------------crud credito--------------------------*/
        public List<Credito> getCreditos(int id) {
            List<Credito> creditos = new List<Credito>();
            query = "select*from credito where cuenta="+id;
            conexion.ejecutar(query);

            Credito c;
            while (conexion.rs.Read()) {
                c = new Credito();
                c.Id = Convert.ToInt32(conexion.rs[0]);
                c.Cuenta = Convert.ToInt32(conexion.rs[1]);
                c.Fecha = conexion.rs[2].ToString();
                c.Ejecutivo = Convert.ToInt32(conexion.rs[4]);
                c.Monto = conexion.rs[5].ToString();
                creditos.Add(c);
            }

            conexion.cerrar();
            return creditos;
        }

        public void aprobarCredito(Credito c) {
            query = "insert into credito values("+c.Cuenta+", getDate(), 1, "+c.Ejecutivo+",'"+c.Monto+"')";
            conexion.ejecutar(query);
        }

        /*------------------------crud historico------------------------*/
        public List<Historico> getHistorico(Cuenta c)
        {
            List<Historico> historicos = new List<Historico>();
            //transferencias recibidas.
            query = "select*from transferencia where cuentaD="+c.Id+" or cuentaO="+c.Id;
            conexion.ejecutar(query);
            Console.WriteLine(query);

            int id=1;
            Cliente origen;
            Cliente destino;
            Historico historico = new Historico();
            int saldo = 0;
            int idOrigen;
            int idDestino;
            int monto;
            while (conexion.rs.Read()) {
                historico.Id = id;

                idOrigen = Convert.ToInt32(conexion.rs[3]);
                idDestino = Convert.ToInt32(conexion.rs[4]);

                origen = getClientePorID(idOrigen);
                destino = getClientePorID(idDestino);

                historico.Tipo = "Transferencia desde " + origen.NombreCompleto + " a " + destino.NombreCompleto;
                monto = Convert.ToInt32(conexion.rs[1]);

                if (origen.Id == c.Id) {
                    //transferencia realizada-->monto negativo
                    historico.Monto = "-" + monto.ToString();
                    saldo = saldo - monto;
                    historico.Saldo = saldo.ToString();
                }
                else{
                    //transferencias recibidas
                    historico.Monto = monto.ToString();
                    saldo = saldo + monto;
                    historico.Saldo = saldo.ToString();
                }
                
                historicos.Add(historico);
                id++;
            }

            conexion.cerrar();
            return historicos;
        }

    }
}
