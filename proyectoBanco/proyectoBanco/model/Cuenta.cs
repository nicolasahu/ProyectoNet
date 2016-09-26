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
        private int numCuenta;
        private Cliente cliente;
        private int saldo;
        private DateTime fechaNacimiento;
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

        internal Cliente Cliente
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

        public DateTime fechaCreacion
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
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
    }
}
