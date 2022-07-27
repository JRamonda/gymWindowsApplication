using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.RepositoriosBD;
using PAV1_GYM.Entidades;

namespace PAV1_GYM.Servicios
{
    public class EmpleadosServicio
    {
        private EmpleadosRepositorio empleadosRepositorio;
        public static Empleado UsuarioLogueado;

        public EmpleadosServicio()
        {
            empleadosRepositorio = new EmpleadosRepositorio();
        }

        public Empleado Login(Empleado usuarioIngresado)
        {
            var usuario = empleadosRepositorio.LoginBD(usuarioIngresado);
            UsuarioLogueado = usuario;
            return usuario;
        }

        public bool RegistrarEmpleado(Empleado empleado)
        {
            return empleadosRepositorio.RegistrarEmpleado(empleado);
        }

        public Empleado ObtenerEmpleado(string nroDoc, int tipoDoc)
        {
            return empleadosRepositorio.ObtenerEmpleado(nroDoc, tipoDoc);
        }
        public Empleado ObtenerEmpleadoLeg(int legajo)
        {
            return empleadosRepositorio.ObtenerEmpleadoLeg(legajo);
        }

        public void EliminarEmpleado(int legajoEmpleado)
        {
            if (!empleadosRepositorio.EliminarEmpleado(legajoEmpleado))
                throw new ApplicationException("Hubo un problema al eliminar al empleado");
        }

        public void ModificarEstadoEmpleado(Empleado empleado)
        {
            if (!empleadosRepositorio.ModificarEstadoEmpleado(empleado))
                throw new ApplicationException("Hubo un problema al cambiar el estado del empleado");
        }

        public bool ModificarEmpleado(Empleado empleado, int Legajo)
        {
            return empleadosRepositorio.ModificarEmpleado(empleado, Legajo);
        }

        public bool CambiarContraseña(string password, int legajoEmpleado)
        {
            return empleadosRepositorio.CambiarContraseña(password, legajoEmpleado);
        }

        public List<Empleado> Obtener(Empleado e)
        {
            return empleadosRepositorio.Obtener(e);
        }
    }
}