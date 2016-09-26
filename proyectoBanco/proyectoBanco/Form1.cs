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
            login();
        }

        private void showMenu(int idUsuario, int privilegio) {
            switch (privilegio) {
                case 1: //admin
                    FormAdmin fa = new FormAdmin(idUsuario);
                    fa.Show();
                    break;
                case 2: //ejecutivo
                    FormEjec fe = new FormEjec(idUsuario);
                    fe.Show();
                    break;
                case 3: //cliente
                    FormCliente fc = new FormCliente(idUsuario);
                    fc.Show();
                    break;
            }
        }

        private void login() {
            errorLogin.Clear();
            String user = txtUser.Text;
            String pass = txtPass.Text;

            Usuario u = d.getUsuario(user);

            if (u == null)
            {
                errorLogin.SetError(txtUser, "Usuario invalido");
            }
            else if (u.Contraseña != pass)
            {
                errorLogin.SetError(txtPass, "Contraseña invalida");
            }
            else
            {
                //MessageBox.Show(
                //    "Acceso Concedido",
                //    "Bienvenido",
                //    MessageBoxButtons.OK,
                //    MessageBoxIcon.Information
                //    );
                showMenu(u.Id, u.Privilegio);
            }
        }

        private void txtUser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter) {
                login();
            }
            
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}
