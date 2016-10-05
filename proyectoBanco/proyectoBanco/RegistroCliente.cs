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
            cargarCiudades();
        }

        private void cargarCiudades()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String rut = txtCrearCliente_RUT.Text;
            Cliente c = d.getClientePorRut(rut);

            //validar campos

        }

        private void txtCrearCliente_RUT_Validated(object sender, EventArgs e)
        {
            if (txtCrearCliente_RUT.Text.Trim() == "") {
                errorRegistroCliente.SetError(txtCrearCliente_RUT, "Por favor, indique rut");
            } else if () {
                /*Rut Valido
                 * -Que sea una serie de numeros
                 * -Que tenga 8+1 digitos.
                 * -Y que el digito_verificador sea correcto
                 */
            }
        }
    }
}
