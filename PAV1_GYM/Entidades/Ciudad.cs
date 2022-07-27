using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAV1_GYM.Entidades
{
    public class Ciudad
    {
        public int Id_Ciudad { get; set; }
        public Provincia Provincia { get; set; }
        public string Nombre { get; set; }
    }
}
