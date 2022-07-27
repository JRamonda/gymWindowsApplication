namespace PAV1_GYM.InterfacesDeUsuarios.PerfilUsuario
{
    partial class CambiarContraseña
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
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.GbContraseña = new System.Windows.Forms.GroupBox();
            this.TxtContraseñaActual = new System.Windows.Forms.TextBox();
            this.LblContraseñaActual = new System.Windows.Forms.Label();
            this.TxtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.TxtContraseñaNueva = new System.Windows.Forms.TextBox();
            this.LblConfirmarContraseña = new System.Windows.Forms.Label();
            this.LblContraseñaNueva = new System.Windows.Forms.Label();
            this.PanelFormHijo.SuspendLayout();
            this.GbContraseña.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFormHijo
            // 
            this.PanelFormHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.PanelFormHijo.Controls.Add(this.BtnConfirmar);
            this.PanelFormHijo.Controls.Add(this.BtnSalir);
            this.PanelFormHijo.Controls.Add(this.GbContraseña);
            this.PanelFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormHijo.Location = new System.Drawing.Point(0, 0);
            this.PanelFormHijo.Name = "PanelFormHijo";
            this.PanelFormHijo.Size = new System.Drawing.Size(545, 286);
            this.PanelFormHijo.TabIndex = 6;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnConfirmar.FlatAppearance.BorderSize = 0;
            this.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnConfirmar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnConfirmar.Location = new System.Drawing.Point(174, 236);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(93, 31);
            this.BtnConfirmar.TabIndex = 3;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.ForeColor = System.Drawing.Color.LightGray;
            this.BtnSalir.Location = new System.Drawing.Point(302, 236);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(93, 31);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // GbContraseña
            // 
            this.GbContraseña.Controls.Add(this.TxtContraseñaActual);
            this.GbContraseña.Controls.Add(this.LblContraseñaActual);
            this.GbContraseña.Controls.Add(this.TxtConfirmarContraseña);
            this.GbContraseña.Controls.Add(this.TxtContraseñaNueva);
            this.GbContraseña.Controls.Add(this.LblConfirmarContraseña);
            this.GbContraseña.Controls.Add(this.LblContraseñaNueva);
            this.GbContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.GbContraseña.ForeColor = System.Drawing.Color.Gainsboro;
            this.GbContraseña.Location = new System.Drawing.Point(29, 21);
            this.GbContraseña.Name = "GbContraseña";
            this.GbContraseña.Size = new System.Drawing.Size(489, 197);
            this.GbContraseña.TabIndex = 1;
            this.GbContraseña.TabStop = false;
            this.GbContraseña.Text = "Contraseña";
            // 
            // TxtContraseñaActual
            // 
            this.TxtContraseñaActual.Location = new System.Drawing.Point(208, 39);
            this.TxtContraseñaActual.Name = "TxtContraseñaActual";
            this.TxtContraseñaActual.Size = new System.Drawing.Size(188, 24);
            this.TxtContraseñaActual.TabIndex = 0;
            this.TxtContraseñaActual.UseSystemPasswordChar = true;
            // 
            // LblContraseñaActual
            // 
            this.LblContraseñaActual.AutoSize = true;
            this.LblContraseñaActual.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblContraseñaActual.ForeColor = System.Drawing.Color.DarkGray;
            this.LblContraseñaActual.Location = new System.Drawing.Point(48, 39);
            this.LblContraseñaActual.Name = "LblContraseñaActual";
            this.LblContraseñaActual.Size = new System.Drawing.Size(153, 22);
            this.LblContraseñaActual.TabIndex = 4;
            this.LblContraseñaActual.Text = "Contraseña Actual:";
            // 
            // TxtConfirmarContraseña
            // 
            this.TxtConfirmarContraseña.Location = new System.Drawing.Point(208, 132);
            this.TxtConfirmarContraseña.Name = "TxtConfirmarContraseña";
            this.TxtConfirmarContraseña.Size = new System.Drawing.Size(188, 24);
            this.TxtConfirmarContraseña.TabIndex = 2;
            this.TxtConfirmarContraseña.UseSystemPasswordChar = true;
            // 
            // TxtContraseñaNueva
            // 
            this.TxtContraseñaNueva.Location = new System.Drawing.Point(208, 85);
            this.TxtContraseñaNueva.Name = "TxtContraseñaNueva";
            this.TxtContraseñaNueva.Size = new System.Drawing.Size(188, 24);
            this.TxtContraseñaNueva.TabIndex = 1;
            this.TxtContraseñaNueva.UseSystemPasswordChar = true;
            // 
            // LblConfirmarContraseña
            // 
            this.LblConfirmarContraseña.AutoSize = true;
            this.LblConfirmarContraseña.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblConfirmarContraseña.ForeColor = System.Drawing.Color.DarkGray;
            this.LblConfirmarContraseña.Location = new System.Drawing.Point(21, 132);
            this.LblConfirmarContraseña.Name = "LblConfirmarContraseña";
            this.LblConfirmarContraseña.Size = new System.Drawing.Size(181, 22);
            this.LblConfirmarContraseña.TabIndex = 1;
            this.LblConfirmarContraseña.Text = "Confirmar Contraseña:";
            // 
            // LblContraseñaNueva
            // 
            this.LblContraseñaNueva.AutoSize = true;
            this.LblContraseñaNueva.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblContraseñaNueva.ForeColor = System.Drawing.Color.DarkGray;
            this.LblContraseñaNueva.Location = new System.Drawing.Point(48, 85);
            this.LblContraseñaNueva.Name = "LblContraseñaNueva";
            this.LblContraseñaNueva.Size = new System.Drawing.Size(154, 22);
            this.LblContraseñaNueva.TabIndex = 0;
            this.LblContraseñaNueva.Text = "Contraseña Nueva:";
            // 
            // CambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 286);
            this.Controls.Add(this.PanelFormHijo);
            this.Name = "CambiarContraseña";
            this.Text = "CambiarContraseña";
            this.Load += new System.EventHandler(this.CambiarContraseña_Load);
            this.PanelFormHijo.ResumeLayout(false);
            this.GbContraseña.ResumeLayout(false);
            this.GbContraseña.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFormHijo;
        private System.Windows.Forms.GroupBox GbContraseña;
        private System.Windows.Forms.TextBox TxtContraseñaActual;
        private System.Windows.Forms.Label LblContraseñaActual;
        private System.Windows.Forms.TextBox TxtConfirmarContraseña;
        private System.Windows.Forms.TextBox TxtContraseñaNueva;
        private System.Windows.Forms.Label LblConfirmarContraseña;
        private System.Windows.Forms.Label LblContraseñaNueva;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnConfirmar;
    }
}