using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_GYM.Entidades;
using PAV1_GYM.Servicios;
using PAV1_GYM.InterfacesDeUsuarios;
using PAV1_GYM.InterfacesDeUsuarios.PerfilUsuario;
using PAV1_GYM.InterfacesDeUsuarios.Consultas;
using PAV1_GYM.InterfacesDeUsuarios.Mantenimiento;
using PAV1_GYM.Estadisticas;
using PAV1_GYM.Utils;
using PAV1_GYM.Reportes;


namespace PAV1_GYM.InterfacesDeUsuarios
{
    public partial class PrincipalMenu : Form
    {
        private Empleado usuarioLogueado;
        private AbrirForm abrirForm;
        public PrincipalMenu()
        {
            abrirForm = new AbrirForm();
            InitializeComponent();
            PersonalizarDiseño();
        }

        private void PrincipalMenu_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            var Login = new Login();
            Login.ShowDialog();
            usuarioLogueado = EmpleadosServicio.UsuarioLogueado;
            LblBienvenido.Parent = ImagenFondo;
            if (usuarioLogueado != null)
            {
                this.Visible = true;
                var nombreUsuario = usuarioLogueado.Nombre; 
                LblBienvenido.Text = $"Bienvenido {nombreUsuario}!!";
                LblNombreUsuario.Text = $"Usuario conectado: {nombreUsuario}";
                Timer.Enabled = true;
                if (usuarioLogueado.Perfil.Id_Perfil == 3)
                {
                    BtnEmpleados.Visible = false;
                    BtnActividades.Visible = false;
                    BtnPlanes.Visible = false;
                    BtnTurnos.Visible = false;
                    BtnReportes.Visible = false;
                    BtnEstadisticas.Visible = false;
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LblHorario.Text = DateTime.Now.ToString("hh:mm:ss");
            LblFecha.Text = DateTime.Now.ToLongDateString();
        }

        #region Diseño

        private void PersonalizarDiseño()
        {
            panelMantenimientoSubMenu.Visible = false;
            panelPerfilSubMenu.Visible = false;
            panelReportesSubMenu.Visible = false;
            panelEstadisticasSubMenu.Visible = false;
        }

        private void EsconderSubMenu()
        {
            if (panelMantenimientoSubMenu.Visible == true)
                panelMantenimientoSubMenu.Visible = false;
            if (panelPerfilSubMenu.Visible == true)
                panelPerfilSubMenu.Visible = false;
            if (panelReportesSubMenu.Visible == true)
                panelReportesSubMenu.Visible = false;
            if (panelEstadisticasSubMenu.Visible == true)
                panelEstadisticasSubMenu.Visible = false;
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                EsconderSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #endregion

        private void BtnAsistencia_Click(object sender, EventArgs e)
        {
            abrirForm.AbrirFormHijo(new Asistencias(), PanelFormHijo);
            EsconderSubMenu();
        }

        private void BtnMantenimiento_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelMantenimientoSubMenu);
        }
        #region MantenimientoSubMenu

        private void BtnSocios_Click(object sender, EventArgs e)
        {
            abrirForm.AbrirFormHijo(new ConsultaSocios(), PanelFormHijo);
            EsconderSubMenu();
        }

        private void BtnTurnos_Click(object sender, EventArgs e)
        {
            abrirForm.AbrirFormHijo(new ConsultaTurnos(), PanelFormHijo);
            EsconderSubMenu();
        }

        private void BtnActividades_Click(object sender, EventArgs e)
        {
            abrirForm.AbrirFormHijo(new ConsultaActividades(), PanelFormHijo);
            EsconderSubMenu();
        }

        private void BtnPlanes_Click(object sender, EventArgs e)
        {
            abrirForm.AbrirFormHijo(new ConsultaPlanes(), PanelFormHijo);
            EsconderSubMenu();
        }

        private void BtnObjetivos_Click(object sender, EventArgs e)
        {
            abrirForm.AbrirFormHijo(new ConsultaObjetivos(), PanelFormHijo);
            EsconderSubMenu();
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            abrirForm.AbrirFormHijo(new ConsultaEmpleados(), PanelFormHijo);
            EsconderSubMenu();
        }

