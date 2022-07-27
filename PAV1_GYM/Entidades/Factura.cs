using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAV1_GYM.Entidades
{
    public class Factura
    {
        public int NroFactura { get; set; }
        public Socio Socio { get; set; }
        public Empleado Empleado { get; set; }
        public MetodoPago MetodoPago { get; set; }
        public DateTime Fecha { get; set; }
        public float MontoTotal { get; set; }
        public bool CondicionCobro { get; set; }
        public List<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();
    }
}