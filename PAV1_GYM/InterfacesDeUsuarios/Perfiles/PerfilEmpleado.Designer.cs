namespace PAV1_GYM.InterfacesDeUsuarios.Perfiles
{
    partial class PerfilEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSalir = new System.Windows.Forms.Button();
            this.GbPerfil = new System.Windows.Forms.GroupBox();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblActividadyTurno = new System.Windows.Forms.Label();
            this.PbFem = new System.Windows.Forms.PictureBox();
            this.PbMasc = new System.Windows.Forms.PictureBox();
            this.LblLegajoEmpleado = new System.Windows.Forms.Label();
            this.LblCodigoPostal = new System.Windows.Forms.Label();
            this.LblCiudad = new System.Windows.Forms.Label();
            this.LblPerfil = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblEdad = new System.Windows.Forms.Label();
            this.LblFechaNac = new System.Windows.Forms.Label();
            this.LblTipoDoc = new System.Windows.Forms.Label();
            this.LblNroDoc = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblFechaBaja = new System.Windows.Forms.Label();
            this.LblFechaIngreso = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.GbPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbFem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMasc)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.ForeColor = System.Drawing.Color.LightGray;
            this.BtnSalir.Location = new System.Drawing.Point(499, 425);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(93, 31);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // GbPerfil
            // 
            this.GbPerfil.Controls.Add(this.LblFechaBaja);
            this.GbPerfil.Controls.Add(this.LblFechaIngreso);
            this.GbPerfil.Controls.Add(this.LblEstado);
            this.GbPerfil.Controls.Add(this.LblSexo);
            this.GbPerfil.Controls.Add(this.LblActividadyTurno);
            this.GbPerfil.Controls.Add(this.PbFem);
            this.GbPerfil.Controls.Add(this.PbMasc);
            this.GbPerfil.Controls.Add(this.LblLegajoEmpleado);
            this.GbPerfil.Controls.Add(this.LblCodigoPostal);
            this.GbPerfil.Controls.Add(this.LblCiudad);
            this.GbPerfil.Controls.Add(this.LblPerfil);
            this.GbPerfil.Controls.Add(this.LblDireccion);
            this.GbPerfil.Controls.Add(this.LblTelefono);
            this.GbPerfil.Controls.Add(this.LblEmail);
            this.GbPerfil.Controls.Add(this.LblEdad);
            this.GbPerfil.Controls.Add(this.LblFechaNac);
            this.GbPerfil.Controls.Add(this.LblTipoDoc);
            this.GbPerfil.Controls.Add(this.LblNroDoc);
            this.GbPerfil.Controls.Add(this.LblApellido);
            this.GbPerfil.Controls.Add(this.LblNombre);
            this.GbPerfil.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.GbPerfil.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.GbPerfil.Location = new System.Drawing.Point(12, 12);
            this.GbPerfil.Name = "GbPerfil";
            this.GbPerfil.Size = new System.Drawing.Size(580, 398);
            this.GbPerfil.TabIndex = 7;
            this.GbPerfil.TabStop = false;
            this.GbPerfil.Text = "Perfil";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblSexo.Location = new System.Drawing.Point(22, 212);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(51, 22);
            this.LblSexo.TabIndex = 24;
            this.LblSexo.Text = "Sexo:";
            // 
            // LblActividadyTurno
            // 
            this.LblActividadyTurno.AutoSize = true;
            this.LblActividadyTurno.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblActividadyTurno.Location = new System.Drawing.Point(22, 344);
            this.LblActividadyTurno.Name = "LblActividadyTurno";
            this.LblActividadyTurno.Size = new System.Drawing.Size(148, 22);
            this.LblActividadyTurno.TabIndex = 23;
            this.LblActividadyTurno.Text = "Actividad y Turno:";
            this.LblActividadyTurno.Visible = false;
            // 
            // PbFem
            // 
            this.PbFem.Image = global::PAV1_GYM.Properties.Resources.PerfilF;
            this.PbFem.Location = new System.Drawing.Point(455, 25);
            this.PbFem.Name = "PbFem";
            this.PbFem.Size = new System.Drawing.Size(98, 104);
            this.PbFem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbFem.TabIndex = 22;
            this.PbFem.TabStop = false;
            this.PbFem.Visible = false;
            // 
            // PbMasc
            // 
            this.PbMasc.Image = global::PAV1_GYM.Properties.Resources.PerfilM;
            this.PbMasc.Location = new System.Drawing.Point(455, 25);
            this.PbMasc.Name = "PbMasc";
            this.PbMasc.Size = new System.Drawing.Size(98, 104);
            this.PbMasc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbMasc.TabIndex = 21;
            this.PbMasc.TabStop = false;
            this.PbMasc.Visible = false;
            // 
            // LblLegajoEmpleado
            // 
            this.LblLegajoEmpleado.AutoSize = true;
            this.LblLegajoEmpleado.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblLegajoEmpleado.Location = new System.Drawing.Point(22, 27);
            this.LblLegajoEmpleado.Name = "LblLegajoEmpleado";
            this.LblLegajoEmpleado.Size = new System.Drawing.Size(65, 22);
            this.LblLegajoEmpleado.TabIndex = 18;
            this.LblLegajoEmpleado.Text = "Legajo:";
            // 
            // LblCodigoPostal
            // 
            this.LblCodigoPostal.AutoSize = true;
            this.LblCodigoPostal.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblCodigoPostal.Location = new System.Drawing.Point(22, 256);
            this.LblCodigoPostal.Name = "LblCodigoPostal";
            this.LblCodigoPostal.Size = new System.Drawing.Size(118, 22);
            this.LblCodigoPostal.TabIndex = 17;
            this.LblCodigoPostal.Text = "Código Postal:";
            // 
            // LblCiudad
            // 
            this.LblCiudad.AutoSize = true;
            this.LblCiudad.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblCiudad.Location = new System.Drawing.Point(22, 234);
            this.LblCiudad.Name = "LblCiudad";
            this.LblCiudad.Size = new System.Drawing.Size(68, 22);
            this.LblCiudad.TabIndex = 16;
            this.LblCiudad.Text = "Ciudad:";
            // 
            // LblPerfil
            // 
            this.LblPerfil.AutoSize = true;
            this.LblPerfil.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblPerfil.Location = new System.Drawing.Point(22, 49);
            this.LblPerfil.Name = "LblPerfil";
            this.LblPerfil.Size = new System.Drawing.Size(54, 22);
            this.LblPerfil.TabIndex = 11;
            this.LblPerfil.Text = "Perfil:";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblDireccion.Location = new System.Drawing.Point(22, 278);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(85, 22);
            this.LblDireccion.TabIndex = 9;
            this.LblDireccion.Text = "Direccion:";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblTelefono.Location = new System.Drawing.Point(22, 300);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(80, 22);
            this.LblTelefono.TabIndex = 8;
            this.LblTelefono.Text = "Telefono:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblEmail.Location = new System.Drawing.Point(22, 322);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(56, 22);
            this.LblEmail.TabIndex = 7;
            this.LblEmail.Text = "Email:";
            // 
            // LblEdad
            // 
            this.LblEdad.AutoSize = true;
            this.LblEdad.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblEdad.Location = new System.Drawing.Point(22, 189);
            this.LblEdad.Name = "LblEdad";
            this.LblEdad.Size = new System.Drawing.Size(53, 22);
            this.LblEdad.TabIndex = 5;
            this.LblEdad.Text = "Edad:";
            // 
            // LblFechaNac
            // 
            this.LblFechaNac.AutoSize = true;
            this.LblFechaNac.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblFechaNac.Location = new System.Drawing.Point(22, 167);
            this.LblFechaNac.Name = "LblFechaNac";
            this.LblFechaNac.Size = new System.Drawing.Size(173, 22);
            this.LblFechaNac.TabIndex = 4;
            this.LblFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // LblTipoDoc
            // 
            this.LblTipoDoc.AutoSize = true;
            this.LblTipoDoc.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblTipoDoc.Location = new System.Drawing.Point(22, 145);
            this.LblTipoDoc.Name = "LblTipoDoc";
            this.LblTipoDoc.Size = new System.Drawing.Size(141, 22);
            this.LblTipoDoc.TabIndex = 3;
            this.LblTipoDoc.Text = "Tipo Documento:";
            // 
            // LblNroDoc
            // 
            this.LblNroDoc.AutoSize = true;
            this.LblNroDoc.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblNroDoc.Location = new System.Drawing.Point(22, 120);
            this.LblNroDoc.Name = "LblNroDoc";
            this.LblNroDoc.Size = new System.Drawing.Size(136, 22);
            this.LblNroDoc.TabIndex = 2;
            this.LblNroDoc.Text = "Nro Documento:";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblApellido.Location = new System.Drawing.Point(22, 96);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(77, 22);
            this.LblApellido.TabIndex = 1;
            this.LblApellido.Text = "Apellido:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblNombre.Location = new System.Drawing.Point(22, 71);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(77, 22);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblFechaBaja
            // 
            this.LblFechaBaja.AutoSize = true;
            this.LblFechaBaja.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblFechaBaja.Location = new System.Drawing.Point(462, 226);
            this.LblFechaBaja.Name = "LblFechaBaja";
            this.LblFechaBaja.Size = new System.Drawing.Size(87, 22);
            this.LblFechaBaja.TabIndex = 30;
            this.LblFechaBaja.Text = "FechaBaja";
            this.LblFechaBaja.Visible = false;
            // 
            // LblFechaIngreso
            // 
            this.LblFechaIngreso.AutoSize = true;
            this.LblFechaIngreso.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblFechaIngreso.Location = new System.Drawing.Point(462, 182);
            this.LblFechaIngreso.Name = "LblFechaIngreso";
            this.LblFechaIngreso.Size = new System.Drawing.Size(110, 22);
            this.LblFechaIngreso.TabIndex = 29;
            this.LblFechaIngreso.Text = "FechaIngreso";
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblEstado.Location = new System.Drawing.Point(483, 145);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(61, 22);
            this.LblEstado.TabIndex = 28;
            this.LblEstado.Text = "Estado";
            // 
            // PerfilEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(607, 477);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.GbPerfil);
            this.Name = "PerfilEmpleado";
            this.Text = "Perfil Empleado";
            this.Load += new System.EventHandler(this.PerfilEmpleado_Load);
            this.GbPerfil.ResumeLayout(false);
            this.GbPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbFem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMasc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.GroupBox GbPerfil;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblActividadyTurno;
        private System.Windows.Forms.PictureBox PbFem;
        private System.Windows.Forms.PictureBox PbMasc;
        private System.Windows.Forms.Label LblLegajoEmpleado;
        private System.Windows.Forms.Label LblCodigoPostal;
        private System.Windows.Forms.Label LblCiudad;
        private System.Windows.Forms.Label LblPerfil;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblEdad;
        private System.Windows.Forms.Label LblFechaNac;
        private System.Windows.Forms.Label LblTipoDoc;
        private System.Windows.Forms.Label LblNroDoc;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblFechaBaja;
        private System.Windows.Forms.Label LblFechaIngreso;
        private System.Windows.Forms.Label LblEstado;
    }
}