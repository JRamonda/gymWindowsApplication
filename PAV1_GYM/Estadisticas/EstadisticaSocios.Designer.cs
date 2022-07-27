namespace PAV1_GYM.Estadisticas
{
    partial class EstadisticaSocios
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
            this.rdbTodos = new System.Windows.Forms.Panel();
            this.TCSocios = new System.Windows.Forms.TabControl();
            this.TPSocios = new System.Windows.Forms.TabPage();
            this.DtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnBuscarSocios = new System.Windows.Forms.Button();
            this.RvSocios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ChFiltrarFecha = new System.Windows.Forms.CheckBox();
            this.DtpFechaHastaDS = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaDesdeDS = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuscarDetalle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbBaja = new System.Windows.Forms.RadioButton();
            this.RbActivo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RbMasc = new System.Windows.Forms.RadioButton();
            this.RbFem = new System.Windows.Forms.RadioButton();
            this.RbTodos = new System.Windows.Forms.RadioButton();
            this.RvDetalle = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LblEstadistica = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnLimpiarDS = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.rdbTodos.SuspendLayout();
            this.TCSocios.SuspendLayout();
            this.TPSocios.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoScroll = true;
            this.rdbTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.rdbTodos.Controls.Add(this.TCSocios);
            this.rdbTodos.Controls.Add(this.LblEstadistica);
            this.rdbTodos.Controls.Add(this.BtnSalir);
            this.rdbTodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbTodos.Location = new System.Drawing.Point(0, 0);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(800, 450);
            this.rdbTodos.TabIndex = 8;
            // 
            // TCSocios
            // 
            this.TCSocios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TCSocios.Controls.Add(this.TPSocios);
            this.TCSocios.Controls.Add(this.tabPage1);
            this.TCSocios.Location = new System.Drawing.Point(28, 50);
            this.TCSocios.Name = "TCSocios";
            this.TCSocios.SelectedIndex = 0;
            this.TCSocios.Size = new System.Drawing.Size(749, 341);
            this.TCSocios.TabIndex = 43;
            // 
            // TPSocios
            // 
            this.TPSocios.Controls.Add(this.BtnLimpiar);
            this.TPSocios.Controls.Add(this.DtpFechaHasta);
            this.TPSocios.Controls.Add(this.DtpFechaDesde);
            this.TPSocios.Controls.Add(this.label1);
            this.TPSocios.Controls.Add(this.label6);
            this.TPSocios.Controls.Add(this.BtnBuscarSocios);
            this.TPSocios.Controls.Add(this.RvSocios);
            this.TPSocios.Location = new System.Drawing.Point(4, 22);
            this.TPSocios.Name = "TPSocios";
            this.TPSocios.Padding = new System.Windows.Forms.Padding(3);
            this.TPSocios.Size = new System.Drawing.Size(741, 315);
            this.TPSocios.TabIndex = 0;
            this.TPSocios.Text = "Lista de Socios";
            this.TPSocios.UseVisualStyleBackColor = true;
            // 
            // DtpFechaHasta
            // 
            this.DtpFechaHasta.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.DtpFechaHasta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DtpFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaHasta.Location = new System.Drawing.Point(223, 10);
            this.DtpFechaHasta.Name = "DtpFechaHasta";
            this.DtpFechaHasta.Size = new System.Drawing.Size(100, 21);
            this.DtpFechaHasta.TabIndex = 63;
            // 
            // DtpFechaDesde
            // 
            this.DtpFechaDesde.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.DtpFechaDesde.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DtpFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaDesde.Location = new System.Drawing.Point(50, 10);
            this.DtpFechaDesde.Name = "DtpFechaDesde";
            this.DtpFechaDesde.Size = new System.Drawing.Size(100, 21);
            this.DtpFechaDesde.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Hasta";
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Desde";
            // 
            // BtnBuscarSocios
            // 
            this.BtnBuscarSocios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarSocios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnBuscarSocios.FlatAppearance.BorderSize = 0;
            this.BtnBuscarSocios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarSocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnBuscarSocios.ForeColor = System.Drawing.Color.LightGray;
            this.BtnBuscarSocios.Location = new System.Drawing.Point(644, 10);
            this.BtnBuscarSocios.Name = "BtnBuscarSocios";
            this.BtnBuscarSocios.Size = new System.Drawing.Size(75, 27);
            this.BtnBuscarSocios.TabIndex = 47;
            this.BtnBuscarSocios.Text = "Buscar";
            this.BtnBuscarSocios.UseVisualStyleBackColor = false;
            this.BtnBuscarSocios.Click += new System.EventHandler(this.BtnBuscarSocios_Click);
            // 
            // RvSocios
            // 
            this.RvSocios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RvSocios.LocalReport.ReportEmbeddedResource = "PAV1_GYM.Estadisticas.Rdlc.EstadisticaSocios.rdlc";
            this.RvSocios.Location = new System.Drawing.Point(6, 76);
            this.RvSocios.Name = "RvSocios";
            this.RvSocios.ServerReport.BearerToken = null;
            this.RvSocios.Size = new System.Drawing.Size(729, 233);
            this.RvSocios.TabIndex = 44;
            this.RvSocios.Load += new System.EventHandler(this.RvSocios_Load);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnLimpiarDS);
            this.tabPage1.Controls.Add(this.ChFiltrarFecha);
            this.tabPage1.Controls.Add(this.DtpFechaHastaDS);
            this.tabPage1.Controls.Add(this.DtpFechaDesdeDS);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.BtnBuscarDetalle);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.RbTodos);
            this.tabPage1.Controls.Add(this.RvDetalle);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(741, 315);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "DetalleSocios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ChFiltrarFecha
            // 
            this.ChFiltrarFecha.AutoSize = true;
            this.ChFiltrarFecha.Location = new System.Drawing.Point(441, 15);
            this.ChFiltrarFecha.Name = "ChFiltrarFecha";
            this.ChFiltrarFecha.Size = new System.Drawing.Size(84, 17);
            this.ChFiltrarFecha.TabIndex = 68;
            this.ChFiltrarFecha.Text = "Filtrar Fecha";
            this.ChFiltrarFecha.UseVisualStyleBackColor = true;
            this.ChFiltrarFecha.CheckedChanged += new System.EventHandler(this.ChFiltrarFecha_CheckedChanged);
            // 
            // DtpFechaHastaDS
            // 
            this.DtpFechaHastaDS.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.DtpFechaHastaDS.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DtpFechaHastaDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DtpFechaHastaDS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaHastaDS.Location = new System.Drawing.Point(334, 12);
            this.DtpFechaHastaDS.Name = "DtpFechaHastaDS";
            this.DtpFechaHastaDS.Size = new System.Drawing.Size(100, 21);
            this.DtpFechaHastaDS.TabIndex = 67;
            // 
            // DtpFechaDesdeDS
            // 
            this.DtpFechaDesdeDS.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.DtpFechaDesdeDS.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DtpFechaDesdeDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DtpFechaDesdeDS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaDesdeDS.Location = new System.Drawing.Point(178, 12);
            this.DtpFechaDesdeDS.Name = "DtpFechaDesdeDS";
            this.DtpFechaDesdeDS.Size = new System.Drawing.Size(100, 21);
            this.DtpFechaDesdeDS.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 57;
            this.label2.Text = "Seleccione..";
            // 
            // BtnBuscarDetalle
            // 
            this.BtnBuscarDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnBuscarDetalle.FlatAppearance.BorderSize = 0;
            this.BtnBuscarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnBuscarDetalle.ForeColor = System.Drawing.Color.LightGray;
            this.BtnBuscarDetalle.Location = new System.Drawing.Point(657, 15);
            this.BtnBuscarDetalle.Name = "BtnBuscarDetalle";
            this.BtnBuscarDetalle.Size = new System.Drawing.Size(75, 25);
            this.BtnBuscarDetalle.TabIndex = 56;
            this.BtnBuscarDetalle.Text = "Buscar";
            this.BtnBuscarDetalle.UseVisualStyleBackColor = false;
            this.BtnBuscarDetalle.Click += new System.EventHandler(this.BtnBuscarDetalle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbBaja);
            this.groupBox1.Controls.Add(this.RbActivo);
            this.groupBox1.Location = new System.Drawing.Point(316, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 47);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // RbBaja
            // 
            this.RbBaja.AutoSize = true;
            this.RbBaja.Location = new System.Drawing.Point(105, 22);
            this.RbBaja.Name = "RbBaja";
            this.RbBaja.Size = new System.Drawing.Size(89, 17);
            this.RbBaja.TabIndex = 54;
            this.RbBaja.TabStop = true;
            this.RbBaja.Text = "No Activo (N)";
            this.RbBaja.UseVisualStyleBackColor = true;
            // 
            // RbActivo
            // 
            this.RbActivo.AutoSize = true;
            this.RbActivo.Location = new System.Drawing.Point(18, 22);
            this.RbActivo.Name = "RbActivo";
            this.RbActivo.Size = new System.Drawing.Size(71, 17);
            this.RbActivo.TabIndex = 53;
            this.RbActivo.TabStop = true;
            this.RbActivo.Text = "Activo (S)";
            this.RbActivo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RbMasc);
            this.groupBox2.Controls.Add(this.RbFem);
            this.groupBox2.Location = new System.Drawing.Point(136, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 44);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo";
            // 
            // RbMasc
            // 
            this.RbMasc.AutoSize = true;
            this.RbMasc.Location = new System.Drawing.Point(77, 19);
            this.RbMasc.Name = "RbMasc";
            this.RbMasc.Size = new System.Drawing.Size(34, 17);
            this.RbMasc.TabIndex = 4;
            this.RbMasc.TabStop = true;
            this.RbMasc.Text = "M";
            this.RbMasc.UseVisualStyleBackColor = true;
            // 
            // RbFem
            // 
            this.RbFem.AutoSize = true;
            this.RbFem.Location = new System.Drawing.Point(19, 19);
            this.RbFem.Name = "RbFem";
            this.RbFem.Size = new System.Drawing.Size(31, 17);
            this.RbFem.TabIndex = 3;
            this.RbFem.TabStop = true;
            this.RbFem.Text = "F";
            this.RbFem.UseVisualStyleBackColor = true;
            // 
            // RbTodos
            // 
            this.RbTodos.AutoSize = true;
            this.RbTodos.Location = new System.Drawing.Point(6, 47);
            this.RbTodos.Name = "RbTodos";
            this.RbTodos.Size = new System.Drawing.Size(106, 17);
            this.RbTodos.TabIndex = 53;
            this.RbTodos.TabStop = true;
            this.RbTodos.Text = "Todos los Socios";
            this.RbTodos.UseVisualStyleBackColor = true;
            // 
            // RvDetalle
            // 
            this.RvDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RvDetalle.LocalReport.ReportEmbeddedResource = "PAV1_GYM.Estadisticas.Rdlc.EstadisticaSociosActividad.rdlc";
            this.RvDetalle.Location = new System.Drawing.Point(3, 100);
            this.RvDetalle.Name = "RvDetalle";
            this.RvDetalle.ServerReport.BearerToken = null;
            this.RvDetalle.Size = new System.Drawing.Size(729, 212);
            this.RvDetalle.TabIndex = 46;
            this.RvDetalle.Load += new System.EventHandler(this.RvDetalle_Load);
            // 
            // LblEstadistica
            // 
            this.LblEstadistica.AutoSize = true;
            this.LblEstadistica.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.LblEstadistica.ForeColor = System.Drawing.Color.Silver;
            this.LblEstadistica.Location = new System.Drawing.Point(23, 9);
            this.LblEstadistica.Name = "LblEstadistica";
            this.LblEstadistica.Size = new System.Drawing.Size(218, 29);
            this.LblEstadistica.TabIndex = 15;
            this.LblEstadistica.Text = "Estadistica de Socios";
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
            // BtnLimpiarDS
            // 
            this.BtnLimpiarDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiarDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnLimpiarDS.FlatAppearance.BorderSize = 0;
            this.BtnLimpiarDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiarDS.ForeColor = System.Drawing.Color.LightGray;
            this.BtnLimpiarDS.Location = new System.Drawing.Point(657, 46);
            this.BtnLimpiarDS.Name = "BtnLimpiarDS";
            this.BtnLimpiarDS.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiarDS.TabIndex = 69;
            this.BtnLimpiarDS.Text = "Limpiar";
            this.BtnLimpiarDS.UseVisualStyleBackColor = false;
            this.BtnLimpiarDS.Click += new System.EventHandler(this.BtnLimpiarDS_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnLimpiar.Location = new System.Drawing.Point(644, 43);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 27);
            this.BtnLimpiar.TabIndex = 70;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // EstadisticaSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdbTodos);
            this.Name = "EstadisticaSocios";
            this.Text = "EstadisticaSocios";
            this.Load += new System.EventHandler(this.EstadisticaSocios_Load);
            this.rdbTodos.ResumeLayout(false);
            this.rdbTodos.PerformLayout();
            this.TCSocios.ResumeLayout(false);
            this.TPSocios.ResumeLayout(false);
            this.TPSocios.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rdbTodos;
        private System.Windows.Forms.TabControl TCSocios;
        private System.Windows.Forms.TabPage TPSocios;
        private System.Windows.Forms.Button BtnBuscarSocios;
        private Microsoft.Reporting.WinForms.ReportViewer RvSocios;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuscarDetalle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbBaja;
        private System.Windows.Forms.RadioButton RbActivo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RbMasc;
        private System.Windows.Forms.RadioButton RbFem;
        private System.Windows.Forms.RadioButton RbTodos;
        private Microsoft.Reporting.WinForms.ReportViewer RvDetalle;
        private System.Windows.Forms.Label LblEstadistica;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DateTimePicker DtpFechaHasta;
        private System.Windows.Forms.DateTimePicker DtpFechaDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ChFiltrarFecha;
        private System.Windows.Forms.DateTimePicker DtpFechaHastaDS;
        private System.Windows.Forms.DateTimePicker DtpFechaDesdeDS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnLimpiarDS;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}