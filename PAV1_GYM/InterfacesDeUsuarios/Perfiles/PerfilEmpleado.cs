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

namespace PAV1_GYM.InterfacesDeUsuarios.Perfiles
{
    public partial class PerfilEmpleado : Form
    {
        private EmpleadosServicio empleadosServicio;
        public int legajo;

        public PerfilEmpleado()
        {
            empleadosServicio = new EmpleadosServicio();
            InitializeComponent();
        }

        private void PerfilEmpleado_Load(object sender, EventArgs e)
        {
            var empleado = empleadosServicio.ObtenerEmpleadoLeg(legajo);
            CargarDatos(empleado);
            if (empleado.Sexo.Id_Sexo == 1)
            {
                PbMasc.Visible = true;
            }
            else
            {
                PbFem.Visible = true;
            }
        }

        private void CargarDatos(Empleado e)
        {
            int edad = DateTime.Today.Year - e.FechaNacimiento.Year;
            var fechaNacimiento = e.FechaNacimiento.ToString("dd/MM/yyyy");
            LblLegajoEmpleado.Text = $"Nro Socio: {e.LegajoEmpleado}";
            LblPerfil.Text = $"Perfil: {e.Perfil.Nombre}";
            LblNombre.Text = $"Nombre: {e.Nombre}";
            LblApellido.Text = $"Apellido: {e.Apellido}";
            LblNroDoc.Text = $"Nro Documento: {e.NroDocumento}";
            LblTipoDoc.Text = $"Tipo Documento: {e.TipoDocumento.Nombre}";
            LblFechaNac.Text = $"Fecha de Nacimiento: {fechaNacimiento}";
            LblEdad.Text = $"Edad: {edad} años";
            LblSexo.Text = $"Sexo: {e.Sexo.Nombre}";
            LblCiudad.Text = $"Ciudad: {e.Ciudad.Nombre}, {e.Ciudad.Provincia.Nombre}";
            LblCodigoPostal.Text = $"Código Postal: {e.CodigoPostal}";
            LblDireccion.Text = $"Dirección: {e.Calle} {e.NroCalle}";
            LblEmail.Text = $"Email: {e.Email}";
            LblTelefono.Text = $"Telefono: {e.Telefono}";
            LblFechaIngreso.Text = $"Fecha de Ingreso\n  {e.FechaIngreso.ToString("dd/MM/yyyy")}";
            var estado = e.Estado ? "Activo" : "Baja";
            LblEstado.Text = $" Estado\n {estado}";
            if (e.FechaBaja != null)
                LblFechaBaja.Text = $"Fecha de Baja\n  {e.FechaBaja?.ToString("dd/MM/yyyy")}";
            if (e.Perfil.Nombre == "Entrenador")
            {
                string actividadesyturnos = "Actividad y Turno: ";
                for (int i = 0; i < e.ActividadesXTurnos.Count; i++)
                {
                    if (i == 0)
                    {
                        actividadesyturnos += $"{e.ActividadesXTurnos[i].Actividad.Nombre}, {e.ActividadesXTurnos[i].Turno.Nombre}";
                    }

                    else
                        actividadesyturnos += $" | {e.ActividadesXTurnos[i].Actividad.Nombre}, {e.ActividadesXTurnos[i].Turno.Nombre}";
                }
                LblActividadyTurno.Text = actividadesyturnos;
                LblActividadyTurno.Visible = true;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
