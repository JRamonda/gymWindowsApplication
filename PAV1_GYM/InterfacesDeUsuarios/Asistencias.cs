using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_GYM.Entidades;
using PAV1_GYM.Servicios;
using PAV1_GYM.Utils;

namespace PAV1_GYM.InterfacesDeUsuarios
{
    public partial class Asistencias : Form
    {
        private SociosServicio sociosServicio;
        private TurnosServicio turnosServicio;
        private ActividadesServicio actividadesServicio;
        private AsistenciasServicio asistenciasServicio;
        private AbrirForm abrirForm;

        public Asistencias()
        {
            sociosServicio = new SociosServicio();
            turnosServicio = new TurnosServicio();
            actividadesServicio = new ActividadesServicio();
            asistenciasServicio = new AsistenciasServicio();
            abrirForm = new AbrirForm();
            InitializeComponent();
        }

        #region CargarDatos

        private void Asistencias_Load(object sender, EventArgs e)
        {
            CargarTurnos();
            CargarActividades();
            CargarFecha();
            HabilitarComboBoxs(false);
            Consultar();
        }

        private void CargarTurnos()
        {
            var turnos = turnosServicio.GetTurnos();
            var turnoDefault = new Turno();
            turnoDefault.Nombre = "Seleccionar";
            turnos.Add(turnoDefault);
            var conector = new BindingSource();
            conector.DataSource = turnos;
            CbTurno.DataSource = conector;
            CbTurno.DisplayMember = "Nombre";
            CbTurno.ValueMember = "Id_Turno";
            CbTurno.SelectedItem = turnoDefault;
        }

        private void CargarActividades()
        {
            var actividades = actividadesServicio.GetActividades();
            var actividadDefault = new Actividad();
            actividadDefault.Nombre = "Seleccionar";
            actividades.Add(actividadDefault);
            var conector = new BindingSource();
            conector.DataSource = actividades;
            CbActividad.DataSource = conector;
            CbActividad.DisplayMember = "Nombre";
            CbActividad.ValueMember = "Id_Actividad";
            CbActividad.SelectedItem = actividadDefault;
        }

        private void CargarFecha()
        {
            CbFecha.Items.Add("Hoy");
            CbFecha.Items.Add("Historico");
            CbFecha.SelectedIndex = 0;
        }

        #endregion

        #region Clicks

        private void BtnCargarTurno_Click(object sender, EventArgs e)
        {
            if (!EsOperacionConfirmada())
                return;
            abrirForm.AbrirFormHijo(new Turnos(), PanelFormHijo);
            Consultar();
            Limpiar();
        }

        private void BtnConfirmarAsistencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                int nroSocio = Convert.ToInt32(DgvAsistencias.SelectedRows[0].Cells[0].Value);
                DateTime fecha = Convert.ToDateTime(DgvAsistencias.SelectedRows[0].Cells[4].Value);
                string turnoNombre = Convert.ToString(DgvAsistencias.SelectedRows[0].Cells[3].Value);
                var turnos = turnosServicio.GetTurnos();
                string dia = fecha.ToString("dddd", CultureInfo.CreateSpecificCulture("es-ES"));
                string diaSinAcentos = Regex.Replace(dia, @"[^a-zA-z0-9 ]+", "");
                int id_turno = 0;
                foreach (Turno turno in turnos)
                {
                    if (turno.Nombre == turnoNombre && turno.Dia.ToLower() == diaSinAcentos)
                    {
                        id_turno = turno.Id_Turno;
                    }
                }
                asistenciasServicio.ConfirmarAsistencia(nroSocio, id_turno);
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

