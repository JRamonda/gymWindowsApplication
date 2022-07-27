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
using PAV1_GYM.Entidades;
using PAV1_GYM.Servicios;

namespace PAV1_GYM.Reportes
{
    public partial class ReporteFacturas : Form
    {
        private ActividadesServicio actividadesServicio;
        private PlanesServicio planesServicio;
        private FacturasServicio facturasServicio;
        private string alcance = "Todas las facturas";
        private string alcanceDF = "Todos los detalles facturas";

        public ReporteFacturas()
        {
            actividadesServicio = new ActividadesServicio();
            planesServicio = new PlanesServicio();
            facturasServicio = new FacturasServicio();
            InitializeComponent();
        }

        private void ReporteFacturas_Load(object sender, EventArgs e)
        {
            this.RvFacturas.RefreshReport();
            this.RvDetalleFacturas.RefreshReport();
            DtpFechaDesde.MinDate = DateTime.Parse("01/01/2022");
            DtpFechaDesde.MaxDate = DateTime.Today;
            DtpFechaHasta.MinDate = DateTime.Parse("01/01/2022");
            DtpFechaHasta.MaxDate = DateTime.Today;
            DtpFechaDesdeDF.MinDate = DateTime.Parse("01/01/2022");
            DtpFechaDesdeDF.MaxDate = DateTime.Today;
            DtpFechaHastaDF.MinDate = DateTime.Parse("01/01/2022");
            DtpFechaHastaDF.MaxDate = DateTime.Today;
            CargarActividades();
            CargarPlanes();
            CargarNroFacturas();
            HabilitarFechas(false);
            HabilitarFechasDF(false);
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
        private void CargarPlanes()
        {
            var planes = planesServicio.GetPlanes();
            var planDefault = new Plan();
            planDefault.Nombre = "Seleccionar";
            planes.Add(planDefault);
            var conector = new BindingSource();
            conector.DataSource = planes;
            CbPlan.DataSource = conector;
            CbPlan.DisplayMember = "Nombre";
            CbPlan.ValueMember = "Id_Plan";
            CbPlan.SelectedItem = planDefault;
        }
        private void CargarNroFacturas()
        {
            var nroFacturas = facturasServicio.GetNroFacturas();
            foreach (int nro in nroFacturas)
            {
                CbNroFactura.Items.Add(nro);
            }
        }

        private void CargarDatosFactura(string sentencia)
        {
            var sentenciaSql = "SELECT f.nroFactura, CONCAT(s.nombre, ' ', s.apellido) nombreSocio, CONCAT(e.nombre, ' ', e.apellido) nombreEmpleado, " +
                "mp.nombre as nombrePago, CONVERT(VARCHAR(10), f.fecha, 103) as fecha, f.montoTotal, f.condicionCobro " +
                "FROM Facturas f LEFT JOIN Socios s ON f.nroSocio = s.nroSocio LEFT JOIN Empleados e ON f.legajoEmpleado = e.legajoEmpleado " +
                "LEFT JOIN Metodos_Pagos mp ON f.id_metodoPago = mp.id_metodoPago WHERE f.nroFactura LIKE '%%'";
            sentenciaSql += sentencia;
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            ReportDataSource ds = new ReportDataSource("DataSetReporteFactura", tabla);
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("PR01", alcance);
            RvFacturas.LocalReport.SetParameters(parametros);
            RvFacturas.LocalReport.DataSources.Clear();
            RvFacturas.LocalReport.DataSources.Add(ds);
            RvFacturas.LocalReport.Refresh();
            this.RvFacturas.RefreshReport();
        }

        private void CargarDatosDetalleFactura(string sentencia)
        {
            var sentenciaSql = "SELECT df.nroFactura, a.nombre as NombreActividad, p.nombre as NombrePlan, df.precioUnitario, df.promocion, CONVERT(VARCHAR(10), df.fechaDevReal, 103) as fecha " +
                "FROM Detalles_Facturas df LEFT JOIN Actividades a ON df.id_actividad = a.id_actividad LEFT JOIN Planes p ON df.id_plan = p.id_plan " +
                "WHERE nroFactura LIKE '%%'";
            sentenciaSql += sentencia;
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            ReportDataSource ds = new ReportDataSource("DataSetReporteDetalleFactura", tabla);
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("PR01", alcanceDF);
            RvDetalleFacturas.LocalReport.SetParameters(parametros);
            RvDetalleFacturas.LocalReport.DataSources.Clear();
            RvDetalleFacturas.LocalReport.DataSources.Add(ds);
            RvDetalleFacturas.LocalReport.Refresh();
            this.RvDetalleFacturas.RefreshReport();
        }

        private void RvFacturas_Load(object sender, EventArgs e)
        {
            CargarDatosFactura("");
        }

        private void RvDetalleFacturas_Load(object sender, EventArgs e)
        {
            CargarDatosDetalleFactura("");
        }

        private void BtnBuscarFacturacion_Click(object sender, EventArgs e)
        {
            var sentenciaSql = "";
            alcance = "Las facturas";
            if (ChFiltrarFecha.Checked)
            {
                var fechaDesde = DtpFechaDesde.Value.ToString("dd/MM/yyyy");
                var fechaHasta = DtpFechaHasta.Value.ToString("dd/MM/yyyy");
                sentenciaSql += $" AND CONVERT(VARCHAR(10), f.fecha, 103) >= CONVERT(VARCHAR(10), '{fechaDesde}', 103) AND CONVERT(VARCHAR(10), f.fecha, 103) <= CONVERT(VARCHAR(10), '{fechaHasta}', 103)";
                alcance += $" entre las fechas {fechaDesde} y {fechaHasta}";
            }
            if (ChOrdenarPrecio.Checked)
            {
                sentenciaSql += " ORDER BY f.montoTotal DESC";
                alcance += " ordenadas por el monto total";
            }
            CargarDatosFactura(sentenciaSql);
        }

        private void BtnBuscarDetalleFacturacion_Click(object sender, EventArgs e)
        {
            var sentenciaSql = "";
            alcanceDF = "Los detalles facturas";
            if (ChFiltrarFechaDF.Checked)
            {
                var fechaDesde = DtpFechaDesdeDF.Value.ToString("dd/MM/yyyy");
                var fechaHasta = DtpFechaHastaDF.Value.ToString("dd/MM/yyyy");
                sentenciaSql += $" AND df.fechaDevReal >= CONVERT(VARCHAR(10), '{fechaDesde}', 103) AND df.fechaDevReal <= CONVERT(VARCHAR(10), '{fechaHasta}', 103)";
                alcanceDF += $" entre las fechas {fechaDesde} y {fechaHasta}";
            }
            if (((Actividad)CbActividad.SelectedItem).Nombre != "Seleccionar")
            {
                sentenciaSql += $" AND a.id_actividad = {((Actividad)CbActividad.SelectedItem).Id_Actividad}";
                alcanceDF += $" de actividad {((Actividad)CbActividad.SelectedItem).Nombre}";
            }

            if (((Plan)CbPlan.SelectedItem).Nombre != "Seleccionar")
            {
                sentenciaSql += $" AND p.id_plan = {((Plan)CbPlan.SelectedItem).Id_Plan}";
                alcanceDF += $" con un {((Plan)CbPlan.SelectedItem).Nombre}";
            }
            if (CbNroFactura.SelectedItem != null)
            {
                sentenciaSql += $" AND df.nroFactura = {CbNroFactura.SelectedItem.ToString()}";
                alcanceDF += $" con numero de factura '{CbNroFactura.SelectedItem.ToString()}'";
            }
            if (ChOrdenarPrecioDF.Checked)
            {
                sentenciaSql += " ORDER BY df.precioUnitario DESC";
                alcanceDF += " ordenados por su precio";
            }
            CargarDatosDetalleFactura(sentenciaSql);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            DtpFechaDesde.Text = DateTime.Today.ToString();
            DtpFechaHasta.Text = DateTime.Today.ToString();
            ChFiltrarFecha.Checked = false;
            ChOrdenarPrecio.Checked = false;
            alcance = "Todas las facturas";
            CargarDatosFactura("");
        }

        private void BtnLimpiarDF_Click(object sender, EventArgs e)
        {
            DtpFechaDesdeDF.Text = DateTime.Today.ToString();
            DtpFechaHastaDF.Text = DateTime.Today.ToString();
            CbActividad.SelectedIndex = CbActividad.Items.Count - 1;
            CbPlan.SelectedIndex = CbPlan.Items.Count - 1;
            CbNroFactura.SelectedIndex = -1;
            ChFiltrarFechaDF.Checked = false;
            ChOrdenarPrecioDF.Checked = false;
            alcanceDF = "Todos los detalles facturas";
            CargarDatosDetalleFactura("");
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

        private void HabilitarFechasDF(bool op)
        {
            DtpFechaDesdeDF.Enabled = op;
            DtpFechaHastaDF.Enabled = op;
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

        private void ChFiltrarFechaDF_CheckedChanged(object sender, EventArgs e)
        {
            if (ChFiltrarFechaDF.Checked)
            {
                HabilitarFechasDF(true);
            }
            else
            {
                HabilitarFechasDF(false);
            }
        }
    }
}