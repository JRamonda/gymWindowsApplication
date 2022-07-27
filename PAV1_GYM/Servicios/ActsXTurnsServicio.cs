using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.Entidades;
using PAV1_GYM.RepositoriosBD;

namespace PAV1_GYM.Servicios
{
    public class ActsXTurnsServicio
    {
        private ActsXTursRepositorio actsXTursRepositorio;
        public ActsXTurnsServicio() 
        {
            actsXTursRepositorio = new ActsXTursRepositorio();
        }

        public List<ActividadXTurno> GetActsXTurns()
        {
            return actsXTursRepositorio.GetActsXTurns();
        }
    }
}