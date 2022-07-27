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

namespace PAV1_GYM.Reportes
{
    public partial class ReportePlanes : Form
    {
        private string alcance = "Todos los planes";
        public ReportePlanes()
        {
            InitializeComponent();
        }

        private void ReportePlanes_Load(object sender, EventArgs e)
        {
            this.RvPlanes.RefreshReport();
            DtpFechaDesde.MinDate = DateTime.Parse("01/01/2022");
            DtpFechaDesde.MaxDate = DateTime.Today;
            DtpFechaHasta.MinDate = DateTime.Parse("01/01/2022");
            DtpFechaHasta.MaxDate = DateTime.Today;
            DtpFechaDesde.Enabled = false;
            DtpFechaHasta.Enabled = false;
        }

        private void RvPlanes_Load(object sender, EventArgs e)
        {
            CargarDatosPlan("");
        }

        private void BtnBuscarPlan_Click(object sender, EventArgs e)
        {
            var fechaDesde = DtpFechaDesde.Value.ToString("dd/MM/yyyy");
            var fechaHasta = DtpFechaHasta.Value.ToString("dd/MM/yyyy");
            var sentenciaSql = "";
            alcance = "Los planes";
            if (ChFiltrarFecha.Checked)
            {
                sentenciaSql += $" WHERE df.fechaDevReal >= CONVERT(VARCHAR(10), '{fechaDesde}', 103) AND df.fechaDevReal <= CONVERT(VARCHAR(10), '{fechaHasta}', 103)";
                alcance += $" entre las fechas {fechaDesde} y {fechaHasta}";
            }
            sentenciaSql += " GROUP BY p.id_plan, p.nombre, p.descripcion, p.precioEstandar, p.fechaInicioPlan, p.estado";
            if (RbOrdenarCantidad.Checked)
            {
                sentenciaSql += " ORDER BY CantidadContratada DESC";
                alcance += " ordenados por la cantidad contratada";
            }
            if (RbOrdenarPrecio.Checked)
            {
                sentenciaSql += " ORDER BY p.precioEstandar DESC";
                alcance += " ordenados por el precio de mayor a menor";
            }
            CargarDatosPlan(sentenciaSql);
        }

        private void CargarDatosPlan(string sentencia)
        {
            var sentenciaSql = "SELECT p.*, count(df.id_plan) AS CantidadContratada FROM Detalles_Facturas df RIGHT JOIN Planes p ON df.id_plan = p.id_plan ";
            sentenciaSql += sentencia;
            if (sentencia == "")
            {
                sentenciaSql += " GROUP BY p.id_plan, p.nombre, p.descripcion, p.precioEstandar, p.fechaInicioPlan, p.estado";
            }
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            ReportDataSource ds = new ReportDataSource("DataSetPlanes", tabla);
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("PR01", alcance);
            RvPlanes.LocalReport.SetParameters(parametros);
            RvPlanes.LocalReport.DataSources.Clear();
            RvPlanes.LocalReport.DataSources.Add(ds);
            RvPlanes.LocalReport.Refresh();
            this.RvPlanes.RefreshReport();
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

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            DtpFechaDesde.Text = DateTime.Today.ToString();
            DtpFechaHasta.Text = DateTime.Today.ToString();
            ChFiltrarFecha.Checked = false;
            RbOrdenarCantidad.Checked = false;
            RbOrdenarPrecio.Checked = false;
            alcance = "Todos los planes";
            CargarDatosPlan("");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}