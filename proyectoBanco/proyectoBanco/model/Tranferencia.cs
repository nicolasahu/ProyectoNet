using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBanco.model
{
    class Tranferencia
    {
        private int id;
        private int monto;
        private DateTime fecha;
        private int cuentaOrigen;
        private int cuentaDestino;
        private String comentario;

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

        public int Monto
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

        public DateTime Fecha
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
    }
}
