namespace PAV1_GYM.InterfacesDeUsuarios.Mantenimiento
{
    partial class ConsultaCiudades
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
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.GbListadoCiudades = new System.Windows.Forms.GroupBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.CbProvinciaListado = new System.Windows.Forms.ComboBox();
            this.LblProvincias = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.DgvCiudades = new System.Windows.Forms.DataGridView();
            this.IdCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblNombre = new System.Windows.Forms.Label();
            this.GrupoDatosCiudad = new System.Windows.Forms.GroupBox();
            this.CbProvincia = new System.Windows.Forms.ComboBox();
            this.LblProvinciaC = new System.Windows.Forms.Label();
            this.TxtNombreCiudad = new System.Windows.Forms.TextBox();
            this.LblNombreCiudad = new System.Windows.Forms.Label();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.GbListadoCiudades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCiudades)).BeginInit();
            this.GrupoDatosCiudad.SuspendLayout();
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
            this.BtnSalir.Location = new System.Drawing.Point(560, 425);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(90, 30);
            this.BtnSalir.TabIndex = 10;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnModificar.Enabled = false;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnModificar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnModificar.Location = new System.Drawing.Point(117, 425);
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
            this.BtnRegistrar.Location = new System.Drawing.Point(21, 425);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(90, 30);
            this.BtnRegistrar.TabIndex = 6;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnEliminar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnEliminar.Location = new System.Drawing.Point(216, 425);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(95, 30);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // GbListadoCiudades
            // 
            this.GbListadoCiudades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbListadoCiudades.Controls.Add(this.TxtNombre);
            this.GbListadoCiudades.Controls.Add(this.CbProvinciaListado);
            this.GbListadoCiudades.Controls.Add(this.LblProvincias);
            this.GbListadoCiudades.Controls.Add(this.BtnLimpiar);
            this.GbListadoCiudades.Controls.Add(this.BtnBuscar);
            this.GbListadoCiudades.Controls.Add(this.DgvCiudades);
            this.GbListadoCiudades.Controls.Add(this.LblNombre);
            this.GbListadoCiudades.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.GbListadoCiudades.ForeColor = System.Drawing.Color.Gainsboro;
            this.GbListadoCiudades.Location = new System.Drawing.Point(21, 12);
            this.GbListadoCiudades.Name = "GbListadoCiudades";
            this.GbListadoCiudades.Size = new System.Drawing.Size(629, 264);
            this.GbListadoCiudades.TabIndex = 55;
            this.GbListadoCiudades.TabStop = false;
            this.GbListadoCiudades.Text = "Listado de Ciudades";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(165, 51);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(121, 24);
            this.TxtNombre.TabIndex = 1;
            // 
            // CbProvinciaListado
            // 
            this.CbProvinciaListado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbProvinciaListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.CbProvinciaListado.FormattingEnabled = true;
            this.CbProvinciaListado.Location = new System.Drawing.Point(25, 51);
            this.CbProvinciaListado.Name = "CbProvinciaListado";
            this.CbProvinciaListado.Size = new System.Drawing.Size(119, 24);
            this.CbProvinciaListado.TabIndex = 0;
            // 
            // LblProvincias
            // 
            this.LblProvincias.AutoSize = true;
            this.LblProvincias.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblProvincias.ForeColor = System.Drawing.Color.DarkGray;
            this.LblProvincias.Location = new System.Drawing.Point(21, 26);
            this.LblProvincias.Name = "LblProvincias";
            this.LblProvincias.Size = new System.Drawing.Size(80, 22);
            this.LblProvincias.TabIndex = 13;
            this.LblProvincias.Text = "Provincia";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnLimpiar.Location = new System.Drawing.Point(528, 23);
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
            this.BtnBuscar.Location = new System.Drawing.Point(528, 52);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // DgvCiudades
            // 
            this.DgvCiudades.AllowUserToAddRows = false;
            this.DgvCiudades.AllowUserToDeleteRows = false;
            this.DgvCiudades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvCiudades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvCiudades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvCiudades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.DgvCiudades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvCiudades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvCiudades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCiudades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCiudades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCiudad,
            this.NombreCiudad,
            this.IdProvincia,
            this.NombreProvincia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCiudades.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCiudades.EnableHeadersVisualStyles = false;
            this.DgvCiudades.Location = new System.Drawing.Point(25, 81);
            this.DgvCiudades.MultiSelect = false;
            this.DgvCiudades.Name = "DgvCiudades";
            this.DgvCiudades.ReadOnly = true;
            this.DgvCiudades.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DgvCiudades.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCiudades.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvCiudades.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 16F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DgvCiudades.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvCiudades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCiudades.Size = new System.Drawing.Size(578, 141);
            this.DgvCiudades.TabIndex = 8;
            this.DgvCiudades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCiudades_CellClick);
            // 
            // IdCiudad
            // 
            this.IdCiudad.HeaderText = "Id Ciudad";
            this.IdCiudad.Name = "IdCiudad";
            this.IdCiudad.ReadOnly = true;
            this.IdCiudad.Visible = false;
            this.IdCiudad.Width = 82;
            // 
            // NombreCiudad
            // 
            this.NombreCiudad.HeaderText = "Ciudad";
            this.NombreCiudad.Name = "NombreCiudad";
            this.NombreCiudad.ReadOnly = true;
            this.NombreCiudad.Width = 106;
            // 
            // IdProvincia
            // 
            this.IdProvincia.HeaderText = "Id Provincia";
            this.IdProvincia.Name = "IdProvincia";
            this.IdProvincia.ReadOnly = true;
            this.IdProvincia.Visible = false;
            this.IdProvincia.Width = 119;
            // 
            // NombreProvincia
            // 
            this.NombreProvincia.HeaderText = "Provincia";
            this.NombreProvincia.Name = "NombreProvincia";
            this.NombreProvincia.ReadOnly = true;
            this.NombreProvincia.Width = 129;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblNombre.ForeColor = System.Drawing.Color.DarkGray;
            this.LblNombre.Location = new System.Drawing.Point(161, 26);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(72, 22);
            this.LblNombre.TabIndex = 6;
            this.LblNombre.Text = "Nombre";
            // 
            // GrupoDatosCiudad
            // 
            this.GrupoDatosCiudad.AccessibleName = "";
            this.GrupoDatosCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrupoDatosCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.GrupoDatosCiudad.Controls.Add(this.CbProvincia);
            this.GrupoDatosCiudad.Controls.Add(this.LblProvinciaC);
            this.GrupoDatosCiudad.Controls.Add(this.TxtNombreCiudad);
            this.GrupoDatosCiudad.Controls.Add(this.LblNombreCiudad);
            this.GrupoDatosCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.GrupoDatosCiudad.ForeColor = System.Drawing.Color.LightGray;
            this.GrupoDatosCiudad.Location = new System.Drawing.Point(21, 282);
            this.GrupoDatosCiudad.Name = "GrupoDatosCiudad";
            this.GrupoDatosCiudad.Size = new System.Drawing.Size(629, 124);
            this.GrupoDatosCiudad.TabIndex = 58;
            this.GrupoDatosCiudad.TabStop = false;
            this.GrupoDatosCiudad.Text = "Datos Ciudad";
            // 
            // CbProvincia
            // 
            this.CbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CbProvincia.FormattingEnabled = true;
            this.CbProvincia.Location = new System.Drawing.Point(77, 76);
            this.CbProvincia.Name = "CbProvincia";
            this.CbProvincia.Size = new System.Drawing.Size(200, 23);
            this.CbProvincia.TabIndex = 5;
            // 
            // LblProvinciaC
            // 
            this.LblProvinciaC.AutoSize = true;
            this.LblProvinciaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblProvinciaC.Location = new System.Drawing.Point(11, 79);
            this.LblProvinciaC.Name = "LblProvinciaC";
            this.LblProvinciaC.Size = new System.Drawing.Size(60, 15);
            this.LblProvinciaC.TabIndex = 31;
            this.LblProvinciaC.Text = "Provincia:";
            // 
            // TxtNombreCiudad
            // 
            this.TxtNombreCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TxtNombreCiudad.Location = new System.Drawing.Point(77, 40);
            this.TxtNombreCiudad.Name = "TxtNombreCiudad";
            this.TxtNombreCiudad.Size = new System.Drawing.Size(200, 21);
            this.TxtNombreCiudad.TabIndex = 4;
            // 
            // LblNombreCiudad
            // 
            this.LblNombreCiudad.AutoSize = true;
            this.LblNombreCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblNombreCiudad.Location = new System.Drawing.Point(16, 40);
            this.LblNombreCiudad.Name = "LblNombreCiudad";
            this.LblNombreCiudad.Size = new System.Drawing.Size(55, 15);
            this.LblNombreCiudad.TabIndex = 2;
            this.LblNombreCiudad.Text = "Nombre:";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnNuevo.ForeColor = System.Drawing.Color.LightGray;
            this.BtnNuevo.Location = new System.Drawing.Point(319, 425);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(95, 30);
            this.BtnNuevo.TabIndex = 9;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // ConsultaCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(690, 478);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.GrupoDatosCiudad);
            this.Controls.Add(this.GbListadoCiudades);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.BtnModificar);
            this.Name = "ConsultaCiudades";
            this.Text = "ABMCiudad";
            this.Load += new System.EventHandler(this.ABMCiudad_Load);
            this.GbListadoCiudades.ResumeLayout(false);
            this.GbListadoCiudades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCiudades)).EndInit();
            this.GrupoDatosCiudad.ResumeLayout(false);
            this.GrupoDatosCiudad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.GroupBox GbListadoCiudades;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView DgvCiudades;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.ComboBox CbProvinciaListado;
        private System.Windows.Forms.Label LblProvincias;
        private System.Windows.Forms.GroupBox GrupoDatosCiudad;
        private System.Windows.Forms.ComboBox CbProvincia;
        private System.Windows.Forms.Label LblProvinciaC;
        private System.Windows.Forms.TextBox TxtNombreCiudad;
        private System.Windows.Forms.Label LblNombreCiudad;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProvincia;
    }
}