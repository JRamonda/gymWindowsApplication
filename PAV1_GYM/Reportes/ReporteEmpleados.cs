using Microsoft.Reporting.WinForms;
using PAV1_GYM.RepositoriosBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_GYM.Servicios;

namespace PAV1_GYM.Reportes
{
    public partial class ReporteEmpleados : Form
    {
        private ActividadesServicio actividadesServicio;
        private TurnosServicio turnosServicio;
        private PerfilesServicio perfilesServicio;
        public ReporteEmpleados()
        {
            actividadesServicio = new ActividadesServicio();
            turnosServicio = new TurnosServicio();
            perfilesServicio = new PerfilesServicio();
            InitializeComponent();
        }

        private void ReporteEmpleados_Load(object sender, EventArgs e)
        {

            
            this.rptEmpleadosActividadTurnos.RefreshReport();
           

        }

        //-----------------------------EMPLEADO---------------------------

        private void rptEmpleados_Load(object sender, EventArgs e)
        {
            cargarEmpleados("");
            CargarComboPerfiles();
            rbtnTodosLosEmpleados.Checked = true;
        }

        private void CargarComboPerfiles()
        {
            try
            {
                cmbPerfiles.DataSource = perfilesServicio.GetPerfiles(1);

                cmbPerfiles.DisplayMember = "nombre";

                cmbPerfiles.ValueMember = "id_perfil";
                cmbPerfiles.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("error al cargar Perfil");
            }
        }

        private void MostrarPorFecha(bool valor)
        {
            LblFechaDesde.Visible = valor;
            LblFechaHasta.Visible = valor;
            DtpFechaDesde.Visible = valor;
            DtpFechaHasta.Visible = valor;
        }
        private void MostrarPorFechaId(bool valor)
        {
            LblPerfil.Visible = valor;
            cmbPerfiles.Visible = valor;
        }

        private void rbtnRestringidoFecha_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            btnLimpiar.Enabled = true;
            MostrarPorFecha(true);
            MostrarPorFechaId(false);
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sentencia = "";
            if (rbtnTodosLosEmpleados.Checked)
            {
                cargarEmpleados("");
            }
            if (rbtnRestringidoPorPerfil.Checked)
            {
                if(cmbPerfiles.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un perfil");
                }
                else
                {
                    int id_perfil = Convert.ToInt32(cmbPerfiles.SelectedValue.ToString());
                    sentencia = $" where e.id_perfil = {id_perfil}";
                }
               
            }
            if (rbtnRestringidoFecha.Checked)
            {
                var fechaDesde = DtpFechaDesde.Value.ToString("dd/MM/yyyy");
                var fechaHasta = DtpFechaHasta.Value.ToString("dd/MM/yyyy");
                sentencia += $" where e.fechaIngreso >= CONVERT(VARCHAR(10), '{fechaDesde}', 103) AND e.fechaIngreso <= CONVERT(VARCHAR(10), '{fechaHasta}', 103)";
            }
            cargarEmpleados(sentencia);

        }

        private void cargarEmpleados(string sentencia)
        {
            string sentenciaSql = "SELECT e.*, pe.Nombre as NombrePerfil, td.Nombre as NombreDoc, se.Nombre as NombreSexo, c.nombre as NombreCiudad, p.id_provincia as Id_Provincia, " +
                "p.Nombre as NombreProvincia, eat.id_actividad as Id_Actividad, a.nombre as NombreActividad,a.descripcion as Descripcion, a.precio as Precio, a.estado as EstadoActividad, " +
                "eat.id_turno as Id_Turno, t.nombre as NombreTurno, t.hora_Inicio as Hora_Inicio, t.hora_Fin as Hora_Fin, t.dia as Dia, t.estado as EstadoTurno, " +
                "CONCAT(e.nombre, ' ', e.apellido) empleado " +
                "FROM Empleados e LEFT JOIN Tipos_Documentos td ON e.id_tipoDoc = td.id_tipoDoc LEFT JOIN Sexos se ON e.id_sexo = se.id_sexo " +
                "LEFT JOIN Ciudades c ON e.id_ciudad = c.id_ciudad LEFT JOIN Provincias p ON c.id_provincia = p.id_provincia JOIN Perfiles pe ON e.id_perfil = pe.id_perfil LEFT JOIN Actividades_Y_Turnos_X_Empleados eat ON " +
                "e.legajoEmpleado = eat.legajoEmpleado LEFT JOIN Actividades a ON eat.id_actividad = a.id_actividad LEFT JOIN Turnos t ON eat.id_turno = t.id_turno ";
            sentenciaSql += sentencia;
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            ReportDataSource ds = new ReportDataSource("DatosEmpleados", tabla);


            rptEmpleados.LocalReport.DataSources.Clear();
            rptEmpleados.LocalReport.DataSources.Add(ds);
            rptEmpleados.LocalReport.Refresh();
            this.rptEmpleados.RefreshReport();
        }

