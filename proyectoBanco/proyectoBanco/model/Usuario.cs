using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBanco.model
{
    class Usuario
    {
        private int id;
        private String nombreLogin;
        private String contraseña;
        private string privilegio;

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

        public string NombreLogin
        {
            get
            {
                return nombreLogin;
            }

            set
            {
                nombreLogin = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return contraseña;
            }

            set
            {
                contraseña = value;
            }
        }

        public string Privilegio
        {
            get
            {
                return privilegio;
            }

            set
            {
                privilegio = value;
            }
        }
    }
}
