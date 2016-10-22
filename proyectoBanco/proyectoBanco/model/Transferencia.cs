using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBanco.model
{
    class Transferencia
    {
        private int id;
        private String monto;
        private String fecha;
        private int cuentaOrigen;
        private int cuentaDestino;
        private String comentario;
        private int tipo;

        public static int TRANSFERENCIA=1;
        public static int ABONO = 2;
        public static int CREDITO = 3;
        
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

        public string Monto
        {
            get
            {
                return monto;
            }

            set
            {
                monto = value;
            }
        }

        public string Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public int CuentaOrigen
        {
            get
            {
                return cuentaOrigen;
            }

            set
            {
                cuentaOrigen = value;
            }
        }

        public int CuentaDestino
        {
            get
            {
                return cuentaDestino;
            }

            set
            {
                cuentaDestino = value;
            }
        }

        public string Comentario
        {
            get
            {
                return comentario;
            }

            set
            {
                comentario = value;
            }
        }

        public int Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }
    }
}

