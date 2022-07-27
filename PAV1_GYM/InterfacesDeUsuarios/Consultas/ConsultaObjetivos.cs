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
    public partial class ConsultaObjetivos : Form
    {
        private ObjetivosServicio objetivosServicio;
        private Objetivo objetivo;
        public string nombreObjetivoBuscado;

        public ConsultaObjetivos()
        {
            objetivosServicio = new ObjetivosServicio();
            objetivo = new Objetivo();
            objetivosServicio = new ObjetivosServicio();
            InitializeComponent();
        }

        #region CargarDatos

        private void ConsultaObjetivos_Load(object sender, EventArgs e)
        {
            BtnModificar.Enabled = false;
            BtnEliminarObjetivo.Enabled = false;
            Consultar();
        }

        public void CargarObjetivo(Objetivo objetivo)
        {
            TxtNombreObjetivo.Text = objetivo.Nombre;
            TxtDescripcion.Text = objetivo.Descripcion;
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
                if (!EsObjetivoValido())
                    return;
                if (!objetivosServicio.RegistrarObjetivo(objetivo))
                {
                    MessageBox.Show("El objetivo ya se encuentra cargado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El objetivo se registró con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (!EsObjetivoValido())
                    return;
                if (!objetivosServicio.ModificarObjetivo(objetivo, nombreObjetivoBuscado))
                {
                    MessageBox.Show("Problema al modificar el objetivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("El objetivo se modificó con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnEliminarObjetivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                if (DgvObjetivos.SelectedRows.Count != 0)
                {
                    int idObjetivo = Convert.ToInt32(DgvObjetivos.SelectedRows[0].Cells[0].Value);
                    objetivosServicio.EliminarObjetivo(idObjetivo);
                    Consultar();
                    LimpiarCampos();
                    MessageBox.Show("La operación se realizó con éxito", "Información");
                }
                else
                    MessageBox.Show("Seleccione un Objetivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            LimpiarCampos();
            Consultar();
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
            TxtNombreLista.Text = "";
        }

        private void LimpiarCampos()
        {
            TxtNombreObjetivo.Text = "";
            TxtDescripcion.Text = "";
            BtnModificar.Enabled = false;
            BtnEliminarObjetivo.Enabled = false;
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
            var objetivo = new Objetivo();
            objetivo.Nombre = TxtNombreLista.Text;
            var objetivos = objetivosServicio.ObtenerObjetivos(objetivo);
            CargarGrilla(objetivos);
        }

        private void CargarGrilla(List<Objetivo> objetivos)
        {
            DgvObjetivos.Rows.Clear();
            foreach (Objetivo o in objetivos)
            {
                var fila = new string[] {
                o.Id_Objetivo.ToString(),
                o.Nombre,
                o.Descripcion };
                DgvObjetivos.Rows.Add(fila);
            }
        }

        private bool EsCamposValidos()
        {
            if (TxtNombreObjetivo.Text.Equals("") || TxtDescripcion.Text.Equals(""))
            {
                MessageBox.Show("Hay campos sin rellenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool EsObjetivoValido()
        {
            var objetivoIngresado = new Objetivo
            {
                Nombre = TxtNombreObjetivo.Text,
                Descripcion = TxtDescripcion.Text,
            };
            objetivo = objetivoIngresado;
            return true;
        }

        private void HabilitarBotones()
        {
            BtnModificar.Enabled = true;
            BtnEliminarObjetivo.Enabled = true;
        }

        private void CargarObjetivoBuscado()
        {
            try
            {
                var objetivoBuscado = new Objetivo();
                nombreObjetivoBuscado = Convert.ToString(DgvObjetivos.SelectedRows[0].Cells["Nombre"].Value);
                objetivoBuscado = objetivosServicio.ObtenerObjetivo(nombreObjetivoBuscado);
                if (objetivoBuscado == null)
                {
                    MessageBox.Show("El turno no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    objetivo = objetivoBuscado;
                    CargarObjetivo(objetivoBuscado);
                    HabilitarBotones();
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

        private void DgvObjetivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvObjetivos.RowCount > 0)
            {
                CargarObjetivoBuscado();
                HabilitarBotones();
            }
        }
        #endregion
    }
}