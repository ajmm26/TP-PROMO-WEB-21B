using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Cliente
    {
        string nombre;
        string apellido;
        string email;
        string documento;
        string direccion;
        string ciudad;
        string cp;


        public string nombnre { get => nombre; set => nombre = value; }

        public string Apellido { get => apellido; set => apellido = value; }

        public string Email { get => email; set => email = value; }

        public string Documento { get => documento; set => documento = value; }

        public string Direccion { get => direccion; set => direccion = value; }

        public string Ciudad { get => ciudad; set => ciudad = value; }

        public string Cp { get => cp; set => cp = value; }
    }
}
