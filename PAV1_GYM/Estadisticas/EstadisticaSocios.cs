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
    public partial class EstadisticaSocios : Form
    {
        string alcance = "Todos los Socios ingresados en el Sistema";
        public EstadisticaSocios()
        {
            InitializeComponent();
        }

        private void EstadisticaSocios_Load(object sender, EventArgs e)
        {
            this.RvSocios.RefreshReport();
            this.RvDetalle.RefreshReport();
            DtpFechaDesde.MinDate = DateTime.Parse("01/01/2022");
            DtpFechaDesde.MaxDate = DateTime.Today;
            DtpFechaHasta.MinDate = DateTime.Parse("01/01/2022");
            DtpFechaHasta.MaxDate = DateTime.Today;
            DtpFechaDesdeDS.MinDate = DateTime.Parse("01/01/2022");
            DtpFechaDesdeDS.MaxDate = DateTime.Today;
            DtpFechaHastaDS.MinDate = DateTime.Parse("01/01/2022");
            DtpFechaHastaDS.MaxDate = DateTime.Today;
            DtpFechaDesdeDS.Enabled = false;
            DtpFechaHastaDS.Enabled = false;
        }

        private void CargarDatosSocio(string sentencia)
        {
            var sentenciaSql = "SELECT s.nroSocio, CONCAT(s.nombre,' ', s.apellido) nombre, s.nroDoc, td.nombre as tipoDoc, se.nombre as sexo, " +
                "CONCAT(c.nombre, ', ', p.nombre) ciudad, s.fechaAlta, s.fechaBaja, s.estado " +
                "FROM Socios s JOIN Tipos_Documentos td ON s.id_tipoDoc = td.id_tipoDoc  JOIN Sexos se ON s.id_sexo = se.id_sexo JOIN Ciudades c ON s.id_ciudad = c.id_ciudad LEFT JOIN Provincias p ON c.id_provincia = p.id_provincia " +
                "JOIN Empleados e ON s.legajoEmpleado = e.legajoEmpleado ";
            sentenciaSql += sentencia;
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            ReportDataSource ds = new ReportDataSource("EstadisticaSocios", tabla);
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("PR01", alcance);
            RvSocios.LocalReport.SetParameters(parametros);
            RvSocios.LocalReport.DataSources.Clear();
            RvSocios.LocalReport.DataSources.Add(ds);
            RvSocios.LocalReport.Refresh();
            this.RvSocios.RefreshReport();
        }

        private void RvSocios_Load(object sender, EventArgs e)
        {
            CargarDatosSocio("");
        }

        private void BtnBuscarSocios_Click(object sender, EventArgs e)
        {
            var fechaDesde = DtpFechaDesde.Value.ToString("dd/MM/yyyy");
            var fechaHasta = DtpFechaHasta.Value.ToString("dd/MM/yyyy");
            var sentenciaSql = $" WHERE s.fechaAlta >= CONVERT(VARCHAR(10), '{fechaDesde}', 103) AND s.fechaAlta <= CONVERT(VARCHAR(10), '{fechaHasta}', 103)";
            alcance = $"Los Socios dados de Alta en el periodo de Tiempo: '{fechaDesde}' y '{fechaHasta}'";
            CargarDatosSocio(sentenciaSql);
        }

        private void RvDetalle_Load(object sender, EventArgs e)
        {
            CargarDatosDetalleSocio("");
        }

        private void CargarDatosDetalleSocio(string sentencia)
        {
            var sentenciaSql = "SELECT s.nroSocio, CONCAT(s.nombre, ' ', s.apellido) nombre, s.nroDoc, td.nombre as tipoDoc, se.nombre as sexo, " +
                "CONCAT(c.nombre, ', ', p.nombre) ciudad, s.fechaAlta, s.fechaBaja, s.estado, CONCAT(a.nombre, ' ', pl.nombre) actividadyplan, a.nombre as NombreActividad, pl.nombre as NombrePlan " +
                "FROM Socios s JOIN Tipos_Documentos td ON s.id_tipoDoc = td.id_tipoDoc  JOIN Sexos se ON s.id_sexo = se.id_sexo JOIN Ciudades c ON s.id_ciudad = c.id_ciudad LEFT JOIN Provincias p ON c.id_provincia = p.id_provincia " +
                "JOIN Empleados e ON s.legajoEmpleado = e.legajoEmpleado RIGHT JOIN Actividades_Y_Planes_X_Socios aps ON aps.nroSocio = s.nroSocio " +
                "LEFT JOIN Actividades a ON aps.id_actividad = a.id_actividad LEFT JOIN Planes pl ON aps.id_plan = pl.id_plan " +
                "WHERE s.nroSocio LIKE '%%' ";
            sentenciaSql += sentencia;
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            ReportDataSource ds = new ReportDataSource("EstadisticaDetalle", tabla);
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("PR01", alcance);
            RvDetalle.LocalReport.SetParameters(parametros);
            RvDetalle.LocalReport.DataSources.Clear();
            RvDetalle.LocalReport.DataSources.Add(ds);
            RvDetalle.LocalReport.Refresh();
            this.RvDetalle.RefreshReport();
        }

        private void BtnBuscarDetalle_Click(object sender, EventArgs e)
        {
            var sentenciaSql = "";
            alcance = "Socios";

            if (RbMasc.Checked)
            {
                sentenciaSql += " AND s.id_sexo = 1";
                alcance += " masculinos";
            }
            if (RbFem.Checked)
            {
                sentenciaSql += " AND s.id_sexo = 2";
                alcance += " femeninos";
            }
            if (RbActivo.Checked)
            {
                sentenciaSql += " AND s.estado = 'S'";
                alcance += " activos";
            }
            if (RbBaja.Checked)
            {
                sentenciaSql += " AND s.estado = 'N'";
                alcance += " dados de baja";
            }
            if (ChFiltrarFecha.Checked)
            {
                var fechaDesde = DtpFechaDesdeDS.Value.ToString("dd/MM/yyyy");
                var fechaHasta = DtpFechaHastaDS.Value.ToString("dd/MM/yyyy");
                sentenciaSql += $" AND s.fechaAlta >= CONVERT(VARCHAR(10), '{fechaDesde}', 103) AND s.fechaAlta <= CONVERT(VARCHAR(10), '{fechaHasta}', 103)";
                alcance += $" dados de alta en el periodo de tiempo: '{fechaDesde}' y '{fechaHasta}'";
            }
            if (RbTodos.Checked)
            {
                sentenciaSql = "";
                alcance = "Todos los Socios ingresados en el Sistema";
            }
            CargarDatosDetalleSocio(sentenciaSql);   
        }

        private void Limpiar()
        {
            alcance = "Todos los Socios ingresados en el Sistema";
            DtpFechaDesde.Text = DateTime.Today.ToString();
            DtpFechaHasta.Text = DateTime.Today.ToString();
            CargarDatosSocio("");
        }

        private void LimpiarDS()
        {
            DtpFechaDesdeDS.Text = DateTime.Today.ToString();
            DtpFechaHastaDS.Text = DateTime.Today.ToString();
            RbTodos.Checked = false;
            RbActivo.Checked = false;
            RbBaja.Checked = false;
            RbFem.Checked = false;
            RbMasc.Checked = false;
            ChFiltrarFecha.Checked = false;
            alcance = "Todos los Socios ingresados en el Sistema";
            CargarDatosDetalleSocio("");
        }

        private void ChFiltrarFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (ChFiltrarFecha.Checked)
            {
                DtpFechaDesdeDS.Enabled = true;
                DtpFechaHastaDS.Enabled = true;
            }
            else
            {
                DtpFechaDesdeDS.Enabled = false;
                DtpFechaHastaDS.Enabled = false;
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnLimpiarDS_Click(object sender, EventArgs e)
        {
            LimpiarDS();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}