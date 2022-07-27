using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.Entidades;
using PAV1_GYM.RepositoriosBD;

namespace PAV1_GYM.Servicios
{
    public class ObjetivosServicio
    {
        private ObjetivosRepositorio objetivosRepositorio;

        public ObjetivosServicio()
        {
            objetivosRepositorio = new ObjetivosRepositorio();
        }

        public List<Objetivo> GetObjetivos()
        {
            return objetivosRepositorio.GetObjetivos();
        }

        public bool RegistrarObjetivo(Objetivo objetivo)
        {
            return objetivosRepositorio.RegistrarObjetivo(objetivo);
        }

        public void EliminarObjetivo(int id_objetivo)
        {
            if (!objetivosRepositorio.EliminarObjetivo(id_objetivo))
                throw new ApplicationException("Hubo un problema al eliminar el Objetivo");
        }

        public bool ModificarObjetivo(Objetivo objetivo, string nombreObjetivoBuscado)
        {
            return objetivosRepositorio.ModificarObjetivo(objetivo, nombreObjetivoBuscado);
        }

        public List<Objetivo> ObtenerObjetivos(Objetivo objetivo)
        {
            return objetivosRepositorio.ObtenerObjetivo(objetivo);
        }

        public Objetivo ObtenerObjetivo(string nombre)
        {
            return objetivosRepositorio.ObtenerObjetivo(nombre);
        }
    }
}