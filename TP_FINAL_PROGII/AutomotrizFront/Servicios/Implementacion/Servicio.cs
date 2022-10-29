using AutomotrizFront.Servicios.Interfaz;
using DataAPIAutomo.Datos.Implementacion;
using DataAPIAutomo.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizFront.Servicios.Implementacion
{
    internal class Servicio : IServicio
    {
        private IFacturaDAO dao;

        public Servicio()
        {
            dao = new FacturaDAO();
        }


    }
}
