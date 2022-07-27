using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAV1_GYM.Entidades
{
    public class Turno
    {
        public int Id_Turno { get; set; }
        public string Nombre { get; set; }
        public DateTime Hora_Inicio { get; set; }
        public DateTime Hora_Fin { get; set; }
        public string Dia { get; set; }
        public bool Estado { get; set; }
    }
}
