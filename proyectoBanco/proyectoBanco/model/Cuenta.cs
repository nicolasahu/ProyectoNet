﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace proyectoBanco.model
{
    class Cuenta
    {
        private int id;
        private int numCuenta;
        private int cliente;
        private int saldo;
        private String fechaCreacion;
        private int ejecutivo;
        private Boolean activo;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int NumCuenta
        {
            get
            {
                return numCuenta;
            }

            set
            {
                numCuenta = value;
            }
        }

        public int Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }

        public int Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                saldo = value;
            }
        }

        public int Ejecutivo
        {
            get
            {
                return ejecutivo;
            }

            set
            {
                ejecutivo = value;
            }
        }

        public string FechaCreacion
        {
            get
            {
                return fechaCreacion;
            }

            set
            {
                fechaCreacion = value;
            }
        }
    }
}
