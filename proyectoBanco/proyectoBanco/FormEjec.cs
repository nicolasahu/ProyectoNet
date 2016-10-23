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
        private Ejecutivo ejec;
        public FormEjec(int idUsuario)
        {
            InitializeComponent();
            d = new Data();
            ejec = d.getEjecutivo(idUsuario);
            cargarDatos();
            cargarClientes(ejec);
            cargarClientesDisponibles();
        }

        private void cargarClientes(Ejecutivo e)
        {
            gridCuentasAdjudicadas.DataSource = d.getCuentas(e);
        }

        private void cargarClientesDisponibles() {
            gridClientesDisponibles.DataSource = d.getClientesSinCuenta();
        }

        private void cargarDatos()
        {
            lblEjecNombre.Text = "Bienvenido(a) " + ejec.Nombre;
            lblEjecRUT.Text = ejec.Rut;
        }

        private void gridCuentasAdjudicadas_Click(object sender, EventArgs e)
        {
            actualizarCreditos();
        }

        private void actualizarCreditos() {
            //rescatar id cuenta.
            int id = Convert.ToInt32(gridCuentasAdjudicadas.CurrentRow.Cells[0].Value);

            //obetener creditos asociados
            List<Credito> creditos = d.getCreditos(id);
            gridCreditosAprobados.DataSource = null;
            gridCreditosAprobados.DataSource = creditos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String monto = txtMonto_AprobarCredito.Text;
            int cuenta = Convert.ToInt32(gridCuentasAdjudicadas.CurrentRow.Cells[0].Value); ;

            Credito c = new Credito();
            c.Cuenta = cuenta;
            c.Monto = monto;
            c.Ejecutivo = ejec.Id;
            
            d.aprobarCredito(c);

            Transferencia trans = new Transferencia();
            trans.CuentaOrigen = Cuenta.ADMIN;
            trans.CuentaDestino = cuenta;
            trans.Monto = monto;

            d.realizarTransferencia(trans);

            //cambios
            txtMonto_AprobarCredito.ResetText();
            actualizarCreditos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id_cliente = Convert.ToInt32(gridClientesDisponibles.CurrentRow.Cells[0].Value);
            Cliente cliente = d.getClientePorID(id_cliente);

            //adjudicar
            Cuenta c=new Cuenta();
            c.Cliente = id_cliente;
            c.Ejecutivo = ejec.Id;
            c.NumCuenta = d.generarNumeroCuenta();
            c.Saldo = "0";
            
            c.Saldo = d.generarSaldo(cliente); //definir segun edad
            d.registrarCuenta(c);
            //d.RegistrarTarjetaTranferenciaCliente


            Transferencia trans = new Transferencia();
            trans.Monto= d.generarSaldo(cliente); //definir segun edad
            trans.CuentaOrigen = Cuenta.ADMIN;
            trans.CuentaDestino = c.Id;
            trans.Comentario = "Abono inicial";
            trans.Tipo = Transferencia.ABONO;
            d.realizarTransferencia(trans);

            cargarClientesDisponibles();
            cargarClientes(ejec);
        }
    }
}
