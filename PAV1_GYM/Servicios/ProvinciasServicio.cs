using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.RepositoriosBD;
using PAV1_GYM.Entidades;

namespace PAV1_GYM.Servicios
{
    public class ProvinciasServicio
    {
        private ProvinciasRepositorio provinciasRepositorio;

        public ProvinciasServicio()
        {
            provinciasRepositorio = new ProvinciasRepositorio();
        }

        public List<Provincia> GetProvincias()
        {
            return provinciasRepositorio.GetProvincias();
        }

        public List<Provincia> GetProvinciasConCiudad()
        {
            return provinciasRepositorio.GetProvinciasConCiudad();
        }
    }
}
