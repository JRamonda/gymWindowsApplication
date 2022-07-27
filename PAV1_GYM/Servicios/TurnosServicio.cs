using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.Entidades;
using PAV1_GYM.RepositoriosBD;
using System.Data;

namespace PAV1_GYM.Servicios
{
    public class TurnosServicio
    {
        private TurnosRepositorio turnosRepositorio;

        public TurnosServicio()
        {
            turnosRepositorio = new TurnosRepositorio();
        }

        public List<Turno> GetTurnos()
        {
            return turnosRepositorio.GetTurnos();
        }

        public DataTable GetTurnosUnicos()
        {
            return turnosRepositorio.GetTurnosUnicos();
        }

        public List<Turno> ObtenerTurnosXActividad(int id_actividad, string dia)
        {
            return turnosRepositorio.ObtenerTurnosXActividad(id_actividad, dia);
        }

        public List<Turno> GetTurnosXDia(string dia)
        {
            return turnosRepositorio.GetTurnosXDia(dia);
        }


        public bool RegistrarTurno(Turno turno)
        {
            return turnosRepositorio.RegistrarTurno(turno);
        }

        public void ModificarEstadoTurno(Turno turno)
        {
            if (!turnosRepositorio.ModificarEstadoTurno(turno))
                throw new ApplicationException("Hubo un problema al cambiar el estado del turno");
        }

        public void EliminarTurno(int id_turno)
        {
            if (!turnosRepositorio.EliminarTurno(id_turno))
                throw new ApplicationException("Hubo un problema al eliminar el turno");
        }

        public bool ModificarTurno(Turno turno, string nombreBuscado, string diaBuscado)
        {
            return turnosRepositorio.ModificarTurno(turno, nombreBuscado, diaBuscado);
        }

        public List<Turno> Obtener(Turno turno)
        {
            return turnosRepositorio.Obtener(turno);
        }

        public Turno ObtenerTurno(string nombre, string dia)
        {
            return turnosRepositorio.ObtenerTurno(nombre, dia);
        }
    }
}