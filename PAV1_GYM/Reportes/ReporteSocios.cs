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
    public partial class ReporteSocios : Form
    {
        string alcance = "Todos los Socios ingresados en el Sistema";
        public ReporteSocios()
        {
            InitializeComponent();
        }

        private void ReporteSocios_Load(object sender, EventArgs e)
        {
            this.RvSocios.RefreshReport();
            this.RVPeriodoSocio.RefreshReport();
            this.RvTodos.RefreshReport();
            DtpFechaDesde.MinDate = DateTime.Parse("01/01/2022");
            DtpFechaDesde.MaxDate = DateTime.Today;
            DtpFechaHasta.MinDate = DateTime.Parse("01/01/2022");
            DtpFechaHasta.MaxDate = DateTime.Today;
        }

        private void CargarDatosSocio(string sentencia)
        {
            var sentenciaSql = "SELECT s.nroSocio, CONCAT(s.nombre,' ', s.apellido) nombre, s.nroDoc, td.nombre as tipoDoc, se.nombre as sexo, " +
                "CONCAT(c.nombre, ', ', p.nombre) ciudad, s.fechaAlta, s.fechaBaja, s.estado " +
                "FROM Socios s JOIN Tipos_Documentos td ON s.id_tipoDoc = td.id_tipoDoc  JOIN Sexos se ON s.id_sexo = se.id_sexo JOIN Ciudades c ON s.id_ciudad = c.id_ciudad LEFT JOIN Provincias p ON c.id_provincia = p.id_provincia " +
                "JOIN Empleados e ON s.legajoEmpleado = e.legajoEmpleado ";
            sentenciaSql += sentencia;
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            ReportDataSource ds = new ReportDataSource("DataSetSocios", tabla);
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
                        alcance = "Todos los Socios ingresados en el Sistema";
            CargarDatosSocio("");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var sentenciaSql = "";

            if (ckbTodos.Checked)
            {
                sentenciaSql += "";
                alcance = "Todos los Socios ingresados en el Sistema";
            }

            if (ckbF.Checked)
            {
                if (ckbActivo.Checked)
                {
                    sentenciaSql += " WHERE s.id_sexo =2 AND s.estado = 'S'";
                    alcance = "Socios Femeninos Y Activos";
                }
                else if (ckbNoActivo.Checked)
                {
                    sentenciaSql += " WHERE s.id_sexo =2 AND s.estado = 'N'";
                    alcance = "Socios Femeninos Y No Activos";
                }
                else
                {
                    sentenciaSql += " WHERE s.id_sexo =2";
                    alcance = "Todos los Socios Femeninos";
                }

            }
            if (ckbM.Checked)
            {
                if (ckbActivo.Checked)
                {
                    sentenciaSql += " WHERE s.id_sexo =1 AND s.estado = 'S'";
                    alcance = "Socios Masculinos Y Activos";

                }
                else if (ckbNoActivo.Checked)
                {
                    sentenciaSql += " WHERE s.id_sexo =1 AND s.estado = 'N'";
                    alcance = "Socios Masculinos Y No Activos";
                    ckbTodos.Checked = false;
                }
                else
                {
                    sentenciaSql += " WHERE s.id_sexo =1";
                    alcance = "Todos los Socios Masculinos";

                }
            }

            if (ckbActivo.Checked && (ckbF.Checked == false) && (ckbM.Checked == false))
            {
                sentenciaSql += " WHERE s.estado = 'S'";
                alcance = "Solo socios Activos";

            }
            if (ckbNoActivo.Checked && (ckbF.Checked == false) && (ckbM.Checked == false))
            {
                sentenciaSql += " WHERE s.estado = 'N' ";
                alcance = "Solo socios No Activos";

            }
            CargarDatosSocio(sentenciaSql);
            Limpiar();


        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatosPeriodoSocio(string sentencia)
        {
            var sentenciaSql = "SELECT s.nroSocio, CONCAT(s.nombre, ' ', s.apellido) nombre, s.nroDoc, td.nombre as tipoDoc, se.nombre as sexo, " +
                "CONCAT(c.nombre, ', ', p.nombre) ciudad, s.fechaAlta, s.fechaBaja, s.estado " +
                "FROM Socios s JOIN Tipos_Documentos td ON s.id_tipoDoc = td.id_tipoDoc  JOIN Sexos se ON s.id_sexo = se.id_sexo JOIN Ciudades c ON s.id_ciudad = c.id_ciudad LEFT JOIN Provincias p ON c.id_provincia = p.id_provincia " +
                "JOIN Empleados e ON s.legajoEmpleado = e.legajoEmpleado";
            sentenciaSql += sentencia;
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            ReportDataSource ds = new ReportDataSource("DataSetPeriodoSocios", tabla);
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("PR02", alcance);
            RVPeriodoSocio.LocalReport.SetParameters(parametros);
            RVPeriodoSocio.LocalReport.DataSources.Clear();
            RVPeriodoSocio.LocalReport.DataSources.Add(ds);
            RVPeriodoSocio.LocalReport.Refresh();
            this.RVPeriodoSocio.RefreshReport();
        }

        private void RVPeriodoSocio_Load(object sender, EventArgs e)
        {
            alcance = "Todos los Socios ingresados en el Sistema";
            CargarDatosPeriodoSocio("");
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            var sentenciaSql = "";

            var fechaDesde = DtpFechaDesde.Value.ToString("dd/MM/yyyy");
            var fechaHasta = DtpFechaHasta.Value.ToString("dd/MM/yyyy");
            sentenciaSql += $" WHERE s.fechaAlta >= CONVERT(VARCHAR(10), '{fechaDesde}', 103) AND s.fechaAlta <= CONVERT(VARCHAR(10), '{fechaHasta}', 103)";

            alcance = $"Los Socios dados de Alta en el periodo de Tiempo: '{fechaDesde}' y '{fechaHasta}'";


            CargarDatosPeriodoSocio(sentenciaSql);
        }


        private void CargarDatosDetalleSocios(string sentencia)
        {
            var sentenciaSql = "SELECT s.nroSocio, CONCAT(s.nombre, ' ', s.apellido) nombre, s.nroDoc, td.nombre as tipoDoc, se.nombre as sexo, " +
                "CONCAT(c.nombre, ', ', p.nombre) ciudad, s.fechaAlta, s.fechaBaja, s.estado, CONCAT(a.nombre, ' ', pl.nombre) actividadyplan " +
                "FROM Socios s JOIN Tipos_Documentos td ON s.id_tipoDoc = td.id_tipoDoc  JOIN Sexos se ON s.id_sexo = se.id_sexo JOIN Ciudades c ON s.id_ciudad = c.id_ciudad LEFT JOIN Provincias p ON c.id_provincia = p.id_provincia " +
                "JOIN Empleados e ON s.legajoEmpleado = e.legajoEmpleado LEFT JOIN Actividades_Y_Planes_X_Socios aps ON aps.nroSocio = s.nroSocio " +
                "LEFT JOIN Actividades a ON aps.id_actividad = a.id_actividad LEFT JOIN Planes pl ON aps.id_plan = pl.id_plan ";
            sentenciaSql += sentencia;
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            ReportDataSource ds = new ReportDataSource("DataSetDetalleSocios", tabla);
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("PR03", alcance);
            RvTodos.LocalReport.SetParameters(parametros);
            RvTodos.LocalReport.DataSources.Clear();
            RvTodos.LocalReport.DataSources.Add(ds);
            RvTodos.LocalReport.Refresh();
            this.RvTodos.RefreshReport();

        }

        private void btnBuscar3_Click(object sender, EventArgs e)
        {
            var sentenciaSql = "";

            if (rbdTodos.Checked)
            {
                sentenciaSql += "";
                alcance = "Todos los Socios ingresados en el Sistema";
            }

            if (rdbF.Checked)
            {
                if (rdbActivo.Checked)
                {
                    sentenciaSql += " WHERE s.id_sexo =2 AND s.estado = 'S'";
                    alcance = "Socios Femeninos Y Activos";
                }
                else if (rdbNoActivo.Checked)
                {
                    sentenciaSql += " WHERE s.id_sexo =2 AND s.estado = 'N'";
                    alcance = "Socios Femeninos Y No Activos";
                }
                else
                {
                    sentenciaSql += " WHERE s.id_sexo =2";
                    alcance = "Todos los Socios Femeninos";
                }

            }
            if (rdbM.Checked)
            {
                if (rdbActivo.Checked)
                {
                    sentenciaSql += " WHERE s.id_sexo =1 AND s.estado = 'S'";
                    alcance = "Socios Masculinos Y Activos";

                }
                else if (rdbNoActivo.Checked)
                {
                    sentenciaSql += " WHERE s.id_sexo =1 AND s.estado = 'N'";
                    alcance = "Socios Masculinos Y No Activos";
                    rbdTodos.Checked = false;
                }
                else
                {
                    sentenciaSql += " WHERE s.id_sexo =1";
                    alcance = "Todos los Socios Masculinos";

                }
            }
            if (rdbActivo.Checked && (rdbF.Checked == false) && (rdbM.Checked == false))
            {
                sentenciaSql += " WHERE s.estado = 'S'";
                alcance = "Solo socios Activos";

            }
            if (rdbNoActivo.Checked && (rdbF.Checked == false) && (rdbM.Checked == false))
            {
                sentenciaSql += " WHERE s.estado = 'N' ";
                alcance = "Solo socios No Activos";

            }

            CargarDatosDetalleSocios(sentenciaSql);
            Limpiar();

        }

        private void Limpiar()
        {
            ckbTodos.Checked = false;
            ckbF.Checked = false;
            ckbM.Checked = false;
            ckbActivo.Checked = false;
            ckbNoActivo.Checked = false;
            rbdTodos.Checked = false;
            rdbActivo.Checked = false;
            rdbNoActivo.Checked = false;
            rdbF.Checked = false;
            rdbM.Checked = false;
            alcance = "Todos los Socios ingresados en el Sistema";
        }


        private void RvTodos_Load(object sender, EventArgs e)
        {
            alcance = "Todos los Socios ingresados en el Sistema";
            CargarDatosDetalleSocios("");
        }
    }
}