namespace PAV1_GYM.InterfacesDeUsuarios.Consultas
{
    partial class ConsultaObjetivos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelFormHijo = new System.Windows.Forms.Panel();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.GrupoDatosObjetivo = new System.Windows.Forms.GroupBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtNombreObjetivo = new System.Windows.Forms.TextBox();
            this.LblNombreObjetivo = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.BtnEliminarObjetivo = new System.Windows.Forms.Button();
            this.GbListadoObjetivos = new System.Windows.Forms.GroupBox();
            this.TxtNombreLista = new System.Windows.Forms.TextBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.DgvObjetivos = new System.Windows.Forms.DataGridView();
            this.Id_Objetivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblNombre = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PanelFormHijo.SuspendLayout();
            this.GrupoDatosObjetivo.SuspendLayout();
            this.GbListadoObjetivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvObjetivos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelFormHijo
            // 
            this.PanelFormHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.PanelFormHijo.Controls.Add(this.BtnNuevo);
            this.PanelFormHijo.Controls.Add(this.BtnModificar);
            this.PanelFormHijo.Controls.Add(this.BtnRegistrar);
            this.PanelFormHijo.Controls.Add(this.GrupoDatosObjetivo);
            this.PanelFormHijo.Controls.Add(this.BtnEliminarObjetivo);
            this.PanelFormHijo.Controls.Add(this.GbListadoObjetivos);
            this.PanelFormHijo.Controls.Add(this.BtnSalir);
            this.PanelFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormHijo.Location = new System.Drawing.Point(0, 0);
            this.PanelFormHijo.Name = "PanelFormHijo";
            this.PanelFormHijo.Size = new System.Drawing.Size(800, 498);
            this.PanelFormHijo.TabIndex = 2;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnNuevo.ForeColor = System.Drawing.Color.LightGray;
            this.BtnNuevo.Location = new System.Drawing.Point(289, 456);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(90, 30);
            this.BtnNuevo.TabIndex = 9;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnModificar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnModificar.Location = new System.Drawing.Point(107, 456);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(90, 30);
            this.BtnModificar.TabIndex = 7;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnRegistrar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnRegistrar.Location = new System.Drawing.Point(11, 456);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(90, 30);
            this.BtnRegistrar.TabIndex = 6;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // GrupoDatosObjetivo
            // 
            this.GrupoDatosObjetivo.AccessibleName = "";
            this.GrupoDatosObjetivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrupoDatosObjetivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.GrupoDatosObjetivo.Controls.Add(this.TxtDescripcion);
            this.GrupoDatosObjetivo.Controls.Add(this.TxtNombreObjetivo);
            this.GrupoDatosObjetivo.Controls.Add(this.LblNombreObjetivo);
            this.GrupoDatosObjetivo.Controls.Add(this.LblDescripcion);
            this.GrupoDatosObjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.GrupoDatosObjetivo.ForeColor = System.Drawing.Color.LightGray;
            this.GrupoDatosObjetivo.Location = new System.Drawing.Point(12, 307);
            this.GrupoDatosObjetivo.Name = "GrupoDatosObjetivo";
            this.GrupoDatosObjetivo.Size = new System.Drawing.Size(760, 127);
            this.GrupoDatosObjetivo.TabIndex = 54;
            this.GrupoDatosObjetivo.TabStop = false;
            this.GrupoDatosObjetivo.Text = "Datos Objetivo";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TxtDescripcion.Location = new System.Drawing.Point(96, 75);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(216, 21);
            this.TxtDescripcion.TabIndex = 5;
            // 
            // TxtNombreObjetivo
            // 
            this.TxtNombreObjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TxtNombreObjetivo.Location = new System.Drawing.Point(77, 40);
            this.TxtNombreObjetivo.Name = "TxtNombreObjetivo";
            this.TxtNombreObjetivo.Size = new System.Drawing.Size(200, 21);
            this.TxtNombreObjetivo.TabIndex = 4;
            // 
            // LblNombreObjetivo
            // 
            this.LblNombreObjetivo.AutoSize = true;
            this.LblNombreObjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblNombreObjetivo.Location = new System.Drawing.Point(16, 40);
            this.LblNombreObjetivo.Name = "LblNombreObjetivo";
            this.LblNombreObjetivo.Size = new System.Drawing.Size(55, 15);
            this.LblNombreObjetivo.TabIndex = 2;
            this.LblNombreObjetivo.Text = "Nombre:";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblDescripcion.Location = new System.Drawing.Point(15, 78);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(75, 15);
            this.LblDescripcion.TabIndex = 1;
            this.LblDescripcion.Text = "Descripcion:";
            // 
            // BtnEliminarObjetivo
            // 
            this.BtnEliminarObjetivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminarObjetivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnEliminarObjetivo.Enabled = false;
            this.BtnEliminarObjetivo.FlatAppearance.BorderSize = 0;
            this.BtnEliminarObjetivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarObjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnEliminarObjetivo.ForeColor = System.Drawing.Color.LightGray;
            this.BtnEliminarObjetivo.Location = new System.Drawing.Point(203, 456);
            this.BtnEliminarObjetivo.Name = "BtnEliminarObjetivo";
            this.BtnEliminarObjetivo.Size = new System.Drawing.Size(80, 30);
            this.BtnEliminarObjetivo.TabIndex = 8;
            this.BtnEliminarObjetivo.Text = "Eliminar";
            this.BtnEliminarObjetivo.UseVisualStyleBackColor = false;
            this.BtnEliminarObjetivo.Click += new System.EventHandler(this.BtnEliminarObjetivo_Click);
            // 
            // GbListadoObjetivos
            // 
            this.GbListadoObjetivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbListadoObjetivos.Controls.Add(this.TxtNombreLista);
            this.GbListadoObjetivos.Controls.Add(this.BtnLimpiar);
            this.GbListadoObjetivos.Controls.Add(this.BtnBuscar);
            this.GbListadoObjetivos.Controls.Add(this.DgvObjetivos);
            this.GbListadoObjetivos.Controls.Add(this.LblNombre);
            this.GbListadoObjetivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.GbListadoObjetivos.ForeColor = System.Drawing.Color.Gainsboro;
            this.GbListadoObjetivos.Location = new System.Drawing.Point(12, 12);
            this.GbListadoObjetivos.Name = "GbListadoObjetivos";
            this.GbListadoObjetivos.Size = new System.Drawing.Size(760, 289);
            this.GbListadoObjetivos.TabIndex = 21;
            this.GbListadoObjetivos.TabStop = false;
            this.GbListadoObjetivos.Text = "Listado de Objetivos";
            // 
            // TxtNombreLista
            // 
            this.TxtNombreLista.Location = new System.Drawing.Point(25, 54);
            this.TxtNombreLista.Name = "TxtNombreLista";
            this.TxtNombreLista.Size = new System.Drawing.Size(127, 24);
            this.TxtNombreLista.TabIndex = 1;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnLimpiar.Location = new System.Drawing.Point(659, 23);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 2;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnBuscar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnBuscar.Location = new System.Drawing.Point(659, 54);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // DgvObjetivos
            // 
            this.DgvObjetivos.AllowUserToAddRows = false;
            this.DgvObjetivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvObjetivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvObjetivos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvObjetivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.DgvObjetivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvObjetivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvObjetivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvObjetivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvObjetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvObjetivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Objetivo,
            this.Nombre,
            this.Descripcion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvObjetivos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvObjetivos.EnableHeadersVisualStyles = false;
            this.DgvObjetivos.Location = new System.Drawing.Point(25, 96);
            this.DgvObjetivos.MultiSelect = false;
            this.DgvObjetivos.Name = "DgvObjetivos";
            this.DgvObjetivos.ReadOnly = true;
            this.DgvObjetivos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvObjetivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvObjetivos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 16F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DgvObjetivos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvObjetivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvObjetivos.Size = new System.Drawing.Size(709, 166);
            this.DgvObjetivos.TabIndex = 8;
            this.DgvObjetivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvObjetivos_CellClick);
            // 
            // Id_Objetivo
            // 
            this.Id_Objetivo.HeaderText = "Id Objetivo";
            this.Id_Objetivo.Name = "Id_Objetivo";
            this.Id_Objetivo.ReadOnly = true;
            this.Id_Objetivo.Visible = false;
            this.Id_Objetivo.Width = 92;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 91;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 121;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblNombre.ForeColor = System.Drawing.Color.DarkGray;
            this.LblNombre.Location = new System.Drawing.Point(21, 29);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(72, 22);
            this.LblNombre.TabIndex = 6;
            this.LblNombre.Text = "Nombre";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.ForeColor = System.Drawing.Color.LightGray;
            this.BtnSalir.Location = new System.Drawing.Point(692, 456);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(80, 30);
            this.BtnSalir.TabIndex = 10;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // ConsultaObjetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.PanelFormHijo);
            this.Name = "ConsultaObjetivos";
            this.Text = "ConsultaObjetivos";
            this.Load += new System.EventHandler(this.ConsultaObjetivos_Load);
            this.PanelFormHijo.ResumeLayout(false);
            this.GrupoDatosObjetivo.ResumeLayout(false);
            this.GrupoDatosObjetivo.PerformLayout();
            this.GbListadoObjetivos.ResumeLayout(false);
            this.GbListadoObjetivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvObjetivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFormHijo;
        private System.Windows.Forms.Button BtnEliminarObjetivo;
        private System.Windows.Forms.GroupBox GbListadoObjetivos;
        private System.Windows.Forms.TextBox TxtNombreLista;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView DgvObjetivos;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.GroupBox GrupoDatosObjetivo;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtNombreObjetivo;
        private System.Windows.Forms.Label LblNombreObjetivo;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Objetivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}