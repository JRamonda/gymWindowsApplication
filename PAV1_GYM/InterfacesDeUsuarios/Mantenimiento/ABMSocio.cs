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
using PAV1_GYM.InterfacesDeUsuarios.Consultas;

namespace PAV1_GYM.InterfacesDeUsuarios.Mantenimiento
{
    public partial class ABMSocio : Form
    {

        private Empleado usuarioLogueado;
        private Socio socio;
        private SociosServicio sociosServicio;
        private TiposDocumentoServicio tiposDocumentoServicio;
        private SexosServicio sexosServicio;
        private ProvinciasServicio provinciasServicio;
        private CiudadesServicio ciudadesServicio;
        private ObjetivosServicio objetivosServicio;
        public int nroSocioBuscado;
        private int cantObj;
        private Dictionary<string , Objetivo> DicObjetivos = new Dictionary<string , Objetivo>();

        //SACAR ESTADOS, VER EL TEMA DE FECHA BAJA COMO ESTADO.

        public ABMSocio()
        {
            sociosServicio = new SociosServicio();
            tiposDocumentoServicio = new TiposDocumentoServicio();
            sexosServicio = new SexosServicio();
            provinciasServicio = new ProvinciasServicio();
            ciudadesServicio = new CiudadesServicio();
            objetivosServicio = new ObjetivosServicio();
            InitializeComponent();
        }

