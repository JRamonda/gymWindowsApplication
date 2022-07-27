namespace PAV1_GYM.InterfacesDeUsuarios
{
    partial class Turnos
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
            this.BtnCargarTurno = new System.Windows.Forms.Button();
            this.GbSocios = new System.Windows.Forms.GroupBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.LblNroSocio = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtNroSocio = new System.Windows.Forms.TextBox();
            this.LblFecha = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblTurno = new System.Windows.Forms.Label();
            this.LblActividad = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.CbTurno = new System.Windows.Forms.ComboBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.DgvSocios = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Objetivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActividadYPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CbActividad = new System.Windows.Forms.ComboBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PanelFormHijo.SuspendLayout();
            this.GbSocios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelFormHijo
            // 
            this.PanelFormHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.PanelFormHijo.Controls.Add(this.BtnCargarTurno);
            this.PanelFormHijo.Controls.Add(this.GbSocios);
            this.PanelFormHijo.Controls.Add(this.BtnSalir);
            this.PanelFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormHijo.Location = new System.Drawing.Point(0, 0);
            this.PanelFormHijo.Name = "PanelFormHijo";
            this.PanelFormHijo.Size = new System.Drawing.Size(1012, 587);
            this.PanelFormHijo.TabIndex = 2;
            // 
            // BtnCargarTurno
            // 
            this.BtnCargarTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCargarTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnCargarTurno.Enabled = false;
            this.BtnCargarTurno.FlatAppearance.BorderSize = 0;
            this.BtnCargarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCargarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnCargarTurno.ForeColor = System.Drawing.Color.LightGray;
            this.BtnCargarTurno.Location = new System.Drawing.Point(12, 545);
            this.BtnCargarTurno.Name = "BtnCargarTurno";
            this.BtnCargarTurno.Size = new System.Drawing.Size(127, 30);
            this.BtnCargarTurno.TabIndex = 39;
            this.BtnCargarTurno.Text = "Cargar Turno";
            this.BtnCargarTurno.UseVisualStyleBackColor = false;
            this.BtnCargarTurno.Click += new System.EventHandler(this.BtnCargarTurno_Click);
            // 
            // GbSocios
            // 
            this.GbSocios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbSocios.Controls.Add(this.DtpFecha);
            this.GbSocios.Controls.Add(this.BtnLimpiar);
            this.GbSocios.Controls.Add(this.LblNroSocio);
            this.GbSocios.Controls.Add(this.BtnBuscar);
            this.GbSocios.Controls.Add(this.TxtNroSocio);
            this.GbSocios.Controls.Add(this.LblFecha);
            this.GbSocios.Controls.Add(this.TxtApellido);
            this.GbSocios.Controls.Add(this.LblApellido);
            this.GbSocios.Controls.Add(this.LblTurno);
            this.GbSocios.Controls.Add(this.LblActividad);
            this.GbSocios.Controls.Add(this.TxtNombre);
            this.GbSocios.Controls.Add(this.CbTurno);
            this.GbSocios.Controls.Add(this.LblNombre);
            this.GbSocios.Controls.Add(this.DgvSocios);
            this.GbSocios.Controls.Add(this.CbActividad);
            this.GbSocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbSocios.ForeColor = System.Drawing.SystemColors.Control;
            this.GbSocios.Location = new System.Drawing.Point(12, 12);
            this.GbSocios.Name = "GbSocios";
            this.GbSocios.Size = new System.Drawing.Size(988, 508);
            this.GbSocios.TabIndex = 34;
            this.GbSocios.TabStop = false;
            this.GbSocios.Text = "Socios";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DtpFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DtpFecha.Enabled = false;
            this.DtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(305, 465);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(100, 21);
            this.DtpFecha.TabIndex = 38;
            this.DtpFecha.ValueChanged += new System.EventHandler(this.DtpFecha_ValueChanged);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnLimpiar.Location = new System.Drawing.Point(890, 29);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 7;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // LblNroSocio
            // 
            this.LblNroSocio.AutoSize = true;
            this.LblNroSocio.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblNroSocio.ForeColor = System.Drawing.Color.DarkGray;
            this.LblNroSocio.Location = new System.Drawing.Point(295, 32);
            this.LblNroSocio.Name = "LblNroSocio";
            this.LblNroSocio.Size = new System.Drawing.Size(83, 22);
            this.LblNroSocio.TabIndex = 12;
            this.LblNroSocio.Text = "Nro Socio";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnBuscar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnBuscar.Location = new System.Drawing.Point(890, 58);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 8;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtNroSocio
            // 
            this.TxtNroSocio.Location = new System.Drawing.Point(299, 57);
            this.TxtNroSocio.Name = "TxtNroSocio";
            this.TxtNroSocio.Size = new System.Drawing.Size(127, 24);
            this.TxtNroSocio.TabIndex = 11;
            // 
            // LblFecha
            // 
            this.LblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(302, 441);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(54, 18);
            this.LblFecha.TabIndex = 37;
            this.LblFecha.Text = "Fecha";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(165, 57);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(127, 24);
            this.TxtApellido.TabIndex = 6;
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblApellido.ForeColor = System.Drawing.Color.DarkGray;
            this.LblApellido.Location = new System.Drawing.Point(161, 32);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(72, 22);
            this.LblApellido.TabIndex = 10;
            this.LblApellido.Text = "Apellido";
            // 
            // LblTurno
            // 
            this.LblTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblTurno.AutoSize = true;
            this.LblTurno.Location = new System.Drawing.Point(168, 436);
            this.LblTurno.Name = "LblTurno";
            this.LblTurno.Size = new System.Drawing.Size(52, 18);
            this.LblTurno.TabIndex = 31;
            this.LblTurno.Text = "Turno";
            // 
            // LblActividad
            // 
            this.LblActividad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblActividad.AutoSize = true;
            this.LblActividad.Location = new System.Drawing.Point(31, 436);
            this.LblActividad.Name = "LblActividad";
            this.LblActividad.Size = new System.Drawing.Size(75, 18);
            this.LblActividad.TabIndex = 30;
            this.LblActividad.Text = "Actividad";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(28, 57);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(127, 24);
            this.TxtNombre.TabIndex = 5;
            // 
            // CbTurno
            // 
            this.CbTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTurno.Enabled = false;
            this.CbTurno.FormattingEnabled = true;
            this.CbTurno.Location = new System.Drawing.Point(171, 460);
            this.CbTurno.Name = "CbTurno";
            this.CbTurno.Size = new System.Drawing.Size(121, 26);
            this.CbTurno.TabIndex = 0;
            this.CbTurno.SelectionChangeCommitted += new System.EventHandler(this.CbTurno_SelectionChangeCommitted);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblNombre.ForeColor = System.Drawing.Color.DarkGray;
            this.LblNombre.Location = new System.Drawing.Point(24, 32);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(72, 22);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre";
            // 
            // DgvSocios
            // 
            this.DgvSocios.AllowUserToAddRows = false;
            this.DgvSocios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvSocios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvSocios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvSocios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.DgvSocios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvSocios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvSocios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSocios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.NroDocSocio,
            this.TipoDocSocio,
            this.Nombre,
            this.Sexo,
            this.Objetivos,
            this.ActividadYPlan});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSocios.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvSocios.EnableHeadersVisualStyles = false;
            this.DgvSocios.Location = new System.Drawing.Point(28, 92);
            this.DgvSocios.MultiSelect = false;
            this.DgvSocios.Name = "DgvSocios";
            this.DgvSocios.ReadOnly = true;
            this.DgvSocios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSocios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvSocios.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 16F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DgvSocios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSocios.Size = new System.Drawing.Size(937, 311);
            this.DgvSocios.TabIndex = 8;
            this.DgvSocios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSocios_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nro Socio";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 99;
            // 
            // NroDocSocio
            // 
            this.NroDocSocio.HeaderText = "Nro Doc";
            this.NroDocSocio.Name = "NroDocSocio";
            this.NroDocSocio.ReadOnly = true;
            this.NroDocSocio.Width = 87;
            // 
            // TipoDocSocio
            // 
            this.TipoDocSocio.HeaderText = "Tipo Doc";
            this.TipoDocSocio.Name = "TipoDocSocio";
            this.TipoDocSocio.ReadOnly = true;
            this.TipoDocSocio.Width = 64;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 91;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 69;
            // 
            // Objetivos
            // 
            this.Objetivos.HeaderText = "Objetivos";
            this.Objetivos.Name = "Objetivos";
            this.Objetivos.ReadOnly = true;
            this.Objetivos.Width = 102;
            // 
            // ActividadYPlan
            // 
            this.ActividadYPlan.HeaderText = "Actividad y Plan";
            this.ActividadYPlan.Name = "ActividadYPlan";
            this.ActividadYPlan.ReadOnly = true;
            this.ActividadYPlan.Width = 106;
            // 
            // CbActividad
            // 
            this.CbActividad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CbActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbActividad.Enabled = false;
            this.CbActividad.FormattingEnabled = true;
            this.CbActividad.Location = new System.Drawing.Point(34, 460);
            this.CbActividad.Name = "CbActividad";
            this.CbActividad.Size = new System.Drawing.Size(121, 26);
            this.CbActividad.TabIndex = 1;
            this.CbActividad.SelectionChangeCommitted += new System.EventHandler(this.CbActividad_SelectionChangeCommitted);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.ForeColor = System.Drawing.Color.LightGray;
            this.BtnSalir.Location = new System.Drawing.Point(903, 545);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(97, 30);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Turnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 587);
            this.Controls.Add(this.PanelFormHijo);
            this.Name = "Turnos";
            this.Text = "Turnos";
            this.Load += new System.EventHandler(this.Turnos_Load);
            this.PanelFormHijo.ResumeLayout(false);
            this.GbSocios.ResumeLayout(false);
            this.GbSocios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSocios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFormHijo;
        private System.Windows.Forms.Button BtnCargarTurno;
        private System.Windows.Forms.Label LblNroSocio;
        private System.Windows.Forms.TextBox TxtNroSocio;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView DgvSocios;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.GroupBox GbSocios;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblTurno;
        private System.Windows.Forms.Label LblActividad;
        private System.Windows.Forms.ComboBox CbTurno;
        private System.Windows.Forms.ComboBox CbActividad;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Objetivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActividadYPlan;
    }
}