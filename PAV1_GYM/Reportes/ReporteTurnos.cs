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
    public partial class ReporteTurnos : Form
    {
        private string alcance = "Todos los turnos  ";
        public ReporteTurnos()
        {
            InitializeComponent();
        }

        private void ReporteTurnos_Load(object sender, EventArgs e)
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

        private void RvTurnos_Load(object sender, EventArgs e)
        {
            var sentenciaSql = "SELECT t.*, count(asi.id_turno) AS cantidadSocios FROM Asistencias asi RIGHT JOIN Turnos t ON asi.id_turno = t.id_turno RIGHT JOIN Socios s ON asi.nroSocio = s.nroSocio " +
                "GROUP BY t.id_turno, t.nombre, t.hora_inicio, t.hora_fin, t.dia, t.estado";

            CargarDatosTurno(sentenciaSql);
        }


        private void CargarDatosTurno(string sentencia)
        {
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentencia);
            ReportDataSource ds = new ReportDataSource("DatosTurnos", tabla);
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("PR01", alcance);
            RvTurnos.LocalReport.SetParameters(parametros);
            RvTurnos.LocalReport.DataSources.Clear();
            RvTurnos.LocalReport.DataSources.Add(ds);
            RvTurnos.LocalReport.Refresh();
            this.RvTurnos.RefreshReport();
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

        private void BtnBuscarTurno_Click(object sender, EventArgs e)
        {
            var fechaDesde = DtpFechaDesde.Value.ToString("dd/MM/yyyy");
            var fechaHasta = DtpFechaHasta.Value.ToString("dd/MM/yyyy");
            var sentenciaSql = "SELECT t.*, count(asi.id_turno) AS cantidadSocios FROM Asistencias asi RIGHT JOIN Turnos t ON asi.id_turno = t.id_turno RIGHT JOIN Socios s ON asi.nroSocio = s.nroSocio " +
                "WHERE s.nroSocio LIKE '%%'";

            alcance = "";

            if (ChFiltrarFecha.Checked)
            {
                sentenciaSql += $" AND asi.fecha >= CONVERT(VARCHAR(10), '{fechaDesde}', 103) AND asi.fecha <= CONVERT(VARCHAR(10), '{fechaHasta}', 103)";
                alcance += $" Entre las fechas {fechaDesde} y {fechaHasta}  ";

            }


            if (RbMasc.Checked)
            {
                sentenciaSql += " AND s.id_sexo = 1";
                alcance += $" Socios Masculinos  ";
            }

            if (RbFem.Checked)
            {
                sentenciaSql += " AND s.id_sexo = 2";
                alcance += $" Socios Femeninos  ";

            }

            if (CkEdad.Checked)
            {
                int edadInicial;
                int edadFinal;
                if (int.TryParse(TxtEdadInicial.Text, out edadInicial) && int.TryParse(TxtEdadFinal.Text, out edadFinal))
                {
                    sentenciaSql += $" AND DATEDIFF(year, s.fechaNacimiento, GETDATE()) >= {edadInicial} AND DATEDIFF(year, s.fechaNacimiento, GETDATE()) <= {edadFinal}";
                    alcance += $" Entre las edades de {edadInicial} y {edadFinal}  ";
                }
                else
                    MessageBox.Show("Ingrese un intervalo de edades válidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sentenciaSql += " GROUP BY t.id_turno, t.nombre, t.hora_inicio, t.hora_fin, t.dia, t.estado";


            CargarDatosTurno(sentenciaSql);
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
            alcance = $"Todos los turnos";

            var sentenciaSql = "SELECT t.*, count(asi.id_turno) AS cantidadSocios FROM Asistencias asi RIGHT JOIN Turnos t ON asi.id_turno = t.id_turno RIGHT JOIN Socios s ON asi.nroSocio = s.nroSocio " +
                "GROUP BY t.id_turno, t.nombre, t.hora_inicio, t.hora_fin, t.dia, t.estado";


            CargarDatosTurno(sentenciaSql);

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}