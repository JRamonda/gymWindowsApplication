
namespace PAV1_GYM.Reportes
{
    partial class ReporteEmpleados
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LblFechaDesde = new System.Windows.Forms.Label();
            this.DtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.LblFechaHasta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnRestringidoPorPerfil = new System.Windows.Forms.RadioButton();
            this.rbtnRestringidoFecha = new System.Windows.Forms.RadioButton();
            this.rbtnTodosLosEmpleados = new System.Windows.Forms.RadioButton();
            this.rptEmpleados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnTurno = new System.Windows.Forms.RadioButton();
            this.rbtnActividad = new System.Windows.Forms.RadioButton();
            this.rbtnTodosLosEmpleadosActividadYTurnos = new System.Windows.Forms.RadioButton();
            this.rptEmpleadosActividadTurnos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbTurnos = new System.Windows.Forms.ComboBox();
            this.cmbActividades = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar2 = new System.Windows.Forms.Button();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.cmbPerfiles = new System.Windows.Forms.ComboBox();
            this.LblPerfil = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 402);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LblPerfil);
            this.tabPage1.Controls.Add(this.cmbPerfiles);
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.LblFechaDesde);
            this.tabPage1.Controls.Add(this.DtpFechaDesde);
            this.tabPage1.Controls.Add(this.DtpFechaHasta);
            this.tabPage1.Controls.Add(this.LblFechaHasta);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.rptEmpleados);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(772, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reporte Simple";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LblFechaDesde
            // 
            this.LblFechaDesde.AutoSize = true;
            this.LblFechaDesde.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Underline);
            this.LblFechaDesde.ForeColor = System.Drawing.Color.Black;
            this.LblFechaDesde.Location = new System.Drawing.Point(284, 7);
            this.LblFechaDesde.Name = "LblFechaDesde";
            this.LblFechaDesde.Size = new System.Drawing.Size(79, 17);
            this.LblFechaDesde.TabIndex = 47;
            this.LblFechaDesde.Text = "Fecha Desde";
            this.LblFechaDesde.Visible = false;
            // 
            // DtpFechaDesde
            // 
            this.DtpFechaDesde.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DtpFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaDesde.Location = new System.Drawing.Point(367, 5);
            this.DtpFechaDesde.Name = "DtpFechaDesde";
            this.DtpFechaDesde.Size = new System.Drawing.Size(100, 21);
            this.DtpFechaDesde.TabIndex = 49;
            this.DtpFechaDesde.Visible = false;
            // 
            // DtpFechaHasta
            // 
            this.DtpFechaHasta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DtpFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaHasta.Location = new System.Drawing.Point(547, 3);
            this.DtpFechaHasta.Name = "DtpFechaHasta";
            this.DtpFechaHasta.Size = new System.Drawing.Size(101, 21);
            this.DtpFechaHasta.TabIndex = 50;
            this.DtpFechaHasta.Visible = false;
            // 
            // LblFechaHasta
            // 
            this.LblFechaHasta.AutoSize = true;
            this.LblFechaHasta.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Underline);
            this.LblFechaHasta.ForeColor = System.Drawing.Color.Black;
            this.LblFechaHasta.Location = new System.Drawing.Point(472, 7);
            this.LblFechaHasta.Name = "LblFechaHasta";
            this.LblFechaHasta.Size = new System.Drawing.Size(77, 17);
            this.LblFechaHasta.TabIndex = 48;
            this.LblFechaHasta.Text = "Fecha Hasta";
            this.LblFechaHasta.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnRestringidoPorPerfil);
            this.groupBox1.Controls.Add(this.rbtnRestringidoFecha);
            this.groupBox1.Controls.Add(this.rbtnTodosLosEmpleados);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rbtnRestringidoPorPerfil
            // 
            this.rbtnRestringidoPorPerfil.AutoSize = true;
            this.rbtnRestringidoPorPerfil.Location = new System.Drawing.Point(132, 14);
            this.rbtnRestringidoPorPerfil.Name = "rbtnRestringidoPorPerfil";
            this.rbtnRestringidoPorPerfil.Size = new System.Drawing.Size(122, 17);
            this.rbtnRestringidoPorPerfil.TabIndex = 2;
            this.rbtnRestringidoPorPerfil.TabStop = true;
            this.rbtnRestringidoPorPerfil.Text = "Restringido por Perfil";
            this.rbtnRestringidoPorPerfil.UseVisualStyleBackColor = true;
            this.rbtnRestringidoPorPerfil.CheckedChanged += new System.EventHandler(this.rbtnRestringidoPorPerfil_CheckedChanged);
            // 
            // rbtnRestringidoFecha
            // 
            this.rbtnRestringidoFecha.AutoSize = true;
            this.rbtnRestringidoFecha.Location = new System.Drawing.Point(18, 37);
            this.rbtnRestringidoFecha.Name = "rbtnRestringidoFecha";
            this.rbtnRestringidoFecha.Size = new System.Drawing.Size(182, 17);
            this.rbtnRestringidoFecha.TabIndex = 1;
            this.rbtnRestringidoFecha.TabStop = true;
            this.rbtnRestringidoFecha.Text = "Restringido por Fecha de Ingreso";
            this.rbtnRestringidoFecha.UseVisualStyleBackColor = true;
            this.rbtnRestringidoFecha.CheckedChanged += new System.EventHandler(this.rbtnRestringidoFecha_CheckedChanged);
            // 
            // rbtnTodosLosEmpleados
            // 
            this.rbtnTodosLosEmpleados.AutoSize = true;
            this.rbtnTodosLosEmpleados.Location = new System.Drawing.Point(0, 14);
            this.rbtnTodosLosEmpleados.Name = "rbtnTodosLosEmpleados";
            this.rbtnTodosLosEmpleados.Size = new System.Drawing.Size(126, 17);
            this.rbtnTodosLosEmpleados.TabIndex = 0;
            this.rbtnTodosLosEmpleados.TabStop = true;
            this.rbtnTodosLosEmpleados.Text = "Todos los Empleados";
            this.rbtnTodosLosEmpleados.UseVisualStyleBackColor = true;
            this.rbtnTodosLosEmpleados.CheckedChanged += new System.EventHandler(this.rbtnTodosLosEmpleados_CheckedChanged);
            // 
            // rptEmpleados
            // 
            this.rptEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rptEmpleados.LocalReport.ReportEmbeddedResource = "PAV1_GYM.Reportes.Rdlc.RptEmpleado.rdlc";
            this.rptEmpleados.Location = new System.Drawing.Point(3, 72);
            this.rptEmpleados.Name = "rptEmpleados";
            this.rptEmpleados.ServerReport.BearerToken = null;
            this.rptEmpleados.Size = new System.Drawing.Size(767, 276);
            this.rptEmpleados.TabIndex = 0;
            this.rptEmpleados.Load += new System.EventHandler(this.rptEmpleados_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLimpiar2);
            this.tabPage2.Controls.Add(this.btnBuscar2);
            this.tabPage2.Controls.Add(this.lblTurno);
            this.tabPage2.Controls.Add(this.lblActividad);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.rptEmpleadosActividadTurnos);
            this.tabPage2.Controls.Add(this.cmbTurnos);
            this.tabPage2.Controls.Add(this.cmbActividades);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(772, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reporte por Actividades y Turnos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(338, 43);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(96, 13);
            this.lblTurno.TabIndex = 5;
            this.lblTurno.Text = "Selecciones Turno";
            this.lblTurno.Visible = false;
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(338, 7);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(112, 13);
            this.lblActividad.TabIndex = 4;
            this.lblActividad.Text = "Selecciones Actividad";
            this.lblActividad.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnTurno);
            this.groupBox2.Controls.Add(this.rbtnActividad);
            this.groupBox2.Controls.Add(this.rbtnTodosLosEmpleadosActividadYTurnos);
            this.groupBox2.Location = new System.Drawing.Point(7, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // rbtnTurno
            // 
            this.rbtnTurno.AutoSize = true;
            this.rbtnTurno.Location = new System.Drawing.Point(161, 43);
            this.rbtnTurno.Name = "rbtnTurno";
            this.rbtnTurno.Size = new System.Drawing.Size(127, 17);
            this.rbtnTurno.TabIndex = 2;
            this.rbtnTurno.TabStop = true;
            this.rbtnTurno.Text = "Restringido por Turno";
            this.rbtnTurno.UseVisualStyleBackColor = true;
            this.rbtnTurno.CheckedChanged += new System.EventHandler(this.rbtnTurno_CheckedChanged);
            // 
            // rbtnActividad
            // 
            this.rbtnActividad.AutoSize = true;
            this.rbtnActividad.Location = new System.Drawing.Point(6, 43);
            this.rbtnActividad.Name = "rbtnActividad";
            this.rbtnActividad.Size = new System.Drawing.Size(143, 17);
            this.rbtnActividad.TabIndex = 1;
            this.rbtnActividad.TabStop = true;
            this.rbtnActividad.Text = "Restringido por Actividad";
            this.rbtnActividad.UseVisualStyleBackColor = true;
            this.rbtnActividad.CheckedChanged += new System.EventHandler(this.rbtnActividad_CheckedChanged);
            // 
            // rbtnTodosLosEmpleadosActividadYTurnos
            // 
            this.rbtnTodosLosEmpleadosActividadYTurnos.AutoSize = true;
            this.rbtnTodosLosEmpleadosActividadYTurnos.Location = new System.Drawing.Point(6, 19);
            this.rbtnTodosLosEmpleadosActividadYTurnos.Name = "rbtnTodosLosEmpleadosActividadYTurnos";
            this.rbtnTodosLosEmpleadosActividadYTurnos.Size = new System.Drawing.Size(263, 17);
            this.rbtnTodosLosEmpleadosActividadYTurnos.TabIndex = 0;
            this.rbtnTodosLosEmpleadosActividadYTurnos.TabStop = true;
            this.rbtnTodosLosEmpleadosActividadYTurnos.Text = "Todos los Empleados con su Actividades y Turnos";
            this.rbtnTodosLosEmpleadosActividadYTurnos.UseVisualStyleBackColor = true;
            this.rbtnTodosLosEmpleadosActividadYTurnos.CheckedChanged += new System.EventHandler(this.rbtnTodosLosEmpleadosActividadYTurnos_CheckedChanged);
            // 
            // rptEmpleadosActividadTurnos
            // 
            this.rptEmpleadosActividadTurnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rptEmpleadosActividadTurnos.LocalReport.ReportEmbeddedResource = "PAV1_GYM.Reportes.Rdlc.RptEmpActividadesTurnos.rdlc";
            this.rptEmpleadosActividadTurnos.Location = new System.Drawing.Point(4, 86);
            this.rptEmpleadosActividadTurnos.Name = "rptEmpleadosActividadTurnos";
            this.rptEmpleadosActividadTurnos.ServerReport.BearerToken = null;
            this.rptEmpleadosActividadTurnos.Size = new System.Drawing.Size(719, 256);
            this.rptEmpleadosActividadTurnos.TabIndex = 0;
            this.rptEmpleadosActividadTurnos.Load += new System.EventHandler(this.rptEmpleadosActividadTurnos_Load);
            // 
            // cmbTurnos
            // 
            this.cmbTurnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurnos.FormattingEnabled = true;
            this.cmbTurnos.Location = new System.Drawing.Point(341, 59);
            this.cmbTurnos.Name = "cmbTurnos";
            this.cmbTurnos.Size = new System.Drawing.Size(121, 21);
            this.cmbTurnos.TabIndex = 3;
            this.cmbTurnos.Visible = false;
            // 
            // cmbActividades
            // 
            this.cmbActividades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActividades.FormattingEnabled = true;
            this.cmbActividades.Location = new System.Drawing.Point(341, 23);
            this.cmbActividades.Name = "cmbActividades";
            this.cmbActividades.Size = new System.Drawing.Size(121, 21);
            this.cmbActividades.TabIndex = 2;
            this.cmbActividades.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reporte Empleados";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.ForeColor = System.Drawing.Color.LightGray;
            this.BtnSalir.Location = new System.Drawing.Point(708, 474);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(80, 30);
            this.BtnSalir.TabIndex = 14;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiar.Location = new System.Drawing.Point(691, 40);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 58;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.LightGray;
            this.btnBuscar.Location = new System.Drawing.Point(691, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 57;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnLimpiar2.FlatAppearance.BorderSize = 0;
            this.btnLimpiar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar2.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiar2.Location = new System.Drawing.Point(648, 49);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar2.TabIndex = 50;
            this.btnLimpiar2.Text = "Limpiar";
            this.btnLimpiar2.UseVisualStyleBackColor = false;
            this.btnLimpiar2.Click += new System.EventHandler(this.btnLimpiar2_Click);
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnBuscar2.FlatAppearance.BorderSize = 0;
            this.btnBuscar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar2.ForeColor = System.Drawing.Color.LightGray;
            this.btnBuscar2.Location = new System.Drawing.Point(648, 20);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar2.TabIndex = 49;
            this.btnBuscar2.Text = "Buscar";
            this.btnBuscar2.UseVisualStyleBackColor = false;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // cmbPerfiles
            // 
            this.cmbPerfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfiles.FormattingEnabled = true;
            this.cmbPerfiles.Location = new System.Drawing.Point(329, 36);
            this.cmbPerfiles.Name = "cmbPerfiles";
            this.cmbPerfiles.Size = new System.Drawing.Size(121, 21);
            this.cmbPerfiles.TabIndex = 59;
            this.cmbPerfiles.Visible = false;
            // 
            // LblPerfil
            // 
            this.LblPerfil.AutoSize = true;
            this.LblPerfil.Location = new System.Drawing.Point(293, 40);
            this.LblPerfil.Name = "LblPerfil";
            this.LblPerfil.Size = new System.Drawing.Size(30, 13);
            this.LblPerfil.TabIndex = 60;
            this.LblPerfil.Text = "Perfil";
            this.LblPerfil.Visible = false;
            // 
            // ReporteEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(809, 516);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "ReporteEmpleados";
            this.Text = "ReporteEmpleados";
            this.Load += new System.EventHandler(this.ReporteEmpleados_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rptEmpleados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnRestringidoPorPerfil;
        private System.Windows.Forms.RadioButton rbtnRestringidoFecha;
        private System.Windows.Forms.RadioButton rbtnTodosLosEmpleados;
        private Microsoft.Reporting.WinForms.ReportViewer rptEmpleadosActividadTurnos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnTurno;
        private System.Windows.Forms.RadioButton rbtnActividad;
        private System.Windows.Forms.RadioButton rbtnTodosLosEmpleadosActividadYTurnos;
        private System.Windows.Forms.DateTimePicker DtpFechaHasta;
        private System.Windows.Forms.DateTimePicker DtpFechaDesde;
        private System.Windows.Forms.Label LblFechaHasta;
        private System.Windows.Forms.Label LblFechaDesde;
        private System.Windows.Forms.ComboBox cmbTurnos;
        private System.Windows.Forms.ComboBox cmbActividades;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar2;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.Label LblPerfil;
        private System.Windows.Forms.ComboBox cmbPerfiles;
    }
}