using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.Entidades;
using PAV1_GYM.RepositoriosBD;

namespace PAV1_GYM.Servicios
{
    public class ActividadesServicio
    {
        private ActividadesRepositorio actividadesRepositorio;

        public ActividadesServicio()
        {
            actividadesRepositorio = new ActividadesRepositorio();
        }

        public List<Actividad> GetActividades()
        {
            return actividadesRepositorio.GetActividades();
        }

        public List<Actividad> ObtenerActividades(Actividad actividad)
        {
            return actividadesRepositorio.ObtenerActividades(actividad);
        }

        public List<Actividad> ObtenerActividadesSocio(int nroSocio)
        {
            return actividadesRepositorio.ObtenerActividadesSocio(nroSocio);
        }

        public Actividad ObtenerActividad(int id_actividad)
        {
            return actividadesRepositorio.ObtenerActividad(id_actividad);
        }

        public bool RegistrarActividad(Actividad actividad, List<int> idTurnos)
        {
            return actividadesRepositorio.RegistrarActividad(actividad, idTurnos);
        }

        public void ModificarEstadoActividad(Actividad actividad)
        {
            if (!actividadesRepositorio.ModificarEstadoActividad(actividad))
                throw new ApplicationException("Hubo un problema al cambiar el estado de la actividad");
        }

        public void EliminarActividad(int id_actividad)
        {
            if (!actividadesRepositorio.EliminarActividad(id_actividad))
                throw new ApplicationException("Hubo un problema al eliminar la actividad");
        }

        public bool ModificarActividad(Actividad actividad, List<int> idTurnos)
        {
            return actividadesRepositorio.ModificarActividad(actividad, idTurnos);
        }
    }
}
