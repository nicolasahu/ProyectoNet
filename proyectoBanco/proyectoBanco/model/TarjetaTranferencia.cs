using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBanco.model
{
    class TarjetaTranferencia
    {
        private int id;
        private String numeros;
        private int cuenta;

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

        public int Cuenta
        {
            get
            {
                return cuenta;
            }

            set
            {
                cuenta = value;
            }
        }

        public string Numeros
        {
            get
            {
                return numeros;
            }

            set
            {
                numeros = value;
            }
        }
    }
}
