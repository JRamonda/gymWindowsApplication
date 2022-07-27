using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAV1_GYM.Entidades
{
    public class Asistencia
    {
        public Actividad Actividad { get; set; }
        public Socio Socio { get; set; }
        public Turno Turno { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? Hora_Ingreso { get; set; }
        public DateTime? Hora_Egreso { get; set; }
    }
}