        private void BtnMarcarEgreso_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                int nroSocio = Convert.ToInt32(DgvAsistencias.SelectedRows[0].Cells[0].Value);
                DateTime fecha = Convert.ToDateTime(DgvAsistencias.SelectedRows[0].Cells[4].Value);
                string turnoNombre = Convert.ToString(DgvAsistencias.SelectedRows[0].Cells[3].Value);
                var turnos = turnosServicio.GetTurnos();
                string dia = fecha.ToString("dddd", CultureInfo.CreateSpecificCulture("es-ES"));
                string diaSinAcentos = Regex.Replace(dia, @"[^a-zA-z0-9 ]+", "");
                int id_turno = 0;
                foreach (Turno turno in turnos)
                {
                    if (turno.Nombre == turnoNombre && turno.Dia.ToLower() == diaSinAcentos)
                    {
                        id_turno = turno.Id_Turno;
                    }
                }
                asistenciasServicio.MarcarEgreso(nroSocio, id_turno);
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

        private void BtnEliminarAsistencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                int nroSocio = Convert.ToInt32(DgvAsistencias.SelectedRows[0].Cells[0].Value);
                string turnoNombre = Convert.ToString(DgvAsistencias.SelectedRows[0].Cells[3].Value);
                var turnos = turnosServicio.GetTurnos();
                int id_turno = 0;
                foreach (Turno turno in turnos)
                {
                    if (turno.Nombre == turnoNombre)
                    {
                        id_turno = turno.Id_Turno;
                    }
                }
                asistenciasServicio.EliminarAsistencia(nroSocio, id_turno);
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

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Consultar();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Funciones

        private void Limpiar()
        {
            CbFecha.SelectedIndex = 0;
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            CkBFiltros.Checked = false;
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

        private void Consultar()
        {
            var socio = new Socio();
            socio.Nombre = TxtNombre.Text;
            socio.Apellido = TxtApellido.Text;
            var asis = new Asistencia();
            asis.Turno = (Turno)CbTurno.SelectedItem;
            asis.Actividad = (Actividad)CbActividad.SelectedItem;
            if (CbFecha.SelectedItem.ToString() == "Hoy")
                asis.Fecha = DateTime.Today;
            asis.Socio = socio;
            var asistencias = asistenciasServicio.ObtenerAsistencias(asis);
            CargarGrilla(asistencias);
        }

        private void CargarGrilla(List<Asistencia> asistencias)
        {
            DgvAsistencias.Rows.Clear();
            foreach (Asistencia a in asistencias)
            {
                string horaEgreso = "";
                if (a.Hora_Egreso != null)
                    horaEgreso = a.Hora_Egreso?.ToString("HH:mm");
                string horaIngreso = "";
                if (a.Hora_Ingreso != null)
                    horaIngreso = a.Hora_Ingreso?.ToString("HH:mm");
                var fila = new string[] {
                a.Socio.NroSocio.ToString(),
                $"{a.Socio.Nombre}, {a.Socio.Apellido}",
                a.Actividad.Nombre,
                a.Turno.Nombre,
                a.Fecha.ToString("dd/MM/yyyy"),
                horaIngreso,
                horaEgreso};
                DgvAsistencias.Rows.Add(fila);
            }
        }

        private void BotonesSeleccion(bool op)
        { 
            BtnConfirmarAsistencia.Enabled = op;
            BtnMarcarEgreso.Enabled = op;
            BtnEliminarAsistencia.Enabled = op;
        }

        private void DgvAsistencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvAsistencias.RowCount > 0)
            {
                if (Convert.ToDateTime(DgvAsistencias.SelectedRows[0].Cells[4].Value) == DateTime.Today)
                    BotonesSeleccion(true);
                else
                    BotonesSeleccion(false);
            }
        }

        private void CbFecha_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Consultar();
        }

        private void CbActividad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Consultar();
        }

        private void CbTurno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Consultar();
        }

        private void HabilitarComboBoxs(bool op)
        {
            CbActividad.Visible = op;
            CbTurno.Visible = op;
            LblActividad.Visible = op;
            LblTurno.Visible = op;
            CbTurno.SelectedIndex = CbTurno.Items.Count - 1;
            CbActividad.SelectedIndex = CbActividad.Items.Count - 1;
            Consultar();
        }

        private void CkBFiltros_CheckedChanged(object sender, EventArgs e)
        {
            if (CkBFiltros.Checked == true)
            {
                HabilitarComboBoxs(true);
            }
            else
            {
                HabilitarComboBoxs(false);
            }
        }
        #endregion
    }
}