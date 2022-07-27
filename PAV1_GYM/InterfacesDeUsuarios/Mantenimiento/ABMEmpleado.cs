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

namespace PAV1_GYM.InterfacesDeUsuarios.Mantenimiento
{
    public partial class ABMEmpleado : Form
    {
        private Empleado empleado;
        private EmpleadosServicio empleadosServicio;
        private TiposDocumentoServicio tiposDocumentoServicio;
        private PerfilesServicio perfilesServicio;
        private SexosServicio sexosServicio;
        private ActividadesServicio actividadesServicio;
        private TurnosServicio turnosServicio;
        private CiudadesServicio ciudadesServicio;
        private Empleado usuarioLogueado;
        private ProvinciasServicio provinciasServicio;
        private int id_perfilUsuario;
        public int legajoEmpleadoBuscado;
        private Dictionary<int, ActividadXTurno> DicActXTur { get; set; } = new Dictionary<int, ActividadXTurno>();

        private ActsXTurnsServicio actsXTurnsServicio;

        public ABMEmpleado()
        {
            empleadosServicio = new EmpleadosServicio();
            tiposDocumentoServicio = new TiposDocumentoServicio();
            sexosServicio = new SexosServicio();
            actividadesServicio = new ActividadesServicio();
            perfilesServicio = new PerfilesServicio();
            turnosServicio = new TurnosServicio();
            ciudadesServicio = new CiudadesServicio();
            provinciasServicio = new ProvinciasServicio();
            actsXTurnsServicio = new ActsXTurnsServicio();
            InitializeComponent();
        }

        #region CargarDatos
        private void ABMEmpleado_Load(object sender, EventArgs e)
        {
            CargarTiposDocumento();
            CargarSexos();
            CargarActividades();
            CargarPerfiles();
            CargarTurnos();
            CargarProvincias();
            dtpFechaNacimiento.MinDate = DateTime.Parse("01/01/1930");
            dtpFechaNacimiento.MaxDate = DateTime.Today;
            dtpFechaIngreso.MinDate = DateTime.Parse("01/01/2022");
            dtpFechaIngreso.MaxDate = DateTime.Today;
            BtnModificar.Enabled = false;
            BtnDarBaja.Enabled = false;
            BtnDarAlta.Visible = false;
            LblEstado.Visible = false;
            usuarioLogueado = EmpleadosServicio.UsuarioLogueado;
            id_perfilUsuario = usuarioLogueado.Perfil.Id_Perfil;
            if (legajoEmpleadoBuscado != 0)
            {
                empleado = empleadosServicio.ObtenerEmpleadoLeg(legajoEmpleadoBuscado);
                CargarEmpleado(empleado);
                HabilitarBotones(empleado);
            }
        }

        private void CargarTiposDocumento()
        {
            var tiposDocumento = tiposDocumentoServicio.GetTiposDocumento();
            var tipoSeleccionado = tiposDocumento.First();
            var conector = new BindingSource();
            conector.DataSource = tiposDocumento;
            CbTipoDocumento.DataSource = conector;
            CbTipoDocumento.DisplayMember = "Nombre";
            CbTipoDocumento.ValueMember = "Id_TipoDoc";
            CbTipoDocumento.SelectedItem = tipoSeleccionado;
        }
        private void CargarSexos()
        {
            var sexos = sexosServicio.GetSexos();
            var sexoSeleccionado = sexos.First();
            var conector = new BindingSource();
            conector.DataSource = sexos;
            CbSexo.DataSource = conector;
            CbSexo.DisplayMember = "Nombre";
            CbSexo.ValueMember = "Id_Sexo";
            CbSexo.SelectedItem = sexoSeleccionado;
        }
        private void CargarPerfiles()
        {
            var perfiles = perfilesServicio.GetPerfiles(id_perfilUsuario);
            var perfilSeleccionado = perfiles.First();
            var conector = new BindingSource();
            conector.DataSource = perfiles;
            CbPerfil.DataSource = conector;
            CbPerfil.DisplayMember = "Nombre";
            CbPerfil.ValueMember = "Id_Perfil";
            CbPerfil.SelectedItem = perfilSeleccionado;
        }
        private void CargarActividades()
        {
            var actividades = actividadesServicio.GetActividades();
            var actividadSeleccionada = actividades.First();
            var conector = new BindingSource();
            conector.DataSource = actividades;
            CbActividad.DataSource = conector;
            CbActividad.DisplayMember = "Nombre";
            CbActividad.ValueMember = "Id_Actividad";
            CbActividad.SelectedItem = actividadSeleccionada;
        }
        private void CargarTurnos()
        {
            var turnos = turnosServicio.GetTurnos();
            var turnoSeleccionado = turnos.First();
            var conector = new BindingSource();
            conector.DataSource = turnos;
            CbTurno.DataSource = conector;
            CbTurno.DisplayMember = "Nombre";
            CbTurno.ValueMember = "Id_Turno";
            CbTurno.SelectedItem = turnoSeleccionado;
        }

