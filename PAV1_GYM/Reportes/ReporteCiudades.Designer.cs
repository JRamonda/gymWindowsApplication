namespace PAV1_GYM.Reportes
{
    partial class ReporteCiudades
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
            this.TCCiudades = new System.Windows.Forms.TabControl();
            this.TPCiudades = new System.Windows.Forms.TabPage();
            this.GbFiltros = new System.Windows.Forms.GroupBox();
            this.RbOrdenarProvincia = new System.Windows.Forms.RadioButton();
            this.RbCantidadEmpleados = new System.Windows.Forms.RadioButton();
            this.RbCantidadSocios = new System.Windows.Forms.RadioButton();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnBuscarCiudad = new System.Windows.Forms.Button();
            this.RvCiudades = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LblCiudades = new System.Windows.Forms.Label();
            this.TCCiudades.SuspendLayout();
            this.TPCiudades.SuspendLayout();
            this.GbFiltros.SuspendLayout();
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
            this.BtnSalir.Location = new System.Drawing.Point(709, 410);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(80, 30);
            this.BtnSalir.TabIndex = 48;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TCCiudades
            // 
            this.TCCiudades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TCCiudades.Controls.Add(this.TPCiudades);
            this.TCCiudades.Location = new System.Drawing.Point(16, 43);
            this.TCCiudades.Name = "TCCiudades";
            this.TCCiudades.SelectedIndex = 0;
            this.TCCiudades.Size = new System.Drawing.Size(773, 353);
            this.TCCiudades.TabIndex = 47;
            // 
            // TPCiudades
            // 
            this.TPCiudades.Controls.Add(this.GbFiltros);
            this.TPCiudades.Controls.Add(this.BtnLimpiar);
            this.TPCiudades.Controls.Add(this.BtnBuscarCiudad);
            this.TPCiudades.Controls.Add(this.RvCiudades);
            this.TPCiudades.Location = new System.Drawing.Point(4, 22);
            this.TPCiudades.Name = "TPCiudades";
            this.TPCiudades.Padding = new System.Windows.Forms.Padding(3);
            this.TPCiudades.Size = new System.Drawing.Size(765, 327);
            this.TPCiudades.TabIndex = 0;
            this.TPCiudades.Text = "Ciudades";
            this.TPCiudades.UseVisualStyleBackColor = true;
            // 
            // GbFiltros
            // 
            this.GbFiltros.Controls.Add(this.RbOrdenarProvincia);
            this.GbFiltros.Controls.Add(this.RbCantidadEmpleados);
            this.GbFiltros.Controls.Add(this.RbCantidadSocios);
            this.GbFiltros.Location = new System.Drawing.Point(12, 6);
            this.GbFiltros.Name = "GbFiltros";
            this.GbFiltros.Size = new System.Drawing.Size(400, 51);
            this.GbFiltros.TabIndex = 66;
            this.GbFiltros.TabStop = false;
            this.GbFiltros.Text = "Filtros";
            // 
            // RbOrdenarProvincia
            // 
            this.RbOrdenarProvincia.AutoSize = true;
            this.RbOrdenarProvincia.Location = new System.Drawing.Point(239, 19);
            this.RbOrdenarProvincia.Name = "RbOrdenarProvincia";
            this.RbOrdenarProvincia.Size = new System.Drawing.Size(127, 17);
            this.RbOrdenarProvincia.TabIndex = 66;
            this.RbOrdenarProvincia.TabStop = true;
            this.RbOrdenarProvincia.Text = "Ordenar por provincia";
            this.RbOrdenarProvincia.UseVisualStyleBackColor = true;
            // 
            // RbCantidadEmpleados
            // 
            this.RbCantidadEmpleados.AutoSize = true;
            this.RbCantidadEmpleados.Location = new System.Drawing.Point(6, 19);
            this.RbCantidadEmpleados.Name = "RbCantidadEmpleados";
            this.RbCantidadEmpleados.Size = new System.Drawing.Size(121, 17);
            this.RbCantidadEmpleados.TabIndex = 64;
            this.RbCantidadEmpleados.TabStop = true;
            this.RbCantidadEmpleados.Text = "Cantidad empleados";
            this.RbCantidadEmpleados.UseVisualStyleBackColor = true;
            // 
            // RbCantidadSocios
            // 
            this.RbCantidadSocios.AutoSize = true;
            this.RbCantidadSocios.Location = new System.Drawing.Point(133, 19);
            this.RbCantidadSocios.Name = "RbCantidadSocios";
            this.RbCantidadSocios.Size = new System.Drawing.Size(100, 17);
            this.RbCantidadSocios.TabIndex = 65;
            this.RbCantidadSocios.TabStop = true;
            this.RbCantidadSocios.Text = "Cantidad socios";
            this.RbCantidadSocios.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnLimpiar.Location = new System.Drawing.Point(684, 34);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 48;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnBuscarCiudad
            // 
            this.BtnBuscarCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnBuscarCiudad.FlatAppearance.BorderSize = 0;
            this.BtnBuscarCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnBuscarCiudad.ForeColor = System.Drawing.Color.LightGray;
            this.BtnBuscarCiudad.Location = new System.Drawing.Point(684, 5);
            this.BtnBuscarCiudad.Name = "BtnBuscarCiudad";
            this.BtnBuscarCiudad.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarCiudad.TabIndex = 47;
            this.BtnBuscarCiudad.Text = "Buscar";
            this.BtnBuscarCiudad.UseVisualStyleBackColor = false;
            this.BtnBuscarCiudad.Click += new System.EventHandler(this.BtnBuscarCiudad_Click);
            // 
            // RvCiudades
            // 
            this.RvCiudades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RvCiudades.LocalReport.ReportEmbeddedResource = "PAV1_GYM.Reportes.Rdlc.Rpt_Ciudades.rdlc";
            this.RvCiudades.Location = new System.Drawing.Point(12, 63);
            this.RvCiudades.Name = "RvCiudades";
            this.RvCiudades.ServerReport.BearerToken = null;
            this.RvCiudades.Size = new System.Drawing.Size(747, 258);
            this.RvCiudades.TabIndex = 44;
            this.RvCiudades.Load += new System.EventHandler(this.RvCiudades_Load);
            // 
            // LblCiudades
            // 
            this.LblCiudades.AutoSize = true;
            this.LblCiudades.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.LblCiudades.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblCiudades.Location = new System.Drawing.Point(11, 11);
            this.LblCiudades.Name = "LblCiudades";
            this.LblCiudades.Size = new System.Drawing.Size(191, 29);
            this.LblCiudades.TabIndex = 46;
            this.LblCiudades.Text = "Reporte Ciudades";
            // 
            // ReporteCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.TCCiudades);
            this.Controls.Add(this.LblCiudades);
            this.Name = "ReporteCiudades";
            this.Text = "ReporteCiudades";
            this.Load += new System.EventHandler(this.ReporteCiudades_Load);
            this.TCCiudades.ResumeLayout(false);
            this.TPCiudades.ResumeLayout(false);
            this.GbFiltros.ResumeLayout(false);
            this.GbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TabControl TCCiudades;
        private System.Windows.Forms.TabPage TPCiudades;
        private System.Windows.Forms.GroupBox GbFiltros;
        private System.Windows.Forms.RadioButton RbOrdenarProvincia;
        private System.Windows.Forms.RadioButton RbCantidadEmpleados;
        private System.Windows.Forms.RadioButton RbCantidadSocios;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnBuscarCiudad;
        private Microsoft.Reporting.WinForms.ReportViewer RvCiudades;
        private System.Windows.Forms.Label LblCiudades;
    }
}