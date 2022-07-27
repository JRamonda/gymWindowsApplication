using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using PAV1_GYM.RepositoriosBD;


namespace PAV1_GYM.Estadisticas
{
    public partial class EstadisticaAsistencias : Form
    {
        private string alcance = "Todas las asistencias";
        public EstadisticaAsistencias()
        {
            InitializeComponent();
        }

        private void EstadisticaAsistencias_Load(object sender, EventArgs e)
        {
            this.RvAsistencias.RefreshReport();
            DtpFechaDesde.MinDate = DateTime.Parse("01/01/2022");
            DtpFechaDesde.MaxDate = DateTime.Today;
            DtpFechaHasta.MinDate = DateTime.Parse("01/01/2022");
            DtpFechaHasta.MaxDate = DateTime.Today;
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
            ReportDataSource ds = new ReportDataSource("DataSetEstadisticaAsistencias", tabla);
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
            alcance = "Las asistencias";
            var sentenciaSql = "";
            if (RbTodasAsistencias.Checked)
            {
                alcance = "Todas las asistencias";
            }
            if (RbAsistenciasConfirmadas.Checked)
            {
                sentenciaSql = $" AND hora_ingreso IS NOT NULL";
                alcance += " solo confirmadas";
            }
            if (ChFiltrarFecha.Checked)
            {
                var fechaDesde = DtpFechaDesde.Value.ToString("dd/MM/yyyy");
                var fechaHasta = DtpFechaHasta.Value.ToString("dd/MM/yyyy");
                sentenciaSql = $" AND asi.fecha >= CONVERT(VARCHAR(10), '{fechaDesde}', 103) AND asi.fecha <= CONVERT(VARCHAR(10), '{fechaHasta}', 103)";
                alcance += $" entre las fechas {fechaDesde} y {fechaHasta}";
            }
            CargarDatosAsistencias(sentenciaSql);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            DtpFechaDesde.Text = DateTime.Today.ToString();
            DtpFechaHasta.Text = DateTime.Today.ToString();
            RbAsistenciasConfirmadas.Checked = false;
            RbTodasAsistencias.Checked = false;
            ChFiltrarFecha.Checked = false;
            alcance = "Todas las asistencias";
            CargarDatosAsistencias("");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}