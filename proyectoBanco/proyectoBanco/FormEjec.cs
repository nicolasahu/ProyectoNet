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
    public partial class FormEjec : Form
    {
        private Data d;
        private Ejecutivo e;
        public FormEjec(int idUsuario)
        {
            InitializeComponent();
            d = new Data();
            e = d.getEjecutivo(idUsuario);
            cargarDatos();
            cargarClientes(e);
        }

        private void cargarClientes(Ejecutivo e)
        {
            gridCuentasAdjudicadas.DataSource = d.getCuentas(e);
        }

        private void cargarDatos()
        {
            lblEjecNombre.Text = "Bienvenido(a) " + e.Nombre;
            lblEjecRUT.Text = e.Rut;
        }

        private void gridCuentasAdjudicadas_Click(object sender, EventArgs e)
        {
            //rescatar id cuenta.
            int id = Convert.ToInt32(gridCuentasAdjudicadas.CurrentRow.Cells[0].Value);

            //obetener creditos asociados
            List<Credito> creditos = d.getCreditos(id);
            gridCreditosAprobados.DataSource = null;
            gridCreditosAprobados.DataSource = creditos;
        }
    }
}
