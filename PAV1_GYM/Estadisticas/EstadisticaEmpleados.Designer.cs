namespace PAV1_GYM.Estadisticas
{
    partial class EstadisticaEmpleados
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
            this.TCEmpleados = new System.Windows.Forms.TabControl();
            this.TpEmpleados = new System.Windows.Forms.TabPage();
            this.BtnLimpiar1 = new System.Windows.Forms.Button();
            this.BtnBuscar1 = new System.Windows.Forms.Button();
            this.RvEmpleados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.LblFechaHasta = new System.Windows.Forms.Label();
            this.LblFechaDesde = new System.Windows.Forms.Label();
            this.TpAcyTur = new System.Windows.Forms.TabPage();
            this.BtnLimpiar2 = new System.Windows.Forms.Button();
            this.BtnBuscar2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RbFem = new System.Windows.Forms.RadioButton();
            this.RbMasc = new System.Windows.Forms.RadioButton();
            this.LblEdadHasta = new System.Windows.Forms.Label();
            this.LblEdadDesde = new System.Windows.Forms.Label();
            this.TxtEdadInicio = new System.Windows.Forms.TextBox();
            this.TxtEdadFin = new System.Windows.Forms.TextBox();
            this.RvEntrenadoresXActividad = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbFiltroSexo = new System.Windows.Forms.RadioButton();
            this.RbFiltroEdad = new System.Windows.Forms.RadioButton();
            this.LblEstadistica = new System.Windows.Forms.Label();
            this.RvEntrenadoresXTurno = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TCEmpleados.SuspendLayout();
            this.TpEmpleados.SuspendLayout();
            this.TpAcyTur.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.ForeColor = System.Drawing.Color.LightGray;
            this.BtnSalir.Location = new System.Drawing.Point(607, 390);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(100, 30);
            this.BtnSalir.TabIndex = 20;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TCEmpleados
            // 
            this.TCEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TCEmpleados.Controls.Add(this.TpEmpleados);
            this.TCEmpleados.Controls.Add(this.TpAcyTur);
            this.TCEmpleados.Location = new System.Drawing.Point(15, 57);
            this.TCEmpleados.Name = "TCEmpleados";
            this.TCEmpleados.SelectedIndex = 0;
            this.TCEmpleados.Size = new System.Drawing.Size(690, 317);
            this.TCEmpleados.TabIndex = 18;
            // 
            // TpEmpleados
            // 
            this.TpEmpleados.Controls.Add(this.BtnLimpiar1);
            this.TpEmpleados.Controls.Add(this.BtnBuscar1);
            this.TpEmpleados.Controls.Add(this.RvEmpleados);
            this.TpEmpleados.Controls.Add(this.DtpFechaHasta);
            this.TpEmpleados.Controls.Add(this.DtpFechaDesde);
            this.TpEmpleados.Controls.Add(this.LblFechaHasta);
            this.TpEmpleados.Controls.Add(this.LblFechaDesde);
            this.TpEmpleados.Location = new System.Drawing.Point(4, 22);
            this.TpEmpleados.Name = "TpEmpleados";
            this.TpEmpleados.Padding = new System.Windows.Forms.Padding(3);
            this.TpEmpleados.Size = new System.Drawing.Size(682, 291);
            this.TpEmpleados.TabIndex = 0;
            this.TpEmpleados.Text = "Empleados";
            this.TpEmpleados.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiar1
            // 
            this.BtnLimpiar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnLimpiar1.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar1.ForeColor = System.Drawing.Color.LightGray;
            this.BtnLimpiar1.Location = new System.Drawing.Point(601, 33);
            this.BtnLimpiar1.Name = "BtnLimpiar1";
            this.BtnLimpiar1.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar1.TabIndex = 59;
            this.BtnLimpiar1.Text = "Limpiar";
            this.BtnLimpiar1.UseVisualStyleBackColor = false;
            this.BtnLimpiar1.Click += new System.EventHandler(this.BtnLimpiar1_Click);
            // 
            // BtnBuscar1
            // 
            this.BtnBuscar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnBuscar1.FlatAppearance.BorderSize = 0;
            this.BtnBuscar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnBuscar1.ForeColor = System.Drawing.Color.LightGray;
            this.BtnBuscar1.Location = new System.Drawing.Point(601, 4);
            this.BtnBuscar1.Name = "BtnBuscar1";
            this.BtnBuscar1.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar1.TabIndex = 58;
            this.BtnBuscar1.Text = "Buscar";
            this.BtnBuscar1.UseVisualStyleBackColor = false;
            this.BtnBuscar1.Click += new System.EventHandler(this.BtnBuscar1_Click);
            // 
            // RvEmpleados
            // 
            this.RvEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RvEmpleados.LocalReport.ReportEmbeddedResource = "PAV1_GYM.Estadisticas.Rdlc.EstadisticasEmpleados.rdlc";
            this.RvEmpleados.Location = new System.Drawing.Point(3, 69);
            this.RvEmpleados.Name = "RvEmpleados";
            this.RvEmpleados.ServerReport.BearerToken = null;
            this.RvEmpleados.Size = new System.Drawing.Size(676, 219);
            this.RvEmpleados.TabIndex = 57;
            this.RvEmpleados.Load += new System.EventHandler(this.RvEmpleados_Load);
            // 
            // DtpFechaHasta
            // 
            this.DtpFechaHasta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DtpFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaHasta.Location = new System.Drawing.Point(282, 6);
            this.DtpFechaHasta.Name = "DtpFechaHasta";
            this.DtpFechaHasta.Size = new System.Drawing.Size(100, 21);
            this.DtpFechaHasta.TabIndex = 56;
            // 
            // DtpFechaDesde
            // 
            this.DtpFechaDesde.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DtpFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaDesde.Location = new System.Drawing.Point(93, 6);
            this.DtpFechaDesde.Name = "DtpFechaDesde";
            this.DtpFechaDesde.Size = new System.Drawing.Size(100, 21);
            this.DtpFechaDesde.TabIndex = 55;
            // 
            // LblFechaHasta
            // 
            this.LblFechaHasta.AutoSize = true;
            this.LblFechaHasta.Font = new System.Drawing.Font("Calibri", 10F);
            this.LblFechaHasta.ForeColor = System.Drawing.Color.Black;
            this.LblFechaHasta.Location = new System.Drawing.Point(199, 10);
            this.LblFechaHasta.Name = "LblFechaHasta";
            this.LblFechaHasta.Size = new System.Drawing.Size(77, 17);
            this.LblFechaHasta.TabIndex = 54;
            this.LblFechaHasta.Text = "Fecha Hasta";
            // 
            // LblFechaDesde
            // 
            this.LblFechaDesde.AutoSize = true;
            this.LblFechaDesde.Font = new System.Drawing.Font("Calibri", 10F);
            this.LblFechaDesde.ForeColor = System.Drawing.Color.Black;
            this.LblFechaDesde.Location = new System.Drawing.Point(9, 10);
            this.LblFechaDesde.Name = "LblFechaDesde";
            this.LblFechaDesde.Size = new System.Drawing.Size(79, 17);
            this.LblFechaDesde.TabIndex = 53;
            this.LblFechaDesde.Text = "Fecha Desde";
            // 
            // TpAcyTur
            // 
            this.TpAcyTur.Controls.Add(this.RvEntrenadoresXTurno);
            this.TpAcyTur.Controls.Add(this.BtnLimpiar2);
            this.TpAcyTur.Controls.Add(this.BtnBuscar2);
            this.TpAcyTur.Controls.Add(this.groupBox2);
            this.TpAcyTur.Controls.Add(this.LblEdadHasta);
            this.TpAcyTur.Controls.Add(this.LblEdadDesde);
            this.TpAcyTur.Controls.Add(this.TxtEdadInicio);
            this.TpAcyTur.Controls.Add(this.TxtEdadFin);
            this.TpAcyTur.Controls.Add(this.RvEntrenadoresXActividad);
            this.TpAcyTur.Controls.Add(this.groupBox1);
            this.TpAcyTur.Location = new System.Drawing.Point(4, 22);
            this.TpAcyTur.Name = "TpAcyTur";
            this.TpAcyTur.Padding = new System.Windows.Forms.Padding(3);
            this.TpAcyTur.Size = new System.Drawing.Size(682, 291);
            this.TpAcyTur.TabIndex = 1;
            this.TpAcyTur.Text = "Empleados por Actividad y Turno";
            this.TpAcyTur.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiar2
            // 
            this.BtnLimpiar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnLimpiar2.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar2.ForeColor = System.Drawing.Color.LightGray;
            this.BtnLimpiar2.Location = new System.Drawing.Point(601, 44);
            this.BtnLimpiar2.Name = "BtnLimpiar2";
            this.BtnLimpiar2.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar2.TabIndex = 62;
            this.BtnLimpiar2.Text = "Limpiar";
            this.BtnLimpiar2.UseVisualStyleBackColor = false;
            this.BtnLimpiar2.Click += new System.EventHandler(this.BtnLimpiar2_Click);
            // 
            // BtnBuscar2
            // 
            this.BtnBuscar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnBuscar2.FlatAppearance.BorderSize = 0;
            this.BtnBuscar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnBuscar2.ForeColor = System.Drawing.Color.LightGray;
            this.BtnBuscar2.Location = new System.Drawing.Point(601, 15);
            this.BtnBuscar2.Name = "BtnBuscar2";
            this.BtnBuscar2.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar2.TabIndex = 61;
            this.BtnBuscar2.Text = "Buscar";
            this.BtnBuscar2.UseVisualStyleBackColor = false;
            this.BtnBuscar2.Click += new System.EventHandler(this.BtnBuscar2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RbFem);
            this.groupBox2.Controls.Add(this.RbMasc);
            this.groupBox2.Location = new System.Drawing.Point(135, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 34);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            // 
            // RbFem
            // 
            this.RbFem.AutoSize = true;
            this.RbFem.Enabled = false;
            this.RbFem.Location = new System.Drawing.Point(6, 10);
            this.RbFem.Name = "RbFem";
            this.RbFem.Size = new System.Drawing.Size(71, 17);
            this.RbFem.TabIndex = 2;
            this.RbFem.TabStop = true;
            this.RbFem.Text = "Femenino";
            this.RbFem.UseVisualStyleBackColor = true;
            // 
            // RbMasc
            // 
            this.RbMasc.AutoSize = true;
            this.RbMasc.Enabled = false;
            this.RbMasc.Location = new System.Drawing.Point(84, 10);
            this.RbMasc.Name = "RbMasc";
            this.RbMasc.Size = new System.Drawing.Size(73, 17);
            this.RbMasc.TabIndex = 3;
            this.RbMasc.TabStop = true;
            this.RbMasc.Text = "Masculino";
            this.RbMasc.UseVisualStyleBackColor = true;
            // 
            // LblEdadHasta
            // 
            this.LblEdadHasta.AutoSize = true;
            this.LblEdadHasta.Location = new System.Drawing.Point(209, 3);
            this.LblEdadHasta.Name = "LblEdadHasta";
            this.LblEdadHasta.Size = new System.Drawing.Size(63, 13);
            this.LblEdadHasta.TabIndex = 59;
            this.LblEdadHasta.Text = "Edad Hasta";
            // 
            // LblEdadDesde
            // 
            this.LblEdadDesde.AutoSize = true;
            this.LblEdadDesde.Location = new System.Drawing.Point(135, 3);
            this.LblEdadDesde.Name = "LblEdadDesde";
            this.LblEdadDesde.Size = new System.Drawing.Size(66, 13);
            this.LblEdadDesde.TabIndex = 58;
            this.LblEdadDesde.Text = "Edad Desde";
            // 
            // TxtEdadInicio
            // 
            this.TxtEdadInicio.Enabled = false;
            this.TxtEdadInicio.Location = new System.Drawing.Point(138, 18);
            this.TxtEdadInicio.Name = "TxtEdadInicio";
            this.TxtEdadInicio.Size = new System.Drawing.Size(51, 20);
            this.TxtEdadInicio.TabIndex = 2;
            // 
            // TxtEdadFin
            // 
            this.TxtEdadFin.Enabled = false;
            this.TxtEdadFin.Location = new System.Drawing.Point(212, 18);
            this.TxtEdadFin.Name = "TxtEdadFin";
            this.TxtEdadFin.Size = new System.Drawing.Size(51, 20);
            this.TxtEdadFin.TabIndex = 3;
            // 
            // RvEntrenadoresXActividad
            // 
            this.RvEntrenadoresXActividad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RvEntrenadoresXActividad.LocalReport.ReportEmbeddedResource = "PAV1_GYM.Estadisticas.Rdlc.EstadisticasEntrenadoresXActividad.rdlc";
            this.RvEntrenadoresXActividad.Location = new System.Drawing.Point(14, 86);
            this.RvEntrenadoresXActividad.Name = "RvEntrenadoresXActividad";
            this.RvEntrenadoresXActividad.ServerReport.BearerToken = null;
            this.RvEntrenadoresXActividad.Size = new System.Drawing.Size(128, 199);
            this.RvEntrenadoresXActividad.TabIndex = 56;
            this.RvEntrenadoresXActividad.Load += new System.EventHandler(this.RvEntrenadoresXActividad_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbFiltroSexo);
            this.groupBox1.Controls.Add(this.RbFiltroEdad);
            this.groupBox1.Location = new System.Drawing.Point(14, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 73);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // RbFiltroSexo
            // 
            this.RbFiltroSexo.AutoSize = true;
            this.RbFiltroSexo.Location = new System.Drawing.Point(6, 44);
            this.RbFiltroSexo.Name = "RbFiltroSexo";
            this.RbFiltroSexo.Size = new System.Drawing.Size(93, 17);
            this.RbFiltroSexo.TabIndex = 1;
            this.RbFiltroSexo.TabStop = true;
            this.RbFiltroSexo.Text = "Filtar Por Sexo";
            this.RbFiltroSexo.UseVisualStyleBackColor = true;
            this.RbFiltroSexo.CheckedChanged += new System.EventHandler(this.RbFiltroSexo_CheckedChanged);
            // 
            // RbFiltroEdad
            // 
            this.RbFiltroEdad.AutoSize = true;
            this.RbFiltroEdad.Location = new System.Drawing.Point(6, 19);
            this.RbFiltroEdad.Name = "RbFiltroEdad";
            this.RbFiltroEdad.Size = new System.Drawing.Size(96, 17);
            this.RbFiltroEdad.TabIndex = 0;
            this.RbFiltroEdad.TabStop = true;
            this.RbFiltroEdad.Text = "Filtrar por Edad";
            this.RbFiltroEdad.UseVisualStyleBackColor = true;
            this.RbFiltroEdad.CheckedChanged += new System.EventHandler(this.RbFiltroEdad_CheckedChanged);
            // 
            // LblEstadistica
            // 
            this.LblEstadistica.AutoSize = true;
            this.LblEstadistica.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.LblEstadistica.ForeColor = System.Drawing.Color.Silver;
            this.LblEstadistica.Location = new System.Drawing.Point(10, 9);
            this.LblEstadistica.Name = "LblEstadistica";
            this.LblEstadistica.Size = new System.Drawing.Size(276, 29);
            this.LblEstadistica.TabIndex = 21;
            this.LblEstadistica.Text = "Estadisticas de Empleados";
            // 
            // RvEntrenadoresXTurno
            // 
            this.RvEntrenadoresXTurno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RvEntrenadoresXTurno.LocalReport.ReportEmbeddedResource = "PAV1_GYM.Estadisticas.Rdlc.EstadisticaEntrenadoresXTurno.rdlc";
            this.RvEntrenadoresXTurno.Location = new System.Drawing.Point(148, 86);
            this.RvEntrenadoresXTurno.Name = "RvEntrenadoresXTurno";
            this.RvEntrenadoresXTurno.ServerReport.BearerToken = null;
            this.RvEntrenadoresXTurno.Size = new System.Drawing.Size(528, 199);
            this.RvEntrenadoresXTurno.TabIndex = 63;
            this.RvEntrenadoresXTurno.Load += new System.EventHandler(this.RvEntrenadoresXTurno_Load);
            // 
            // EstadisticaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(719, 432);
            this.Controls.Add(this.LblEstadistica);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.TCEmpleados);
            this.Name = "EstadisticaEmpleados";
            this.Text = "EstadisticaEmpleados";
            this.Load += new System.EventHandler(this.EstadisticaEmpleados_Load);
            this.TCEmpleados.ResumeLayout(false);
            this.TpEmpleados.ResumeLayout(false);
            this.TpEmpleados.PerformLayout();
            this.TpAcyTur.ResumeLayout(false);
            this.TpAcyTur.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TabControl TCEmpleados;
        private System.Windows.Forms.TabPage TpEmpleados;
        private Microsoft.Reporting.WinForms.ReportViewer RvEmpleados;
        private System.Windows.Forms.DateTimePicker DtpFechaHasta;
        private System.Windows.Forms.DateTimePicker DtpFechaDesde;
        private System.Windows.Forms.Label LblFechaHasta;
        private System.Windows.Forms.Label LblFechaDesde;
        private System.Windows.Forms.TabPage TpAcyTur;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RbFem;
        private System.Windows.Forms.RadioButton RbMasc;
        private System.Windows.Forms.Label LblEdadHasta;
        private System.Windows.Forms.Label LblEdadDesde;
        private System.Windows.Forms.TextBox TxtEdadInicio;
        private System.Windows.Forms.TextBox TxtEdadFin;
        private Microsoft.Reporting.WinForms.ReportViewer RvEntrenadoresXActividad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbFiltroSexo;
        private System.Windows.Forms.RadioButton RbFiltroEdad;
        private System.Windows.Forms.Label LblEstadistica;
        private System.Windows.Forms.Button BtnLimpiar1;
        private System.Windows.Forms.Button BtnBuscar1;
        private System.Windows.Forms.Button BtnLimpiar2;
        private System.Windows.Forms.Button BtnBuscar2;
        private Microsoft.Reporting.WinForms.ReportViewer RvEntrenadoresXTurno;
    }
}