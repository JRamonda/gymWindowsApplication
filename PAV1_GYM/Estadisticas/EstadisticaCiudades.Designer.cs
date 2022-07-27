namespace PAV1_GYM.Estadisticas
{
    partial class EstadisticaCiudades
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
            this.TCCiudades = new System.Windows.Forms.TabControl();
            this.TPCiudades = new System.Windows.Forms.TabPage();
            this.RvCiudades = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LblEstadistica = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PanelFormHijo.SuspendLayout();
            this.TCCiudades.SuspendLayout();
            this.TPCiudades.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFormHijo
            // 
            this.PanelFormHijo.AutoScroll = true;
            this.PanelFormHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.PanelFormHijo.Controls.Add(this.TCCiudades);
            this.PanelFormHijo.Controls.Add(this.LblEstadistica);
            this.PanelFormHijo.Controls.Add(this.BtnSalir);
            this.PanelFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormHijo.Location = new System.Drawing.Point(0, 0);
            this.PanelFormHijo.Name = "PanelFormHijo";
            this.PanelFormHijo.Size = new System.Drawing.Size(800, 450);
            this.PanelFormHijo.TabIndex = 6;
            // 
            // TCCiudades
            // 
            this.TCCiudades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TCCiudades.Controls.Add(this.TPCiudades);
            this.TCCiudades.Location = new System.Drawing.Point(28, 50);
            this.TCCiudades.Name = "TCCiudades";
            this.TCCiudades.SelectedIndex = 0;
            this.TCCiudades.Size = new System.Drawing.Size(749, 341);
            this.TCCiudades.TabIndex = 43;
            // 
            // TPCiudades
            // 
            this.TPCiudades.Controls.Add(this.RvCiudades);
            this.TPCiudades.Location = new System.Drawing.Point(4, 22);
            this.TPCiudades.Name = "TPCiudades";
            this.TPCiudades.Padding = new System.Windows.Forms.Padding(3);
            this.TPCiudades.Size = new System.Drawing.Size(741, 315);
            this.TPCiudades.TabIndex = 0;
            this.TPCiudades.Text = "Ciudades";
            this.TPCiudades.UseVisualStyleBackColor = true;
            // 
            // RvCiudades
            // 
            this.RvCiudades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RvCiudades.LocalReport.ReportEmbeddedResource = "PAV1_GYM.Estadisticas.Rdlc.EstadisticaCiudades.rdlc";
            this.RvCiudades.Location = new System.Drawing.Point(6, 6);
            this.RvCiudades.Name = "RvCiudades";
            this.RvCiudades.ServerReport.BearerToken = null;
            this.RvCiudades.Size = new System.Drawing.Size(729, 303);
            this.RvCiudades.TabIndex = 44;
            this.RvCiudades.Load += new System.EventHandler(this.RvCiudades_Load);
            // 
            // LblEstadistica
            // 
            this.LblEstadistica.AutoSize = true;
            this.LblEstadistica.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.LblEstadistica.ForeColor = System.Drawing.Color.Silver;
            this.LblEstadistica.Location = new System.Drawing.Point(23, 9);
            this.LblEstadistica.Name = "LblEstadistica";
            this.LblEstadistica.Size = new System.Drawing.Size(257, 29);
            this.LblEstadistica.TabIndex = 15;
            this.LblEstadistica.Text = "Estadisticas de Ciudades";
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
            // EstadisticaCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelFormHijo);
            this.Name = "EstadisticaCiudades";
            this.Text = "EstadisticaCiudades";
            this.Load += new System.EventHandler(this.EstadisticaCiudades_Load);
            this.PanelFormHijo.ResumeLayout(false);
            this.PanelFormHijo.PerformLayout();
            this.TCCiudades.ResumeLayout(false);
            this.TPCiudades.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFormHijo;
        private System.Windows.Forms.TabControl TCCiudades;
        private System.Windows.Forms.TabPage TPCiudades;
        private Microsoft.Reporting.WinForms.ReportViewer RvCiudades;
        private System.Windows.Forms.Label LblEstadistica;
        private System.Windows.Forms.Button BtnSalir;
    }
}