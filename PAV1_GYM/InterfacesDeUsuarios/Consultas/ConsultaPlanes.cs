using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PAV1_GYM.Servicios;
using PAV1_GYM.Entidades;

namespace PAV1_GYM.InterfacesDeUsuarios.Consultas
{
    public partial class ConsultaPlanes : Form
    {
        private Plan plan;
        private PlanesServicio planesServicio;
        public string nombrePlanBuscado;

        public ConsultaPlanes()
        {
            planesServicio = new PlanesServicio();
            plan = new Plan();
            InitializeComponent();
        }

        #region CargarDatos

        private void ConsultaPlanes_Load(object sender, EventArgs e)
        {
            BtnModificar.Enabled = false;
            BtnEliminarPlan.Enabled = false;
            BtnDarBaja.Enabled = false;
            BtnDarAlta.Visible = false;
            LblEstadoBuscado.Visible = false;
            CargarEstados();
            Consultar();
        }

        public void CargarPlan(Plan plan)
        {
            TxtNombrePlan.Text = plan.Nombre;
            TxtDescripcion.Text = plan.Descripcion;
            TxtPrecio.Text = plan.PrecioEstandar.ToString();
            LblEstado.Visible = true;
            if (plan.Estado == true)
                LblEstado.Text = "Estado: Activo";
            else
                LblEstado.Text = "Estado: Inactivo";
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

        private void BtnEliminarPlan_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                if (DgvPlanes.SelectedRows.Count != 0)
                {
                    int idPlan = Convert.ToInt32(DgvPlanes.SelectedRows[0].Cells[0].Value);
                    planesServicio.EliminarPlan(idPlan);
                    Consultar();
                    LimpiarCampos();
                    MessageBox.Show("La operación se realizó con éxito", "Información");
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

        private void BtnDarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsCamposValidos())
                    return;
                if (!EsOperacionConfirmada())
                    return;
                if (!EsPlanValido())
                    return;
                if (plan != null)
                {
                    plan.Estado = true;
                    planesServicio.ModificarEstadoPlan(plan);
                    MessageBox.Show("La operación se realizó con éxito", "Información");
                    Consultar();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Problema al dar de alta el plan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (!EsPlanValido())
                    return;
                if (plan != null)
                {
                    plan.Estado = false;
                    planesServicio.ModificarEstadoPlan(plan);
                    MessageBox.Show("La operación se realizó con éxito", "Información");
                    Consultar();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Problema al dar de baja el plan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (!EsPlanValido())
                    return;
                if (!planesServicio.ModificarPlan(plan, nombrePlanBuscado))
                {
                    MessageBox.Show("Problema al modificar el plan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("El plan se modificó con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsCamposValidos())
                    return;
                if (!EsOperacionConfirmada())
                    return;
                if (!EsPlanValido())
                    return;
                if (!planesServicio.RegistrarPlan(plan))
                {
                    MessageBox.Show("El plan ya se encuentra cargado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El plan se registró con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            var plan = new Plan();
            plan.Nombre = TxtNombre.Text;
            if (CbEstado.SelectedItem.ToString() == "Activo")
                plan.Estado = true;
            if (CbEstado.SelectedItem.ToString() == "Inactivo")
                plan.Estado = false;
            var planes = planesServicio.ObtenerPlanes(plan);
            CargarGrilla(planes);
        }

        private void CargarGrilla(List<Plan> planes)
        {
            DgvPlanes.Rows.Clear();
            foreach (Plan p in planes)
            {
                var descripcionEstado = p.Estado ? "Activo" : "Baja";
                var fila = new string[] {
                p.Id_Plan.ToString(),
                p.Nombre,
                p.Descripcion,
                p.PrecioEstandar.ToString(),
                p.FechaInicioPlan.ToString("d"),
                descripcionEstado};
                DgvPlanes.Rows.Add(fila);
            }
        }

        private void CargarPlanBuscado()
        {
            try
            {
                nombrePlanBuscado = Convert.ToString(DgvPlanes.SelectedRows[0].Cells["Nombre"].Value);
                plan = planesServicio.ObtenerPlan(nombrePlanBuscado);
                CargarPlan(plan);
                HabilitarBotones(plan);
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

        private void Limpiar()
        {
            TxtNombre.Text = "";
            CbEstado.SelectedIndex = 0;
        }

        private void LimpiarCampos()
        {
            TxtNombrePlan.Text = "";
            TxtDescripcion.Text = "";
            TxtPrecio.Text = "";
            BtnModificar.Enabled = false;
            BtnDarBaja.Enabled = false;
            BtnDarAlta.Visible = false;
            BtnEliminarPlan.Enabled = false;
            LblEstado.Visible = false;
        }

        private bool EsCamposValidos()
        {
            if (TxtNombrePlan.Text.Equals("") || TxtPrecio.Text.Equals(""))
            {
                MessageBox.Show("Hay campos sin rellenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!(float.TryParse(TxtPrecio.Text, out float number) && number > 0))
            {
                MessageBox.Show("Ingrese un precio válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool EsPlanValido()
        {
            var planIngresado = new Plan
            {
                Nombre = TxtNombrePlan.Text,
                Descripcion = TxtDescripcion.Text,
                PrecioEstandar = float.Parse(TxtPrecio.Text),
                FechaInicioPlan = DateTime.Today
            };
            plan = planIngresado;
            return true;
        }

        private void HabilitarBotones(Plan plan)
        {
            BtnModificar.Enabled = true;
            BtnDarBaja.Enabled = true;
            BtnEliminarPlan.Enabled = true;
            if (plan.Estado == false)
                BtnDarAlta.Visible = true;
        }

        private void DgvPlanes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvPlanes.RowCount > 0)
            {
                CargarPlanBuscado();
                HabilitarBotones(plan);
            }
        }
        #endregion
    }
}
