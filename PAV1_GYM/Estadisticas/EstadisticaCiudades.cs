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
    public partial class EstadisticaCiudades : Form
    {
        private string alcance = "Todas las ciudades";
        public EstadisticaCiudades()
        {
            InitializeComponent();
        }

        private void EstadisticaCiudades_Load(object sender, EventArgs e)
        {
            this.RvCiudades.RefreshReport();
        }

        private void CargarDatosCiudades()
        {
            var sentenciaSql = "SELECT c.*, p.Nombre AS NombreProvincia, count(DISTINCT e.legajoEmpleado) AS cantidadEmpleados, count(DISTINCT s.nroSocio) AS cantidadSocios " +
                "FROM Ciudades c JOIN Provincias p ON c.id_provincia = p.id_provincia LEFT JOIN Socios s ON s.id_ciudad = c.id_ciudad LEFT JOIN Empleados e ON e.id_ciudad = c.id_ciudad " +
                "GROUP BY c.id_ciudad, c.id_provincia, c.nombre, p.nombre " +
                "HAVING count(DISTINCT e.legajoEmpleado) > 0 OR count(DISTINCT s.nroSocio) > 0";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            ReportDataSource ds = new ReportDataSource("EstadisticaCiudades", tabla);
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("PR01", alcance);
            RvCiudades.LocalReport.SetParameters(parametros);
            RvCiudades.LocalReport.DataSources.Clear();
            RvCiudades.LocalReport.DataSources.Add(ds);
            this.RvCiudades.RefreshReport();
        }

        private void RvCiudades_Load(object sender, EventArgs e)
        {
            CargarDatosCiudades();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
