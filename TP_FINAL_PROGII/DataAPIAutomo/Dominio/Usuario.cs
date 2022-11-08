using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPIAutomo.Dominio
{
    public class Usuario
    {
        public string nombre { get; set; }  
        public string clave { get; set; }

        public Usuario(string nombre, string clave)
        {
            this.nombre = nombre;
            this.clave = clave;
        }
    }
}
