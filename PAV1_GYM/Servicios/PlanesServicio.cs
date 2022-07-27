using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.Entidades;
using PAV1_GYM.RepositoriosBD;

namespace PAV1_GYM.Servicios
{
    public class PlanesServicio
    {
        private PlanesRepositorio planesRepositorio;
        
        public PlanesServicio()
        {
            planesRepositorio = new PlanesRepositorio();
        }

        public List<Plan> GetPlanes()
        {
            return planesRepositorio.GetPlanes();
        }

        public bool RegistrarPlan(Plan plan)
        {
            return planesRepositorio.RegistrarPlan(plan);
        }

        public void ModificarEstadoPlan(Plan plan)
        {
            if (!planesRepositorio.ModificarEstadoPlan(plan))
                throw new ApplicationException("Hubo un problema al cambiar el estado del plan");
        }

        public void EliminarPlan(int id_plan)
        {
            if (!planesRepositorio.EliminarPlan(id_plan))
                throw new ApplicationException("Hubo un problema al eliminar el plan");
        }

        public bool ModificarPlan(Plan plan, string nombrePlanBuscado)
        {
            return planesRepositorio.ModificarPlan(plan, nombrePlanBuscado);
        }

        public List<Plan> ObtenerPlanes(Plan plan)
        {
            return planesRepositorio.ObtenerPlanes(plan);
        }

        public Plan ObtenerPlan(string nombre)
        {
            return planesRepositorio.ObtenerPlan(nombre);
        }
    }
}