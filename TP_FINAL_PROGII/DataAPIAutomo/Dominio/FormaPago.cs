using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPIAutomo.Dominio
{
    public class FormaPago
    {
        public int Id
        {
            get; set;
        }
        public string Descripcion
        {
            get; set;
        }
        
        public FormaPago(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
          
        }
     }
}
