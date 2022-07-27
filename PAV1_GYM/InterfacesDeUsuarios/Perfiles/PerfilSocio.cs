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
    public partial class PerfilSocio : Form
    {
        private SociosServicio sociosServicio;
        public int nroSocio;

        public PerfilSocio()
        {
            sociosServicio = new SociosServicio();
            InitializeComponent();
        }

        private void PerfilSocio_Load(object sender, EventArgs e)
        {
            var socio = sociosServicio.ObtenerSocioNro(nroSocio);
            CargarDatos(socio);
            if (socio.Sexo.Id_Sexo == 1)
            {
                PbMasc.Visible = true;
            }
            else
            {
                PbFem.Visible = true;
            }
        }

        private void CargarDatos(Socio s)
        {
            int edad = DateTime.Today.Year - s.FechaNacimiento.Year;
            var fechaNacimiento = s.FechaNacimiento.ToString("dd/MM/yyyy");
            LblNroSocio.Text = $"Nro Socio: {s.NroSocio}";
            LblNombre.Text = $"Nombre: {s.Nombre}";
            LblApellido.Text = $"Apellido: {s.Apellido}";
            LblNroDoc.Text = $"Nro Documento: {s.NroDocumento}";
            LblTipoDoc.Text = $"Tipo Documento: {s.TipoDocumento.Nombre}";
            LblFechaNac.Text = $"Fecha de Nacimiento: {fechaNacimiento}";
            LblEdad.Text = $"Edad: {edad} años";
            LblSexo.Text = $"Sexo: {s.Sexo.Nombre}";
            LblCiudad.Text = $"Ciudad: {s.Ciudad.Nombre}, {s.Ciudad.Provincia.Nombre}";
            LblCodigoPostal.Text = $"Código Postal: {s.CodigoPostal}";
            LblDireccion.Text = $"Dirección: {s.Calle} {s.NroCalle}";
            LblEmail.Text = $"Email: {s.Email}";
            LblTelefono.Text = $"Telefono: {s.Telefono}";
            LblAntecedenteMedico.Text = $"Antecedente Médico: {s.AntecedenteMedico}";
            LblFechaAlta.Text = $"Fecha de Alta\n  {s.FechaAlta.ToString("dd/MM/yyyy")}";
            var estado = s.Estado ? "Activo" : "Baja";
            LblEstado.Text = $" Estado\n {estado}";
            if (s.FechaBaja != null)
                LblFechaBaja.Text = $"Fecha de Baja\n  {s.FechaBaja?.ToString("dd/MM/yyyy")}";
            string objetivos = "Objetivos: ";
            for (int i = 0; i < s.Objetivos.Count; i++)
            {
                if (i == 0)
                {
                    objetivos += $"{ s.Objetivos[i].Nombre}";
                }
                else
                    objetivos += $", {s.Objetivos[i].Nombre}";
            }
            LblObjetivos.Text = objetivos;
            string nombreVendedor = $"Vendedor\n {s.Empleado?.Nombre}, {s.Empleado?.Apellido}";
            if (s.Empleado.LegajoEmpleado == 1)
                nombreVendedor = $"Vendedor\n {s.Empleado?.Nombre}";
            LblVendedor.Text = nombreVendedor;
            string actividadesyplanes = "Actividad y Plan: ";
            for (int i = 0; i < s.Actividades.Count; i++)
            {
                if (i == 0)
                    actividadesyplanes += $"{s.Actividades[i].Nombre}, {s.Planes[i].Nombre}";
                else
                    actividadesyplanes += $" | {s.Actividades[i].Nombre}, {s.Planes[i].Nombre}";
            }
            LblActividadyPlan.Text = actividadesyplanes;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}