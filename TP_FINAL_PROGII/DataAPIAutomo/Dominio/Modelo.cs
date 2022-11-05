using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPIAutomo.Dominio
{
    public class Modelo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public Modelo(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }

    }
}
