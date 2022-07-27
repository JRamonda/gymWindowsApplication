namespace PAV1_GYM.Reportes
{
    partial class ReporteAsistencias
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
            this.PanelFormHijo = new System.Windows.Forms.Panel();
            this.TCAsistencias = new System.Windows.Forms.TabControl();
            this.TPAsistencia = new System.Windows.Forms.TabPage();
            this.ChFiltrarFecha = new System.Windows.Forms.CheckBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnBuscarAsistencia = new System.Windows.Forms.Button();
            this.DtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.RvAsistencias = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LblFechaHasta = new System.Windows.Forms.Label();
            this.LblFechaDesde = new System.Windows.Forms.Label();
            this.LblReportes = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.RbMasc = new System.Windows.Forms.RadioButton();
            this.RbFem = new System.Windows.Forms.RadioButton();
            this.CbTurno = new System.Windows.Forms.ComboBox();
            this.CbActividad = new System.Windows.Forms.ComboBox();
            this.LblTurno = new System.Windows.Forms.Label();
            this.LblActividad = new System.Windows.Forms.Label();
            this.PanelFormHijo.SuspendLayout();
            this.TCAsistencias.SuspendLayout();
            this.TPAsistencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFormHijo
            // 
            this.PanelFormHijo.AutoScroll = true;
            this.PanelFormHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.PanelFormHijo.Controls.Add(this.TCAsistencias);
            this.PanelFormHijo.Controls.Add(this.LblReportes);
            this.PanelFormHijo.Controls.Add(this.BtnSalir);
            this.PanelFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormHijo.Location = new System.Drawing.Point(0, 0);
            this.PanelFormHijo.Name = "PanelFormHijo";
            this.PanelFormHijo.Size = new System.Drawing.Size(800, 450);
            this.PanelFormHijo.TabIndex = 4;
            // 
            // TCAsistencias
            // 
            this.TCAsistencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TCAsistencias.Controls.Add(this.TPAsistencia);
            this.TCAsistencias.Location = new System.Drawing.Point(28, 50);
            this.TCAsistencias.Name = "TCAsistencias";
            this.TCAsistencias.SelectedIndex = 0;
            this.TCAsistencias.Size = new System.Drawing.Size(749, 341);
            this.TCAsistencias.TabIndex = 43;
            // 
            // TPAsistencia
            // 
            this.TPAsistencia.Controls.Add(this.CbTurno);
            this.TPAsistencia.Controls.Add(this.CbActividad);
            this.TPAsistencia.Controls.Add(this.LblTurno);
            this.TPAsistencia.Controls.Add(this.LblActividad);
            this.TPAsistencia.Controls.Add(this.RbFem);
            this.TPAsistencia.Controls.Add(this.RbMasc);
            this.TPAsistencia.Controls.Add(this.ChFiltrarFecha);
            this.TPAsistencia.Controls.Add(this.BtnLimpiar);
            this.TPAsistencia.Controls.Add(this.BtnBuscarAsistencia);
            this.TPAsistencia.Controls.Add(this.DtpFechaHasta);
            this.TPAsistencia.Controls.Add(this.DtpFechaDesde);
            this.TPAsistencia.Controls.Add(this.RvAsistencias);
            this.TPAsistencia.Controls.Add(this.LblFechaHasta);
            this.TPAsistencia.Controls.Add(this.LblFechaDesde);
            this.TPAsistencia.Location = new System.Drawing.Point(4, 22);
            this.TPAsistencia.Name = "TPAsistencia";
            this.TPAsistencia.Padding = new System.Windows.Forms.Padding(3);
            this.TPAsistencia.Size = new System.Drawing.Size(741, 315);
            this.TPAsistencia.TabIndex = 0;
            this.TPAsistencia.Text = "Asistencias";
            this.TPAsistencia.UseVisualStyleBackColor = true;
            // 
            // ChFiltrarFecha
            // 
            this.ChFiltrarFecha.AutoSize = true;
            this.ChFiltrarFecha.Location = new System.Drawing.Point(385, 10);
            this.ChFiltrarFecha.Name = "ChFiltrarFecha";
            this.ChFiltrarFecha.Size = new System.Drawing.Size(99, 17);
            this.ChFiltrarFecha.TabIndex = 70;
            this.ChFiltrarFecha.Text = "Filtrar por fecha";
            this.ChFiltrarFecha.UseVisualStyleBackColor = true;
            this.ChFiltrarFecha.CheckedChanged += new System.EventHandler(this.ChFiltrarFecha_CheckedChanged);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnLimpiar.Location = new System.Drawing.Point(660, 34);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 48;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnBuscarAsistencia
            // 
            this.BtnBuscarAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarAsistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnBuscarAsistencia.FlatAppearance.BorderSize = 0;
            this.BtnBuscarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnBuscarAsistencia.ForeColor = System.Drawing.Color.LightGray;
            this.BtnBuscarAsistencia.Location = new System.Drawing.Point(660, 5);
            this.BtnBuscarAsistencia.Name = "BtnBuscarAsistencia";
            this.BtnBuscarAsistencia.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarAsistencia.TabIndex = 47;
            this.BtnBuscarAsistencia.Text = "Buscar";
            this.BtnBuscarAsistencia.UseVisualStyleBackColor = false;
            this.BtnBuscarAsistencia.Click += new System.EventHandler(this.BtnBuscarAsistencia_Click);
            // 
            // DtpFechaHasta
            // 
            this.DtpFechaHasta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DtpFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaHasta.Location = new System.Drawing.Point(279, 6);
            this.DtpFechaHasta.Name = "DtpFechaHasta";
            this.DtpFechaHasta.Size = new System.Drawing.Size(100, 21);
            this.DtpFechaHasta.TabIndex = 46;
            // 
            // DtpFechaDesde
            // 
            this.DtpFechaDesde.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DtpFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaDesde.Location = new System.Drawing.Point(90, 6);
            this.DtpFechaDesde.Name = "DtpFechaDesde";
            this.DtpFechaDesde.Size = new System.Drawing.Size(100, 21);
            this.DtpFechaDesde.TabIndex = 45;
            // 
            // RvAsistencias
            // 
            this.RvAsistencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RvAsistencias.LocalReport.ReportEmbeddedResource = "PAV1_GYM.Reportes.Rdlc.Rpt_Asistencias.rdlc";
            this.RvAsistencias.Location = new System.Drawing.Point(6, 63);
            this.RvAsistencias.Name = "RvAsistencias";
            this.RvAsistencias.ServerReport.BearerToken = null;
            this.RvAsistencias.Size = new System.Drawing.Size(729, 246);
            this.RvAsistencias.TabIndex = 44;
            this.RvAsistencias.Load += new System.EventHandler(this.RvAsistencias_Load);
            // 
            // LblFechaHasta
            // 
            this.LblFechaHasta.AutoSize = true;
            this.LblFechaHasta.Font = new System.Drawing.Font("Calibri", 10F);
            this.LblFechaHasta.ForeColor = System.Drawing.Color.Black;
            this.LblFechaHasta.Location = new System.Drawing.Point(196, 10);
            this.LblFechaHasta.Name = "LblFechaHasta";
            this.LblFechaHasta.Size = new System.Drawing.Size(77, 17);
            this.LblFechaHasta.TabIndex = 42;
            this.LblFechaHasta.Text = "Fecha Hasta";
            // 
            // LblFechaDesde
            // 
            this.LblFechaDesde.AutoSize = true;
            this.LblFechaDesde.Font = new System.Drawing.Font("Calibri", 10F);
            this.LblFechaDesde.ForeColor = System.Drawing.Color.Black;
            this.LblFechaDesde.Location = new System.Drawing.Point(6, 10);
            this.LblFechaDesde.Name = "LblFechaDesde";
            this.LblFechaDesde.Size = new System.Drawing.Size(79, 17);
            this.LblFechaDesde.TabIndex = 41;
            this.LblFechaDesde.Text = "Fecha Desde";
            // 
            // LblReportes
            // 
            this.LblReportes.AutoSize = true;
            this.LblReportes.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.LblReportes.ForeColor = System.Drawing.Color.Silver;
            this.LblReportes.Location = new System.Drawing.Point(23, 9);
            this.LblReportes.Name = "LblReportes";
            this.LblReportes.Size = new System.Drawing.Size(241, 29);
            this.LblReportes.TabIndex = 15;
            this.LblReportes.Text = "Reporte de Asistencias";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.ForeColor = System.Drawing.Color.LightGray;
            this.BtnSalir.Location = new System.Drawing.Point(697, 408);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(80, 30);
            this.BtnSalir.TabIndex = 13;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // RbMasc
            // 
            this.RbMasc.AutoSize = true;
            this.RbMasc.Location = new System.Drawing.Point(9, 34);
            this.RbMasc.Name = "RbMasc";
            this.RbMasc.Size = new System.Drawing.Size(78, 17);
            this.RbMasc.TabIndex = 71;
            this.RbMasc.TabStop = true;
            this.RbMasc.Text = "Masculinos";
            this.RbMasc.UseVisualStyleBackColor = true;
            // 
            // RbFem
            // 
            this.RbFem.AutoSize = true;
            this.RbFem.Location = new System.Drawing.Point(90, 34);
            this.RbFem.Name = "RbFem";
            this.RbFem.Size = new System.Drawing.Size(76, 17);
            this.RbFem.TabIndex = 72;
            this.RbFem.TabStop = true;
            this.RbFem.Text = "Femeninos";
            this.RbFem.UseVisualStyleBackColor = true;
            // 
            // CbTurno
            // 
            this.CbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTurno.FormattingEnabled = true;
            this.CbTurno.Location = new System.Drawing.Point(384, 32);
            this.CbTurno.Name = "CbTurno";
            this.CbTurno.Size = new System.Drawing.Size(100, 21);
            this.CbTurno.TabIndex = 76;
            // 
            // CbActividad
            // 
            this.CbActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbActividad.FormattingEnabled = true;
            this.CbActividad.Location = new System.Drawing.Point(238, 32);
            this.CbActividad.Name = "CbActividad";
            this.CbActividad.Size = new System.Drawing.Size(100, 21);
            this.CbActividad.TabIndex = 75;
            // 
            // LblTurno
            // 
            this.LblTurno.AutoSize = true;
            this.LblTurno.Font = new System.Drawing.Font("Calibri", 10F);
            this.LblTurno.ForeColor = System.Drawing.Color.Black;
            this.LblTurno.Location = new System.Drawing.Point(346, 34);
            this.LblTurno.Name = "LblTurno";
            this.LblTurno.Size = new System.Drawing.Size(40, 17);
            this.LblTurno.TabIndex = 74;
            this.LblTurno.Text = "Turno";
            // 
            // LblActividad
            // 
            this.LblActividad.AutoSize = true;
            this.LblActividad.Font = new System.Drawing.Font("Calibri", 10F);
            this.LblActividad.ForeColor = System.Drawing.Color.Black;
            this.LblActividad.Location = new System.Drawing.Point(172, 34);
            this.LblActividad.Name = "LblActividad";
            this.LblActividad.Size = new System.Drawing.Size(60, 17);
            this.LblActividad.TabIndex = 73;
            this.LblActividad.Text = "Actividad";
            // 
            // ReporteAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelFormHijo);
            this.Name = "ReporteAsistencias";
            this.Text = "ReporteAsistencias";
            this.Load += new System.EventHandler(this.ReporteAsistencias_Load);
            this.PanelFormHijo.ResumeLayout(false);
            this.PanelFormHijo.PerformLayout();
            this.TCAsistencias.ResumeLayout(false);
            this.TPAsistencia.ResumeLayout(false);
            this.TPAsistencia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFormHijo;
        private System.Windows.Forms.TabControl TCAsistencias;
        private System.Windows.Forms.TabPage TPAsistencia;
        private System.Windows.Forms.CheckBox ChFiltrarFecha;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnBuscarAsistencia;
        private System.Windows.Forms.DateTimePicker DtpFechaHasta;
        private System.Windows.Forms.DateTimePicker DtpFechaDesde;
        private Microsoft.Reporting.WinForms.ReportViewer RvAsistencias;
        private System.Windows.Forms.Label LblFechaHasta;
        private System.Windows.Forms.Label LblFechaDesde;
        private System.Windows.Forms.Label LblReportes;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.RadioButton RbFem;
        private System.Windows.Forms.RadioButton RbMasc;
        private System.Windows.Forms.ComboBox CbTurno;
        private System.Windows.Forms.ComboBox CbActividad;
        private System.Windows.Forms.Label LblTurno;
        private System.Windows.Forms.Label LblActividad;
    }
}