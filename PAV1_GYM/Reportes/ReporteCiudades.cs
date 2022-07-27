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
    public partial class ReporteCiudades : Form
    {
        private string alcance = "Todas las ciudades";
        public ReporteCiudades()
        {
            InitializeComponent();
        }

        private void ReporteCiudades_Load(object sender, EventArgs e)
        {
            this.RvCiudades.RefreshReport();
        }

        private void RvCiudades_Load(object sender, EventArgs e)
        {
            CargarDatosCiudad("");
        }
        private void BtnBuscarCiudad_Click(object sender, EventArgs e)
        {
            var sentenciaSql = " GROUP BY c.id_ciudad, c.id_provincia, c.nombre, p.nombre ";
            alcance = "";
            if (RbCantidadEmpleados.Checked)
            {
                sentenciaSql += $" ORDER BY cantidadEmpleados DESC";
                alcance += $"Cantidad de empleados por ciudad  ";
            }

            if (RbCantidadSocios.Checked)
            {
                sentenciaSql += $" ORDER BY cantidadSocios DESC";
                alcance += $"Cantidad de socios por ciudad  ";
            }

            if (RbOrdenarProvincia.Checked)
            {
                sentenciaSql += " ORDER BY p.Nombre DESC";
                alcance += $" Orden alfabético de provincias ";
            }

            CargarDatosCiudad(sentenciaSql);
        }


        private void CargarDatosCiudad(string sentencia)
        {
            var sentenciaSql = "SELECT c.*, p.Nombre AS NombreProvincia, count(DISTINCT e.legajoEmpleado) AS cantidadEmpleados, count(DISTINCT s.nroSocio) AS cantidadSocios " +
                "FROM Ciudades c JOIN Provincias p ON c.id_provincia = p.id_provincia LEFT JOIN Socios s ON s.id_ciudad = c.id_ciudad LEFT JOIN Empleados e ON e.id_ciudad = c.id_ciudad " +
                "WHERE c.nombre LIKE '%%' ";
            sentenciaSql += sentencia;
            if (sentencia == "")
                sentenciaSql += " GROUP BY c.id_ciudad, c.id_provincia, c.nombre, p.nombre ";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            ReportDataSource ds = new ReportDataSource("Ciudades", tabla);
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("PR01", alcance);
            RvCiudades.LocalReport.SetParameters(parametros);
            RvCiudades.LocalReport.DataSources.Clear();
            RvCiudades.LocalReport.DataSources.Add(ds);
            RvCiudades.LocalReport.Refresh();
            this.RvCiudades.RefreshReport();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            RbCantidadEmpleados.Checked = false;
            RbCantidadSocios.Checked = false;
            RbOrdenarProvincia.Checked = false;
            alcance = $"Todas las ciudades";
            CargarDatosCiudad("");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}