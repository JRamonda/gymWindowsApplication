using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.RepositoriosBD;
using PAV1_GYM.Entidades;
using System.Windows.Forms;

namespace PAV1_GYM.Servicios
{
    public class SociosServicio
    {
        private SociosRepositorio sociosRepositorio;

        public SociosServicio()
        {
            sociosRepositorio = new SociosRepositorio();
        }

        public bool RegistrarSocio(Socio socio, int cantObj)
        {
            return sociosRepositorio.RegistrarSocio(socio, cantObj);
        }

        public Socio ObtenerSocio(string nroDoc, int tipoDoc)
        {
            return sociosRepositorio.ObtenerSocio(nroDoc, tipoDoc);
        }

        public List<Socio> ObtenerSociosConActividad(Socio s)
        {
            return sociosRepositorio.ObtenerSociosConActividad(s);
        }

        public Socio ObtenerSocioNro(int nroSocio)
        {
            return sociosRepositorio.ObtenerSocioNro(nroSocio);
        }

        public void ModificarEstadoSocio(Socio socio)
        {
            if (!sociosRepositorio.ModificarEstadoSocio(socio))
                throw new ApplicationException("Hubo un problema al cambiar el estado del socio");
        }

        public void EliminarSocio(int nroSocio)
        {
            if (!sociosRepositorio.EliminarSocio(nroSocio))
                throw new ApplicationException("Hubo un problema al eliminar al socio");
        }

        public bool ModificarSocio(Socio socio, int NroSocio)
        {
            return sociosRepositorio.ModificarSocio(socio, NroSocio);
        }

        public List<Socio> Obtener(Socio s)
        {
            return sociosRepositorio.Obtener(s);
        }
    }
}