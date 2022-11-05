using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPIAutomo.Dominio
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

      
        public Cliente(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
         
        }
    }
}
