using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.Entidades;
using PAV1_GYM.RepositoriosBD;

namespace PAV1_GYM.Servicios
{
    public class AsistenciasServicio
    {
        private AsistenciasRepositorio asistenciasRepositorio;

        public AsistenciasServicio()
        {
            asistenciasRepositorio = new AsistenciasRepositorio();
        }

        public List<Asistencia> ObtenerAsistencias(Asistencia asistencia)
        {
            return asistenciasRepositorio.ObtenerAsistencias(asistencia);
        }

        public void ConfirmarAsistencia(int nroSocio, int id_turno)
        {
            if (!asistenciasRepositorio.ConfirmarAsistencia(nroSocio, id_turno))
                throw new ApplicationException("Hubo un problema al confirmar la asistencia");
        }

        public void MarcarEgreso(int nroSocio, int id_turno)
        {
            if (!asistenciasRepositorio.MarcarEgreso(nroSocio, id_turno))
                throw new ApplicationException("Hubo un problema al marcar el egreso");
        }

        public void EliminarAsistencia(int nroSocio, int id_turno)
        {
            if (!asistenciasRepositorio.EliminarAsistencia(nroSocio, id_turno))
                throw new ApplicationException("Hubo un problema al eliminar la asistencia");
        }

        public bool RegistrarAsistencia(Asistencia a)
        {
            return asistenciasRepositorio.RegistrarAsistencia(a);
        }
    }
}
