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
using PAV1_GYM.Entidades;

namespace PAV1_GYM.InterfacesDeUsuarios.Consultas
{
    public partial class ConsultaActividades : Form
    {
        private ActividadesServicio actividadesServicio;
        private Actividad actividad;
        private TurnosServicio turnosServicio;
        private Dictionary<string, Turno> DicTurnos = new Dictionary<string, Turno>();
        private List<int> idTurnos = new List<int>();
        private int id_actividad;

        public ConsultaActividades()
        {
            actividadesServicio = new ActividadesServicio();
            actividad = new Actividad();
            turnosServicio = new TurnosServicio();
            InitializeComponent();
        }

        #region CargarDatos

        private void ConsultaActividades_Load(object sender, EventArgs e)
        {
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnDarBaja.Enabled = false;
            BtnDarAlta.Visible = false;
            LblEstadoBuscado.Visible = false; 
            CargarEstados();
            CargarDias();
            Consultar();
        }

        public void CargarActividad(Actividad actividad)
        {
            TxtNombreActividad.Text = actividad.Nombre;
            TxtDescripcion.Text = actividad.Descripcion;
            TxtPrecio.Text = actividad.Precio.ToString();
            LblEstadoBuscado.Visible = true;
            if (actividad.Estado == true)
                LblEstadoBuscado.Text = "Estado: Activo";
            else
                LblEstadoBuscado.Text = "Estado: Inactivo";
            DicTurnos.Clear();
            LBTurnos.Items.Clear();
            foreach (var turno in actividad.Turnos)
            {
                DicTurnos.Add($"{turno.Nombre}, {turno.Dia}", turno);
                LBTurnos.Items.Add($"{turno.Nombre}, {turno.Dia}");
            }
        }

