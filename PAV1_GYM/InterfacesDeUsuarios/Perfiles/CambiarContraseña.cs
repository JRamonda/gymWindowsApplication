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

namespace PAV1_GYM.InterfacesDeUsuarios.PerfilUsuario
{
    public partial class CambiarContraseña : Form
    {
        private EmpleadosServicio empleadosServicio;
        private Empleado usuarioLogueado;
        public CambiarContraseña()
        {
            empleadosServicio = new EmpleadosServicio();
            InitializeComponent();
        }

        private void CambiarContraseña_Load(object sender, EventArgs e)
        {
            usuarioLogueado = EmpleadosServicio.UsuarioLogueado;
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsCamposValidos())
                    return;
                if (!EsOperacionConfirmada())
                    return;
                if (!EsContraseñaValida())
                    return;
                ModificarContraseña();
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

        private void ModificarContraseña()
        {
            try
            {
                if (!empleadosServicio.CambiarContraseña(TxtContraseñaNueva.Text, usuarioLogueado.LegajoEmpleado))
                {
                    MessageBox.Show("Problema al cambiar la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("La contraseña se cambio con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            TxtContraseñaActual.Text = "";
            TxtContraseñaNueva.Text = "";
            TxtConfirmarContraseña.Text = "";
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
            if (TxtContraseñaActual.Text.Equals("") || TxtContraseñaNueva.Text.Equals("") || TxtConfirmarContraseña.Text.Equals(""))
            {
                MessageBox.Show("Hay campos sin rellenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool EsContraseñaValida()
        {
            if (TxtContraseñaActual.Text != usuarioLogueado.Password)
            {
                MessageBox.Show("Contraseña actual incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCampos();
                return false;
            }
            if (TxtContraseñaNueva.TextLength > 10)
            {
                MessageBox.Show("La contraseña supera los 10 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TxtContraseñaNueva.Text != TxtConfirmarContraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TxtContraseñaNueva.Text == usuarioLogueado.Password)
            {
                MessageBox.Show("La contraseña es igual a la anterior", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
