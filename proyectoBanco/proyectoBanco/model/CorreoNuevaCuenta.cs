using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBanco.model
{
    class CorreoNuevaCuenta
    {
        private String numeroCuenta;
        private String saldo_Actual;
        private String nombreUsuario;
        private String contrasennia;
        private String nombreEjecutivo;
        private String tarjeta;

        public string NumeroCuenta
        {
            get
            {
                return numeroCuenta;
            }

            set
            {
                numeroCuenta = value;
            }
        }

        public string Saldo_Actual
        {
            get
            {
                return saldo_Actual;
            }

            set
            {
                saldo_Actual = value;
            }
        }

        public string NombreUsuario
        {
            get
            {
                return nombreUsuario;
            }

            set
            {
                nombreUsuario = value;
            }
        }

        public string Contrasennia
        {
            get
            {
                return contrasennia;
            }

            set
            {
                contrasennia = value;
            }
        }

        public string NombreEjecutivo
        {
            get
            {
                return nombreEjecutivo;
            }

            set
            {
                nombreEjecutivo = value;
            }
        }

        public string Tarjeta
        {
            get
            {
                return tarjeta;
            }

            set
            {
                tarjeta = value;
            }
        }
    }
}
