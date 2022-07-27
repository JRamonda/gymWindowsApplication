using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAV1_GYM.Entidades
{
    public class Socio
    {
        public int NroSocio { get; set; }
        public string NroDocumento { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Sexo Sexo { get; set; }
        public int Altura { get; set; }
        public float Peso { get; set; }
        public string Calle { get; set; }
        public int NroCalle { get; set; }
        public Ciudad Ciudad { get; set; }
        public string CodigoPostal { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string AntecedenteMedico { get; set; }
        public Empleado Empleado { get; set; }
        public List<Objetivo> Objetivos { get; set; } = new List<Objetivo>();
        public List<Actividad> Actividades { get; set; } = new List<Actividad>();
        public List<Plan> Planes { get; set; } = new List<Plan>();
        public List<Turno> Turnos { get; set; } = new List<Turno>();
        public bool Estado { get; set; }
    }
}
