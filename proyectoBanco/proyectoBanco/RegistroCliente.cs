using proyectoBanco.bd;
using proyectoBanco.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoBanco
{
    public partial class RegistroCliente : Form
    {
        private Data d;
        private Cliente c;

        public RegistroCliente()
        {
            InitializeComponent();
            d = new Data();
            cargarCiudades();            
        }

        private void cargarCiudades()
        {
            cboCrearCliente_Ciudad.DataSource = null;
            cboCrearCliente_Ciudad.DataSource = d.getCiudades();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String rut = txtCrearCliente_RUT.Text;
            Cliente c = d.getClientePorRut(rut);

            if (c == null)
            {
                //Generar Usuario
                Usuario usuario = new Usuario();
                String nombre = txtCrearCliente_Nombre.Text + " " + txtCrearCliente_Apellido.Text;
                usuario.NombreLogin = d.generarNombreUsuario(nombre);
                usuario.Contraseña = d.generarClave2();
                usuario.Privilegio = 3; //privilegio cliente
                d.registrarUsuario(usuario);

                //Generar Cliente
                Cliente cliente = new Cliente();
                Ciudad ciudad= (Ciudad)cboCrearCliente_Ciudad.SelectedItem;
                cliente.Ciudad = ciudad.Nombre;
                cliente.Correo = txtCrearCliente_Correo.Text;
                cliente.Direccion = txtCrearCliente_Direccion.Text;
                cliente.Usuario = d.getIDUduario();
                cliente.Rut = rut;                
                cliente.NombreCompleto = nombre;
                cliente.FechaNacimiento = dtCrearCliente_Nacimiento.Value.ToString();
            }
            else {
                MessageBox.Show("Usuario ya existe");
            }

        }

        //private void txtCrearCliente_RUT_Validated(object sender, EventArgs e)
        //{
        //    if (txtCrearCliente_RUT.Text.Trim() == "") {
        //        errorRegistroCliente.SetError(txtCrearCliente_RUT, "Por favor, indique rut");
        //    } 
        //    //else if () {
        //    //    /*Rut Valido
        //    //     * -Que sea una serie de numeros
        //    //     * -Que tenga 8+1 digitos.
        //    //     * -Y que el digito_verificador sea correcto
        //    //     */
        //    //}
        //}

        //private void txtCrearCliente_Nombre_Validated(object sender, EventArgs e)
        //{
        //    if (txtCrearCliente_Nombre.Text.Trim() == "")
        //    {
        //        errorRegistroCliente.SetError(txtCrearCliente_Nombre, "Por favor, indique nombre");
        //    }
        //}

        //private void txtCrearCliente_Apellido_Validated(object sender, EventArgs e)
        //{
        //    if (txtCrearCliente_Apellido.Text.Trim()=="") {
        //        errorRegistroCliente.SetError(txtCrearCliente_Apellido, "Por favor, indique apellido");
        //    }
        //}

        //private void txtCrearCliente_Direccion_Validated(object sender, EventArgs e)
        //{
        //    if (txtCrearCliente_Direccion.Text.Trim() == "")
        //    {
        //        errorRegistroCliente.SetError(txtCrearCliente_Direccion, "Por favor, indique direccion");
        //    }
        //}

        ////private void cboCrearCliente_Ciudad_Validated(object sender, EventArgs e)
        ////{
        ////}

        //private void txtCrearCliente_Correo_Validated(object sender, EventArgs e)
        //{
        //    if (txtCrearCliente_Correo.Text.Trim() == "")
        //    {
        //        errorRegistroCliente.SetError(txtCrearCliente_Correo, "Por favor, indique correo electronico");
        //    }
        //}
    }
}
