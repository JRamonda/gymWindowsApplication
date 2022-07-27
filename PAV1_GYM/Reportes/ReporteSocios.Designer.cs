namespace PAV1_GYM.Reportes
{
    partial class ReporteSocios
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
            this.label1 = new System.Windows.Forms.Label();
            this.ckbTodos = new System.Windows.Forms.RadioButton();
            this.gpbEstado = new System.Windows.Forms.GroupBox();
            this.ckbNoActivo = new System.Windows.Forms.RadioButton();
            this.ckbActivo = new System.Windows.Forms.RadioButton();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.ckbM = new System.Windows.Forms.RadioButton();
            this.ckbF = new System.Windows.Forms.RadioButton();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.RvSocios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNoActivo = new System.Windows.Forms.RadioButton();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.rdbF = new System.Windows.Forms.RadioButton();
            this.rbdTodos = new System.Windows.Forms.RadioButton();
            this.RvTodos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabSocio = new System.Windows.Forms.TabPage();
            this.DtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RVPeriodoSocio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LblReportes = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.rdbTodos.SuspendLayout();
            this.TCSocios.SuspendLayout();
            this.TPSocios.SuspendLayout();
            this.gpbEstado.SuspendLayout();
            this.gpbSexo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabSocio.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoScroll = true;
            this.rdbTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.rdbTodos.Controls.Add(this.TCSocios);
            this.rdbTodos.Controls.Add(this.LblReportes);
            this.rdbTodos.Controls.Add(this.BtnSalir);
            this.rdbTodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbTodos.Location = new System.Drawing.Point(0, 0);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(800, 450);
            this.rdbTodos.TabIndex = 7;
            // 
            // TCSocios
            // 
            this.TCSocios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TCSocios.Controls.Add(this.TPSocios);
            this.TCSocios.Controls.Add(this.tabPage1);
            this.TCSocios.Controls.Add(this.tabSocio);
            this.TCSocios.Location = new System.Drawing.Point(28, 50);
            this.TCSocios.Name = "TCSocios";
            this.TCSocios.SelectedIndex = 0;
            this.TCSocios.Size = new System.Drawing.Size(749, 341);
            this.TCSocios.TabIndex = 43;
            // 
            // TPSocios
            // 
            this.TPSocios.Controls.Add(this.label1);
            this.TPSocios.Controls.Add(this.ckbTodos);
            this.TPSocios.Controls.Add(this.gpbEstado);
            this.TPSocios.Controls.Add(this.gpbSexo);
            this.TPSocios.Controls.Add(this.BtnBuscar);
            this.TPSocios.Controls.Add(this.RvSocios);
            this.TPSocios.Location = new System.Drawing.Point(4, 22);
            this.TPSocios.Name = "TPSocios";
            this.TPSocios.Padding = new System.Windows.Forms.Padding(3);
            this.TPSocios.Size = new System.Drawing.Size(741, 315);
            this.TPSocios.TabIndex = 0;
            this.TPSocios.Text = "Lista de Socios";
            this.TPSocios.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 54;
            this.label1.Text = "Seleccione..";
            // 
            // ckbTodos
            // 
            this.ckbTodos.AutoSize = true;
            this.ckbTodos.Location = new System.Drawing.Point(6, 45);
            this.ckbTodos.Name = "ckbTodos";
            this.ckbTodos.Size = new System.Drawing.Size(106, 17);
            this.ckbTodos.TabIndex = 52;
            this.ckbTodos.TabStop = true;
            this.ckbTodos.Text = "Todos los Socios";
            this.ckbTodos.UseVisualStyleBackColor = true;
            // 
            // gpbEstado
            // 
            this.gpbEstado.Controls.Add(this.ckbNoActivo);
            this.gpbEstado.Controls.Add(this.ckbActivo);
            this.gpbEstado.Location = new System.Drawing.Point(320, 34);
            this.gpbEstado.Name = "gpbEstado";
            this.gpbEstado.Size = new System.Drawing.Size(200, 47);
            this.gpbEstado.TabIndex = 51;
            this.gpbEstado.TabStop = false;
            this.gpbEstado.Text = "Estado";
            // 
            // ckbNoActivo
            // 
            this.ckbNoActivo.AutoSize = true;
            this.ckbNoActivo.Location = new System.Drawing.Point(105, 22);
            this.ckbNoActivo.Name = "ckbNoActivo";
            this.ckbNoActivo.Size = new System.Drawing.Size(89, 17);
            this.ckbNoActivo.TabIndex = 54;
            this.ckbNoActivo.TabStop = true;
            this.ckbNoActivo.Text = "No Activo (N)";
            this.ckbNoActivo.UseVisualStyleBackColor = true;
            // 
            // ckbActivo
            // 
            this.ckbActivo.AutoSize = true;
            this.ckbActivo.Location = new System.Drawing.Point(18, 22);
            this.ckbActivo.Name = "ckbActivo";
            this.ckbActivo.Size = new System.Drawing.Size(71, 17);
            this.ckbActivo.TabIndex = 53;
            this.ckbActivo.TabStop = true;
            this.ckbActivo.Text = "Activo (S)";
            this.ckbActivo.UseVisualStyleBackColor = true;
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.ckbM);
            this.gpbSexo.Controls.Add(this.ckbF);
            this.gpbSexo.Location = new System.Drawing.Point(141, 37);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(142, 44);
            this.gpbSexo.TabIndex = 50;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // ckbM
            // 
            this.ckbM.AutoSize = true;
            this.ckbM.Location = new System.Drawing.Point(77, 19);
            this.ckbM.Name = "ckbM";
            this.ckbM.Size = new System.Drawing.Size(34, 17);
            this.ckbM.TabIndex = 4;
            this.ckbM.TabStop = true;
            this.ckbM.Text = "M";
            this.ckbM.UseVisualStyleBackColor = true;
            // 
            // ckbF
            // 
            this.ckbF.AutoSize = true;
            this.ckbF.Location = new System.Drawing.Point(19, 19);
            this.ckbF.Name = "ckbF";
            this.ckbF.Size = new System.Drawing.Size(31, 17);
            this.ckbF.TabIndex = 3;
            this.ckbF.TabStop = true;
            this.ckbF.Text = "F";
            this.ckbF.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnBuscar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnBuscar.Location = new System.Drawing.Point(643, 26);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 27);
            this.BtnBuscar.TabIndex = 47;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // RvSocios
            // 
            this.RvSocios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RvSocios.LocalReport.ReportEmbeddedResource = "PAV1_GYM.Reportes.Rdlc.Rpt_Socios.rdlc";
            this.RvSocios.Location = new System.Drawing.Point(6, 95);
            this.RvSocios.Name = "RvSocios";
            this.RvSocios.ServerReport.BearerToken = null;
            this.RvSocios.Size = new System.Drawing.Size(729, 214);
            this.RvSocios.TabIndex = 44;
            this.RvSocios.Load += new System.EventHandler(this.RvSocios_Load);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnBuscar3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.rbdTodos);
            this.tabPage1.Controls.Add(this.RvTodos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(741, 315);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "DetalleSocios";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // btnBuscar3
            // 
            this.btnBuscar3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnBuscar3.FlatAppearance.BorderSize = 0;
            this.btnBuscar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar3.ForeColor = System.Drawing.Color.LightGray;
            this.btnBuscar3.Location = new System.Drawing.Point(657, 25);
            this.btnBuscar3.Name = "btnBuscar3";
            this.btnBuscar3.Size = new System.Drawing.Size(75, 25);
            this.btnBuscar3.TabIndex = 56;
            this.btnBuscar3.Text = "Buscar";
            this.btnBuscar3.UseVisualStyleBackColor = false;
            this.btnBuscar3.Click += new System.EventHandler(this.btnBuscar3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNoActivo);
            this.groupBox1.Controls.Add(this.rdbActivo);
            this.groupBox1.Location = new System.Drawing.Point(316, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 47);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // rdbNoActivo
            // 
            this.rdbNoActivo.AutoSize = true;
            this.rdbNoActivo.Location = new System.Drawing.Point(105, 22);
            this.rdbNoActivo.Name = "rdbNoActivo";
            this.rdbNoActivo.Size = new System.Drawing.Size(89, 17);
            this.rdbNoActivo.TabIndex = 54;
            this.rdbNoActivo.TabStop = true;
            this.rdbNoActivo.Text = "No Activo (N)";
            this.rdbNoActivo.UseVisualStyleBackColor = true;
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.Location = new System.Drawing.Point(18, 22);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(71, 17);
            this.rdbActivo.TabIndex = 53;
            this.rdbActivo.TabStop = true;
            this.rdbActivo.Text = "Activo (S)";
            this.rdbActivo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbM);
            this.groupBox2.Controls.Add(this.rdbF);
            this.groupBox2.Location = new System.Drawing.Point(136, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 44);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo";
            // 
            // rdbM
            // 
            this.rdbM.AutoSize = true;
            this.rdbM.Location = new System.Drawing.Point(77, 19);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(34, 17);
            this.rdbM.TabIndex = 4;
            this.rdbM.TabStop = true;
            this.rdbM.Text = "M";
            this.rdbM.UseVisualStyleBackColor = true;
            // 
            // rdbF
            // 
            this.rdbF.AutoSize = true;
            this.rdbF.Location = new System.Drawing.Point(19, 19);
            this.rdbF.Name = "rdbF";
            this.rdbF.Size = new System.Drawing.Size(31, 17);
            this.rdbF.TabIndex = 3;
            this.rdbF.TabStop = true;
            this.rdbF.Text = "F";
            this.rdbF.UseVisualStyleBackColor = true;
            // 
            // rbdTodos
            // 
            this.rbdTodos.AutoSize = true;
            this.rbdTodos.Location = new System.Drawing.Point(6, 47);
            this.rbdTodos.Name = "rbdTodos";
            this.rbdTodos.Size = new System.Drawing.Size(106, 17);
            this.rbdTodos.TabIndex = 53;
            this.rbdTodos.TabStop = true;
            this.rbdTodos.Text = "Todos los Socios";
            this.rbdTodos.UseVisualStyleBackColor = true;
            // 
            // RvTodos
            // 
            this.RvTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RvTodos.LocalReport.ReportEmbeddedResource = "PAV1_GYM.Reportes.Rdlc.Rpt_DetalleSocios.rdlc";
            this.RvTodos.Location = new System.Drawing.Point(3, 100);
            this.RvTodos.Name = "RvTodos";
            this.RvTodos.ServerReport.BearerToken = null;
            this.RvTodos.Size = new System.Drawing.Size(729, 212);
            this.RvTodos.TabIndex = 46;
            this.RvTodos.Load += new System.EventHandler(this.RvTodos_Load);
            // 
            // tabSocio
            // 
            this.tabSocio.Controls.Add(this.DtpFechaHasta);
            this.tabSocio.Controls.Add(this.DtpFechaDesde);
            this.tabSocio.Controls.Add(this.btnBuscar2);
            this.tabSocio.Controls.Add(this.label3);
            this.tabSocio.Controls.Add(this.label4);
            this.tabSocio.Controls.Add(this.label5);
            this.tabSocio.Controls.Add(this.RVPeriodoSocio);
            this.tabSocio.Location = new System.Drawing.Point(4, 22);
            this.tabSocio.Name = "tabSocio";
            this.tabSocio.Padding = new System.Windows.Forms.Padding(3);
            this.tabSocio.Size = new System.Drawing.Size(741, 315);
            this.tabSocio.TabIndex = 3;
            this.tabSocio.Text = "Ingresos Socio";
            this.tabSocio.UseVisualStyleBackColor = true;
            // 
            // DtpFechaHasta
            // 
            this.DtpFechaHasta.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.DtpFechaHasta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DtpFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaHasta.Location = new System.Drawing.Point(391, 30);
            this.DtpFechaHasta.Name = "DtpFechaHasta";
            this.DtpFechaHasta.Size = new System.Drawing.Size(100, 21);
            this.DtpFechaHasta.TabIndex = 59;
            // 
            // DtpFechaDesde
            // 
            this.DtpFechaDesde.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.DtpFechaDesde.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DtpFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaDesde.Location = new System.Drawing.Point(218, 30);
            this.DtpFechaDesde.Name = "DtpFechaDesde";
            this.DtpFechaDesde.Size = new System.Drawing.Size(100, 21);
            this.DtpFechaDesde.TabIndex = 58;
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btnBuscar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnBuscar2.FlatAppearance.BorderSize = 0;
            this.btnBuscar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar2.ForeColor = System.Drawing.Color.LightGray;
            this.btnBuscar2.Location = new System.Drawing.Point(640, 6);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(79, 27);
            this.btnBuscar2.TabIndex = 57;
            this.btnBuscar2.Text = "Buscar";
            this.btnBuscar2.UseVisualStyleBackColor = false;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Desde";
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Establecer el Periodo:";
            // 
            // RVPeriodoSocio
            // 
            this.RVPeriodoSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RVPeriodoSocio.LocalReport.ReportEmbeddedResource = "PAV1_GYM.Reportes.Rdlc.Rpt_PeriodoSocios.rdlc";
            this.RVPeriodoSocio.Location = new System.Drawing.Point(6, 60);
            this.RVPeriodoSocio.Name = "RVPeriodoSocio";
            this.RVPeriodoSocio.ServerReport.BearerToken = null;
            this.RVPeriodoSocio.Size = new System.Drawing.Size(729, 246);
            this.RVPeriodoSocio.TabIndex = 46;
            this.RVPeriodoSocio.Load += new System.EventHandler(this.RVPeriodoSocio_Load);
            // 
            // LblReportes
            // 
            this.LblReportes.AutoSize = true;
            this.LblReportes.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.LblReportes.ForeColor = System.Drawing.Color.Silver;
            this.LblReportes.Location = new System.Drawing.Point(23, 9);
            this.LblReportes.Name = "LblReportes";
            this.LblReportes.Size = new System.Drawing.Size(202, 29);
            this.LblReportes.TabIndex = 15;
            this.LblReportes.Text = "Reportes de Socios";
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
            // ReporteSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdbTodos);
            this.Name = "ReporteSocios";
            this.Text = "ReporteSocios";
            this.Load += new System.EventHandler(this.ReporteSocios_Load);
            this.rdbTodos.ResumeLayout(false);
            this.rdbTodos.PerformLayout();
            this.TCSocios.ResumeLayout(false);
            this.TPSocios.ResumeLayout(false);
            this.TPSocios.PerformLayout();
            this.gpbEstado.ResumeLayout(false);
            this.gpbEstado.PerformLayout();
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabSocio.ResumeLayout(false);
            this.tabSocio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rdbTodos;
        private System.Windows.Forms.TabControl TCSocios;
        private System.Windows.Forms.TabPage TPSocios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ckbTodos;
        private System.Windows.Forms.GroupBox gpbEstado;
        private System.Windows.Forms.RadioButton ckbNoActivo;
        private System.Windows.Forms.RadioButton ckbActivo;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton ckbM;
        private System.Windows.Forms.RadioButton ckbF;
        private System.Windows.Forms.Button BtnBuscar;
        private Microsoft.Reporting.WinForms.ReportViewer RvSocios;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNoActivo;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.RadioButton rdbF;
        private System.Windows.Forms.RadioButton rbdTodos;
        private Microsoft.Reporting.WinForms.ReportViewer RvTodos;
        private System.Windows.Forms.TabPage tabSocio;
        private System.Windows.Forms.DateTimePicker DtpFechaHasta;
        private System.Windows.Forms.DateTimePicker DtpFechaDesde;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Microsoft.Reporting.WinForms.ReportViewer RVPeriodoSocio;
        private System.Windows.Forms.Label LblReportes;
        private System.Windows.Forms.Button BtnSalir;
    }
}