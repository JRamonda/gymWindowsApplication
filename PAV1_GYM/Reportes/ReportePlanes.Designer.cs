namespace PAV1_GYM.Reportes
{
    partial class ReportePlanes
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
            this.TCPlanes = new System.Windows.Forms.TabControl();
            this.TPPlanes = new System.Windows.Forms.TabPage();
            this.ChFiltrarFecha = new System.Windows.Forms.CheckBox();
            this.RbOrdenarPrecio = new System.Windows.Forms.RadioButton();
            this.RbOrdenarCantidad = new System.Windows.Forms.RadioButton();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnBuscarPlan = new System.Windows.Forms.Button();
            this.DtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.RvPlanes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LblFechaHasta = new System.Windows.Forms.Label();
            this.LblFechaDesde = new System.Windows.Forms.Label();
            this.LblReportes = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PanelFormHijo.SuspendLayout();
            this.TCPlanes.SuspendLayout();
            this.TPPlanes.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFormHijo
            // 
            this.PanelFormHijo.AutoScroll = true;
            this.PanelFormHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.PanelFormHijo.Controls.Add(this.TCPlanes);
            this.PanelFormHijo.Controls.Add(this.LblReportes);
            this.PanelFormHijo.Controls.Add(this.BtnSalir);
            this.PanelFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormHijo.Location = new System.Drawing.Point(0, 0);
            this.PanelFormHijo.Name = "PanelFormHijo";
            this.PanelFormHijo.Size = new System.Drawing.Size(800, 450);
            this.PanelFormHijo.TabIndex = 4;
            // 
            // TCPlanes
            // 
            this.TCPlanes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TCPlanes.Controls.Add(this.TPPlanes);
            this.TCPlanes.Location = new System.Drawing.Point(28, 50);
            this.TCPlanes.Name = "TCPlanes";
            this.TCPlanes.SelectedIndex = 0;
            this.TCPlanes.Size = new System.Drawing.Size(749, 341);
            this.TCPlanes.TabIndex = 43;
            // 
            // TPPlanes
            // 
            this.TPPlanes.Controls.Add(this.ChFiltrarFecha);
            this.TPPlanes.Controls.Add(this.RbOrdenarPrecio);
            this.TPPlanes.Controls.Add(this.RbOrdenarCantidad);
            this.TPPlanes.Controls.Add(this.BtnLimpiar);
            this.TPPlanes.Controls.Add(this.BtnBuscarPlan);
            this.TPPlanes.Controls.Add(this.DtpFechaHasta);
            this.TPPlanes.Controls.Add(this.DtpFechaDesde);
            this.TPPlanes.Controls.Add(this.RvPlanes);
            this.TPPlanes.Controls.Add(this.LblFechaHasta);
            this.TPPlanes.Controls.Add(this.LblFechaDesde);
            this.TPPlanes.Location = new System.Drawing.Point(4, 22);
            this.TPPlanes.Name = "TPPlanes";
            this.TPPlanes.Padding = new System.Windows.Forms.Padding(3);
            this.TPPlanes.Size = new System.Drawing.Size(741, 315);
            this.TPPlanes.TabIndex = 0;
            this.TPPlanes.Text = "Planes";
            this.TPPlanes.UseVisualStyleBackColor = true;
            // 
            // ChFiltrarFecha
            // 
            this.ChFiltrarFecha.AutoSize = true;
            this.ChFiltrarFecha.Location = new System.Drawing.Point(385, 10);
            this.ChFiltrarFecha.Name = "ChFiltrarFecha";
            this.ChFiltrarFecha.Size = new System.Drawing.Size(99, 17);
            this.ChFiltrarFecha.TabIndex = 66;
            this.ChFiltrarFecha.Text = "Filtrar por fecha";
            this.ChFiltrarFecha.UseVisualStyleBackColor = true;
            this.ChFiltrarFecha.CheckedChanged += new System.EventHandler(this.ChFiltrarFecha_CheckedChanged);
            // 
            // RbOrdenarPrecio
            // 
            this.RbOrdenarPrecio.AutoSize = true;
            this.RbOrdenarPrecio.Location = new System.Drawing.Point(140, 34);
            this.RbOrdenarPrecio.Name = "RbOrdenarPrecio";
            this.RbOrdenarPrecio.Size = new System.Drawing.Size(113, 17);
            this.RbOrdenarPrecio.TabIndex = 65;
            this.RbOrdenarPrecio.TabStop = true;
            this.RbOrdenarPrecio.Text = "Ordenar por precio";
            this.RbOrdenarPrecio.UseVisualStyleBackColor = true;
            // 
            // RbOrdenarCantidad
            // 
            this.RbOrdenarCantidad.AutoSize = true;
            this.RbOrdenarCantidad.Location = new System.Drawing.Point(9, 33);
            this.RbOrdenarCantidad.Name = "RbOrdenarCantidad";
            this.RbOrdenarCantidad.Size = new System.Drawing.Size(125, 17);
            this.RbOrdenarCantidad.TabIndex = 64;
            this.RbOrdenarCantidad.TabStop = true;
            this.RbOrdenarCantidad.Text = "Ordenar por cantidad";
            this.RbOrdenarCantidad.UseVisualStyleBackColor = true;
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
            // BtnBuscarPlan
            // 
            this.BtnBuscarPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnBuscarPlan.FlatAppearance.BorderSize = 0;
            this.BtnBuscarPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnBuscarPlan.ForeColor = System.Drawing.Color.LightGray;
            this.BtnBuscarPlan.Location = new System.Drawing.Point(660, 5);
            this.BtnBuscarPlan.Name = "BtnBuscarPlan";
            this.BtnBuscarPlan.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarPlan.TabIndex = 47;
            this.BtnBuscarPlan.Text = "Buscar";
            this.BtnBuscarPlan.UseVisualStyleBackColor = false;
            this.BtnBuscarPlan.Click += new System.EventHandler(this.BtnBuscarPlan_Click);
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
            // RvPlanes
            // 
            this.RvPlanes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RvPlanes.LocalReport.ReportEmbeddedResource = "PAV1_GYM.Reportes.Rdlc.Rpt_Planes.rdlc";
            this.RvPlanes.Location = new System.Drawing.Point(6, 63);
            this.RvPlanes.Name = "RvPlanes";
            this.RvPlanes.ServerReport.BearerToken = null;
            this.RvPlanes.Size = new System.Drawing.Size(729, 246);
            this.RvPlanes.TabIndex = 44;
            this.RvPlanes.Load += new System.EventHandler(this.RvPlanes_Load);
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
            this.LblReportes.Size = new System.Drawing.Size(205, 29);
            this.LblReportes.TabIndex = 15;
            this.LblReportes.Text = "Reportes de Planes";
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
            // ReportePlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelFormHijo);
            this.Name = "ReportePlanes";
            this.Text = "ReportePlanes";
            this.Load += new System.EventHandler(this.ReportePlanes_Load);
            this.PanelFormHijo.ResumeLayout(false);
            this.PanelFormHijo.PerformLayout();
            this.TCPlanes.ResumeLayout(false);
            this.TPPlanes.ResumeLayout(false);
            this.TPPlanes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFormHijo;
        private System.Windows.Forms.TabControl TCPlanes;
        private System.Windows.Forms.TabPage TPPlanes;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnBuscarPlan;
        private System.Windows.Forms.DateTimePicker DtpFechaHasta;
        private System.Windows.Forms.DateTimePicker DtpFechaDesde;
        private Microsoft.Reporting.WinForms.ReportViewer RvPlanes;
        private System.Windows.Forms.Label LblFechaHasta;
        private System.Windows.Forms.Label LblFechaDesde;
        private System.Windows.Forms.Label LblReportes;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.CheckBox ChFiltrarFecha;
        private System.Windows.Forms.RadioButton RbOrdenarPrecio;
        private System.Windows.Forms.RadioButton RbOrdenarCantidad;
    }
}