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
    }
}
