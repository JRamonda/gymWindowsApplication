using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_GYM.Entidades;
using PAV1_GYM.Servicios;

namespace PAV1_GYM.InterfacesDeUsuarios.Mantenimiento
{
    public partial class ConsultaCiudades : Form
    {
        private CiudadesServicio ciudadesServicio;
        private ProvinciasServicio provinciasServicio;
        private Ciudad ciudad;
        private string nombreCiudadBuscada;

        public ConsultaCiudades()
        {
            ciudadesServicio = new CiudadesServicio();
            provinciasServicio = new ProvinciasServicio();
            ciudad = new Ciudad();
            InitializeComponent();
        }

        #region CargarDatos

        private void ABMCiudad_Load(object sender, EventArgs e)
        {
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
            CargarProvincias(CbProvinciaListado);
            CargarProvincias(CbProvincia);
            Consultar();
        }

        public void CargarCiudad(Ciudad ciudad)
        {
            TxtNombreCiudad.Text = ciudad.Nombre;
            CbProvincia.SelectedValue = ciudad.Provincia.Id_Provincia;
        }

        private void CargarProvincias(ComboBox CbProvincia)
        {
            var provincias = provinciasServicio.GetProvincias();
            var provinciaDefault = new Provincia();
            provinciaDefault.Nombre = "Seleccionar";
            provincias.Add(provinciaDefault);
            var conector = new BindingSource();
            conector.DataSource = provincias;
            CbProvincia.DataSource = conector;
            CbProvincia.DisplayMember = "Nombre";
            CbProvincia.ValueMember = "Id_Provincia";
            CbProvincia.SelectedItem = provinciaDefault;
        }

        #endregion

        #region Clicks
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            LimpiarCampos();
            Consultar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Consultar();
                LimpiarCampos();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                int idCiudad = Convert.ToInt32(DgvCiudades.SelectedRows[0].Cells[0].Value);
                ciudadesServicio.EliminarCiudad(idCiudad);
                Consultar();
                LimpiarCampos();
                MessageBox.Show("La operación se realizó con éxito", "Información");
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


        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsCamposValidos())
                    return;
                if (!EsOperacionConfirmada())
                    return;
                if (!EsCiudadValida())
                    return;
                if (!ciudadesServicio.RegistrarCiudad(ciudad))
                {
                    MessageBox.Show("La ciudad ya se encuentra cargada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La ciudad se registró con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Consultar();
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
                if (!EsCiudadValida())
                    return;
                if (!ciudadesServicio.ModificarCiudad(ciudad, nombreCiudadBuscada))
                {
                    MessageBox.Show("Problema al modificar la ciudad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("La ciudad se modificó con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Consultar();
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

        private void Limpiar()
        {
            CbProvinciaListado.SelectedIndex = CbProvinciaListado.Items.Count - 1;
            TxtNombre.Text = "";
        }

        private void LimpiarCampos()
        {
            TxtNombreCiudad.Text = "";
            CbProvincia.SelectedIndex = CbProvincia.Items.Count - 1;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

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
            if (TxtNombreCiudad.Text.Equals(""))
            {
                MessageBox.Show("Hay campos sin rellenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (((Provincia)CbProvincia.SelectedItem).Nombre.Equals("Seleccionar"))
            {
                MessageBox.Show("Seleccione una provincia válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void Consultar()
        {
            var ciudad = new Ciudad();
            ciudad.Nombre = TxtNombre.Text;
            ciudad.Provincia = (Provincia)CbProvinciaListado.SelectedItem;
            var ciudades = ciudadesServicio.ObtenerCiudades(ciudad);
            CargarGrilla(ciudades);
        }

        private void CargarGrilla(List<Ciudad> ciudades)
        {
            DgvCiudades.Rows.Clear();
            foreach (Ciudad c in ciudades)
            {
                var fila = new string[] {
                c.Id_Ciudad.ToString(),
                c.Nombre,
                c.Provincia.Id_Provincia.ToString(),
                c.Provincia.Nombre
                };
                DgvCiudades.Rows.Add(fila);
            }
        }

        private void CargarCiudadBuscada()
        {
            try
            {
                nombreCiudadBuscada = Convert.ToString(DgvCiudades.SelectedRows[0].Cells["NombreCiudad"].Value);
                ciudad = ciudadesServicio.ObtenerCiudad(nombreCiudadBuscada);
                CargarCiudad(ciudad);
                HabilitarBotones();
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

        private bool EsCiudadValida()
        {
            var ciudadIngresada = new Ciudad
            {
                Nombre = TxtNombreCiudad.Text,
                Provincia = (Provincia)CbProvincia.SelectedItem
            };
            ciudad = ciudadIngresada;
            return true;
        }

        private void DgvCiudades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvCiudades.RowCount > 0)
            {
                CargarCiudadBuscada();
                HabilitarBotones();
            }
        }

        private void HabilitarBotones()
        {
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
        }
        #endregion
    }
}
