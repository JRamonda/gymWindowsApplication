using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.Entidades;
using PAV1_GYM.RepositoriosBD;

namespace PAV1_GYM.Servicios
{
    public class CiudadesServicio
    {
        private CiudadesRepositorio ciudadesRepositorio;

        public CiudadesServicio()
        {
            ciudadesRepositorio = new CiudadesRepositorio();
        }

        public List<Ciudad> GetCiudades()
        {
            return ciudadesRepositorio.GetCiudades();
        }

        public bool RegistrarCiudad(Ciudad ciudad)
        {
            return ciudadesRepositorio.RegistrarCiudad(ciudad);
        }

        public void EliminarCiudad(int id_ciudad)
        {
            if (!ciudadesRepositorio.EliminarCiudad(id_ciudad))
                throw new ApplicationException("Hubo un problema al eliminar la ciudad");
        }

        public bool ModificarCiudad(Ciudad ciudad, string nombreCiudadBuscada)
        {
            return ciudadesRepositorio.ModificarCiudad(ciudad, nombreCiudadBuscada);
        }

        public List<Ciudad> ObtenerCiudades(Ciudad ciudad)
        {
            return ciudadesRepositorio.ObtenerCiudades(ciudad);
        }

        public Ciudad ObtenerCiudad(string nombre)
        {
            return ciudadesRepositorio.ObtenerCiudad(nombre);
        }
    }
}