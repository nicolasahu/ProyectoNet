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
    public partial class FormCliente : Form
    {
        private Data d;
        private Cliente c;
        private Usuario user;
        private int idUser;
        private Cuenta cuenta;

        public FormCliente(int idUsuario)
        {
            InitializeComponent();
            idUser = idUsuario;
            d = new Data();
            c = d.getClientePorUsuario(idUsuario);
            user = d.getUsuarioPorID(idUser);
            cargarDatos();
            cargarHistorico();
        }

        private void cargarHistorico()
        {
            try{
                cuenta = d.getCuentaPorCliente(c);
                gridHistorico.DataSource = d.getHistorico(cuenta);
            }
            catch(NullReferenceException){}            
        }

        private void cargarDatos()
        {
            lblClienteNombre.Text = "Bienvenido(a) "+c.NombreCompleto;
            lblClienteRUT.Text = c.Rut;
        }

        public void generarCodigo()
        {
            lblCodigo1.Text = d.retornarClaveTranferencia();
            lblCodigo2.Text = d.retornarClaveTranferencia();
            lblCodigo3.Text = d.retornarClaveTranferencia();
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            errorCambiarContraseña.Clear();
            String actual = txtContraseñaActual.Text;
            String nueva = txtContraseñaNueva.Text;
            String confirmar = txtContraseñaConfirmar.Text;

            if (actual == user.Contraseña)
            {
                if (nueva == confirmar)
                {
                    user.Contraseña = nueva;
                    d.cambiarContraseñaUsuario(user);
                    txtContraseñaActual.ResetText();
                    txtContraseñaConfirmar.ResetText();
                    txtContraseñaNueva.ResetText();
                    MessageBox.Show("Contraseña ha sido cambiada exitosamente");
                }
                else
                {
                    errorCambiarContraseña.SetError(txtContraseñaConfirmar, "Contraseñas no coinciden");
                }
            }
            else {
                errorCambiarContraseña.SetError(txtContraseñaActual, "Contraseña actual incorrecta");
            }
        }

        private void btnRealizarTransferencia_Click(object sender, EventArgs e)
        {
            String Codigo1 = lblCodigo1.Text;
            String Codigo2 = lblCodigo2.Text;
            String Codigo3 = lblCodigo3.Text;
            int codigoNum1, codigoNum2, codigoNum3;
            codigoNum1 = Convert.ToInt32(txtCodigoTransferencia1.Text);
            codigoNum2 = Convert.ToInt32(txtCodigoTransferencia2.Text);
            codigoNum3 = Convert.ToInt32(txtCodigoTransferencia3.Text);

            Boolean cod1, cod2, cod3;
            char columna, fila;
            cuenta = d.getCuentaPorCliente(c);//retorna datos de una cuenta por cliente
            columna = Convert.ToChar(Codigo1[0]);
            fila = Convert.ToChar(Codigo1[1]);
            cod1 = d.verificarCodigoTarjeta(columna, fila, codigoNum1, cuenta.Id);
            MessageBox.Show(columna + "-fila=" + fila, "weas", MessageBoxButtons.OK);


            columna = Convert.ToChar(Codigo2[0]);
            fila = Convert.ToChar(Codigo2[1]);
            cod2 = d.verificarCodigoTarjeta(columna, fila, codigoNum2, cuenta.Id);


            columna = Convert.ToChar(Codigo3[0]);
            fila = Convert.ToChar(Codigo3[1]);

            cod3 = d.verificarCodigoTarjeta(columna, fila, codigoNum3, cuenta.Id);
            MessageBox.Show(cod1 + "-" + cod2 + "-" + cod3, "boolean", MessageBoxButtons.OK);
            MessageBox.Show(cuenta.Id.ToString(), "id cuenta", MessageBoxButtons.OK);





            if (cod1 & cod2 & cod3)
            {
                MessageBox.Show("exelente paso", "exelente", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("error en clave", "error", MessageBoxButtons.OK);
            }
        }
    }
}
