using proyectoBanco.bd;
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
    public partial class Form1 : Form
    {
        private Data d;
        public Form1()
        {
            InitializeComponent();
            //try {
            //    d = new Data();
            //    lblEstadoConexion.Text = "Conectado";
            //    lblEstadoConexion.ForeColor = Color.Green;
            //} catch (Exception ex){
            //    errorLogin.SetError(lblEstadoConexion, ex.Message);
            //}
            d = new Data();            
        }

        private void btnIngresar_Click(object sender, EventArgs e){
            errorLogin.Clear();
            String user = txtUser.Text;
            String pass = txtPass.Text;

            if (!d.existeUsuario(user))
            {
                errorLogin.SetError(txtUser, "Usuario invalido");
            }
            else {
                if (!d.login(user, pass))
                {
                    errorLogin.SetError(txtPass, "Contraseña invalida");
                }
                else {
                    MessageBox.Show(
                        "Acceso Concedido",
                        "Bienvenido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
            }
        }
    }
}