        private void CargarTurnos(string dia)
        {
            var turnos = turnosServicio.GetTurnosXDia(dia);
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

        private void CargarDias()
        {
            CbDia.Items.Add("Lunes");
            CbDia.Items.Add("Martes");
            CbDia.Items.Add("Miercoles");
            CbDia.Items.Add("Jueves");
            CbDia.Items.Add("Viernes");
            CbDia.Items.Add("Sabado");
            CbDia.Items.Add("Domingo");
            CbDia.SelectedIndex = -1;
        }

        private void CargarEstados()
        {
            CbEstado.Items.Add("Activo");
            CbEstado.Items.Add("Inactivo");
            CbEstado.SelectedIndex = 0;
        }
        #endregion

        #region Clicks
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            LimpiarCampos();
            Consultar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Consultar();
                LimpiarCampos();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                int idActividad = Convert.ToInt32(DgvActividades.SelectedRows[0].Cells[0].Value);
                actividadesServicio.EliminarActividad(idActividad);
                Consultar();
                LimpiarCampos();
                MessageBox.Show("La operación se realizó con éxito", "Información");
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

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsCamposValidos())
                    return;
                if (!EsOperacionConfirmada())
                    return;
                if (!EsActividadValida())
                    return;
                RegistrarTurnos();
                if (!actividadesServicio.RegistrarActividad(actividad, idTurnos))
                {
                    MessageBox.Show("La actividad ya se encuentra cargada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La actividad se registró con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Consultar();
                    LimpiarCampos();
                }
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

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsCamposValidos())
                    return;
                if (!EsOperacionConfirmada())
                    return;
                if (!EsActividadValida())
                    return;
                RegistrarTurnos();
                actividad.Id_Actividad = id_actividad;
                if (!actividadesServicio.ModificarActividad(actividad, idTurnos))
                {
                    MessageBox.Show("Problema al modificar la actividad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("La actividad se modificó con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Consultar();
                    LimpiarCampos();
                }
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

        private void BtnDarBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsCamposValidos())
                    return;
                if (!EsOperacionConfirmada())
                    return;
                if (!EsActividadValida())
                    return;
                if (actividad != null)
                {
                    actividad.Estado = false;
                    actividadesServicio.ModificarEstadoActividad(actividad);
                    MessageBox.Show("La operación se realizó con éxito", "Información");
                    Consultar();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Problema al dar de baja a la actividad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void BtnDarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsCamposValidos())
                    return;
                if (!EsOperacionConfirmada())
                    return;
                if (!EsActividadValida())
                    return;
                if (actividad != null)
                {
                    actividad.Estado = true;
                    actividadesServicio.ModificarEstadoActividad(actividad);
                    MessageBox.Show("La operación se realizó con éxito", "Información");
                    Consultar();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Problema al dar de alta a la actividad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void LnkAgregarTurno_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var turno = (Turno)CbTurno.SelectedItem;
                if (turno.Nombre != "Seleccionar")
                {
                    DicTurnos.Add($"{turno.Nombre}, {turno.Dia}", turno);
                    LBTurnos.Items.Add($"{turno.Nombre}, {turno.Dia}");
                }
                else
                    MessageBox.Show("Elija un turno válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void LnkQuitarTurno_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                int index = LBTurnos.SelectedIndex;
                if (index != -1)
                {
                    DicTurnos.Remove(LBTurnos.Items[index].ToString());
                    LBTurnos.Items.RemoveAt(index);
                }
                else
                {
                    MessageBox.Show("Seleccione un turno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CbTurno.Focus();
                }
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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Funciones

        private void Limpiar()
        {
            TxtNombre.Text = "";
            CbEstado.SelectedIndex = 0;
            id_actividad = 0;
        }

        private void LimpiarCampos()
        {
            TxtNombreActividad.Text = "";
            TxtDescripcion.Text = "";
            TxtPrecio.Text = "";
            DicTurnos.Clear();
            idTurnos.Clear();
            LBTurnos.Items.Clear();
            id_actividad = 0;
            CbDia.SelectedIndex = -1;
            BtnModificar.Enabled = false;
            BtnDarBaja.Enabled = false;
            BtnDarAlta.Visible = false;
            BtnEliminar.Enabled = false;
            LblEstadoBuscado.Visible = false;
            CbTurno.SelectedIndex = - 1;
            CbTurno.Enabled = false;
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
            if (TxtNombreActividad.Text.Equals("") || TxtPrecio.Text.Equals(""))
            {
                MessageBox.Show("Hay campos sin rellenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!(float.TryParse(TxtPrecio.Text, out float number) && number > 0))
            {
                MessageBox.Show("Ingrese un precio válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (LBTurnos.Items.Count == 0)
            {
                MessageBox.Show("Seleccione un turno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void Consultar()
        {
            var actividad = new Actividad();
            actividad.Nombre = TxtNombre.Text;
            if (CbEstado.SelectedItem.ToString() == "Activo")
                actividad.Estado = true;
            if (CbEstado.SelectedItem.ToString() == "Inactivo")
                actividad.Estado = false;
            var actividades = actividadesServicio.ObtenerActividades(actividad);
            CargarGrilla(actividades);
        }

        private void CargarGrilla(List<Actividad> actividades)
        {
            DgvActividades.Rows.Clear();
            foreach (Actividad a in actividades)
            {
                var descripcionEstado = a.Estado ? "Activo" : "Baja";
                var dias = "";
                var listaDias = new List<string>();
                for (int i = 0; i < a.Turnos.Count; i++)
                {
                    if (!listaDias.Contains(a.Turnos[i].Dia))
                    {
                        listaDias.Add(a.Turnos[i].Dia);
                        if (i == 0)
                            dias += $"{a.Turnos[i].Dia}";
                        else
                            dias += $", {a.Turnos[i].Dia}";
                    }        
                }
                var fila = new string[] {
                a.Id_Actividad.ToString(),
                a.Nombre,
                a.Descripcion,
                a.Precio.ToString(),
                dias,
                descripcionEstado
                };
                DgvActividades.Rows.Add(fila);
            }
        }

        private void CargarActividadBuscada()
        {
            try
            {
                id_actividad = Convert.ToInt32(DgvActividades.SelectedRows[0].Cells[0].Value);
                actividad = actividadesServicio.ObtenerActividad(id_actividad);
                CargarActividad(actividad);
                HabilitarBotones(actividad);
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

        private void RegistrarTurnos()
        {
            idTurnos.Clear();
            foreach (var tur in DicTurnos.Values)
            {
                idTurnos.Add(tur.Id_Turno);
            }
        }

        private bool EsActividadValida()
        {
            var actividadIngresada = new Actividad
            {
                Nombre = TxtNombreActividad.Text,
                Descripcion = TxtDescripcion.Text,
                Precio = float.Parse(TxtPrecio.Text)
            };
            actividad = actividadIngresada;
            return true;
        }

        private void DgvActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvActividades.RowCount > 0)
            {
                CargarActividadBuscada();
                HabilitarBotones(actividad);
            }
        }

        private void CbDia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CbTurno.Enabled = true;
            string dia = CbDia.SelectedItem.ToString();
            CargarTurnos(dia);
        }

        private void HabilitarBotones(Actividad actividad)
        {
            BtnModificar.Enabled = true;
            BtnDarBaja.Enabled = true;
            BtnEliminar.Enabled = true;
            if (actividad.Estado == false)
                BtnDarAlta.Visible = true;
        }
        #endregion
    }
}