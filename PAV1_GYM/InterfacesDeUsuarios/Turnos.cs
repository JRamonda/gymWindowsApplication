using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_GYM.Entidades;
using PAV1_GYM.Servicios;

namespace PAV1_GYM.InterfacesDeUsuarios
{
    public partial class Turnos : Form
    {
        private SociosServicio sociosServicio;
        private TurnosServicio turnosServicio;
        private ActividadesServicio actividadesServicio;
        private AsistenciasServicio asistenciasServicio;
        private Actividad actividad;

        public Turnos()
        {
            sociosServicio = new SociosServicio();
            turnosServicio = new TurnosServicio();
            actividadesServicio = new ActividadesServicio();
            asistenciasServicio = new AsistenciasServicio();
            InitializeComponent();
        }

        #region CargarDatos

        private void Turnos_Load(object sender, EventArgs e)
        {
            DtpFecha.MinDate = DateTime.Today;
            DtpFecha.MaxDate = DateTime.Today.AddDays(30);
            Consultar();
        }

        private void CargarTurnos(int id_actividad, string dia)
        {
            var turnos = turnosServicio.ObtenerTurnosXActividad(id_actividad, dia);
            var turnoDefault = new Turno();
            turnoDefault.Nombre = "Seleccionar";
            turnos.Add(turnoDefault);
            var conector = new BindingSource();
            conector.DataSource = turnos;
            CbTurno.DataSource = conector;
            CbTurno.DisplayMember = "Nombre";
            CbTurno.ValueMember = "Id_Turno";
            CbTurno.SelectedItem = turnoDefault;
        }

        private void CargarActividades(int nroSocio)
        {
            var actividades = actividadesServicio.ObtenerActividadesSocio(nroSocio);
            if (actividades.Count > 0)
            {
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
            else
            {
                CbActividad.DataSource = null;
                CbActividad.Items.Clear();
            }
        }
        #endregion

        #region Clicks

        private void BtnCargarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                if (!EsCamposValidos())
                    return;
                var socio = new Socio
                {
                    NroSocio = Convert.ToInt32(DgvSocios.SelectedRows[0].Cells[0].Value)
                };
                var asistencia = new Asistencia
                {
                    Socio = socio,
                    Actividad = (Actividad)CbActividad.SelectedItem,
                    Turno = (Turno)CbTurno.SelectedItem,
                    Fecha = DtpFecha.Value
                };
                if (asistenciasServicio.RegistrarAsistencia(asistencia))
                {
                    MessageBox.Show("La operación se realizó con éxito", "Información");
                }
                else
                {
                    MessageBox.Show("No se ha podido cargar el turno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Limpiar();
                Consultar();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Consultar();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Consultar();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Funciones

        private void Limpiar()
        {
            DtpFecha.Text = DateTime.Today.ToString();
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtNroSocio.Text = "";
            CbActividad.SelectedIndex = - 1;
            CbTurno.SelectedIndex = - 1;
            BtnCargarTurno.Enabled = false;
            CbTurno.Enabled = false;
            actividad = null;
            HabilitarOpciones(false);
        }

        private bool EsOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("Desea confirmar la operación", "Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }

        private bool EsCamposValidos()
        {
            if (((Turno)CbTurno.SelectedItem).Nombre == "Seleccionar")
            {
                MessageBox.Show("Ingrese un turno válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (((Actividad)CbActividad.SelectedItem).Nombre == "Seleccionar")
            {
                MessageBox.Show("Ingrese una actividad válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Consultar()
        {
            int nroSocio;
            int.TryParse(TxtNroSocio.Text, out nroSocio);
            var socio = new Socio();
            socio.Nombre = TxtNombre.Text;
            socio.Apellido = TxtApellido.Text;
            socio.NroSocio = nroSocio;
            socio.Estado = true;
            var socios = sociosServicio.ObtenerSociosConActividad(socio);
            CargarGrilla(socios);
        }

        private void CargarGrilla(List<Socio> socios)
        {
            DgvSocios.Rows.Clear();
            foreach (Socio s in socios)
            {
                string objetivos = "";
                int contObj = 0;
                foreach (Objetivo objetivo in s.Objetivos)
                {
                    if (contObj == 0)
                    {
                        objetivos += $"{objetivo.Nombre}";
                        contObj += 1;
                    }
                    else
                        objetivos += $", {objetivo.Nombre}";
                }
                string actividadesyplanes = "";
                for (int i = 0; i < s.Actividades.Count; i++)
                {
                    if (i == 0)
                        actividadesyplanes += $"{s.Actividades[i].Nombre}, {s.Planes[i].Nombre}";
                    else
                        actividadesyplanes += $" | {s.Actividades[i].Nombre}, {s.Planes[i].Nombre}";
                }
                var fila = new string[] {
                s.NroSocio.ToString(),
                s.NroDocumento,
                s.TipoDocumento?.Nombre,
                $"{s.Nombre}, {s.Apellido}",
                s.Sexo.Nombre,
                objetivos,
                actividadesyplanes};
                DgvSocios.Rows.Add(fila);
            }
        }

        private void HabilitarOpciones(bool op)
        {
            CbActividad.Enabled = op;
            DtpFecha.Enabled = op;
        }

        private void DgvSocios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvSocios.RowCount > 0)
            {
                int nroSocio = Convert.ToInt32(DgvSocios.SelectedRows[0].Cells[0].Value);
                CargarActividades(nroSocio);
                HabilitarOpciones(true);
            }
        }

        private void CbTurno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BtnCargarTurno.Enabled = true;
        }

        private void CbActividad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (((Actividad)CbActividad.SelectedItem).Nombre == "Seleccionar")
            {
                CbTurno.SelectedIndex = -1;
                CbTurno.Enabled = false;
            }
            else
            {
                actividad = (Actividad)CbActividad.SelectedItem;
                CbTurno.Enabled = true;
                string dia = DtpFecha.Value.ToString("dddd", CultureInfo.CreateSpecificCulture("es-ES"));
                CargarTurnos(actividad.Id_Actividad, dia);
            }
        }

        private void DtpFecha_ValueChanged(object sender, EventArgs e)
        {
            string dia = DtpFecha.Value.ToString("dddd", CultureInfo.CreateSpecificCulture("es-ES"));
            CargarTurnos(actividad.Id_Actividad, dia);
        }
        #endregion
    }
}