namespace PAV1_GYM.InterfacesDeUsuarios.Consultas
{
    partial class ConsultaSocios
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
            this.BtnAgregarSocio = new System.Windows.Forms.Button();
            this.BtnEliminarSocio = new System.Windows.Forms.Button();
            this.BtnEditarSocio = new System.Windows.Forms.Button();
            this.BtnVerSocio = new System.Windows.Forms.Button();
            this.GbListadoSocios = new System.Windows.Forms.GroupBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.LblEstado = new System.Windows.Forms.Label();
            this.DgvSocios = new System.Windows.Forms.DataGridView();
            this.NroSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AntecedenteMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Objetivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActividadYPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CbTipoDoc = new System.Windows.Forms.ComboBox();
            this.LblTipoDocSocio = new System.Windows.Forms.Label();
            this.TxtNroDoc = new System.Windows.Forms.TextBox();
            this.LblNroDocSocio = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PanelFormHijo.SuspendLayout();
            this.GbListadoSocios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelFormHijo
            // 
            this.PanelFormHijo.Controls.Add(this.BtnAgregarSocio);
            this.PanelFormHijo.Controls.Add(this.BtnEliminarSocio);
            this.PanelFormHijo.Controls.Add(this.BtnEditarSocio);
            this.PanelFormHijo.Controls.Add(this.BtnVerSocio);
            this.PanelFormHijo.Controls.Add(this.GbListadoSocios);
            this.PanelFormHijo.Controls.Add(this.BtnSalir);
            this.PanelFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormHijo.Location = new System.Drawing.Point(0, 0);
            this.PanelFormHijo.Name = "PanelFormHijo";
            this.PanelFormHijo.Size = new System.Drawing.Size(807, 657);
            this.PanelFormHijo.TabIndex = 0;
            // 
            // BtnAgregarSocio
            // 
            this.BtnAgregarSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAgregarSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnAgregarSocio.FlatAppearance.BorderSize = 0;
            this.BtnAgregarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnAgregarSocio.ForeColor = System.Drawing.Color.LightGray;
            this.BtnAgregarSocio.Location = new System.Drawing.Point(286, 586);
            this.BtnAgregarSocio.Name = "BtnAgregarSocio";
            this.BtnAgregarSocio.Size = new System.Drawing.Size(139, 30);
            this.BtnAgregarSocio.TabIndex = 8;
            this.BtnAgregarSocio.Text = "+ Agregar Socio";
            this.BtnAgregarSocio.UseVisualStyleBackColor = false;
            this.BtnAgregarSocio.Click += new System.EventHandler(this.BtnAgregarSocio_Click);
            // 
            // BtnEliminarSocio
            // 
            this.BtnEliminarSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminarSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnEliminarSocio.Enabled = false;
            this.BtnEliminarSocio.FlatAppearance.BorderSize = 0;
            this.BtnEliminarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnEliminarSocio.ForeColor = System.Drawing.Color.LightGray;
            this.BtnEliminarSocio.Location = new System.Drawing.Point(200, 586);
            this.BtnEliminarSocio.Name = "BtnEliminarSocio";
            this.BtnEliminarSocio.Size = new System.Drawing.Size(80, 30);
            this.BtnEliminarSocio.TabIndex = 7;
            this.BtnEliminarSocio.Text = "Eliminar";
            this.BtnEliminarSocio.UseVisualStyleBackColor = false;
            this.BtnEliminarSocio.Click += new System.EventHandler(this.BtnEliminarSocio_Click);
            // 
            // BtnEditarSocio
            // 
            this.BtnEditarSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEditarSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnEditarSocio.Enabled = false;
            this.BtnEditarSocio.FlatAppearance.BorderSize = 0;
            this.BtnEditarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnEditarSocio.ForeColor = System.Drawing.Color.LightGray;
            this.BtnEditarSocio.Location = new System.Drawing.Point(114, 586);
            this.BtnEditarSocio.Name = "BtnEditarSocio";
            this.BtnEditarSocio.Size = new System.Drawing.Size(80, 30);
            this.BtnEditarSocio.TabIndex = 6;
            this.BtnEditarSocio.Text = "Editar";
            this.BtnEditarSocio.UseVisualStyleBackColor = false;
            this.BtnEditarSocio.Click += new System.EventHandler(this.BtnEditarSocio_Click);
            // 
            // BtnVerSocio
            // 
            this.BtnVerSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnVerSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnVerSocio.Enabled = false;
            this.BtnVerSocio.FlatAppearance.BorderSize = 0;
            this.BtnVerSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnVerSocio.ForeColor = System.Drawing.Color.LightGray;
            this.BtnVerSocio.Location = new System.Drawing.Point(28, 586);
            this.BtnVerSocio.Name = "BtnVerSocio";
            this.BtnVerSocio.Size = new System.Drawing.Size(80, 30);
            this.BtnVerSocio.TabIndex = 5;
            this.BtnVerSocio.Text = "Ver";
            this.BtnVerSocio.UseVisualStyleBackColor = false;
            this.BtnVerSocio.Click += new System.EventHandler(this.BtnVerSocio_Click);
            // 
            // GbListadoSocios
            // 
            this.GbListadoSocios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbListadoSocios.Controls.Add(this.BtnLimpiar);
            this.GbListadoSocios.Controls.Add(this.BtnBuscar);
            this.GbListadoSocios.Controls.Add(this.CbEstado);
            this.GbListadoSocios.Controls.Add(this.LblEstado);
            this.GbListadoSocios.Controls.Add(this.DgvSocios);
            this.GbListadoSocios.Controls.Add(this.CbTipoDoc);
            this.GbListadoSocios.Controls.Add(this.LblTipoDocSocio);
            this.GbListadoSocios.Controls.Add(this.TxtNroDoc);
            this.GbListadoSocios.Controls.Add(this.LblNroDocSocio);
            this.GbListadoSocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.GbListadoSocios.ForeColor = System.Drawing.Color.Gainsboro;
            this.GbListadoSocios.Location = new System.Drawing.Point(28, 42);
            this.GbListadoSocios.Name = "GbListadoSocios";
            this.GbListadoSocios.Size = new System.Drawing.Size(751, 516);
            this.GbListadoSocios.TabIndex = 21;
            this.GbListadoSocios.TabStop = false;
            this.GbListadoSocios.Text = "Listado de Socios";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnLimpiar.Location = new System.Drawing.Point(650, 23);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 3;
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
            this.BtnBuscar.Location = new System.Drawing.Point(650, 54);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // CbEstado
            // 
            this.CbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.Location = new System.Drawing.Point(280, 53);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(89, 24);
            this.CbEstado.TabIndex = 2;
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblEstado.ForeColor = System.Drawing.Color.DarkGray;
            this.LblEstado.Location = new System.Drawing.Point(276, 28);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(61, 22);
            this.LblEstado.TabIndex = 9;
            this.LblEstado.Text = "Estado";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSocios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroSocio,
            this.NroDocSocio,
            this.TipoDocSocio,
            this.Nombre,
            this.FechaNac,
            this.Sexo,
            this.Altura,
            this.Peso,
            this.Calle,
            this.NroCalle,
            this.Ciudad,
            this.CodigoPostal,
            this.Telefono,
            this.Email,
            this.FechaAlta,
            this.FechaBaja,
            this.AntecedenteMedico,
            this.Objetivos,
            this.ActividadYPlan,
            this.Vendedor,
            this.Estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSocios.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvSocios.EnableHeadersVisualStyles = false;
            this.DgvSocios.Location = new System.Drawing.Point(25, 96);
            this.DgvSocios.MultiSelect = false;
            this.DgvSocios.Name = "DgvSocios";
            this.DgvSocios.ReadOnly = true;
            this.DgvSocios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
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
            this.DgvSocios.Size = new System.Drawing.Size(700, 393);
            this.DgvSocios.TabIndex = 8;
            this.DgvSocios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSocios_CellClick);
            // 
            // NroSocio
            // 
            this.NroSocio.HeaderText = "Nro Socio";
            this.NroSocio.Name = "NroSocio";
            this.NroSocio.ReadOnly = true;
            this.NroSocio.Width = 121;
            // 
            // NroDocSocio
            // 
            this.NroDocSocio.HeaderText = "Nro Doc";
            this.NroDocSocio.Name = "NroDocSocio";
            this.NroDocSocio.ReadOnly = true;
            this.NroDocSocio.Width = 107;
            // 
            // TipoDocSocio
            // 
            this.TipoDocSocio.HeaderText = "Tipo Doc";
            this.TipoDocSocio.Name = "TipoDocSocio";
            this.TipoDocSocio.ReadOnly = true;
            this.TipoDocSocio.Width = 112;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 119;
            // 
            // FechaNac
            // 
            this.FechaNac.HeaderText = "Fecha Nacimiento";
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.ReadOnly = true;
            this.FechaNac.Width = 195;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 82;
            // 
            // Altura
            // 
            this.Altura.HeaderText = "Altura";
            this.Altura.Name = "Altura";
            this.Altura.ReadOnly = true;
            this.Altura.Width = 98;
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            this.Peso.Width = 84;
            // 
            // Calle
            // 
            this.Calle.HeaderText = "Calle";
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            this.Calle.Width = 85;
            // 
            // NroCalle
            // 
            this.NroCalle.HeaderText = "Nro Calle";
            this.NroCalle.Name = "NroCalle";
            this.NroCalle.ReadOnly = true;
            this.NroCalle.Width = 117;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            this.Ciudad.Width = 106;
            // 
            // CodigoPostal
            // 
            this.CodigoPostal.HeaderText = "Código Postal";
            this.CodigoPostal.Name = "CodigoPostal";
            this.CodigoPostal.ReadOnly = true;
            this.CodigoPostal.Width = 157;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 123;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 92;
            // 
            // FechaAlta
            // 
            this.FechaAlta.HeaderText = "Fecha Alta";
            this.FechaAlta.Name = "FechaAlta";
            this.FechaAlta.ReadOnly = true;
            this.FechaAlta.Width = 128;
            // 
            // FechaBaja
            // 
            this.FechaBaja.HeaderText = "FechaBaja";
            this.FechaBaja.Name = "FechaBaja";
            this.FechaBaja.ReadOnly = true;
            this.FechaBaja.Width = 137;
            // 
            // AntecedenteMedico
            // 
            this.AntecedenteMedico.HeaderText = "Antecedente Medico";
            this.AntecedenteMedico.Name = "AntecedenteMedico";
            this.AntecedenteMedico.ReadOnly = true;
            this.AntecedenteMedico.Width = 221;
            // 
            // Objetivos
            // 
            this.Objetivos.HeaderText = "Objetivos";
            this.Objetivos.Name = "Objetivos";
            this.Objetivos.ReadOnly = true;
            this.Objetivos.Width = 131;
            // 
            // ActividadYPlan
            // 
            this.ActividadYPlan.HeaderText = "Actividad y Plan";
            this.ActividadYPlan.Name = "ActividadYPlan";
            this.ActividadYPlan.ReadOnly = true;
            this.ActividadYPlan.Width = 138;
            // 
            // Vendedor
            // 
            this.Vendedor.HeaderText = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.ReadOnly = true;
            this.Vendedor.Width = 134;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 104;
            // 
            // CbTipoDoc
            // 
            this.CbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.CbTipoDoc.FormattingEnabled = true;
            this.CbTipoDoc.Location = new System.Drawing.Point(169, 53);
            this.CbTipoDoc.Name = "CbTipoDoc";
            this.CbTipoDoc.Size = new System.Drawing.Size(93, 24);
            this.CbTipoDoc.TabIndex = 1;
            // 
            // LblTipoDocSocio
            // 
            this.LblTipoDocSocio.AutoSize = true;
            this.LblTipoDocSocio.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblTipoDocSocio.ForeColor = System.Drawing.Color.DarkGray;
            this.LblTipoDocSocio.Location = new System.Drawing.Point(165, 28);
            this.LblTipoDocSocio.Name = "LblTipoDocSocio";
            this.LblTipoDocSocio.Size = new System.Drawing.Size(76, 22);
            this.LblTipoDocSocio.TabIndex = 6;
            this.LblTipoDocSocio.Text = "Tipo Doc";
            // 
            // TxtNroDoc
            // 
            this.TxtNroDoc.Location = new System.Drawing.Point(25, 53);
            this.TxtNroDoc.Name = "TxtNroDoc";
            this.TxtNroDoc.Size = new System.Drawing.Size(127, 24);
            this.TxtNroDoc.TabIndex = 0;
            // 
            // LblNroDocSocio
            // 
            this.LblNroDocSocio.AutoSize = true;
            this.LblNroDocSocio.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblNroDocSocio.ForeColor = System.Drawing.Color.DarkGray;
            this.LblNroDocSocio.Location = new System.Drawing.Point(21, 28);
            this.LblNroDocSocio.Name = "LblNroDocSocio";
            this.LblNroDocSocio.Size = new System.Drawing.Size(131, 22);
            this.LblNroDocSocio.TabIndex = 1;
            this.LblNroDocSocio.Text = "Nro Documento";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.ForeColor = System.Drawing.Color.LightGray;
            this.BtnSalir.Location = new System.Drawing.Point(699, 586);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(80, 30);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // ConsultaSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(807, 657);
            this.Controls.Add(this.PanelFormHijo);
            this.Name = "ConsultaSocios";
            this.Text = "ConsultaSocios";
            this.Load += new System.EventHandler(this.ConsultaSocios_Load);
            this.PanelFormHijo.ResumeLayout(false);
            this.GbListadoSocios.ResumeLayout(false);
            this.GbListadoSocios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSocios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFormHijo;
        private System.Windows.Forms.Button BtnAgregarSocio;
        private System.Windows.Forms.Button BtnEliminarSocio;
        private System.Windows.Forms.Button BtnEditarSocio;
        private System.Windows.Forms.Button BtnVerSocio;
        private System.Windows.Forms.GroupBox GbListadoSocios;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.DataGridView DgvSocios;
        private System.Windows.Forms.ComboBox CbTipoDoc;
        private System.Windows.Forms.Label LblTipoDocSocio;
        private System.Windows.Forms.TextBox TxtNroDoc;
        private System.Windows.Forms.Label LblNroDocSocio;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn AntecedenteMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Objetivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActividadYPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}