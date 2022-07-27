using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.Entidades;
using PAV1_GYM.RepositoriosBD;

namespace PAV1_GYM.Servicios
{
    public class SexosServicio
    {
        private SexosRepositorio sexosRepositorio;

        public SexosServicio()
        {
            sexosRepositorio = new SexosRepositorio();
        }

        public List<Sexo> GetSexos()
        {
            return sexosRepositorio.GetSexos();
        }
    }
}
