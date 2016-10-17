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
            cboClientesAdjudicado.DataSource = d.getClientes(e);
        }

        private void cargarDatos()
        {
            lblEjecNombre.Text = "Bienvenido(a) " + e.Nombre;
            lblEjecRUT.Text = e.Rut;
        }
    }
}
