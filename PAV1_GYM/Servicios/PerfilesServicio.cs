using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.RepositoriosBD;
using PAV1_GYM.Entidades;

namespace PAV1_GYM.Servicios
{
    public class PerfilesServicio
    {
        private PerfilesRepositorio perfilesRepositorio;

        public PerfilesServicio()
        {
            perfilesRepositorio = new PerfilesRepositorio();
        }

        public List<Perfil> GetPerfiles(int id_perfilUsuario)
        {
            return perfilesRepositorio.GetPerfiles(id_perfilUsuario);
        }
    }
}
