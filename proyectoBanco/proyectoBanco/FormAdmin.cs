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
        }

        private void cargarDatos()
        {
            lblAdminNombre.Text = "Bienvenido(a) "+a.Nombre;
            lblAdminRUT.Text = a.Rut;
        }
    }
}
