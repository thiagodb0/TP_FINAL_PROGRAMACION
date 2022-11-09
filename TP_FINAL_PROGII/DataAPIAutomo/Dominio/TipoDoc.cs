using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPIAutomo.Dominio
{
    public class TipoDoc
    {
        int cod { get; set; }
        string desc { get; set; }

        public TipoDoc(int cod, string desc)
        {
            this.cod = cod;
            this.desc = desc;
        }
    }
}
