namespace PAV1_GYM.Reportes
{
    partial class ReporteTurnos
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
            this.TCTurnos = new System.Windows.Forms.TabControl();
            this.TPTurnos = new System.Windows.Forms.TabPage();
            this.LblMenorQue = new System.Windows.Forms.Label();
            this.GbSexo = new System.Windows.Forms.GroupBox();
            this.CkEdad = new System.Windows.Forms.CheckBox();
            this.TxtEdadFinal = new System.Windows.Forms.TextBox();
            this.TxtEdadInicial = new System.Windows.Forms.TextBox();
            this.ChFiltrarFecha = new System.Windows.Forms.CheckBox();
            this.DtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.LblFechaHasta = new System.Windows.Forms.Label();
            this.DtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.LblFechaDesde = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnBuscarTurno = new System.Windows.Forms.Button();
            this.RvTurnos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LblReportes = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.RbMasc = new System.Windows.Forms.RadioButton();
            this.RbFem = new System.Windows.Forms.RadioButton();
            this.TCTurnos.SuspendLayout();
            this.TPTurnos.SuspendLayout();
            this.GbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCTurnos
            // 
            this.TCTurnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TCTurnos.Controls.Add(this.TPTurnos);
            this.TCTurnos.Location = new System.Drawing.Point(17, 41);
            this.TCTurnos.Name = "TCTurnos";
            this.TCTurnos.SelectedIndex = 0;
            this.TCTurnos.Size = new System.Drawing.Size(789, 437);
            this.TCTurnos.TabIndex = 20;
            // 
            // TPTurnos
            // 
            this.TPTurnos.Controls.Add(this.LblMenorQue);
            this.TPTurnos.Controls.Add(this.GbSexo);
            this.TPTurnos.Controls.Add(this.CkEdad);
            this.TPTurnos.Controls.Add(this.TxtEdadFinal);
            this.TPTurnos.Controls.Add(this.TxtEdadInicial);
            this.TPTurnos.Controls.Add(this.ChFiltrarFecha);
            this.TPTurnos.Controls.Add(this.DtpFechaHasta);
            this.TPTurnos.Controls.Add(this.LblFechaHasta);
            this.TPTurnos.Controls.Add(this.DtpFechaDesde);
            this.TPTurnos.Controls.Add(this.LblFechaDesde);
            this.TPTurnos.Controls.Add(this.BtnLimpiar);
            this.TPTurnos.Controls.Add(this.BtnBuscarTurno);
            this.TPTurnos.Controls.Add(this.RvTurnos);
            this.TPTurnos.Location = new System.Drawing.Point(4, 22);
            this.TPTurnos.Name = "TPTurnos";
            this.TPTurnos.Padding = new System.Windows.Forms.Padding(3);
            this.TPTurnos.Size = new System.Drawing.Size(781, 411);
            this.TPTurnos.TabIndex = 0;
            this.TPTurnos.Text = "Turnos";
            this.TPTurnos.UseVisualStyleBackColor = true;
            // 
            // LblMenorQue
            // 
            this.LblMenorQue.AutoSize = true;
            this.LblMenorQue.Font = new System.Drawing.Font("Calibri", 10F);
            this.LblMenorQue.ForeColor = System.Drawing.Color.Black;
            this.LblMenorQue.Location = new System.Drawing.Point(202, 58);
            this.LblMenorQue.Name = "LblMenorQue";
            this.LblMenorQue.Size = new System.Drawing.Size(15, 17);
            this.LblMenorQue.TabIndex = 75;
            this.LblMenorQue.Text = "<";
            // 
            // GbSexo
            // 
            this.GbSexo.Controls.Add(this.RbFem);
            this.GbSexo.Controls.Add(this.RbMasc);
            this.GbSexo.Location = new System.Drawing.Point(6, 35);
            this.GbSexo.Name = "GbSexo";
            this.GbSexo.Size = new System.Drawing.Size(89, 56);
            this.GbSexo.TabIndex = 74;
            this.GbSexo.TabStop = false;
            this.GbSexo.Text = "Sexo";
            // 
            // CkEdad
            // 
            this.CkEdad.AutoSize = true;
            this.CkEdad.Location = new System.Drawing.Point(150, 35);
            this.CkEdad.Name = "CkEdad";
            this.CkEdad.Size = new System.Drawing.Size(51, 17);
            this.CkEdad.TabIndex = 71;
            this.CkEdad.Text = "Edad";
            this.CkEdad.UseVisualStyleBackColor = true;
            this.CkEdad.CheckedChanged += new System.EventHandler(this.CkEdad_CheckedChanged);
            // 
            // TxtEdadFinal
            // 
            this.TxtEdadFinal.Location = new System.Drawing.Point(224, 58);
            this.TxtEdadFinal.Name = "TxtEdadFinal";
            this.TxtEdadFinal.Size = new System.Drawing.Size(46, 20);
            this.TxtEdadFinal.TabIndex = 70;
            // 
            // TxtEdadInicial
            // 
            this.TxtEdadInicial.Location = new System.Drawing.Point(150, 58);
            this.TxtEdadInicial.Name = "TxtEdadInicial";
            this.TxtEdadInicial.Size = new System.Drawing.Size(46, 20);
            this.TxtEdadInicial.TabIndex = 69;
            // 
            // ChFiltrarFecha
            // 
            this.ChFiltrarFecha.AutoSize = true;
            this.ChFiltrarFecha.Location = new System.Drawing.Point(437, 9);
            this.ChFiltrarFecha.Name = "ChFiltrarFecha";
            this.ChFiltrarFecha.Size = new System.Drawing.Size(99, 17);
            this.ChFiltrarFecha.TabIndex = 67;
            this.ChFiltrarFecha.Text = "Filtrar por fecha";
            this.ChFiltrarFecha.UseVisualStyleBackColor = true;
            this.ChFiltrarFecha.CheckedChanged += new System.EventHandler(this.ChFiltrarFecha_CheckedChanged);
            // 
            // DtpFechaHasta
            // 
            this.DtpFechaHasta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DtpFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaHasta.Location = new System.Drawing.Point(304, 5);
            this.DtpFechaHasta.Name = "DtpFechaHasta";
            this.DtpFechaHasta.Size = new System.Drawing.Size(100, 21);
            this.DtpFechaHasta.TabIndex = 54;
            // 
            // LblFechaHasta
            // 
            this.LblFechaHasta.AutoSize = true;
            this.LblFechaHasta.Font = new System.Drawing.Font("Calibri", 10F);
            this.LblFechaHasta.ForeColor = System.Drawing.Color.Black;
            this.LblFechaHasta.Location = new System.Drawing.Point(221, 6);
            this.LblFechaHasta.Name = "LblFechaHasta";
            this.LblFechaHasta.Size = new System.Drawing.Size(77, 17);
            this.LblFechaHasta.TabIndex = 53;
            this.LblFechaHasta.Text = "Fecha Hasta";
            // 
            // DtpFechaDesde
            // 
            this.DtpFechaDesde.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DtpFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaDesde.Location = new System.Drawing.Point(88, 5);
            this.DtpFechaDesde.Name = "DtpFechaDesde";
            this.DtpFechaDesde.Size = new System.Drawing.Size(100, 21);
            this.DtpFechaDesde.TabIndex = 52;
            // 
            // LblFechaDesde
            // 
            this.LblFechaDesde.AutoSize = true;
            this.LblFechaDesde.Font = new System.Drawing.Font("Calibri", 10F);
            this.LblFechaDesde.ForeColor = System.Drawing.Color.Black;
            this.LblFechaDesde.Location = new System.Drawing.Point(3, 6);
            this.LblFechaDesde.Name = "LblFechaDesde";
            this.LblFechaDesde.Size = new System.Drawing.Size(79, 17);
            this.LblFechaDesde.TabIndex = 51;
            this.LblFechaDesde.Text = "Fecha Desde";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnLimpiar.Location = new System.Drawing.Point(703, 35);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 49;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnBuscarTurno
            // 
            this.BtnBuscarTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnBuscarTurno.FlatAppearance.BorderSize = 0;
            this.BtnBuscarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnBuscarTurno.ForeColor = System.Drawing.Color.LightGray;
            this.BtnBuscarTurno.Location = new System.Drawing.Point(703, 6);
            this.BtnBuscarTurno.Name = "BtnBuscarTurno";
            this.BtnBuscarTurno.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarTurno.TabIndex = 48;
            this.BtnBuscarTurno.Text = "Buscar";
            this.BtnBuscarTurno.UseVisualStyleBackColor = false;
            this.BtnBuscarTurno.Click += new System.EventHandler(this.BtnBuscarTurno_Click);
            // 
            // RvTurnos
            // 
            this.RvTurnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RvTurnos.LocalReport.ReportEmbeddedResource = "PAV1_GYM.Reportes.Rdlc.Rpt_Turnos.rdlc";
            this.RvTurnos.Location = new System.Drawing.Point(6, 97);
            this.RvTurnos.Name = "RvTurnos";
            this.RvTurnos.ServerReport.BearerToken = null;
            this.RvTurnos.Size = new System.Drawing.Size(769, 307);
            this.RvTurnos.TabIndex = 3;
            this.RvTurnos.Load += new System.EventHandler(this.RvTurnos_Load);
            // 
            // LblReportes
            // 
            this.LblReportes.AutoSize = true;
            this.LblReportes.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.LblReportes.ForeColor = System.Drawing.Color.Silver;
            this.LblReportes.Location = new System.Drawing.Point(12, 9);
            this.LblReportes.Name = "LblReportes";
            this.LblReportes.Size = new System.Drawing.Size(208, 29);
            this.LblReportes.TabIndex = 19;
            this.LblReportes.Text = "Reportes de Turnos";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.ForeColor = System.Drawing.Color.LightGray;
            this.BtnSalir.Location = new System.Drawing.Point(726, 496);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(80, 30);
            this.BtnSalir.TabIndex = 21;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // RbMasc
            // 
            this.RbMasc.AutoSize = true;
            this.RbMasc.Location = new System.Drawing.Point(5, 14);
            this.RbMasc.Name = "RbMasc";
            this.RbMasc.Size = new System.Drawing.Size(73, 17);
            this.RbMasc.TabIndex = 0;
            this.RbMasc.TabStop = true;
            this.RbMasc.Text = "Masculino";
            this.RbMasc.UseVisualStyleBackColor = true;
            // 
            // RbFem
            // 
            this.RbFem.AutoSize = true;
            this.RbFem.Location = new System.Drawing.Point(5, 33);
            this.RbFem.Name = "RbFem";
            this.RbFem.Size = new System.Drawing.Size(71, 17);
            this.RbFem.TabIndex = 1;
            this.RbFem.TabStop = true;
            this.RbFem.Text = "Femenino";
            this.RbFem.UseVisualStyleBackColor = true;
            // 
            // ReporteTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(834, 538);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.TCTurnos);
            this.Controls.Add(this.LblReportes);
            this.Name = "ReporteTurnos";
            this.Text = "ReporteTurnos";
            this.Load += new System.EventHandler(this.ReporteTurnos_Load);
            this.TCTurnos.ResumeLayout(false);
            this.TPTurnos.ResumeLayout(false);
            this.TPTurnos.PerformLayout();
            this.GbSexo.ResumeLayout(false);
            this.GbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TCTurnos;
        private System.Windows.Forms.TabPage TPTurnos;
        private System.Windows.Forms.Label LblMenorQue;
        private System.Windows.Forms.GroupBox GbSexo;
        private System.Windows.Forms.CheckBox CkEdad;
        private System.Windows.Forms.TextBox TxtEdadFinal;
        private System.Windows.Forms.TextBox TxtEdadInicial;
        private System.Windows.Forms.CheckBox ChFiltrarFecha;
        private System.Windows.Forms.DateTimePicker DtpFechaHasta;
        private System.Windows.Forms.Label LblFechaHasta;
        private System.Windows.Forms.DateTimePicker DtpFechaDesde;
        private System.Windows.Forms.Label LblFechaDesde;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnBuscarTurno;
        private Microsoft.Reporting.WinForms.ReportViewer RvTurnos;
        private System.Windows.Forms.Label LblReportes;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.RadioButton RbFem;
        private System.Windows.Forms.RadioButton RbMasc;
    }
}