using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAV1_GYM.Entidades
{
    public class DetalleFactura
    {
        public Factura Factura { get; set; }
        public int Orden { get; set; }
        public Actividad Actividad { get; set; }
        public Plan Plan { get; set; }
        public float PrecioUnitario { get; set; }
        public float Promocion { get; set; }
        public DateTime FechaDevPrevista { get; set; }
        public DateTime FechaDevReal { get; set; }
}
}
