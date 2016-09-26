﻿using proyectoBanco.bd;
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
        public FormCliente(int idUsuario)
        {
            InitializeComponent();
            d = new Data();
            c = d.getCliente(idUsuario);
            cargarDatos();
        }

        private void cargarDatos()
        {
            lblClienteNombre.Text = "Bienvenido(a) "+c.NombreCompleto;
            lblClienteRUT.Text = c.Rut;
        }
    }
}