        private void rbtnRestringidoPorPerfil_CheckedChanged(object sender, EventArgs e)
        {
            MostrarPorFechaId(true);
            MostrarPorFecha(false);
            btnBuscar.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void rbtnTodosLosEmpleados_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            
            MostrarPorFechaId(false);
            MostrarPorFecha(false);
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            rbtnTodosLosEmpleados.Checked = true;
            
            btnLimpiar.Enabled = false;
            
            MostrarPorFechaId(false);
            MostrarPorFecha(false);
            cargarEmpleados("");

        }






        //---------------------EMPLEADO ACTIVIDAD TURNO-----------------
        private void rptEmpleadosActividadTurnos_Load(object sender, EventArgs e)
        {
            cargarEmpleadosActividadadesTurnos("");
            rbtnTodosLosEmpleadosActividadYTurnos.Checked = true;
            CargarComboActivades();
            CargarComboTurnos();
        }
        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            string sentencia = "";
            if(rbtnActividad.Checked)
            {
                if(cmbActividades.SelectedIndex >-1)
                {
                    int idActividad = Convert.ToInt32(cmbActividades.SelectedValue);
                    sentencia = $" where eat.id_actividad = '{idActividad}'";
                }
                else
                {
                    MessageBox.Show("Elija una Actividad");
                }
            }

            if (rbtnTurno.Checked)
               
            {
                if(cmbTurnos.SelectedIndex>-1)
                {
                    string nombreTurno = cmbTurnos.SelectedItem.ToString();
                    sentencia = $" where t.nombre = '{nombreTurno}'";
                }
                else
                {
                    MessageBox.Show("Elija un Turno");
                }
                
            }

            cargarEmpleadosActividadadesTurnos(sentencia);
        }


        private void cargarEmpleadosActividadadesTurnos(string sentencia)
        {
            DataTable tabla2 = new DataTable();
            string sentenciaSql = "Select pe.Nombre as NombrePerfil, e.legajoEmpleado, CONCAT(e.nombre, ' ', e.apellido) empleado, eat.id_actividad, a.nombre as nombreActividad, " +
                "t.id_turno, t.nombre as nombreTurno, t.dia From Actividades_Y_Turnos_X_Empleados eat left join Actividades a ON eat.id_actividad=a.id_actividad " +
                "left join Turnos t ON eat.id_turno = t.id_turno left join Empleados e on eat.legajoEmpleado = e.legajoEmpleado " +
                "join perfiles pe ON e.id_perfil = pe.id_perfil";
            sentenciaSql += sentencia;
            tabla2 = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            ReportDataSource ds = new ReportDataSource("DataSet1", tabla2);


            rptEmpleadosActividadTurnos.LocalReport.DataSources.Clear();
            rptEmpleadosActividadTurnos.LocalReport.DataSources.Add(ds);
            rptEmpleadosActividadTurnos.LocalReport.Refresh();
            this.rptEmpleadosActividadTurnos.RefreshReport();
        }




        private void CargarComboActivades()
        {
            try
            {
                cmbActividades.DataSource = actividadesServicio.GetActividades();
               
                cmbActividades.DisplayMember = "nombre";
                
                cmbActividades.ValueMember = "id_actividad";
                cmbActividades.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("error al cargar Actividad");
            }
        }

        private void CargarComboTurnos()
        {
            try
            {
                var tablaTurnos = turnosServicio.GetTurnosUnicos();
                if (tablaTurnos.Rows.Count > 0)
                {
                    foreach (DataRow row in tablaTurnos.Rows)
                    {
                        cmbTurnos.Items.Add(row["nombre"].ToString());
                    }
                }
                cmbTurnos.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("error al cargar Turnos");
            }
        }

        private void MostrarComboTurno(bool valor)
        {
            lblTurno.Visible = valor;
            cmbTurnos.Visible = valor;
        }

        private void MostrarComboActividad(bool valor)
        {
            lblActividad.Visible = valor;
            cmbActividades.Visible = valor;
        }

        private void rbtnActividad_CheckedChanged(object sender, EventArgs e)
        {
            btnLimpiar2.Enabled = true;
            btnBuscar2.Enabled = true;
            MostrarComboActividad(true);
            MostrarComboTurno(false);
        }

        private void rbtnTurno_CheckedChanged(object sender, EventArgs e)
        {
            btnLimpiar2.Enabled = true;
            btnLimpiar2.Enabled = true;
            btnBuscar2.Enabled = true;
            MostrarComboActividad(false);
            MostrarComboTurno(true);
        }

        private void rbtnTodosLosEmpleadosActividadYTurnos_CheckedChanged(object sender, EventArgs e)
        {
            
            btnBuscar2.Enabled = true;
            MostrarComboActividad(false);
            MostrarComboTurno(false);
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            rbtnTodosLosEmpleadosActividadYTurnos.Checked = true;
            btnLimpiar2.Enabled = false;
            MostrarComboActividad(false);
            MostrarComboTurno(false);
            cargarEmpleadosActividadadesTurnos("");
            

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
