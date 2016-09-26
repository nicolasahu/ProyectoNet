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
            d.crearCiudad(nombreCiudad);
            gridCiudad.DataSource = d.getCiudades();

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
            String nombre = gridCiudad.CurrentRow.Cells[1].Value.ToString();
            Ciudad c = new Ciudad();
            c.Id = Convert.ToInt32(id);
            c.Nombre = nombre;

            d.actualizarCiudad(c);

            txtNombreCiudad.ResetText();
            gridCiudad.DataSource = null;
            gridCiudad.DataSource = d.getCiudades();

        }
    }
}
