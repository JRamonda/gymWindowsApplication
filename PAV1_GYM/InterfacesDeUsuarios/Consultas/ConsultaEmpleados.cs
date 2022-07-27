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
    public partial class ConsultaEmpleados : Form
    {
        private EmpleadosServicio empleadosServicio;
        private TiposDocumentoServicio tiposDocumentoServicio;
        private AbrirForm abrirForm;

        public ConsultaEmpleados()
        {
            empleadosServicio = new EmpleadosServicio();
            tiposDocumentoServicio = new TiposDocumentoServicio();
            abrirForm = new AbrirForm();
            InitializeComponent();
        }

        #region CargarDatos

        private void ConsultaEmpleados_Load(object sender, EventArgs e)
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

        private void BtnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            if (!EsOperacionConfirmada())
                return;
            abrirForm.AbrirFormHijo(new ABMEmpleado(), PanelFormHijo);
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

        private void BtnVerEmpleado_Click(object sender, EventArgs e)
        {
            if (!EsOperacionConfirmada())
                return;
            if (DgvEmpleados.SelectedRows.Count == 1)
            {
                var perfilEmpleado = new PerfilEmpleado();
                perfilEmpleado.legajo = Convert.ToInt32(DgvEmpleados.SelectedRows[0].Cells["LegajoEmpleado"].Value);
                abrirForm.AbrirFormHijo(perfilEmpleado, PanelFormHijo);
                return;
            }
        }

        private void BtnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                int legajoEmpleado = Convert.ToInt32(DgvEmpleados.SelectedRows[0].Cells[0].Value);
                empleadosServicio.EliminarEmpleado(legajoEmpleado);
                Consultar();
                Limpiar();
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

        private void BtnEditarEmpleado_Click(object sender, EventArgs e)
        {
            if (!EsOperacionConfirmada())
                return;
            if (DgvEmpleados.SelectedRows.Count == 1)
            {
                ABMEmpleado abmEmpleado = new ABMEmpleado();
                abmEmpleado.legajoEmpleadoBuscado = Convert.ToInt32(DgvEmpleados.SelectedRows[0].Cells["LegajoEmpleado"].Value);
                abrirForm.AbrirFormHijo(abmEmpleado, PanelFormHijo);
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
            var empleado = new Empleado();
            empleado.NroDocumento = TxtNroDoc.Text;
            empleado.TipoDocumento = (TipoDocumento)CbTipoDoc.SelectedItem;
            if (CbEstado.SelectedItem.ToString() == "Activo")
                empleado.Estado = true;
            if (CbEstado.SelectedItem.ToString() == "Inactivo")
                empleado.Estado = false;
            var empleados = empleadosServicio.Obtener(empleado);
            CargarGrilla(empleados);
        }

        private void CargarGrilla(List<Empleado> empleados)
        {
            DgvEmpleados.Rows.Clear();
            foreach (var e in empleados)
            {
                string actividadesYturnos = "";
                int contAcYtur = 0;
                foreach (ActividadXTurno ax in e.ActividadesXTurnos)
                {
                    if (contAcYtur == 0)
                    {
                        actividadesYturnos += $"{ax.Actividad.Nombre}, {ax.Turno.Nombre}";
                        contAcYtur += 1;
                    }
                    else
                        actividadesYturnos += $" | {ax.Actividad.Nombre}, {ax.Turno.Nombre}";
                }
                var descripcionEstado = e.Estado ? "Activo" : "Baja";
                string fechaBaja = "";
                if (e.FechaBaja != null)
                    fechaBaja = e.FechaBaja?.ToString("dd/MM/yyyy");
                var fila = new string[] {
                    e.LegajoEmpleado.ToString(),
                    e.Perfil?.Nombre,
                    e.NroDocumento,
                    e.TipoDocumento?.Nombre,
                    $"{e.Nombre}, {e.Apellido}",
                    e.FechaNacimiento.ToString("dd/MM/yyyy"),
                    e.Sexo?.Nombre,
                    e.Calle,
                    e.NroCalle.ToString(),
                    $"{e.Ciudad?.Nombre}, {e.Ciudad.Provincia.Nombre}",
                    e.CodigoPostal,
                    e.Telefono,
                    e.Email,
                    e.FechaIngreso.ToString("dd/MM/yyyy"),
                    fechaBaja,
                    actividadesYturnos,
                    descripcionEstado
                };
                DgvEmpleados.Rows.Add(fila);
            }
        }

        private void DgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvEmpleados.RowCount > 0)
                BotonesSeleccion(true);
        }

        private void BotonesSeleccion(bool op)
        {
            BtnVerEmpleado.Enabled = op;
            BtnEditarEmpleado.Enabled = op;
            BtnEliminarEmpleado.Enabled = op;
        }
        #endregion
    }
}