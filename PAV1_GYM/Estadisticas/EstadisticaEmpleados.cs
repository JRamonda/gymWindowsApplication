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
    public partial class EstadisticaEmpleados : Form
    {
        public EstadisticaEmpleados()
        {
            InitializeComponent();
        }

        private string alcanceEmpleado = "Todos los empleados";
        private string alcanceEntrenador = "Todos los entrenadores";

        private void EstadisticaEmpleados_Load(object sender, EventArgs e)
        {
            this.RvEmpleados.RefreshReport();
            this.RvEntrenadoresXActividad.RefreshReport();
            this.RvEntrenadoresXTurno.RefreshReport();
            DtpFechaDesde.MinDate = DateTime.Parse("01/01/2022");
            DtpFechaDesde.MaxDate = DateTime.Today;
            DtpFechaHasta.MinDate = DateTime.Parse("01/01/2022");
            DtpFechaHasta.MaxDate = DateTime.Today;
        }

        private void BtnBuscar1_Click(object sender, EventArgs e)
        {
            var fechaDesde = DtpFechaDesde.Value.ToString("dd/MM/yyyy");
            var fechaHasta = DtpFechaHasta.Value.ToString("dd/MM/yyyy");
            var sentenciaSql = $" AND e.fechaIngreso >= CONVERT(VARCHAR(10), '{fechaDesde}', 103) AND e.fechaIngreso <= CONVERT(VARCHAR(10), '{fechaHasta}', 103)";
            alcanceEmpleado = $"Los empleados que ingresaron entre las fechas {fechaDesde} y {fechaHasta}";
            CargarEmpleados(sentenciaSql);
        }

        private void RvEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados("");
        }

        private void CargarEmpleados(string sentencia)
        {
            string sentenciaSql = "SELECT CONCAT(e.nombre, ' ', e.apellido) NombreEmpleado, p.nombre as Perfil, DATEDIFF(year, e.fechaNacimiento, GETDATE()) as Edad, " +
                "se.nombre as NombreSexo FROM Empleados e LEFT JOIN Tipos_Documentos td ON e.id_tipoDoc = td.id_tipoDoc LEFT JOIN Sexos se ON e.id_sexo = se.id_sexo " +
                "LEFT JOIN Perfiles p on e.id_perfil = p.id_perfil WHERE e.id_perfil != 1 ";
            sentenciaSql += sentencia;
            sentenciaSql += " GROUP BY e.nombre, e.apellido, e.fechaNacimiento, se.nombre, p.nombre";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            ReportDataSource ds = new ReportDataSource("EstadisticaEmpleados", tabla);
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("PR01", alcanceEmpleado);
            RvEmpleados.LocalReport.SetParameters(parametros);
            RvEmpleados.LocalReport.DataSources.Clear();
            RvEmpleados.LocalReport.DataSources.Add(ds);
            RvEmpleados.LocalReport.Refresh();
            this.RvEmpleados.RefreshReport();
        }

        private void BtnLimpiar1_Click(object sender, EventArgs e)
        {
            DtpFechaDesde.Text = DateTime.Today.ToString();
            DtpFechaHasta.Text = DateTime.Today.ToString();
            alcanceEmpleado = "Todos los empleados";
            CargarEmpleados("");
        }

        //////////////////////////////////////////// EMPLEADOS POR ACTIVIDAD Y TURNOS///////////////////////////////////////////////

        private void RvEntrenadoresXActividad_Load(object sender, EventArgs e)
        {
            CargarEntrenadoresPorActividad("");
        }

        private void CargarEntrenadoresPorActividad(string sentencia)
        {
            string sentenciaSql = "SELECT a.nombre as NombreActividad, COUNT(DISTINCT e.nombre) AS CantidadEmpleados " +
                "FROM Actividades_Y_Turnos_X_Empleados ate LEFT JOIN Empleados e ON ate.legajoEmpleado = e.legajoEmpleado LEFT JOIN Actividades a " +
                "ON ate.id_actividad = a.id_actividad ";
            sentenciaSql += sentencia;
            sentenciaSql += " GROUP BY a.nombre";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            ReportDataSource ds = new ReportDataSource("EstadisticasEntrenadoresXActividad", tabla);
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("PR01", alcanceEntrenador);
            RvEntrenadoresXActividad.LocalReport.SetParameters(parametros);
            RvEntrenadoresXActividad.LocalReport.DataSources.Clear();
            RvEntrenadoresXActividad.LocalReport.DataSources.Add(ds);
            RvEntrenadoresXActividad.LocalReport.Refresh();
            this.RvEntrenadoresXActividad.RefreshReport();
        }

        ///PARTE TURNOS//
        ///
        private void RvEntrenadoresXTurno_Load(object sender, EventArgs e)
        {
            CargarEntrenadoresPorTurno("");
        }

        private void CargarEntrenadoresPorTurno(string sentencia)
        {
            string sentenciaSql = "SELECT t.nombre as NombreTurno, COUNT(DISTINCT e.nombre) AS CantidadEmpleados " +
                "FROM Actividades_Y_Turnos_X_Empleados ate LEFT JOIN Empleados e ON ate.legajoEmpleado = e.legajoEmpleado LEFT JOIN Turnos t ON ate.id_turno = t.id_turno ";
            sentenciaSql += sentencia;
            sentenciaSql += " GROUP BY t.nombre";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            ReportDataSource ds = new ReportDataSource("EstadisticasEntrenadoresXTurno", tabla);
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("PR01", alcanceEntrenador);
            RvEntrenadoresXTurno.LocalReport.SetParameters(parametros);
            RvEntrenadoresXTurno.LocalReport.DataSources.Clear();
            RvEntrenadoresXTurno.LocalReport.DataSources.Add(ds);
            RvEntrenadoresXTurno.LocalReport.Refresh();
            this.RvEntrenadoresXTurno.RefreshReport();
        }


        private void BtnBuscar2_Click(object sender, EventArgs e)
        {
            alcanceEntrenador = "Los entrenadores";
            string sentencia = "";
            if (RbFiltroEdad.Checked)
            {
                int edadInicial;
                int edadFinal;

                if (int.TryParse(TxtEdadInicio.Text, out edadInicial) && int.TryParse(TxtEdadFin.Text, out edadFinal))
                {
                    sentencia = $" WHERE DATEDIFF(YEAR, e.fechaNacimiento, GETDATE()) >= {edadInicial} AND DATEDIFF(YEAR, e.fechaNacimiento, GETDATE()) <= {edadFinal}";
                    alcanceEntrenador += $" mayores de {edadInicial} años y menores de {edadFinal} años";
                }
                else
                {
                    MessageBox.Show("Ingrese tipo de valor correcto");
                }
            }

            if (RbFiltroSexo.Checked)
            {

                if (RbFem.Checked)
                {
                    sentencia = " WHERE e.id_Sexo = 2";
                    alcanceEntrenador += " femeninos";
                }
                else if (RbMasc.Checked)
                {
                    sentencia = " WHERE e.id_Sexo = 1 ";
                    alcanceEntrenador += " masculinos";
                }
                else
                {
                    MessageBox.Show("Seleccine un sexo");
                }
            }
            CargarEntrenadoresPorActividad(sentencia);
            CargarEntrenadoresPorTurno(sentencia);

        }

        private void BtnLimpiar2_Click(object sender, EventArgs e)
        {
            RbFiltroEdad.Checked = false;
            RbFiltroSexo.Checked = false;
            RbFem.Checked = false;
            RbMasc.Checked = false;
            RbFem.Enabled = false;
            RbMasc.Enabled = false;
            TxtEdadFin.Text = "";
            TxtEdadInicio.Text = "";
            TxtEdadFin.Enabled = false;
            TxtEdadInicio.Enabled = false;
            alcanceEntrenador = "Todos los entrenadores";
            CargarEntrenadoresPorActividad("");
            CargarEntrenadoresPorTurno("");
        }

        private void RbFiltroEdad_CheckedChanged(object sender, EventArgs e)
        {
            TxtEdadFin.Enabled = true;
            TxtEdadInicio.Enabled = true;
            RbFem.Enabled = false;
            RbMasc.Enabled = false;
            RbFem.Checked = false;
            RbMasc.Checked = false;
        }

        private void RbFiltroSexo_CheckedChanged(object sender, EventArgs e)
        {
            RbFem.Enabled = true;
            RbMasc.Enabled = true;
            TxtEdadFin.Enabled = false;
            TxtEdadInicio.Enabled = false;
            TxtEdadFin.Text = "";
            TxtEdadInicio.Text = "";
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}