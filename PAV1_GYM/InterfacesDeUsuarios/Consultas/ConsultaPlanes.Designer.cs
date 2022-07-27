namespace PAV1_GYM.InterfacesDeUsuarios.Consultas
{
    partial class ConsultaPlanes
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
            this.GbListadoPlanes = new System.Windows.Forms.GroupBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.LblEstado = new System.Windows.Forms.Label();
            this.DgvPlanes = new System.Windows.Forms.DataGridView();
            this.IdPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioEstandar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblNombrePlan = new System.Windows.Forms.Label();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnDarAlta = new System.Windows.Forms.Button();
            this.BtnDarBaja = new System.Windows.Forms.Button();
            this.GrupoDatosPlan = new System.Windows.Forms.GroupBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtNombrePlan = new System.Windows.Forms.TextBox();
            this.LblEstadoBuscado = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.BtnEliminarPlan = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PanelFormHijo.SuspendLayout();
            this.GbListadoPlanes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPlanes)).BeginInit();
            this.GrupoDatosPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFormHijo
            // 
            this.PanelFormHijo.AutoScroll = true;
            this.PanelFormHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.PanelFormHijo.Controls.Add(this.GbListadoPlanes);
            this.PanelFormHijo.Controls.Add(this.BtnNuevo);
            this.PanelFormHijo.Controls.Add(this.BtnRegistrar);
            this.PanelFormHijo.Controls.Add(this.BtnModificar);
            this.PanelFormHijo.Controls.Add(this.BtnDarAlta);
            this.PanelFormHijo.Controls.Add(this.BtnDarBaja);
            this.PanelFormHijo.Controls.Add(this.GrupoDatosPlan);
            this.PanelFormHijo.Controls.Add(this.BtnEliminarPlan);
            this.PanelFormHijo.Controls.Add(this.BtnSalir);
            this.PanelFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormHijo.Location = new System.Drawing.Point(0, 0);
            this.PanelFormHijo.Name = "PanelFormHijo";
            this.PanelFormHijo.Size = new System.Drawing.Size(777, 484);
            this.PanelFormHijo.TabIndex = 2;
            // 
            // GbListadoPlanes
            // 
            this.GbListadoPlanes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbListadoPlanes.Controls.Add(this.TxtNombre);
            this.GbListadoPlanes.Controls.Add(this.BtnLimpiar);
            this.GbListadoPlanes.Controls.Add(this.BtnBuscar);
            this.GbListadoPlanes.Controls.Add(this.CbEstado);
            this.GbListadoPlanes.Controls.Add(this.LblEstado);
            this.GbListadoPlanes.Controls.Add(this.DgvPlanes);
            this.GbListadoPlanes.Controls.Add(this.LblNombrePlan);
            this.GbListadoPlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.GbListadoPlanes.ForeColor = System.Drawing.Color.Gainsboro;
            this.GbListadoPlanes.Location = new System.Drawing.Point(28, 12);
            this.GbListadoPlanes.Name = "GbListadoPlanes";
            this.GbListadoPlanes.Size = new System.Drawing.Size(721, 272);
            this.GbListadoPlanes.TabIndex = 21;
            this.GbListadoPlanes.TabStop = false;
            this.GbListadoPlanes.Text = "Listado de Planes";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(25, 53);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(127, 24);
            this.TxtNombre.TabIndex = 1;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnLimpiar.Location = new System.Drawing.Point(620, 23);
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
            this.BtnBuscar.Location = new System.Drawing.Point(620, 54);
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
            this.CbEstado.Location = new System.Drawing.Point(180, 55);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(89, 24);
            this.CbEstado.TabIndex = 2;
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblEstado.ForeColor = System.Drawing.Color.DarkGray;
            this.LblEstado.Location = new System.Drawing.Point(176, 28);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(61, 22);
            this.LblEstado.TabIndex = 9;
            this.LblEstado.Text = "Estado";
            // 
            // DgvPlanes
            // 
            this.DgvPlanes.AllowUserToAddRows = false;
            this.DgvPlanes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPlanes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvPlanes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvPlanes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.DgvPlanes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvPlanes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvPlanes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPlanes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPlanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPlan,
            this.Nombre,
            this.Descripcion,
            this.PrecioEstandar,
            this.FechaInicio,
            this.Estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPlanes.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvPlanes.EnableHeadersVisualStyles = false;
            this.DgvPlanes.Location = new System.Drawing.Point(25, 96);
            this.DgvPlanes.MultiSelect = false;
            this.DgvPlanes.Name = "DgvPlanes";
            this.DgvPlanes.ReadOnly = true;
            this.DgvPlanes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPlanes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvPlanes.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 16F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DgvPlanes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvPlanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPlanes.Size = new System.Drawing.Size(670, 155);
            this.DgvPlanes.TabIndex = 8;
            this.DgvPlanes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPlanes_CellClick);
            // 
            // IdPlan
            // 
            this.IdPlan.HeaderText = "Id Plan";
            this.IdPlan.Name = "IdPlan";
            this.IdPlan.ReadOnly = true;
            this.IdPlan.Visible = false;
            this.IdPlan.Width = 63;
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
            // PrecioEstandar
            // 
            this.PrecioEstandar.HeaderText = "Precio Estandar";
            this.PrecioEstandar.Name = "PrecioEstandar";
            this.PrecioEstandar.ReadOnly = true;
            this.PrecioEstandar.Width = 139;
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Width = 112;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 84;
            // 
            // LblNombrePlan
            // 
            this.LblNombrePlan.AutoSize = true;
            this.LblNombrePlan.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblNombrePlan.ForeColor = System.Drawing.Color.DarkGray;
            this.LblNombrePlan.Location = new System.Drawing.Point(21, 28);
            this.LblNombrePlan.Name = "LblNombrePlan";
            this.LblNombrePlan.Size = new System.Drawing.Size(72, 22);
            this.LblNombrePlan.TabIndex = 6;
            this.LblNombrePlan.Text = "Nombre";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnNuevo.ForeColor = System.Drawing.Color.LightGray;
            this.BtnNuevo.Location = new System.Drawing.Point(417, 442);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(72, 30);
            this.BtnNuevo.TabIndex = 12;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnRegistrar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnRegistrar.Location = new System.Drawing.Point(28, 442);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(90, 30);
            this.BtnRegistrar.TabIndex = 8;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnModificar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnModificar.Location = new System.Drawing.Point(124, 442);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(90, 30);
            this.BtnModificar.TabIndex = 9;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnDarAlta
            // 
            this.BtnDarAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDarAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnDarAlta.FlatAppearance.BorderSize = 0;
            this.BtnDarAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDarAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnDarAlta.ForeColor = System.Drawing.Color.LightGray;
            this.BtnDarAlta.Location = new System.Drawing.Point(219, 442);
            this.BtnDarAlta.Name = "BtnDarAlta";
            this.BtnDarAlta.Size = new System.Drawing.Size(105, 30);
            this.BtnDarAlta.TabIndex = 10;
            this.BtnDarAlta.Text = "Dar de Alta";
            this.BtnDarAlta.UseVisualStyleBackColor = false;
            this.BtnDarAlta.Click += new System.EventHandler(this.BtnDarAlta_Click);
            // 
            // BtnDarBaja
            // 
            this.BtnDarBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDarBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnDarBaja.FlatAppearance.BorderSize = 0;
            this.BtnDarBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDarBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnDarBaja.ForeColor = System.Drawing.Color.LightGray;
            this.BtnDarBaja.Location = new System.Drawing.Point(220, 442);
            this.BtnDarBaja.Name = "BtnDarBaja";
            this.BtnDarBaja.Size = new System.Drawing.Size(105, 30);
            this.BtnDarBaja.TabIndex = 10;
            this.BtnDarBaja.Text = "Dar de baja";
            this.BtnDarBaja.UseVisualStyleBackColor = false;
            this.BtnDarBaja.Click += new System.EventHandler(this.BtnDarBaja_Click);
            // 
            // GrupoDatosPlan
            // 
            this.GrupoDatosPlan.AccessibleName = "";
            this.GrupoDatosPlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrupoDatosPlan.AutoSize = true;
            this.GrupoDatosPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.GrupoDatosPlan.Controls.Add(this.TxtPrecio);
            this.GrupoDatosPlan.Controls.Add(this.TxtDescripcion);
            this.GrupoDatosPlan.Controls.Add(this.TxtNombrePlan);
            this.GrupoDatosPlan.Controls.Add(this.LblEstadoBuscado);
            this.GrupoDatosPlan.Controls.Add(this.LblNombre);
            this.GrupoDatosPlan.Controls.Add(this.LblDescripcion);
            this.GrupoDatosPlan.Controls.Add(this.LblPrecio);
            this.GrupoDatosPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.GrupoDatosPlan.ForeColor = System.Drawing.Color.LightGray;
            this.GrupoDatosPlan.Location = new System.Drawing.Point(28, 290);
            this.GrupoDatosPlan.Name = "GrupoDatosPlan";
            this.GrupoDatosPlan.Size = new System.Drawing.Size(721, 121);
            this.GrupoDatosPlan.TabIndex = 49;
            this.GrupoDatosPlan.TabStop = false;
            this.GrupoDatosPlan.Text = "Datos Plan";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TxtPrecio.Location = new System.Drawing.Point(422, 75);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(103, 21);
            this.TxtPrecio.TabIndex = 7;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TxtDescripcion.Location = new System.Drawing.Point(96, 75);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(216, 21);
            this.TxtDescripcion.TabIndex = 6;
            // 
            // TxtNombrePlan
            // 
            this.TxtNombrePlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TxtNombrePlan.Location = new System.Drawing.Point(77, 40);
            this.TxtNombrePlan.Name = "TxtNombrePlan";
            this.TxtNombrePlan.Size = new System.Drawing.Size(200, 21);
            this.TxtNombrePlan.TabIndex = 5;
            // 
            // LblEstadoBuscado
            // 
            this.LblEstadoBuscado.AutoSize = true;
            this.LblEstadoBuscado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblEstadoBuscado.Location = new System.Drawing.Point(367, 43);
            this.LblEstadoBuscado.Name = "LblEstadoBuscado";
            this.LblEstadoBuscado.Size = new System.Drawing.Size(48, 15);
            this.LblEstadoBuscado.TabIndex = 3;
            this.LblEstadoBuscado.Text = "Estado:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblNombre.Location = new System.Drawing.Point(16, 40);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(55, 15);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombre:";
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
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblPrecio.Location = new System.Drawing.Point(367, 78);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(45, 15);
            this.LblPrecio.TabIndex = 0;
            this.LblPrecio.Text = "Precio:";
            // 
            // BtnEliminarPlan
            // 
            this.BtnEliminarPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminarPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnEliminarPlan.Enabled = false;
            this.BtnEliminarPlan.FlatAppearance.BorderSize = 0;
            this.BtnEliminarPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnEliminarPlan.ForeColor = System.Drawing.Color.LightGray;
            this.BtnEliminarPlan.Location = new System.Drawing.Point(331, 442);
            this.BtnEliminarPlan.Name = "BtnEliminarPlan";
            this.BtnEliminarPlan.Size = new System.Drawing.Size(80, 30);
            this.BtnEliminarPlan.TabIndex = 11;
            this.BtnEliminarPlan.Text = "Eliminar";
            this.BtnEliminarPlan.UseVisualStyleBackColor = false;
            this.BtnEliminarPlan.Click += new System.EventHandler(this.BtnEliminarPlan_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.ForeColor = System.Drawing.Color.LightGray;
            this.BtnSalir.Location = new System.Drawing.Point(669, 442);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(80, 30);
            this.BtnSalir.TabIndex = 13;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // ConsultaPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 484);
            this.Controls.Add(this.PanelFormHijo);
            this.Name = "ConsultaPlanes";
            this.Text = "ConsultaPlanes";
            this.Load += new System.EventHandler(this.ConsultaPlanes_Load);
            this.PanelFormHijo.ResumeLayout(false);
            this.PanelFormHijo.PerformLayout();
            this.GbListadoPlanes.ResumeLayout(false);
            this.GbListadoPlanes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPlanes)).EndInit();
            this.GrupoDatosPlan.ResumeLayout(false);
            this.GrupoDatosPlan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFormHijo;
        private System.Windows.Forms.Button BtnEliminarPlan;
        private System.Windows.Forms.GroupBox GbListadoPlanes;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.DataGridView DgvPlanes;
        private System.Windows.Forms.Label LblNombrePlan;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.GroupBox GrupoDatosPlan;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtNombrePlan;
        private System.Windows.Forms.Label LblEstadoBuscado;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Button BtnDarBaja;
        private System.Windows.Forms.Button BtnDarAlta;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioEstandar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}