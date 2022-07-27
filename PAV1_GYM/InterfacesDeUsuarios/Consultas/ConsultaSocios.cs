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
using PAV1_GYM.InterfacesDeUsuarios.Mantenimiento;
using PAV1_GYM.InterfacesDeUsuarios.Perfiles;
using PAV1_GYM.Utils;

namespace PAV1_GYM.InterfacesDeUsuarios.Consultas
{
    public partial class ConsultaSocios : Form
    {
        private SociosServicio sociosServicio;
        private TiposDocumentoServicio tiposDocumentoServicio;
        private AbrirForm abrirForm;

        public ConsultaSocios()
        {
            sociosServicio = new SociosServicio();
            tiposDocumentoServicio = new TiposDocumentoServicio();
            abrirForm = new AbrirForm();
            InitializeComponent();
        }

        #region CargarDatos

        private void ConsultaSocios_Load(object sender, EventArgs e)
        {
            CargarTiposDocumento();
            CargarEstados();
            Consultar();
        }

        private void CargarTiposDocumento()
        {
            var tiposDocumento = tiposDocumentoServicio.GetTiposDocumento();
            var tipoDocDefault = new TipoDocumento();
            tipoDocDefault.Nombre = "Seleccionar";
            tiposDocumento.Add(tipoDocDefault);
            var conector = new BindingSource();
            conector.DataSource = tiposDocumento;
            CbTipoDoc.DataSource = conector;
            CbTipoDoc.DisplayMember = "Nombre";
            CbTipoDoc.ValueMember = "Id_TipoDoc";
            CbTipoDoc.SelectedItem = tipoDocDefault;
        }

        private void CargarEstados()
        {
            CbEstado.Items.Add("Activo");
            CbEstado.Items.Add("Inactivo");
            CbEstado.SelectedIndex = 0;
        }
        #endregion

        #region Clicks
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Consultar();
        }

        private void BtnAgregarSocio_Click(object sender, EventArgs e)
        {
            if (!EsOperacionConfirmada())
                return;
            abrirForm.AbrirFormHijo(new ABMSocio(), PanelFormHijo);
            Consultar();
            Limpiar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Consultar();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVerSocio_Click(object sender, EventArgs e)
        {
            if (!EsOperacionConfirmada())
                return;
            if (DgvSocios.SelectedRows.Count == 1)
            {
                var perfilSocio = new PerfilSocio();
                perfilSocio.nroSocio = Convert.ToInt32(DgvSocios.SelectedRows[0].Cells["NroSocio"].Value);
                abrirForm.AbrirFormHijo(perfilSocio, PanelFormHijo);
                return;
            }
        }

        private void BtnEliminarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                if (DgvSocios.SelectedRows.Count != 0)
                {
                    int nroSocio = Convert.ToInt32(DgvSocios.SelectedRows[0].Cells[0].Value);
                    sociosServicio.EliminarSocio(nroSocio);
                    Consultar();
                    Limpiar();
                    MessageBox.Show("La operación se realizó con éxito", "Información");
                }
                else
                    MessageBox.Show("Seleccione un socio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BtnEditarSocio_Click(object sender, EventArgs e)
        {
            if (!EsOperacionConfirmada())
                return;
            if (DgvSocios.SelectedRows.Count == 1)
            {
                ABMSocio abmSocio = new ABMSocio();
                abmSocio.nroSocioBuscado = Convert.ToInt32(DgvSocios.SelectedRows[0].Cells["NroSocio"].Value);
                abrirForm.AbrirFormHijo(abmSocio, PanelFormHijo);
                Consultar();
                Limpiar();
                return;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Funciones
        private void Limpiar()
        {
            TxtNroDoc.Text = "";
            CbTipoDoc.SelectedIndex = CbTipoDoc.Items.Count - 1;
            CbEstado.SelectedIndex = 0;
            BotonesSeleccion(false);
        }

        private bool EsOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("Desea confirmar la operación", "Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }

        public void Consultar()
        {
            var socio = new Socio();
            socio.NroDocumento = TxtNroDoc.Text;
            socio.TipoDocumento = (TipoDocumento)CbTipoDoc.SelectedItem;
            if (CbEstado.SelectedItem.ToString() == "Activo")
                socio.Estado = true;
            if (CbEstado.SelectedItem.ToString() == "Inactivo")
                socio.Estado = false;
            var socios = sociosServicio.Obtener(socio);
            CargarGrilla(socios);
        }

        private void CargarGrilla(List<Socio> socios)
        {
            DgvSocios.Rows.Clear();
            foreach (Socio s in socios)
            {
                var descripcionEstado = s.Estado ? "Activo" : "Baja";
                string fechaBaja = "";
                if (s.FechaBaja != null)
                    fechaBaja = s.FechaBaja?.ToString("dd/MM/yyyy");
                string objetivos = "";
                for (int i = 0; i < s.Objetivos.Count; i++)
                {
                    if (i == 0)
                    {
                        objetivos += $"{ s.Objetivos[i].Nombre}";
                    }
                    else
                        objetivos += $", {s.Objetivos[i].Nombre}";
                }
                string nombreVendedor = $"{s.Empleado?.Nombre}, {s.Empleado?.Apellido}";
                if (s.Empleado.LegajoEmpleado == 1)
                    nombreVendedor = $"{s.Empleado?.Nombre}";
                string actividadesyplanes = "";
                for (int i = 0; i < s.Actividades.Count; i++)
                {
                    if (i == 0)
                        actividadesyplanes += $"{s.Actividades[i].Nombre}, {s.Planes[i].Nombre}";
                    else
                        actividadesyplanes += $" | {s.Actividades[i].Nombre}, {s.Planes[i].Nombre}";
                }
                var fila = new string[] { 
                s.NroSocio.ToString(),
                s.NroDocumento,
                s.TipoDocumento?.Nombre,
                $"{s.Nombre}, {s.Apellido}",
                s.FechaNacimiento.ToString("dd/MM/yyyy"),
                s.Sexo?.Nombre,
                s.Altura.ToString(),
                s.Peso.ToString(),
                s.Calle,
                s.NroCalle.ToString(),
                $"{s.Ciudad?.Nombre}, {s.Ciudad.Provincia.Nombre}",
                s.CodigoPostal,
                s.Telefono,
                s.Email,
                s.FechaAlta.ToString("dd/MM/yyyy"),
                fechaBaja,
                s.AntecedenteMedico,
                objetivos,
                actividadesyplanes,
                nombreVendedor,
                descripcionEstado};
                DgvSocios.Rows.Add(fila);
            }
        }

        private void BotonesSeleccion(bool op)
        {
            BtnVerSocio.Enabled = op;
            BtnEditarSocio.Enabled = op;
            BtnEliminarSocio.Enabled = op;
        }

        private void DgvSocios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvSocios.RowCount > 0)
                BotonesSeleccion(true);
        }
        #endregion

    }
}