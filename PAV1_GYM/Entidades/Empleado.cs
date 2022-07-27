using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAV1_GYM.Entidades
{
    public class Empleado
    {
        public int LegajoEmpleado { get; set; }
        public Perfil Perfil { get; set; }
        public string Password { get; set; }
        public string NroDocumento { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Sexo Sexo { get; set; }
        public string Calle { get; set; }
        public int NroCalle { get; set; }
        public Ciudad Ciudad { get; set; }
        public string CodigoPostal { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaBaja { get; set; }
        public bool Estado { get; set; }
        public List<ActividadXTurno> ActividadesXTurnos { get; set; } = new List<ActividadXTurno>();
    }
}
