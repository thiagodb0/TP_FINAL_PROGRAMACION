using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPIAutomo.Dominio
{
    public class ClienteReport 
    {
        public Cliente cliente { get; set; }

       public double total { get; set; }
        public double promedio { get; set; }
       public  string fecha { get; set; }

        public ClienteReport(Cliente cliente, double total, double promedio, string fecha)
        {
            this.cliente = cliente;
            this.total = total;
            this.promedio = promedio;
            this.fecha = fecha;
        }
    }
}
