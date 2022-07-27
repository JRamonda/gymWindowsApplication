using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_GYM.RepositoriosBD;
using Microsoft.Reporting.WinForms;

namespace PAV1_GYM.Estadisticas
{
    public partial class EstadisticaTurnos : Form
    {
        private string alcance = "Todos los turnos";
        public EstadisticaTurnos()
        {
            InitializeComponent();
        }

        private void EstadisticaTurnos_Load(object sender, EventArgs e)
        {
            this.RvTurnos.RefreshReport();
            DtpFechaDesde.MinDate = DateTime.Parse("01/01/2022");
            DtpFechaDesde.MaxDate = DateTime.Today;
            DtpFechaHasta.MinDate = DateTime.Parse("01/01/2022");
            DtpFechaHasta.MaxDate = DateTime.Today;
            DtpFechaDesde.Enabled = false;
            DtpFechaHasta.Enabled = false;
            TxtEdadInicial.Enabled = false;
            TxtEdadFinal.Enabled = false;
        }

        private void CargarDatosTurnos(string sentencia)
        {
            var sentenciaSql = "SELECT DISTINCT t.nombre, count(asi.id_turno) AS cantidadSocios FROM Asistencias asi JOIN Turnos t ON asi.id_turno = t.id_turno JOIN Socios s ON asi.nroSocio = s.nroSocio " +
                "WHERE t.nombre LIKE '%%' ";
            sentenciaSql += sentencia;
            sentenciaSql += " GROUP BY t.nombre";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            ReportDataSource ds = new ReportDataSource("EstadisticaTurnos", tabla);
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("PR01", alcance);
            RvTurnos.LocalReport.SetParameters(parametros);
            RvTurnos.LocalReport.DataSources.Clear();
            RvTurnos.LocalReport.DataSources.Add(ds);
            this.RvTurnos.RefreshReport();
        }

        private void RvTurnos_Load(object sender, EventArgs e)
        {
            CargarDatosTurnos("");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var fechaDesde = DtpFechaDesde.Value.ToString("dd/MM/yyyy");
            var fechaHasta = DtpFechaHasta.Value.ToString("dd/MM/yyyy");
            var sentenciaSql = "";
            alcance = "Los turnos";
            if (ChFiltrarFecha.Checked)
            {
                sentenciaSql += $" AND asi.fecha >= CONVERT(VARCHAR(10), '{fechaDesde}', 103) AND asi.fecha <= CONVERT(VARCHAR(10), '{fechaHasta}', 103)";
                alcance += $" entre las fechas {fechaDesde} y {fechaHasta}";
            }
            if (RbMasc.Checked)
            {
                sentenciaSql += " AND s.id_sexo = 1";
                alcance += $" de socios masculinos";
            }
            if (RbFem.Checked)
            {
                sentenciaSql += " AND s.id_sexo = 2";
                alcance += $" de socios femeninos";
            }
            if (CkEdad.Checked)
            {
                int edadInicial;
                int edadFinal;
                if (int.TryParse(TxtEdadInicial.Text, out edadInicial) && int.TryParse(TxtEdadFinal.Text, out edadFinal))
                {
                    sentenciaSql += $" AND DATEDIFF(year, s.fechaNacimiento, GETDATE()) >= {edadInicial} AND DATEDIFF(year, s.fechaNacimiento, GETDATE()) <= {edadFinal}";
                    alcance += $" entre las edades de {edadInicial} y {edadFinal}";
                }
                else
                    MessageBox.Show("Ingrese un intervalo de edades válidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarDatosTurnos(sentenciaSql);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            DtpFechaDesde.Text = DateTime.Today.ToString();
            DtpFechaHasta.Text = DateTime.Today.ToString();
            ChFiltrarFecha.Checked = false;
            RbMasc.Checked = false;
            RbFem.Checked = false;
            CkEdad.Checked = false;
            TxtEdadFinal.Text = "";
            TxtEdadInicial.Text = "";
            alcance = "Todos los turnos";
            CargarDatosTurnos("");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChFiltrarFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (ChFiltrarFecha.Checked)
            {
                DtpFechaDesde.Enabled = true;
                DtpFechaHasta.Enabled = true;
            }
            else
            {
                DtpFechaDesde.Enabled = false;
                DtpFechaHasta.Enabled = false;
            }
        }

        private void CkEdad_CheckedChanged(object sender, EventArgs e)
        {
            if (CkEdad.Checked)
            {
                TxtEdadInicial.Enabled = true;
                TxtEdadFinal.Enabled = true;
            }
            else
            {
                TxtEdadInicial.Enabled = false;
                TxtEdadFinal.Enabled = false;
            }
        }
    }
}