        private void CargarProvincias()
        {
            var provincias = provinciasServicio.GetProvinciasConCiudad();
            var provinciaSeleccionada = new Provincia();
            provinciaSeleccionada.Nombre = "Seleccionar";
            provincias.Add(provinciaSeleccionada);
            var conector = new BindingSource();
            conector.DataSource = provincias;
            CbProvincia.DataSource = conector;
            CbProvincia.DisplayMember = "Nombre";
            CbProvincia.ValueMember = "Id_Provincia";
            CbProvincia.SelectedItem = provinciaSeleccionada;
        }

        private void CargarCiudades(Ciudad ciu)
        {
            var ciudades = ciudadesServicio.ObtenerCiudades(ciu);
            if (ciudades.Count > 0)
            {
                var ciudadSeleccionada = ciudades.First();
                var conector = new BindingSource();
                conector.DataSource = ciudades;
                CbCiudad.DataSource = conector;
                CbCiudad.DisplayMember = "Nombre";
                CbCiudad.ValueMember = "Id_Ciudad";
                CbCiudad.SelectedItem = ciudadSeleccionada;
            }
            else
            {
                CbCiudad.DataSource = null;
                CbCiudad.Items.Clear();
            }
        }

        private void CargarEmpleado(Empleado empleado)
        {
            TxtNombre.Text = empleado.Nombre;
            TxtApellido.Text = empleado.Apellido;
            CbPerfil.SelectedValue = empleado.Perfil.Id_Perfil;
            TxtNroDocumento.Text = empleado.NroDocumento;
            CbTipoDocumento.SelectedValue = empleado.TipoDocumento.Id_TipoDoc;
            dtpFechaNacimiento.Text = empleado.FechaNacimiento.ToString();
            CbSexo.SelectedValue = empleado.Sexo.Id_Sexo;
            TxtCodigoPostal.Text = empleado.CodigoPostal;
            TxtCalle.Text = empleado.Calle;
            TxtNroCalle.Text = empleado.NroCalle.ToString();
            CbCiudad.SelectedValue = empleado.Ciudad.Id_Ciudad;
            TxtTelefono.Text = empleado.Telefono;
            TxtEmail.Text = empleado.Email;
            dtpFechaIngreso.Text = empleado.FechaIngreso.ToString();
            LblEstado.Visible = true;
            if (empleado.Estado == true)
                LblEstado.Text = "Estado: Activo";
            else
                LblEstado.Text = "Estado: Inactivo";
            foreach (ActividadXTurno at in empleado.ActividadesXTurnos)
            {
                LBActividadYTurno.Items.Add($"{at.Actividad.Nombre}, {at.Turno.Nombre}");
            }
        }
        #endregion

