using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace proyectoBanco.model
{
    class Cuenta
    {
        private int id;
        private String numCuenta;
        private int cliente;
        private String saldo;
        private String fechaCreacion;
        private int ejecutivo;
        private Boolean activo;
        public static int ADMIN = 1;

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

        public bool Activo
        {
            get
            {
                return activo;
            }

            set
            {
                activo = value;
            }
        }

        public string Saldo
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

        public string NumCuenta
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

        //public override string ToString()
        //{
        //    return "N°"+numCuenta.ToString()+"\t"+"Cliente:"+Cliente.ToString();
        //}
    }
}
