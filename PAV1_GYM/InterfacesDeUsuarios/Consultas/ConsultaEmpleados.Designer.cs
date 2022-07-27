namespace PAV1_GYM.InterfacesDeUsuarios.Consultas
{
    partial class ConsultaEmpleados
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
            this.BtnAgregarEmpleado = new System.Windows.Forms.Button();
            this.BtnEliminarEmpleado = new System.Windows.Forms.Button();
            this.BtnEditarEmpleado = new System.Windows.Forms.Button();
            this.BtnVerEmpleado = new System.Windows.Forms.Button();
            this.GbListadoEmpleados = new System.Windows.Forms.GroupBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.LblEstado = new System.Windows.Forms.Label();
            this.DgvEmpleados = new System.Windows.Forms.DataGridView();
            this.LegajoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActividadesYTurnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CbTipoDoc = new System.Windows.Forms.ComboBox();
            this.LblTipoDocSocio = new System.Windows.Forms.Label();
            this.TxtNroDoc = new System.Windows.Forms.TextBox();
            this.LblNroDocSocio = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PanelFormHijo.SuspendLayout();
            this.GbListadoEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelFormHijo
            // 
            this.PanelFormHijo.Controls.Add(this.BtnAgregarEmpleado);
            this.PanelFormHijo.Controls.Add(this.BtnEliminarEmpleado);
            this.PanelFormHijo.Controls.Add(this.BtnEditarEmpleado);
            this.PanelFormHijo.Controls.Add(this.BtnVerEmpleado);
            this.PanelFormHijo.Controls.Add(this.GbListadoEmpleados);
            this.PanelFormHijo.Controls.Add(this.BtnSalir);
            this.PanelFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormHijo.Location = new System.Drawing.Point(0, 0);
            this.PanelFormHijo.Name = "PanelFormHijo";
            this.PanelFormHijo.Size = new System.Drawing.Size(789, 620);
            this.PanelFormHijo.TabIndex = 0;
            // 
            // BtnAgregarEmpleado
            // 
            this.BtnAgregarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAgregarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnAgregarEmpleado.FlatAppearance.BorderSize = 0;
            this.BtnAgregarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnAgregarEmpleado.ForeColor = System.Drawing.Color.LightGray;
            this.BtnAgregarEmpleado.Location = new System.Drawing.Point(277, 568);
            this.BtnAgregarEmpleado.Name = "BtnAgregarEmpleado";
            this.BtnAgregarEmpleado.Size = new System.Drawing.Size(170, 30);
            this.BtnAgregarEmpleado.TabIndex = 8;
            this.BtnAgregarEmpleado.Text = "+ Agregar Empleado";
            this.BtnAgregarEmpleado.UseVisualStyleBackColor = false;
            this.BtnAgregarEmpleado.Click += new System.EventHandler(this.BtnAgregarEmpleado_Click);
            // 
            // BtnEliminarEmpleado
            // 
            this.BtnEliminarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnEliminarEmpleado.Enabled = false;
            this.BtnEliminarEmpleado.FlatAppearance.BorderSize = 0;
            this.BtnEliminarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnEliminarEmpleado.ForeColor = System.Drawing.Color.LightGray;
            this.BtnEliminarEmpleado.Location = new System.Drawing.Point(191, 568);
            this.BtnEliminarEmpleado.Name = "BtnEliminarEmpleado";
            this.BtnEliminarEmpleado.Size = new System.Drawing.Size(80, 30);
            this.BtnEliminarEmpleado.TabIndex = 7;
            this.BtnEliminarEmpleado.Text = "Eliminar";
            this.BtnEliminarEmpleado.UseVisualStyleBackColor = false;
            this.BtnEliminarEmpleado.Click += new System.EventHandler(this.BtnEliminarEmpleado_Click);
            // 
            // BtnEditarEmpleado
            // 
            this.BtnEditarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEditarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnEditarEmpleado.Enabled = false;
            this.BtnEditarEmpleado.FlatAppearance.BorderSize = 0;
            this.BtnEditarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnEditarEmpleado.ForeColor = System.Drawing.Color.LightGray;
            this.BtnEditarEmpleado.Location = new System.Drawing.Point(105, 568);
            this.BtnEditarEmpleado.Name = "BtnEditarEmpleado";
            this.BtnEditarEmpleado.Size = new System.Drawing.Size(80, 30);
            this.BtnEditarEmpleado.TabIndex = 6;
            this.BtnEditarEmpleado.Text = "Editar";
            this.BtnEditarEmpleado.UseVisualStyleBackColor = false;
            this.BtnEditarEmpleado.Click += new System.EventHandler(this.BtnEditarEmpleado_Click);
            // 
            // BtnVerEmpleado
            // 
            this.BtnVerEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnVerEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnVerEmpleado.Enabled = false;
            this.BtnVerEmpleado.FlatAppearance.BorderSize = 0;
            this.BtnVerEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnVerEmpleado.ForeColor = System.Drawing.Color.LightGray;
            this.BtnVerEmpleado.Location = new System.Drawing.Point(19, 568);
            this.BtnVerEmpleado.Name = "BtnVerEmpleado";
            this.BtnVerEmpleado.Size = new System.Drawing.Size(80, 30);
            this.BtnVerEmpleado.TabIndex = 5;
            this.BtnVerEmpleado.Text = "Ver";
            this.BtnVerEmpleado.UseVisualStyleBackColor = false;
            this.BtnVerEmpleado.Click += new System.EventHandler(this.BtnVerEmpleado_Click);
            // 
            // GbListadoEmpleados
            // 
            this.GbListadoEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbListadoEmpleados.Controls.Add(this.BtnLimpiar);
            this.GbListadoEmpleados.Controls.Add(this.BtnBuscar);
            this.GbListadoEmpleados.Controls.Add(this.CbEstado);
            this.GbListadoEmpleados.Controls.Add(this.LblEstado);
            this.GbListadoEmpleados.Controls.Add(this.DgvEmpleados);
            this.GbListadoEmpleados.Controls.Add(this.CbTipoDoc);
            this.GbListadoEmpleados.Controls.Add(this.LblTipoDocSocio);
            this.GbListadoEmpleados.Controls.Add(this.TxtNroDoc);
            this.GbListadoEmpleados.Controls.Add(this.LblNroDocSocio);
            this.GbListadoEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.GbListadoEmpleados.ForeColor = System.Drawing.Color.Gainsboro;
            this.GbListadoEmpleados.Location = new System.Drawing.Point(19, 24);
            this.GbListadoEmpleados.Name = "GbListadoEmpleados";
            this.GbListadoEmpleados.Size = new System.Drawing.Size(751, 516);
            this.GbListadoEmpleados.TabIndex = 33;
            this.GbListadoEmpleados.TabStop = false;
            this.GbListadoEmpleados.Text = "Listado de Empleados";
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
            // DgvEmpleados
            // 
            this.DgvEmpleados.AllowUserToAddRows = false;
            this.DgvEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.DgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LegajoEmpleado,
            this.Perfil,
            this.NroDocEmpleado,
            this.TipoDocEmpleado,
            this.Nombre,
            this.FechaNac,
            this.Sexo,
            this.Calle,
            this.NroCalle,
            this.Ciudad,
            this.CodigoPostal,
            this.Telefono,
            this.Email,
            this.FechaIngreso,
            this.FechaBaja,
            this.ActividadesYTurnos,
            this.Estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvEmpleados.EnableHeadersVisualStyles = false;
            this.DgvEmpleados.Location = new System.Drawing.Point(25, 96);
            this.DgvEmpleados.MultiSelect = false;
            this.DgvEmpleados.Name = "DgvEmpleados";
            this.DgvEmpleados.ReadOnly = true;
            this.DgvEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvEmpleados.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 16F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DgvEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEmpleados.Size = new System.Drawing.Size(700, 393);
            this.DgvEmpleados.TabIndex = 8;
            this.DgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpleados_CellClick);
            // 
            // LegajoEmpleado
            // 
            this.LegajoEmpleado.HeaderText = "Legajo";
            this.LegajoEmpleado.Name = "LegajoEmpleado";
            this.LegajoEmpleado.ReadOnly = true;
            // 
            // Perfil
            // 
            this.Perfil.HeaderText = "Perfil";
            this.Perfil.Name = "Perfil";
            this.Perfil.ReadOnly = true;
            this.Perfil.Width = 89;
            // 
            // NroDocEmpleado
            // 
            this.NroDocEmpleado.HeaderText = "Nro Doc";
            this.NroDocEmpleado.Name = "NroDocEmpleado";
            this.NroDocEmpleado.ReadOnly = true;
            this.NroDocEmpleado.Width = 107;
            // 
            // TipoDocEmpleado
            // 
            this.TipoDocEmpleado.HeaderText = "Tipo Doc";
            this.TipoDocEmpleado.Name = "TipoDocEmpleado";
            this.TipoDocEmpleado.ReadOnly = true;
            this.TipoDocEmpleado.Width = 112;
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
            // FechaIngreso
            // 
            this.FechaIngreso.HeaderText = "Fecha Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            this.FechaIngreso.Width = 157;
            // 
            // FechaBaja
            // 
            this.FechaBaja.HeaderText = "FechaBaja";
            this.FechaBaja.Name = "FechaBaja";
            this.FechaBaja.ReadOnly = true;
            this.FechaBaja.Width = 137;
            // 
            // ActividadesYTurnos
            // 
            this.ActividadesYTurnos.HeaderText = "Actividades y Turnos";
            this.ActividadesYTurnos.Name = "ActividadesYTurnos";
            this.ActividadesYTurnos.ReadOnly = true;
            this.ActividadesYTurnos.Width = 157;
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
            this.BtnSalir.Location = new System.Drawing.Point(690, 568);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(80, 30);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // ConsultaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(789, 620);
            this.Controls.Add(this.PanelFormHijo);
            this.Name = "ConsultaEmpleados";
            this.Text = "ConsultaEmpleados";
            this.Load += new System.EventHandler(this.ConsultaEmpleados_Load);
            this.PanelFormHijo.ResumeLayout(false);
            this.GbListadoEmpleados.ResumeLayout(false);
            this.GbListadoEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFormHijo;
        private System.Windows.Forms.Button BtnAgregarEmpleado;
        private System.Windows.Forms.Button BtnEliminarEmpleado;
        private System.Windows.Forms.Button BtnEditarEmpleado;
        private System.Windows.Forms.Button BtnVerEmpleado;
        private System.Windows.Forms.GroupBox GbListadoEmpleados;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.DataGridView DgvEmpleados;
        private System.Windows.Forms.ComboBox CbTipoDoc;
        private System.Windows.Forms.Label LblTipoDocSocio;
        private System.Windows.Forms.TextBox TxtNroDoc;
        private System.Windows.Forms.Label LblNroDocSocio;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn LegajoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActividadesYTurnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}