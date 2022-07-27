using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV1_GYM.Utils
{
    public class AbrirForm
    {
        private Form formActivo = null;
        public void AbrirFormHijo(Form formHijo, Panel panelHijo)
        {
            if (formActivo != null)
                formActivo.Close();
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelHijo.Controls.Add(formHijo);
            panelHijo.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }
    }
}