        private void BtnCiudades_Click(object sender, EventArgs e)
        {
            abrirForm.AbrirFormHijo(new ConsultaCiudades(), PanelFormHijo);
            EsconderSubMenu();
        }
        #endregion

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            abrirForm.AbrirFormHijo(new Facturar(), PanelFormHijo);
            EsconderSubMenu();
        }

        private void BtnPerfil_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelPerfilSubMenu);
        }
        #region PerfilSubMenu
        private void BtnVerPerfil_Click(object sender, EventArgs e)
        {
            abrirForm.AbrirFormHijo(new PerfilPersonal(), PanelFormHijo);
            EsconderSubMenu();
        }

        private void BtnCambiarContraseña_Click(object sender, EventArgs e)
        {
            abrirForm.AbrirFormHijo(new CambiarContraseña(), PanelFormHijo);
            EsconderSubMenu();
        }
        #endregion

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelReportesSubMenu);
        }

        #region ReportesSubMenu

        private void BtnReporteSocios_Click(object sender, EventArgs e)
        {
            abrirForm.AbrirFormHijo(new ReporteSocios(), PanelFormHijo);
            EsconderSubMenu();
        }

        private void BtnReporteFacturas_Click(object sender, EventArgs e)
        {
            abrirForm.AbrirFormHijo(new ReporteFacturas(), PanelFormHijo);
            EsconderSubMenu();
        }

        private void BtnReportePlanes_Click(object sender, EventArgs e)
        {
            abrirForm.AbrirFormHijo(new ReportePlanes(), PanelFormHijo);
            EsconderSubMenu();
        }

        private void BtnReporteTurnos_Click(object sender, EventArgs e)
        {
           abrirForm.AbrirFormHijo(new ReporteTurnos(), PanelFormHijo);
            EsconderSubMenu();
        }

        private void BtnReporteEmpleados_Click(object sender, EventArgs e)
        {
            abrirForm.AbrirFormHijo(new ReporteEmpleados(), PanelFormHijo);
            EsconderSubMenu();
        }

        private void BtnReporteCiudades_Click(object sender, EventArgs e)
        {
            abrirForm.AbrirFormHijo(new ReporteCiudades(), PanelFormHijo);
            EsconderSubMenu();
        }


        private void BtnReporteAsistencias_Click(object sender, EventArgs e)
        {
            abrirForm.AbrirFormHijo(new ReporteAsistencias(), PanelFormHijo);
            EsconderSubMenu();
        }
        #endregion

        private void BtnEstadisticas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelEstadisticasSubMenu);
        }

        #region EstadisticasSubMenu

        private void BtnEstadisticaSocios_Click(object sender, EventArgs e)
        {
            abrirForm.AbrirFormHijo(new EstadisticaSocios(), PanelFormHijo);
            EsconderSubMenu();
        }

        private void BtnEstadisticaFacturas_Click(object sender, EventArgs e)
        {
            abrirForm.AbrirFormHijo(new EstadisticaFacturas(), PanelFormHijo);
            EsconderSubMenu();
        }

        private void BtnEstadisticaPlanes_Click(object sender, EventArgs e)
        {
            abrirForm.AbrirFormHijo(new EstadisticaPlanes(), PanelFormHijo);
            EsconderSubMenu();
        }

        private void BtnEstadisticaTurnos_Click(object sender, EventArgs e)
        {
            abrirForm.AbrirFormHijo(new EstadisticaTurnos(), PanelFormHijo);
            EsconderSubMenu();
        }

        private void BtnEstadisticaEmpleados_Click(object sender, EventArgs e)
        {
            abrirForm.AbrirFormHijo(new EstadisticaEmpleados(), PanelFormHijo);
            EsconderSubMenu();
        }

        private void BtnEstadisticaCiudades_Click(object sender, EventArgs e)
        {
            abrirForm.AbrirFormHijo(new EstadisticaCiudades(), PanelFormHijo);
            EsconderSubMenu();
        }

        private void BtnEstadisticaAsistencias_Click(object sender, EventArgs e)
        {
            abrirForm.AbrirFormHijo(new EstadisticaAsistencias(), PanelFormHijo);
            EsconderSubMenu();
        }
        #endregion

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new MessageBoxPersonalizado();
            resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK)
                Application.Exit();
            else if (resultado == DialogResult.No)
            {
                this.Dispose();
                var PrincipalMenu = new PrincipalMenu();
                PrincipalMenu.Show();
            }
        }

        private void PrincipalMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
