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

namespace PAV1_GYM.InterfacesDeUsuarios
{
    public partial class Login : Form
    {
        private EmpleadosServicio empleadosServicio;
        private bool usuarioCargado;

        public Login()
        {
            InitializeComponent();
            empleadosServicio = new EmpleadosServicio();
        }

        private void LimpiarCampos()
        {
            TxtUsuario.Text = "";
            TxtContraseña.Text = "";
            TxtUsuario.Focus();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Empleado usuario = new Empleado();
            int legajoEmpleado;
            int.TryParse(TxtUsuario.Text, out legajoEmpleado);
            usuario.LegajoEmpleado = legajoEmpleado;
            usuario.Password = TxtContraseña.Text;
            var usuarioLogueado = empleadosServicio.Login(usuario);
            if (usuarioLogueado == null)
            {
                MessageBox.Show("Usuario/contraseña inválida", "Información", MessageBoxButtons.OK);
                LimpiarCampos();
            }
            else
            {
                usuarioCargado = true;
                this.Dispose();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!usuarioCargado)
            {
                Application.Exit();
            }
        }
    }
}
