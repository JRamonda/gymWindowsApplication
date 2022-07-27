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
using Microsoft.Reporting.WinForms;
using PAV1_GYM.RepositoriosBD;
using PAV1_GYM.Entidades;

namespace PAV1_GYM.Reportes
{
    public partial class ReporteAsistencias : Form
    {
        private ActividadesServicio actividadesServicio;
        private TurnosServicio turnosServicio;
        private string alcance = "Todas las asistencias";

        public ReporteAsistencias()
        {
            actividadesServicio = new ActividadesServicio();
            turnosServicio = new TurnosServicio();
            InitializeComponent();
        }

        private void ReporteAsistencias_Load(object sender, EventArgs e)
        {
            this.RvAsistencias.RefreshReport();
            DtpFechaDesde.MinDate = DateTime.Parse("01/01/2022");
            DtpFechaDesde.MaxDate = DateTime.Today;
            DtpFechaHasta.MinDate = DateTime.Parse("01/01/2022");
            DtpFechaHasta.MaxDate = DateTime.Today;
            CargarActividades();
            CargarTurnos();
            HabilitarFechas(false);
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
        private void CargarTurnos()
        {
            var tablaTurnos = turnosServicio.GetTurnosUnicos();
            if (tablaTurnos.Rows.Count > 0)
            {
                foreach (DataRow row in tablaTurnos.Rows)
                {
                    CbTurno.Items.Add(row["nombre"].ToString());
                }
            }
            CbTurno.Items.Add("Seleccionar");
            CbTurno.SelectedItem = "Seleccionar";
        }

        private void CargarDatosAsistencias(string sentencia)
        {
            var sentenciaSql = "SELECT CONCAT(s.nombre, ' ', s.apellido) nombreSocio, a.nombre as NombreActividad, t.nombre as NombreTurno, left(asi.hora_ingreso, 5) " +
                "as hora_ingreso, left(asi.hora_egreso, 5) as hora_egreso, asi.fecha, DATEDIFF(year, s.fechaNacimiento, GETDATE()) as edad, se.nombre as NombreSexo, " +
                "count(asi.hora_ingreso) as cantidadIngreso " +
                "FROM Asistencias asi LEFT JOIN Actividades a ON asi.id_actividad = a.id_actividad LEFT JOIN Turnos t ON asi.id_turno = t.id_turno LEFT JOIN Socios s " +
                "ON asi.nroSocio = s.nroSocio LEFT JOIN Tipos_Documentos td ON s.id_tipoDoc = td.id_tipoDoc LEFT JOIN Sexos se ON s.id_sexo = se.id_sexo " +
                "WHERE asi.nroSocio LIKE '%%'";
            sentenciaSql += sentencia;
            sentenciaSql += " GROUP BY s.nombre, s.apellido, a.nombre, t.nombre, asi.hora_ingreso, asi.hora_egreso, asi.fecha, s.fechaNacimiento, se.nombre";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            ReportDataSource ds = new ReportDataSource("DataSetReporteAsistencias", tabla);
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("PR01", alcance);
            RvAsistencias.LocalReport.SetParameters(parametros);
            RvAsistencias.LocalReport.DataSources.Clear();
            RvAsistencias.LocalReport.DataSources.Add(ds);
            RvAsistencias.LocalReport.Refresh();
            this.RvAsistencias.RefreshReport();
        }

        private void RvAsistencias_Load(object sender, EventArgs e)
        {
            CargarDatosAsistencias("");
        }

        private void BtnBuscarAsistencia_Click(object sender, EventArgs e)
        {
            var sentenciaSql = "";
            alcance = "Las asistencias";
            if (RbMasc.Checked)
            {
                sentenciaSql += " AND se.id_sexo = 1";
                alcance += " de socios masculinos";
            }
            if (RbFem.Checked)
            {
                sentenciaSql += " AND se.id_sexo = 2";
                alcance += " de socios femeninos";
            }
            if (((Actividad)CbActividad.SelectedItem).Nombre != "Seleccionar")
            {
                sentenciaSql += $" AND a.id_actividad = {((Actividad)CbActividad.SelectedItem).Id_Actividad}";
                alcance += $" de actividad {((Actividad)CbActividad.SelectedItem).Nombre}";
            }
            if (CbTurno.SelectedItem.ToString() != "Seleccionar")
            {
                sentenciaSql += $" AND t.nombre = '{CbTurno.SelectedItem.ToString()}'";
                alcance += $" en el turno {CbTurno.SelectedItem.ToString()}";
            }
            if (ChFiltrarFecha.Checked)
            {
                var fechaDesde = DtpFechaDesde.Value.ToString("dd/MM/yyyy");
                var fechaHasta = DtpFechaHasta.Value.ToString("dd/MM/yyyy");
                sentenciaSql += $" AND asi.fecha >= CONVERT(VARCHAR(10), '{fechaDesde}', 103) AND asi.fecha <= CONVERT(VARCHAR(10), '{fechaHasta}', 103)";
                alcance += $" entre las fechas {fechaDesde} y {fechaHasta}";
            }
            CargarDatosAsistencias(sentenciaSql);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            DtpFechaDesde.Text = DateTime.Today.ToString();
            DtpFechaHasta.Text = DateTime.Today.ToString();
            ChFiltrarFecha.Checked = false;
            RbMasc.Checked = false;
            RbFem.Checked = false;
            CbActividad.SelectedIndex = CbActividad.Items.Count - 1;
            CbTurno.SelectedIndex = CbTurno.Items.Count - 1;
            alcance = "Todas las asistencias";
            CargarDatosAsistencias("");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HabilitarFechas(bool op)
        {
            DtpFechaDesde.Enabled = op;
            DtpFechaHasta.Enabled = op;
        }

        private void ChFiltrarFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (ChFiltrarFecha.Checked)
            {
                HabilitarFechas(true);
            }
            else
            {
                HabilitarFechas(false);
            }
        }
    }
}