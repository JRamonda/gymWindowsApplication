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
    public partial class ConsultaTurnos : Form
    {
        private TurnosServicio turnosServicio;
        private Turno turno;
        private string nombreTurnoBuscado;
        private string diaTurnoBuscado;

        public ConsultaTurnos()
        {
            turnosServicio = new TurnosServicio();
            turno = new Turno();
            InitializeComponent();
        }

        #region Cargar Datos

        private void ConsultaTurnos_Load(object sender, EventArgs e)
        {
            BtnModificar.Enabled = false;
            BtnEliminarTurno.Enabled = false;
            BtnDarBaja.Enabled = false;
            BtnDarAlta.Visible = false;
            LblEstadoBuscado.Visible = false;
            CargarEstados();
            CargarNombres();
            CargarDias();
            Consultar();
        }

        private void CargarEstados()
        {
            CbEstado.Items.Add("Activo");
            CbEstado.Items.Add("Inactivo");
            CbEstado.SelectedIndex = 0;
        }

        private void CargarNombres()
        {
            CbNombre.Items.Add("Mañana");
            CbNombre.Items.Add("Tarde");
            CbNombre.Items.Add("Noche");
            CbNombre.SelectedIndex = -1;
        }

        private void CargarDias()
        {
            CbDia.Items.Add("Lunes");
            CbDia.Items.Add("Martes");
            CbDia.Items.Add("Miercoles");
            CbDia.Items.Add("Jueves");
            CbDia.Items.Add("Viernes");
            CbDia.Items.Add("Sabado");
            CbDia.Items.Add("Domingo");
            CbDia.SelectedIndex = -1;
        }

        public void CargarTurno(Turno turno)
        {
            CbNombre.SelectedItem = turno.Nombre;
            TxtHoraInicio.Text = turno.Hora_Inicio.ToString("HH:mm");
            TxtHoraFin.Text = turno.Hora_Fin.ToString("HH:mm");
            CbDia.SelectedItem = turno.Dia;
            LblEstadoBuscado.Visible = true;
            if (turno.Estado == true)
                LblEstadoBuscado.Text = "Estado: Activo";
            else
                LblEstadoBuscado.Text = "Estado: Inactivo";
        }

        #endregion

        #region Clicks

        private void BtnEliminarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                if (DgvTurnos.SelectedRows.Count != 0)
                {
                    int nroTurno = Convert.ToInt32(DgvTurnos.SelectedRows[0].Cells[0].Value);
                    turnosServicio.EliminarTurno(nroTurno);
                    Consultar();
                    LimpiarCampos();
                    MessageBox.Show("La operación se realizó con éxito", "Información");
                }
                else
                    MessageBox.Show("Seleccione un turno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsCamposValidos())
                    return;
                if (!EsOperacionConfirmada())
                    return;
                if (!EsActividadValida())
                    return;
                if (!turnosServicio.RegistrarTurno(turno))
                {
                    MessageBox.Show("El turno ya se encuentra cargado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El turno se registró con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (!EsActividadValida())
                    return;
                if (!turnosServicio.ModificarTurno(turno, nombreTurnoBuscado, diaTurnoBuscado))
                {
                    MessageBox.Show("Problema al modificar el turno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("El turno se modificó con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnDarBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsCamposValidos())
                    return;
                if (!EsOperacionConfirmada())
                    return;
                if (!EsActividadValida())
                    return;
                if (turno != null)
                {
                    turno.Estado = false;
                    turnosServicio.ModificarEstadoTurno(turno);
                    MessageBox.Show("La operación se realizó con éxito", "Información");
                    Consultar();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Problema al dar de baja el turno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (!EsActividadValida())
                    return;
                if (turno != null)
                {
                    turno.Estado = true;
                    turnosServicio.ModificarEstadoTurno(turno);
                    MessageBox.Show("La operación se realizó con éxito", "Información");
                    Consultar();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Problema al dar de alta al turno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            CbEstado.SelectedIndex = 0;
        }

        private void LimpiarCampos()
        {
            CbNombre.SelectedIndex = -1;
            TxtHoraInicio.Text = "";
            TxtHoraFin.Text = "";
            CbDia.SelectedIndex = -1;
            BtnModificar.Enabled = false;
            BtnDarBaja.Enabled = false;
            BtnDarAlta.Visible = false;
            BtnEliminarTurno.Enabled = false;
            LblEstadoBuscado.Visible = false;
        }

        public void Consultar()
        {
            var turno = new Turno();
            turno.Nombre = TxtNombreLista.Text;
            if (CbEstado.SelectedItem.ToString() == "Activo")
                turno.Estado = true;
            if (CbEstado.SelectedItem.ToString() == "Inactivo")
                turno.Estado = false;
            var turnos = turnosServicio.Obtener(turno);
            CargarGrilla(turnos);
        }

        private void CargarGrilla(List<Turno> turnos)
        {
            DgvTurnos.Rows.Clear();
            var cont = 0;
            foreach (Turno t in turnos)
            {
                cont += 1;
                var descripcionEstado = t.Estado ? "Activo" : "Baja";
                var fila = new string[] {
                t.Id_Turno.ToString(),
                t.Nombre,
                t.Hora_Inicio.ToString("HH:mm"),
                t.Hora_Fin.ToString("HH:mm"),
                t.Dia,
                descripcionEstado};
                DgvTurnos.Rows.Add(fila);
            }
        }

        private void CargarTurnoBuscado()
        {
            try
            {
                var turnoBuscado = new Turno();
                nombreTurnoBuscado = Convert.ToString(DgvTurnos.SelectedRows[0].Cells["Nombre"].Value);
                diaTurnoBuscado = Convert.ToString(DgvTurnos.SelectedRows[0].Cells["Dia"].Value);
                turnoBuscado = turnosServicio.ObtenerTurno(nombreTurnoBuscado, diaTurnoBuscado);
                if (turnoBuscado == null)
                {
                    MessageBox.Show("El turno no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    turno = turnoBuscado;
                    CargarTurno(turnoBuscado);
                    HabilitarBotones(turnoBuscado);
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
            if (CbNombre.SelectedIndex == -1 || TxtHoraInicio.Text.Equals("") || TxtHoraFin.Text.Equals("") || CbDia.SelectedIndex == -1)
            {
                MessageBox.Show("Hay campos sin rellenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool EsActividadValida()
        {
            var turnoIngresado = new Turno
            {
                Nombre = CbNombre.SelectedItem.ToString(),
                Dia = CbDia.SelectedItem.ToString(),
                Hora_Inicio = DateTime.Parse(TxtHoraInicio.Text),
                Hora_Fin = DateTime.Parse(TxtHoraFin.Text),
            };
            turno = turnoIngresado;
            return true;
        }

        private void HabilitarBotones(Turno turno)
        {
            BtnModificar.Enabled = true;
            BtnDarBaja.Enabled = true;
            BtnEliminarTurno.Enabled = true;
            if (turno.Estado == false)
                BtnDarAlta.Visible = true;
        }

        private void DgvTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvTurnos.RowCount > 0)
            {
                CargarTurnoBuscado();
                HabilitarBotones(turno);
            }
        }

        #endregion
    }
}