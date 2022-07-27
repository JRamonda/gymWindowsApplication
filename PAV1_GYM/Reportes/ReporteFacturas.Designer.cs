namespace PAV1_GYM.Reportes
{
    partial class ReporteFacturas
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
            this.TCFacturacion = new System.Windows.Forms.TabControl();
            this.TPFacturacion = new System.Windows.Forms.TabPage();
            this.ChFiltrarFecha = new System.Windows.Forms.CheckBox();
            this.ChOrdenarPrecio = new System.Windows.Forms.CheckBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnBuscarFacturacion = new System.Windows.Forms.Button();
            this.DtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.RvFacturas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LblFechaHasta = new System.Windows.Forms.Label();
            this.LblFechaDesde = new System.Windows.Forms.Label();
            this.TbDetalleFacturacion = new System.Windows.Forms.TabPage();
            this.ChFiltrarFechaDF = new System.Windows.Forms.CheckBox();
            this.ChOrdenarPrecioDF = new System.Windows.Forms.CheckBox();
            this.BtnLimpiarDF = new System.Windows.Forms.Button();
            this.CbNroFactura = new System.Windows.Forms.ComboBox();
            this.LblNroFactura = new System.Windows.Forms.Label();
            this.CbPlan = new System.Windows.Forms.ComboBox();
            this.CbActividad = new System.Windows.Forms.ComboBox();
            this.LblPlan = new System.Windows.Forms.Label();
            this.LblActividad = new System.Windows.Forms.Label();
            this.BtnBuscarDetalleFacturacion = new System.Windows.Forms.Button();
            this.DtpFechaHastaDF = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaDesdeDF = new System.Windows.Forms.DateTimePicker();
            this.RvDetalleFacturas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LblFechaHastaDF = new System.Windows.Forms.Label();
            this.LblFechaDesdeDF = new System.Windows.Forms.Label();
            this.LblReportes = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PanelFormHijo.SuspendLayout();
            this.TCFacturacion.SuspendLayout();
            this.TPFacturacion.SuspendLayout();
            this.TbDetalleFacturacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFormHijo
            // 
            this.PanelFormHijo.AutoScroll = true;
            this.PanelFormHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.PanelFormHijo.Controls.Add(this.TCFacturacion);
            this.PanelFormHijo.Controls.Add(this.LblReportes);
            this.PanelFormHijo.Controls.Add(this.BtnSalir);
            this.PanelFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormHijo.Location = new System.Drawing.Point(0, 0);
            this.PanelFormHijo.Name = "PanelFormHijo";
            this.PanelFormHijo.Size = new System.Drawing.Size(692, 467);
            this.PanelFormHijo.TabIndex = 3;
            // 
            // TCFacturacion
            // 
            this.TCFacturacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TCFacturacion.Controls.Add(this.TPFacturacion);
            this.TCFacturacion.Controls.Add(this.TbDetalleFacturacion);
            this.TCFacturacion.Location = new System.Drawing.Point(28, 50);
            this.TCFacturacion.Name = "TCFacturacion";
            this.TCFacturacion.SelectedIndex = 0;
            this.TCFacturacion.Size = new System.Drawing.Size(641, 358);
            this.TCFacturacion.TabIndex = 43;
            // 
            // TPFacturacion
            // 
            this.TPFacturacion.Controls.Add(this.ChFiltrarFecha);
            this.TPFacturacion.Controls.Add(this.ChOrdenarPrecio);
            this.TPFacturacion.Controls.Add(this.BtnLimpiar);
            this.TPFacturacion.Controls.Add(this.BtnBuscarFacturacion);
            this.TPFacturacion.Controls.Add(this.DtpFechaHasta);
            this.TPFacturacion.Controls.Add(this.DtpFechaDesde);
            this.TPFacturacion.Controls.Add(this.RvFacturas);
            this.TPFacturacion.Controls.Add(this.LblFechaHasta);
            this.TPFacturacion.Controls.Add(this.LblFechaDesde);
            this.TPFacturacion.Location = new System.Drawing.Point(4, 22);
            this.TPFacturacion.Name = "TPFacturacion";
            this.TPFacturacion.Padding = new System.Windows.Forms.Padding(3);
            this.TPFacturacion.Size = new System.Drawing.Size(633, 332);
            this.TPFacturacion.TabIndex = 0;
            this.TPFacturacion.Text = "Facturacion";
            this.TPFacturacion.UseVisualStyleBackColor = true;
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
            // ChOrdenarPrecio
            // 
            this.ChOrdenarPrecio.AutoSize = true;
            this.ChOrdenarPrecio.Location = new System.Drawing.Point(9, 34);
            this.ChOrdenarPrecio.Name = "ChOrdenarPrecio";
            this.ChOrdenarPrecio.Size = new System.Drawing.Size(114, 17);
            this.ChOrdenarPrecio.TabIndex = 69;
            this.ChOrdenarPrecio.Text = "Ordenar por precio";
            this.ChOrdenarPrecio.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnLimpiar.Location = new System.Drawing.Point(552, 34);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 48;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnBuscarFacturacion
            // 
            this.BtnBuscarFacturacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnBuscarFacturacion.FlatAppearance.BorderSize = 0;
            this.BtnBuscarFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnBuscarFacturacion.ForeColor = System.Drawing.Color.LightGray;
            this.BtnBuscarFacturacion.Location = new System.Drawing.Point(552, 5);
            this.BtnBuscarFacturacion.Name = "BtnBuscarFacturacion";
            this.BtnBuscarFacturacion.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarFacturacion.TabIndex = 47;
            this.BtnBuscarFacturacion.Text = "Buscar";
            this.BtnBuscarFacturacion.UseVisualStyleBackColor = false;
            this.BtnBuscarFacturacion.Click += new System.EventHandler(this.BtnBuscarFacturacion_Click);
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
            // RvFacturas
            // 
            this.RvFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RvFacturas.LocalReport.ReportEmbeddedResource = "PAV1_GYM.Reportes.Rdlc.Rpt_Facturacion.rdlc";
            this.RvFacturas.Location = new System.Drawing.Point(6, 63);
            this.RvFacturas.Name = "RvFacturas";
            this.RvFacturas.ServerReport.BearerToken = null;
            this.RvFacturas.Size = new System.Drawing.Size(621, 263);
            this.RvFacturas.TabIndex = 44;
            this.RvFacturas.Load += new System.EventHandler(this.RvFacturas_Load);
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
            // TbDetalleFacturacion
            // 
            this.TbDetalleFacturacion.Controls.Add(this.ChFiltrarFechaDF);
            this.TbDetalleFacturacion.Controls.Add(this.ChOrdenarPrecioDF);
            this.TbDetalleFacturacion.Controls.Add(this.BtnLimpiarDF);
            this.TbDetalleFacturacion.Controls.Add(this.CbNroFactura);
            this.TbDetalleFacturacion.Controls.Add(this.LblNroFactura);
            this.TbDetalleFacturacion.Controls.Add(this.CbPlan);
            this.TbDetalleFacturacion.Controls.Add(this.CbActividad);
            this.TbDetalleFacturacion.Controls.Add(this.LblPlan);
            this.TbDetalleFacturacion.Controls.Add(this.LblActividad);
            this.TbDetalleFacturacion.Controls.Add(this.BtnBuscarDetalleFacturacion);
            this.TbDetalleFacturacion.Controls.Add(this.DtpFechaHastaDF);
            this.TbDetalleFacturacion.Controls.Add(this.DtpFechaDesdeDF);
            this.TbDetalleFacturacion.Controls.Add(this.RvDetalleFacturas);
            this.TbDetalleFacturacion.Controls.Add(this.LblFechaHastaDF);
            this.TbDetalleFacturacion.Controls.Add(this.LblFechaDesdeDF);
            this.TbDetalleFacturacion.Location = new System.Drawing.Point(4, 22);
            this.TbDetalleFacturacion.Name = "TbDetalleFacturacion";
            this.TbDetalleFacturacion.Padding = new System.Windows.Forms.Padding(3);
            this.TbDetalleFacturacion.Size = new System.Drawing.Size(633, 332);
            this.TbDetalleFacturacion.TabIndex = 1;
            this.TbDetalleFacturacion.Text = "Detalle Facturacion";
            this.TbDetalleFacturacion.UseVisualStyleBackColor = true;
            // 
            // ChFiltrarFechaDF
            // 
            this.ChFiltrarFechaDF.AutoSize = true;
            this.ChFiltrarFechaDF.Location = new System.Drawing.Point(385, 11);
            this.ChFiltrarFechaDF.Name = "ChFiltrarFechaDF";
            this.ChFiltrarFechaDF.Size = new System.Drawing.Size(99, 17);
            this.ChFiltrarFechaDF.TabIndex = 69;
            this.ChFiltrarFechaDF.Text = "Filtrar por fecha";
            this.ChFiltrarFechaDF.UseVisualStyleBackColor = true;
            this.ChFiltrarFechaDF.CheckedChanged += new System.EventHandler(this.ChFiltrarFechaDF_CheckedChanged);
            // 
            // ChOrdenarPrecioDF
            // 
            this.ChOrdenarPrecioDF.AutoSize = true;
            this.ChOrdenarPrecioDF.Location = new System.Drawing.Point(9, 65);
            this.ChOrdenarPrecioDF.Name = "ChOrdenarPrecioDF";
            this.ChOrdenarPrecioDF.Size = new System.Drawing.Size(114, 17);
            this.ChOrdenarPrecioDF.TabIndex = 68;
            this.ChOrdenarPrecioDF.Text = "Ordenar por precio";
            this.ChOrdenarPrecioDF.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiarDF
            // 
            this.BtnLimpiarDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiarDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnLimpiarDF.FlatAppearance.BorderSize = 0;
            this.BtnLimpiarDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiarDF.ForeColor = System.Drawing.Color.LightGray;
            this.BtnLimpiarDF.Location = new System.Drawing.Point(552, 34);
            this.BtnLimpiarDF.Name = "BtnLimpiarDF";
            this.BtnLimpiarDF.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiarDF.TabIndex = 60;
            this.BtnLimpiarDF.Text = "Limpiar";
            this.BtnLimpiarDF.UseVisualStyleBackColor = false;
            this.BtnLimpiarDF.Click += new System.EventHandler(this.BtnLimpiarDF_Click);
            // 
            // CbNroFactura
            // 
            this.CbNroFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbNroFactura.FormattingEnabled = true;
            this.CbNroFactura.Location = new System.Drawing.Point(439, 38);
            this.CbNroFactura.Name = "CbNroFactura";
            this.CbNroFactura.Size = new System.Drawing.Size(42, 21);
            this.CbNroFactura.TabIndex = 59;
            // 
            // LblNroFactura
            // 
            this.LblNroFactura.AutoSize = true;
            this.LblNroFactura.Font = new System.Drawing.Font("Calibri", 10F);
            this.LblNroFactura.ForeColor = System.Drawing.Color.Black;
            this.LblNroFactura.Location = new System.Drawing.Point(358, 40);
            this.LblNroFactura.Name = "LblNroFactura";
            this.LblNroFactura.Size = new System.Drawing.Size(75, 17);
            this.LblNroFactura.TabIndex = 58;
            this.LblNroFactura.Text = "Nro Factura";
            // 
            // CbPlan
            // 
            this.CbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPlan.FormattingEnabled = true;
            this.CbPlan.Location = new System.Drawing.Point(234, 38);
            this.CbPlan.Name = "CbPlan";
            this.CbPlan.Size = new System.Drawing.Size(100, 21);
            this.CbPlan.TabIndex = 57;
            // 
            // CbActividad
            // 
            this.CbActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbActividad.FormattingEnabled = true;
            this.CbActividad.Location = new System.Drawing.Point(72, 38);
            this.CbActividad.Name = "CbActividad";
            this.CbActividad.Size = new System.Drawing.Size(100, 21);
            this.CbActividad.TabIndex = 56;
            // 
            // LblPlan
            // 
            this.LblPlan.AutoSize = true;
            this.LblPlan.Font = new System.Drawing.Font("Calibri", 10F);
            this.LblPlan.ForeColor = System.Drawing.Color.Black;
            this.LblPlan.Location = new System.Drawing.Point(196, 40);
            this.LblPlan.Name = "LblPlan";
            this.LblPlan.Size = new System.Drawing.Size(32, 17);
            this.LblPlan.TabIndex = 55;
            this.LblPlan.Text = "Plan";
            // 
            // LblActividad
            // 
            this.LblActividad.AutoSize = true;
            this.LblActividad.Font = new System.Drawing.Font("Calibri", 10F);
            this.LblActividad.ForeColor = System.Drawing.Color.Black;
            this.LblActividad.Location = new System.Drawing.Point(6, 40);
            this.LblActividad.Name = "LblActividad";
            this.LblActividad.Size = new System.Drawing.Size(60, 17);
            this.LblActividad.TabIndex = 54;
            this.LblActividad.Text = "Actividad";
            // 
            // BtnBuscarDetalleFacturacion
            // 
            this.BtnBuscarDetalleFacturacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarDetalleFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnBuscarDetalleFacturacion.FlatAppearance.BorderSize = 0;
            this.BtnBuscarDetalleFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarDetalleFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnBuscarDetalleFacturacion.ForeColor = System.Drawing.Color.LightGray;
            this.BtnBuscarDetalleFacturacion.Location = new System.Drawing.Point(552, 6);
            this.BtnBuscarDetalleFacturacion.Name = "BtnBuscarDetalleFacturacion";
            this.BtnBuscarDetalleFacturacion.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarDetalleFacturacion.TabIndex = 53;
            this.BtnBuscarDetalleFacturacion.Text = "Buscar";
            this.BtnBuscarDetalleFacturacion.UseVisualStyleBackColor = false;
            this.BtnBuscarDetalleFacturacion.Click += new System.EventHandler(this.BtnBuscarDetalleFacturacion_Click);
            // 
            // DtpFechaHastaDF
            // 
            this.DtpFechaHastaDF.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DtpFechaHastaDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DtpFechaHastaDF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaHastaDF.Location = new System.Drawing.Point(279, 7);
            this.DtpFechaHastaDF.Name = "DtpFechaHastaDF";
            this.DtpFechaHastaDF.Size = new System.Drawing.Size(100, 21);
            this.DtpFechaHastaDF.TabIndex = 52;
            // 
            // DtpFechaDesdeDF
            // 
            this.DtpFechaDesdeDF.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DtpFechaDesdeDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DtpFechaDesdeDF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaDesdeDF.Location = new System.Drawing.Point(90, 7);
            this.DtpFechaDesdeDF.Name = "DtpFechaDesdeDF";
            this.DtpFechaDesdeDF.Size = new System.Drawing.Size(100, 21);
            this.DtpFechaDesdeDF.TabIndex = 51;
            // 
            // RvDetalleFacturas
            // 
            this.RvDetalleFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RvDetalleFacturas.LocalReport.ReportEmbeddedResource = "PAV1_GYM.Reportes.Rdlc.Rpt_DetalleFacturacion.rdlc";
            this.RvDetalleFacturas.Location = new System.Drawing.Point(6, 88);
            this.RvDetalleFacturas.Name = "RvDetalleFacturas";
            this.RvDetalleFacturas.ServerReport.BearerToken = null;
            this.RvDetalleFacturas.Size = new System.Drawing.Size(621, 239);
            this.RvDetalleFacturas.TabIndex = 50;
            this.RvDetalleFacturas.Load += new System.EventHandler(this.RvDetalleFacturas_Load);
            // 
            // LblFechaHastaDF
            // 
            this.LblFechaHastaDF.AutoSize = true;
            this.LblFechaHastaDF.Font = new System.Drawing.Font("Calibri", 10F);
            this.LblFechaHastaDF.ForeColor = System.Drawing.Color.Black;
            this.LblFechaHastaDF.Location = new System.Drawing.Point(196, 11);
            this.LblFechaHastaDF.Name = "LblFechaHastaDF";
            this.LblFechaHastaDF.Size = new System.Drawing.Size(77, 17);
            this.LblFechaHastaDF.TabIndex = 49;
            this.LblFechaHastaDF.Text = "Fecha Hasta";
            // 
            // LblFechaDesdeDF
            // 
            this.LblFechaDesdeDF.AutoSize = true;
            this.LblFechaDesdeDF.Font = new System.Drawing.Font("Calibri", 10F);
            this.LblFechaDesdeDF.ForeColor = System.Drawing.Color.Black;
            this.LblFechaDesdeDF.Location = new System.Drawing.Point(6, 11);
            this.LblFechaDesdeDF.Name = "LblFechaDesdeDF";
            this.LblFechaDesdeDF.Size = new System.Drawing.Size(79, 17);
            this.LblFechaDesdeDF.TabIndex = 48;
            this.LblFechaDesdeDF.Text = "Fecha Desde";
            // 
            // LblReportes
            // 
            this.LblReportes.AutoSize = true;
            this.LblReportes.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.LblReportes.ForeColor = System.Drawing.Color.Silver;
            this.LblReportes.Location = new System.Drawing.Point(23, 9);
            this.LblReportes.Name = "LblReportes";
            this.LblReportes.Size = new System.Drawing.Size(254, 29);
            this.LblReportes.TabIndex = 15;
            this.LblReportes.Text = "Reportes de Facturacion";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.ForeColor = System.Drawing.Color.LightGray;
            this.BtnSalir.Location = new System.Drawing.Point(589, 425);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(80, 30);
            this.BtnSalir.TabIndex = 13;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // ReporteFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 467);
            this.Controls.Add(this.PanelFormHijo);
            this.Name = "ReporteFacturas";
            this.Text = "ReporteFacturas";
            this.Load += new System.EventHandler(this.ReporteFacturas_Load);
            this.PanelFormHijo.ResumeLayout(false);
            this.PanelFormHijo.PerformLayout();
            this.TCFacturacion.ResumeLayout(false);
            this.TPFacturacion.ResumeLayout(false);
            this.TPFacturacion.PerformLayout();
            this.TbDetalleFacturacion.ResumeLayout(false);
            this.TbDetalleFacturacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFormHijo;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label LblReportes;
        private System.Windows.Forms.Label LblFechaHasta;
        private System.Windows.Forms.Label LblFechaDesde;
        private System.Windows.Forms.TabControl TCFacturacion;
        private System.Windows.Forms.TabPage TPFacturacion;
        private Microsoft.Reporting.WinForms.ReportViewer RvFacturas;
        private System.Windows.Forms.TabPage TbDetalleFacturacion;
        private System.Windows.Forms.DateTimePicker DtpFechaHasta;
        private System.Windows.Forms.DateTimePicker DtpFechaDesde;
        private System.Windows.Forms.Button BtnBuscarFacturacion;
        private System.Windows.Forms.Button BtnBuscarDetalleFacturacion;
        private System.Windows.Forms.DateTimePicker DtpFechaHastaDF;
        private System.Windows.Forms.DateTimePicker DtpFechaDesdeDF;
        private Microsoft.Reporting.WinForms.ReportViewer RvDetalleFacturas;
        private System.Windows.Forms.Label LblFechaHastaDF;
        private System.Windows.Forms.Label LblFechaDesdeDF;
        private System.Windows.Forms.Label LblPlan;
        private System.Windows.Forms.Label LblActividad;
        private System.Windows.Forms.ComboBox CbNroFactura;
        private System.Windows.Forms.Label LblNroFactura;
        private System.Windows.Forms.ComboBox CbPlan;
        private System.Windows.Forms.ComboBox CbActividad;
        private System.Windows.Forms.Button BtnLimpiarDF;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.CheckBox ChFiltrarFecha;
        private System.Windows.Forms.CheckBox ChOrdenarPrecio;
        private System.Windows.Forms.CheckBox ChFiltrarFechaDF;
        private System.Windows.Forms.CheckBox ChOrdenarPrecioDF;
    }
}