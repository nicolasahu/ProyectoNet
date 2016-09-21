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
        private String[][] numeros;

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

        public string[][] Numeros
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
