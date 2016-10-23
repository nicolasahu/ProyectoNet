using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBanco.model
{
    class CorreoTransferencia
    {
        String nombreCliente_destino;
        String nombreCliente_origen;
        String montoTransferencia;
        String fechaTransferencia;
        String rutCliente_origen;
        String rutCliente_destino;
        String numeroCuenta_origen;
        String numeroCuenta_destino;
        String comentario_Transferencia;

        public string NombreCliente_destino
        {
            get
            {
                return nombreCliente_destino;
            }

            set
            {
                nombreCliente_destino = value;
            }
        }

        public string NombreCliente_origen
        {
            get
            {
                return nombreCliente_origen;
            }

            set
            {
                nombreCliente_origen = value;
            }
        }

        public string MontoTransferencia
        {
            get
            {
                return montoTransferencia;
            }

            set
            {
                montoTransferencia = value;
            }
        }

        public string FechaTransferencia
        {
            get
            {
                return fechaTransferencia;
            }

            set
            {
                fechaTransferencia = value;
            }
        }

        public string RutCliente_origen
        {
            get
            {
                return rutCliente_origen;
            }

            set
            {
                rutCliente_origen = value;
            }
        }

        public string RutCliente_destino
        {
            get
            {
                return rutCliente_destino;
            }

            set
            {
                rutCliente_destino = value;
            }
        }

        public string NumeroCuenta_origen
        {
            get
            {
                return numeroCuenta_origen;
            }

            set
            {
                numeroCuenta_origen = value;
            }
        }

        public string NumeroCuenta_destino
        {
            get
            {
                return numeroCuenta_destino;
            }

            set
            {
                numeroCuenta_destino = value;
            }
        }

        public string Comentario_Transferencia
        {
            get
            {
                return comentario_Transferencia;
            }

            set
            {
                comentario_Transferencia = value;
            }
        }
    }
}
