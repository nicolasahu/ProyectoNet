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
        public Form1()
        {
            InitializeComponent();
            try {
                Data d = new Data();
                lblEstadoConexion.Text = "Conectado";
                lblEstadoConexion.ForeColor = Color.Green;
            } catch (Exception ex){
                errorLogin.SetError(lblEstadoConexion, ex.Message);
            }

            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String user = txtUser.Text;
            String pass = txtPass.Text;
        }
    }
}
