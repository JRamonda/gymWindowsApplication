using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAV1_GYM.Entidades
{
    public class Plan
    {
        public int Id_Plan { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float PrecioEstandar { get; set; }
        public DateTime FechaInicioPlan { get; set; }
        public bool Estado { get; set; }
    }
}
