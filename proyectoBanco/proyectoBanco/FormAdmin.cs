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
using System.Windows.Forms.DataVisualization.Charting;

namespace proyectoBanco
{
    public partial class FormAdmin : Form
    {
        private Data d;
        private Administrador a;

        public FormAdmin(int idUsuario)
        {
            InitializeComponent();
            d = new Data();
            a = d.getAdministrador(idUsuario);
            cargarDatos();
            cargarTablas();
            cargarGafricos();
        }

        private void cargarDatos()
        {
            lblAdminNombre.Text = "Bienvenido(a) "+a.Nombre;
            lblAdminRUT.Text = a.Rut;
        }

        private void cargarTablas() {
            gridCiudad.DataSource = d.getCiudades();
            gridEjecutivo.DataSource = d.getEjecutivos();
        }

        private void btnCiudadCrear_Click(object sender, EventArgs e)
        {

            String nombreCiudad = txtNombreCiudad.Text;

            if (nombreCiudad != "")
            {
                d.crearCiudad(nombreCiudad);
                gridCiudad.DataSource = d.getCiudades();
            }
            else
            {
                MessageBox.Show("la casilla de ciudad esta en blanco", "faltan datos", MessageBoxButtons.OK);
            }
                    
            

            txtNombreCiudad.ResetText();
        }

        private void gridCiudad_DoubleClick(object sender, EventArgs e){
            btnCiudadActualizar.Enabled = true;
            btnCiudadCrear.Enabled = false;
            btnCiudadCancelar.Enabled = true;

            String nombre = gridCiudad.CurrentRow.Cells[1].Value.ToString();
            txtNombreCiudad.Text = nombre;
        }

        private void btnCiudadCancelar_Click(object sender, EventArgs e)
        {
            txtNombreCiudad.ResetText();
            btnCiudadCancelar.Enabled = false;
            btnCiudadActualizar.Enabled = false;
            btnCiudadCrear.Enabled = true;
        }

        private void btnCiudadActualizar_Click(object sender, EventArgs e)
        {
            String id = gridCiudad.CurrentRow.Cells[0].Value.ToString();
            String nombre = txtNombreCiudad.Text;

            Ciudad c = new Ciudad();
            c.Id = Convert.ToInt32(id);
            c.Nombre = nombre;

            d.actualizarCiudad(c);

            txtNombreCiudad.ResetText();
            gridCiudad.DataSource = null;
            gridCiudad.DataSource = d.getCiudades();

        }

        private void gridEjecutivo_DoubleClick(object sender, EventArgs e)
        {
            btnEjecutivoActualizar.Enabled = true;
            btnEjecutivoCrear.Enabled = false;
            btnEjecutivoCancelar.Enabled = true;

            String rut = gridEjecutivo.CurrentRow.Cells[2].Value.ToString();

            String[] nombreCompleto = gridEjecutivo.CurrentRow.Cells[1].Value.ToString().Split(' ');

            txtEjecutivoNombre.Text = nombreCompleto[0];
            txtEjecutivoApellido.Text = nombreCompleto[1];
            txtEjecutivoRut.Text = rut;
            txtEjecutivoRut.Enabled = false;
        }

        private void btnEjecutivoCrear_Click(object sender, EventArgs e)
        {
            String nombre = txtEjecutivoNombre.Text;
            String apellido = txtEjecutivoApellido.Text;
            String rut = txtEjecutivoRut.Text;
            String correo = txtCorreoEjecutivo.Text;

            if (nombre!=""|| apellido != ""|| rut != "" ||correo!="")
            {
                Usuario usuario = new Usuario();
                usuario.NombreLogin = d.generarNombreUsuario(nombre + " " + apellido);
                usuario.Privilegio = 2;
                
                usuario.Contraseña = d.generarClave2();

                d.registrarUsuario(usuario);

                Ejecutivo ejec = new Ejecutivo();
                ejec.Nombre = nombre + " " + apellido;
                ejec.Rut = rut;
                ejec.Correo = correo;
                ejec.Usuario = d.getIDUduario();

                d.crearEjecutivo(ejec);
                limpiarEjecutivoCrear();
            }
            else
            {
                MessageBox.Show("alguna casilla de dato se encuentra en blanco", "faltan datos", MessageBoxButtons.OK);
            }
        }

        private void limpiarEjecutivoCrear()
        {
            txtEjecutivoNombre.ResetText();
            txtEjecutivoApellido.ResetText();
            txtEjecutivoRut.ResetText();

            gridEjecutivo.DataSource = d.getEjecutivos();
        }

        private void btnEjecutivoActualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridEjecutivo.CurrentRow.Cells[0].Value);
            String nombre = txtEjecutivoNombre.Text;
            String apellido = txtEjecutivoApellido.Text;
            String rut = txtEjecutivoRut.Text;
            String correo = txtCorreoEjecutivo.Text;
            Ejecutivo ejec = new Ejecutivo();

            if (nombre != "" || apellido != "" || rut != "" || correo != "")
            {                
                ejec.Id = id;
                ejec.Nombre = nombre + " " + apellido;
                ejec.Rut = rut;
                ejec.Usuario = d.getIDUduario();
                d.actualizarEjecutivo(ejec);
                limpiarEjecutivoCrear();
            }
            else
            {
                MessageBox.Show("alguna casilla de dato se encuentra en blanco", "faltan datos", MessageBoxButtons.OK);

            }            
        }

        private void btnEjecutivoCancelar_Click(object sender, EventArgs e)
        {
            /*          
            txtNombreCiudad.ResetText();
            btnCiudadCancelar.Enabled = false;
            btnCiudadActualizar.Enabled = false;
            btnCiudadCrear.Enabled = true;
             */

            txtEjecutivoApellido.ResetText();
            txtEjecutivoNombre.ResetText();
            txtEjecutivoRut.ResetText();
            gridEjecutivo.ClearSelection();
            btnEjecutivoCrear.Enabled = true;
            btnEjecutivoActualizar.Enabled = false;
            btnEjecutivoCancelar.Enabled = false;
        }

        private void gridCiudad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblAdminNombre_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void cargarGafricos()
        {
            String[] meses = {"Enero","Febrero","Marzo","Abril","Mayo","Junio",
                            "Julio","Agosto","Septiembre", "Octubre","Noviembre","Diciembre" };
            int[] cuentas = {d.getcuentasPorMes(1), d.getcuentasPorMes(2), d.getcuentasPorMes(3), d.getcuentasPorMes(4),
                             d.getcuentasPorMes(5), d.getcuentasPorMes(6), d.getcuentasPorMes(7), d.getcuentasPorMes(8),
                             d.getcuentasPorMes(9), d.getcuentasPorMes(10),d.getcuentasPorMes(11),d.getcuentasPorMes(12) };
            chart1.Titles.Add("Cuentas por mes");

            for (int i = 0; i < meses.Length; i++)
            {
                Series serie = chart1.Series.Add(meses[i]);

                serie.Label = cuentas[i].ToString();
                serie.Points.Add(cuentas[i]);
            }
        }
    }
}
