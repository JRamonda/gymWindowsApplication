using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.Entidades;
using PAV1_GYM.RepositoriosBD;

namespace PAV1_GYM.Servicios
{
    public class MetodosPagoServicio
    {
        private MetodosPagoRepositorio metodosPagoRepositorio;

        public MetodosPagoServicio()
        {
            metodosPagoRepositorio = new MetodosPagoRepositorio();
        }

        public List<MetodoPago> GetMetodosPago()
        {
            return metodosPagoRepositorio.GetMetodosPago();
        }
    }
}