        #region CargarDatos
        private void ABMSocio_Load(object sender, EventArgs e)
        {
            CargarTiposDocumento();
            CargarSexos();
            CargarProvincias();
            CargarObjetivos();
            usuarioLogueado = EmpleadosServicio.UsuarioLogueado;
            dtpFechaNacimiento.MinDate = DateTime.Parse("01/01/1930");
            dtpFechaNacimiento.MaxDate = DateTime.Today;
            BtnModificar.Enabled = false;
            BtnDarBaja.Enabled = false;
            BtnDarAlta.Visible = false;
            LblEstado.Visible = false;
            if (nroSocioBuscado != 0)
            {
                socio = sociosServicio.ObtenerSocioNro(nroSocioBuscado);
                CargarSocio(socio);
                HabilitarBotones(socio);
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

        private void CargarObjetivos()
        {
            var objetivos = objetivosServicio.GetObjetivos();
            var objetivoSeleccionado = objetivos.First();
            var conector = new BindingSource();
            conector.DataSource = objetivos;
            CbObjetivo.DataSource = conector;
            CbObjetivo.DisplayMember = "Nombre";
            CbObjetivo.ValueMember = "Id_Objetivo";
            CbObjetivo.SelectedItem = objetivoSeleccionado;
        }

        public void CargarSocio(Socio socio)
        {
            TxtNombre.Text = socio.Nombre;
            TxtApellido.Text = socio.Apellido;
            TxtNroDocumento.Text = socio.NroDocumento;
            CbTipoDocumento.SelectedValue = socio.TipoDocumento.Id_TipoDoc;
            dtpFechaNacimiento.Text = socio.FechaNacimiento.ToString();
            CbSexo.SelectedValue = socio.Sexo.Id_Sexo;
            TxtCodigoPostal.Text = socio.CodigoPostal;
            TxtCalle.Text = socio.Calle;
            TxtNroCalle.Text = socio.NroCalle.ToString();
            CbCiudad.SelectedValue = socio.Ciudad.Id_Ciudad;
            CbProvincia.SelectedValue = socio.Ciudad.Provincia.Id_Provincia;
            TxtTelefono.Text = socio.Telefono;
            TxtEmail.Text = socio.Email;
            TxtAntecedenteMedico.Text = socio.AntecedenteMedico;
            LblEstado.Visible = true;
            if (socio.Estado == true)
                LblEstado.Text = "Estado: Activo";
            else
                LblEstado.Text = "Estado: Inactivo";
            if (socio.Altura != 0)
                TxtAltura.Text = socio.Altura.ToString();
            if (socio.Peso != 0)
                TxtPeso.Text = socio.Peso.ToString();
            foreach (Objetivo objetivo in socio.Objetivos)
            {
                LBObjetivos.Items.Add(objetivo.Nombre);
                DicObjetivos.Add(objetivo.Nombre, objetivo);
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
                if (!EsSocioValido())
                    return;
                RegistrarObjetivos();
                if (!sociosServicio.RegistrarSocio(socio, cantObj))
                {
                    MessageBox.Show("El socio ya se encuentra cargado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El socio se registró con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsCamposValidos())
                    return;
                if (!EsOperacionConfirmada())
                    return;
                if (!EsSocioValido())
                    return;
                RegistrarObjetivos();
                if (!sociosServicio.ModificarSocio(socio, nroSocioBuscado))
                {
                    MessageBox.Show("Problema al modificar al socio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("El socio se modificó con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (!EsSocioValido())
                    return;
                socio.Estado = false;
                sociosServicio.ModificarEstadoSocio(socio);
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
                if (!EsSocioValido())
                    return;
                socio.Estado = true;
                sociosServicio.ModificarEstadoSocio(socio);
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
                var nroDoc = TxtNroDocumento.Text;
                int tipoDoc = ((TipoDocumento)CbTipoDocumento.SelectedItem).Id_TipoDoc;
                if (nroDoc.Length > 0)
                {
                    var socioBuscado = new Socio();
                    socioBuscado = sociosServicio.ObtenerSocio(nroDoc, tipoDoc);
                    if (socioBuscado == null)
                    {
                        MessageBox.Show("El socio no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        LBObjetivos.Items.Clear();
                        nroSocioBuscado = socioBuscado.NroSocio;
                        socio = socioBuscado;
                        CargarSocio(socioBuscado);
                        HabilitarBotones(socioBuscado);
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

        private void LnkAgregarObjetivo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var objetivo = (Objetivo)CbObjetivo.SelectedItem;
                DicObjetivos.Add(objetivo.Nombre, objetivo);
                LBObjetivos.Items.Add(objetivo.Nombre);
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

        private void LnkQuitarObjetivo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {             
                int index = LBObjetivos.SelectedIndex;
                if (index != -1)
                {
                    DicObjetivos.Remove(LBObjetivos.Items[index].ToString());
                    LBObjetivos.Items.RemoveAt(index);
                }
                else
                {
                    MessageBox.Show("Seleccione un objetivo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CbObjetivo.Focus();
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


        private void LnkAgregarObjNuevo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var consultaObjetivos = new ConsultaObjetivos();
                consultaObjetivos.FormBorderStyle = FormBorderStyle.FixedDialog;
                consultaObjetivos.MaximizeBox = false;
                consultaObjetivos.MinimizeBox = false;
                consultaObjetivos.StartPosition = FormStartPosition.CenterScreen;
                consultaObjetivos.ShowDialog();
                CargarObjetivos();
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
            if (TxtNombre.Text.Equals("") || TxtApellido.Text.Equals("") || TxtNroDocumento.Text.Equals("") || TxtCodigoPostal.Text.Equals("")
                || TxtCalle.Text.Equals("") || TxtNroCalle.Text.Equals("") || TxtTelefono.Text.Equals("") || TxtEmail.Text.Equals(""))
            {
                MessageBox.Show("Hay campos sin rellenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!(int.TryParse(TxtNroCalle.Text, out int number)) || number <= 0)
            {
                MessageBox.Show("Ingrese un número de calle válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNroCalle.Focus();
                return false;
            }
            if (TxtAltura.Text != "")
            {
                if (!(int.TryParse(TxtAltura.Text, out int altura)) || altura <= 0)
                {
                    MessageBox.Show("Ingrese una altura válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtAltura.Focus();
                    return false;
                }
            }
            if (TxtPeso.Text != "")
            {
                if (!(float.TryParse(TxtPeso.Text, out float peso)) || peso <= 0)
                {
                    MessageBox.Show("Ingrese un peso válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtPeso.Focus();
                    return false;
                }
            }
            if (((Provincia)CbProvincia.SelectedItem).Nombre == "Seleccionar")
            {
                MessageBox.Show("Ingrese una provincia válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtNroDocumento.Text = "";
            CbTipoDocumento.SelectedIndex = 0;
            dtpFechaNacimiento.Text = DateTime.Today.ToString();
            CbSexo.SelectedIndex = 0;
            TxtAltura.Text = "";
            TxtPeso.Text = "";
            TxtCodigoPostal.Text = "";
            TxtCalle.Text = "";
            TxtNroCalle.Text = "";
            CbProvincia.SelectedIndex = CbProvincia.Items.Count - 1;
            TxtTelefono.Text = "";
            TxtEmail.Text = "";
            TxtAntecedenteMedico.Text = "";
            CbObjetivo.SelectedIndex = 0;
            cantObj = 0;
            LBObjetivos.Items.Clear();
            DicObjetivos.Clear();
            BtnModificar.Enabled = false;
            BtnDarBaja.Enabled = false;
            BtnDarAlta.Visible = false;
            LblEstado.Visible = false;
        }

        private bool EsSocioValido()
        {
            var empleado = new Empleado();
            empleado.LegajoEmpleado = usuarioLogueado.LegajoEmpleado;
            int altura;
            float peso;
            int nroCalle;
            int.TryParse(TxtAltura.Text, out altura);
            float.TryParse(TxtPeso.Text, out peso);
            int.TryParse(TxtNroCalle.Text, out nroCalle);
            var socioIngresado = new Socio
            {
                NroDocumento = TxtNroDocumento.Text,
                TipoDocumento = (TipoDocumento)CbTipoDocumento.SelectedItem,
                Nombre = TxtNombre.Text,
                Apellido = TxtApellido.Text,
                FechaNacimiento = DateTime.Parse(dtpFechaNacimiento.Text),
                Sexo = (Sexo)CbSexo.SelectedItem,
                Altura = altura,
                Peso = peso,
                CodigoPostal = TxtCodigoPostal.Text,
                Calle = TxtCalle.Text,
                NroCalle = nroCalle,
                Ciudad = (Ciudad)CbCiudad.SelectedItem,
                Telefono = TxtTelefono.Text,
                Email = TxtEmail.Text,
                AntecedenteMedico = TxtAntecedenteMedico.Text,
                FechaAlta = DateTime.Today,
                Empleado = empleado,
            };
            socio = socioIngresado;
            return true;
        }

        private void RegistrarObjetivos()
        {
            foreach (var obj in DicObjetivos.Values)
            {
                socio.Objetivos.Add(obj);
                cantObj += 1;
            }
        }

        private void HabilitarBotones(Socio socio)
        {
            BtnModificar.Enabled = true;
            BtnDarBaja.Enabled = true;
            if (socio.Estado == false)
                BtnDarAlta.Visible = true;
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
        #endregion
    }
}