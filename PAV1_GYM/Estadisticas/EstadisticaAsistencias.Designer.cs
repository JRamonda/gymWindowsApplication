namespace PAV1_GYM.Estadisticas
{
    partial class EstadisticaAsistencias
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
            this.TPAsistencias = new System.Windows.Forms.TabPage();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnBuscarAsistencia = new System.Windows.Forms.Button();
            this.DtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.RvAsistencias = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LblFechaHasta = new System.Windows.Forms.Label();
            this.LblFechaDesde = new System.Windows.Forms.Label();
            this.LblEstadistica = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.RbTodasAsistencias = new System.Windows.Forms.RadioButton();
            this.RbAsistenciasConfirmadas = new System.Windows.Forms.RadioButton();
            this.ChFiltrarFecha = new System.Windows.Forms.CheckBox();
            this.PanelFormHijo.SuspendLayout();
            this.TCAsistencias.SuspendLayout();
            this.TPAsistencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFormHijo
            // 
            this.PanelFormHijo.AutoScroll = true;
            this.PanelFormHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.PanelFormHijo.Controls.Add(this.TCAsistencias);
            this.PanelFormHijo.Controls.Add(this.LblEstadistica);
            this.PanelFormHijo.Controls.Add(this.BtnSalir);
            this.PanelFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormHijo.Location = new System.Drawing.Point(0, 0);
            this.PanelFormHijo.Name = "PanelFormHijo";
            this.PanelFormHijo.Size = new System.Drawing.Size(800, 450);
            this.PanelFormHijo.TabIndex = 5;
            // 
            // TCAsistencias
            // 
            this.TCAsistencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TCAsistencias.Controls.Add(this.TPAsistencias);
            this.TCAsistencias.Location = new System.Drawing.Point(28, 50);
            this.TCAsistencias.Name = "TCAsistencias";
            this.TCAsistencias.SelectedIndex = 0;
            this.TCAsistencias.Size = new System.Drawing.Size(749, 341);
            this.TCAsistencias.TabIndex = 43;
            // 
            // TPAsistencias
            // 
            this.TPAsistencias.Controls.Add(this.ChFiltrarFecha);
            this.TPAsistencias.Controls.Add(this.RbAsistenciasConfirmadas);
            this.TPAsistencias.Controls.Add(this.RbTodasAsistencias);
            this.TPAsistencias.Controls.Add(this.BtnLimpiar);
            this.TPAsistencias.Controls.Add(this.BtnBuscarAsistencia);
            this.TPAsistencias.Controls.Add(this.DtpFechaHasta);
            this.TPAsistencias.Controls.Add(this.DtpFechaDesde);
            this.TPAsistencias.Controls.Add(this.RvAsistencias);
            this.TPAsistencias.Controls.Add(this.LblFechaHasta);
            this.TPAsistencias.Controls.Add(this.LblFechaDesde);
            this.TPAsistencias.Location = new System.Drawing.Point(4, 22);
            this.TPAsistencias.Name = "TPAsistencias";
            this.TPAsistencias.Padding = new System.Windows.Forms.Padding(3);
            this.TPAsistencias.Size = new System.Drawing.Size(741, 315);
            this.TPAsistencias.TabIndex = 0;
            this.TPAsistencias.Text = "Asistencias";
            this.TPAsistencias.UseVisualStyleBackColor = true;
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
            this.DtpFechaHasta.Enabled = false;
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
            this.DtpFechaDesde.Enabled = false;
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
            this.RvAsistencias.LocalReport.ReportEmbeddedResource = "PAV1_GYM.Estadisticas.Rdlc.EstadisticaAsistencias.rdlc";
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
            // LblEstadistica
            // 
            this.LblEstadistica.AutoSize = true;
            this.LblEstadistica.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.LblEstadistica.ForeColor = System.Drawing.Color.Silver;
            this.LblEstadistica.Location = new System.Drawing.Point(23, 9);
            this.LblEstadistica.Name = "LblEstadistica";
            this.LblEstadistica.Size = new System.Drawing.Size(277, 29);
            this.LblEstadistica.TabIndex = 15;
            this.LblEstadistica.Text = "Estadisticas de Asistencias";
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
            // RbTodasAsistencias
            // 
            this.RbTodasAsistencias.AutoSize = true;
            this.RbTodasAsistencias.Location = new System.Drawing.Point(9, 34);
            this.RbTodasAsistencias.Name = "RbTodasAsistencias";
            this.RbTodasAsistencias.Size = new System.Drawing.Size(126, 17);
            this.RbTodasAsistencias.TabIndex = 49;
            this.RbTodasAsistencias.TabStop = true;
            this.RbTodasAsistencias.Text = "Todas las asistencias";
            this.RbTodasAsistencias.UseVisualStyleBackColor = true;
            // 
            // RbAsistenciasConfirmadas
            // 
            this.RbAsistenciasConfirmadas.AutoSize = true;
            this.RbAsistenciasConfirmadas.Location = new System.Drawing.Point(141, 34);
            this.RbAsistenciasConfirmadas.Name = "RbAsistenciasConfirmadas";
            this.RbAsistenciasConfirmadas.Size = new System.Drawing.Size(139, 17);
            this.RbAsistenciasConfirmadas.TabIndex = 50;
            this.RbAsistenciasConfirmadas.TabStop = true;
            this.RbAsistenciasConfirmadas.Text = "Asistencias Confirmadas";
            this.RbAsistenciasConfirmadas.UseVisualStyleBackColor = true;
            // 
            // ChFiltrarFecha
            // 
            this.ChFiltrarFecha.AutoSize = true;
            this.ChFiltrarFecha.Location = new System.Drawing.Point(385, 10);
            this.ChFiltrarFecha.Name = "ChFiltrarFecha";
            this.ChFiltrarFecha.Size = new System.Drawing.Size(99, 17);
            this.ChFiltrarFecha.TabIndex = 62;
            this.ChFiltrarFecha.Text = "Filtrar por fecha";
            this.ChFiltrarFecha.UseVisualStyleBackColor = true;
            // 
            // EstadisticaAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelFormHijo);
            this.Name = "EstadisticaAsistencias";
            this.Text = "EstadisticaAsistencias";
            this.Load += new System.EventHandler(this.EstadisticaAsistencias_Load);
            this.PanelFormHijo.ResumeLayout(false);
            this.PanelFormHijo.PerformLayout();
            this.TCAsistencias.ResumeLayout(false);
            this.TPAsistencias.ResumeLayout(false);
            this.TPAsistencias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFormHijo;
        private System.Windows.Forms.TabControl TCAsistencias;
        private System.Windows.Forms.TabPage TPAsistencias;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnBuscarAsistencia;
        private System.Windows.Forms.DateTimePicker DtpFechaHasta;
        private System.Windows.Forms.DateTimePicker DtpFechaDesde;
        private Microsoft.Reporting.WinForms.ReportViewer RvAsistencias;
        private System.Windows.Forms.Label LblFechaHasta;
        private System.Windows.Forms.Label LblFechaDesde;
        private System.Windows.Forms.Label LblEstadistica;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.RadioButton RbAsistenciasConfirmadas;
        private System.Windows.Forms.RadioButton RbTodasAsistencias;
        private System.Windows.Forms.CheckBox ChFiltrarFecha;
    }
}