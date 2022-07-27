using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_GYM.Entidades;
using PAV1_GYM.Servicios;

namespace PAV1_GYM.InterfacesDeUsuarios.PerfilUsuario
{
    public partial class PerfilPersonal : Form
    {
        private Empleado usuarioLogueado;
        private EmpleadosServicio empleadosServicio;

        public PerfilPersonal()
        {
            empleadosServicio = new EmpleadosServicio();
            InitializeComponent();
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            usuarioLogueado = EmpleadosServicio.UsuarioLogueado;
            int legajo = usuarioLogueado.LegajoEmpleado;
            if (legajo != 1)
            {
                var empleado = empleadosServicio.ObtenerEmpleadoLeg(legajo);
                OcultarDatosUsuario();
                MostrarDatosEmpleado(empleado);
            }
            else
            {
                OcultarDatosEmpleado();
                MostrarDatosUsuario(usuarioLogueado);
            }
        }

        private void OcultarDatosEmpleado()
        {
            LblLegajoEmpleado.Visible = false;
            LblApellido.Visible = false;
            LblNroDocumento.Visible = false;
            LblTipoDocumento.Visible = false;
            LblFechaNacimiento.Visible = false;
            LblEdad.Visible = false;
            LblEmailE.Visible = false;
            LblTelefono.Visible = false;
            LblCalle.Visible = false;
            LblNroCalle.Visible = false;
            LblCiudad.Visible = false;
            LblCodigoPostal.Visible = false;
        }
        private void OcultarDatosUsuario()
        {
            LblId.Visible = false;
            LblEmailU.Visible = false;
        }

        private void MostrarDatosEmpleado(Empleado empleado)
        {
            int edad = DateTime.Today.Year - empleado.FechaNacimiento.Year;
            var fechaNacimiento = empleado.FechaNacimiento.ToString("dd-MM-yyyy");
            LblLegajoEmpleado.Text = $"Legajo: {empleado.LegajoEmpleado}";
            LblPerfil.Text = $"Perfil: {empleado.Perfil.Nombre}";
            LblNombre.Text = $"Nombre:  {empleado.Nombre}";
            LblApellido.Text = $"Apellido:  {empleado.Apellido}";
            LblNroDocumento.Text = $"Nro Documento:  {empleado.NroDocumento}";
            LblTipoDocumento.Text = $"Tipo Documento:  {empleado.TipoDocumento.Nombre}";
            LblFechaNacimiento.Text = $"Fecha de Nacimiento: {fechaNacimiento}";
            LblEdad.Text = $"Edad: {edad} años";
            LblEmailE.Text = $"Email:  {empleado.Email}";
            LblTelefono.Text = $"Telefono:  {empleado.Telefono}";
            LblCalle.Text = $"Calle:  {empleado.Calle}";
            LblNroCalle.Text = $"Nro Calle:  {empleado.NroCalle}";
            LblCiudad.Text = $"Ciudad:  {empleado.Ciudad.Nombre}";
            LblCodigoPostal.Text = $"Código Postal:  {empleado.CodigoPostal}";
        }

        private void MostrarDatosUsuario(Empleado empleado)
        {
            LblId.Text = $"Id:  {empleado.LegajoEmpleado}";
            LblPerfil.Text = $"Perfil:  {empleado.Perfil.Nombre}";
            LblNombre.Text = $"Usuario:  {empleado.Nombre}";
            LblEmailU.Text = $"Email:  {empleado.Email}";
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