        #region Clicks
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsCamposValidos())
                    return;
                if (!EsOperacionConfirmada())
                    return;
                if (!EsEmpleadoValido())
                    return;
                if (!empleadosServicio.RegistrarEmpleado(empleado))
                {
                    MessageBox.Show("El empleado ya se encuentra cargado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El empleado se registró con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Ha ocurrido un problema, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsCamposValidos())
                    return;
                if (!EsOperacionConfirmada())
                    return;
                if (!EsEmpleadoValido())
                    return;
                if (!empleadosServicio.ModificarEmpleado(empleado, legajoEmpleadoBuscado))
                {
                    MessageBox.Show("Problema al modificar el empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("El empleado se modificó con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDarBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsCamposValidos())
                    return;
                if (!EsOperacionConfirmada())
                    return;
                empleado.Estado = false;
                empleadosServicio.ModificarEstadoEmpleado(empleado);
                MessageBox.Show("La operación se realizó con éxito", "Información");
                LimpiarCampos();

            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsCamposValidos())
                    return;
                if (!EsOperacionConfirmada())
                    return;
                if (!EsEmpleadoValido())
                    return;
                empleado.Estado = true;
                empleadosServicio.ModificarEstadoEmpleado(empleado);
                MessageBox.Show("La operación se realizó con éxito", "Información");
                LimpiarCampos();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LnkBuscar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string nroDoc = TxtNroDocumento.Text;
                int tipoDoc = ((TipoDocumento)CbTipoDocumento.SelectedItem).Id_TipoDoc;
                if (nroDoc.Length > 0)
                {
                    var empleadoBuscado = new Empleado();
                    empleadoBuscado = empleadosServicio.ObtenerEmpleado(nroDoc, tipoDoc);
                    if (empleadoBuscado == null)
                    {
                        MessageBox.Show("El empleado no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        LBActividadYTurno.Items.Clear();
                        legajoEmpleadoBuscado = empleadoBuscado.LegajoEmpleado;
                        empleado = empleadoBuscado;
                        CargarEmpleado(empleadoBuscado);
                        HabilitarBotones(empleado);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un documento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtNroDocumento.Focus();
                }

            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LnkAgregar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                bool siHay = false;
                var actividad = ((Actividad)CbActividad.SelectedItem).Nombre;
                var turno = ((Turno)CbTurno.SelectedItem).Nombre;
                foreach (var item in LBActividadYTurno.Items)
                {
                    if (item.ToString().Contains(actividad) && item.ToString().Contains(turno))
                        siHay = true;
                }
                if (siHay)
                {
                    MessageBox.Show("Actividad ya cargada, verifique el turno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    LBActividadYTurno.Items.Add($"{actividad}, {turno}");
                }
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LnkQuitar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                int index = LBActividadYTurno.SelectedIndex;
                if (index != -1)
                {
                    this.LBActividadYTurno.Items.RemoveAt(index);
                }
                else
                {
                    MessageBox.Show("Seleccione una actividad", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CbActividad.Focus();
                }
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LnkAgregarCiudad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var consultaCiudades = new ConsultaCiudades();
                consultaCiudades.FormBorderStyle = FormBorderStyle.FixedDialog;
                consultaCiudades.MaximizeBox = false;
                consultaCiudades.MinimizeBox = false;
                consultaCiudades.StartPosition = FormStartPosition.CenterScreen;
                consultaCiudades.ShowDialog();
                CargarProvincias();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Funciones

        private bool EsOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("Desea confirmar la operación", "Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }

        private bool EsCamposValidos()
        {
            if (TxtNombre.Text.Equals("") || TxtApellido.Text.Equals("") || TxtNroDocumento.Text.Equals("")
                    || TxtCodigoPostal.Text.Equals("") || TxtCalle.Text.Equals("") || TxtNroCalle.Text.Equals("") || TxtTelefono.Text.Equals(""))
            {
                MessageBox.Show("Hay campos sin rellenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!(int.TryParse(TxtNroCalle.Text, out int number) && number > 0))
            {
                MessageBox.Show("Ingrese un número de calle válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNroCalle.Focus();
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtNroDocumento.Text = "";
            CbPerfil.SelectedIndex = 0;
            CbTipoDocumento.SelectedIndex = 0;
            dtpFechaNacimiento.Text = DateTime.Today.ToString();
            CbSexo.SelectedIndex = 0;
            TxtCodigoPostal.Text = "";
            TxtCalle.Text = "";
            TxtNroCalle.Text = "";
            CbProvincia.SelectedIndex = CbProvincia.Items.Count - 1;
            TxtTelefono.Text = "";
            TxtEmail.Text = "";
            dtpFechaIngreso.Text = DateTime.Today.ToString();
            CbActividad.SelectedIndex = 0;
            CbTurno.SelectedIndex = 0;
            DicActXTur.Clear();
            LBActividadYTurno.Items.Clear();
            BtnModificar.Enabled = false;
            BtnDarBaja.Enabled = false;
            BtnDarAlta.Visible = false;
            LblEstado.Visible = false;
        }

        private bool EsEmpleadoValido()
        {
            int nroCalle;
            int.TryParse(TxtNroCalle.Text, out nroCalle);
            var empleadoIngresado = new Empleado
            {
                NroDocumento = TxtNroDocumento.Text,
                TipoDocumento = (TipoDocumento)CbTipoDocumento.SelectedItem,
                Nombre = TxtNombre.Text,
                Apellido = TxtApellido.Text,
                FechaNacimiento = DateTime.Parse(dtpFechaNacimiento.Text),
                Sexo = (Sexo)CbSexo.SelectedItem,
                CodigoPostal = TxtCodigoPostal.Text,
                Calle = TxtCalle.Text,
                NroCalle = nroCalle,
                Ciudad = (Ciudad)CbCiudad.SelectedItem,
                Telefono = TxtTelefono.Text,
                Email = TxtEmail.Text,
                FechaIngreso = DateTime.Parse(dtpFechaIngreso.Text),
                Perfil = (Perfil)CbPerfil.SelectedItem
            };
            empleado = empleadoIngresado;
            if (empleado.Perfil.Id_Perfil == 4)
            {
                RegistrarActXTurno();
            }
            return true;
        }

        private void RegistrarActXTurno()
        {
            var actXturs = actsXTurnsServicio.GetActsXTurns();
            foreach (string item in LBActividadYTurno.Items)
            {
                foreach (ActividadXTurno axt in actXturs)
                {
                    if (item.Contains(axt.Actividad.Nombre) && item.Contains(axt.Turno.Nombre))
                        empleado.ActividadesXTurnos.Add(axt);
                }
            }
        }

        private void CbPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seleccion = CbPerfil.SelectedIndex;
            if (seleccion == 3)
            {
                GrupoActividad.Visible = true;
            }
            else
            {
                GrupoActividad.Visible = false;
            }
        }

        private void CbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((Provincia)CbProvincia.SelectedItem).Nombre == "Seleccionar")
            {
                CbCiudad.DataSource = null;
                CbCiudad.Enabled = false;
            }
            else
            {
                var ciudad = new Ciudad();
                ciudad.Provincia = (Provincia)CbProvincia.SelectedItem;
                CbCiudad.Enabled = true;
                CargarCiudades(ciudad);
            }
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - dtpFechaNacimiento.Value.Year;
            if (fechaActual < dtpFechaNacimiento.Value.AddYears(edad)) edad--;
            LblEdad.Text = $"Edad: {edad}";
        }

        private void HabilitarBotones(Empleado empleado)
        {
            BtnModificar.Enabled = true;
            BtnDarBaja.Enabled = true;
            if (empleado.Estado == false)
                BtnDarAlta.Visible = true;
        }
        #endregion
    }
}
