namespace PAV1_GYM.InterfacesDeUsuarios
{
    partial class Asistencias
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
            this.BtnMarcarEgreso = new System.Windows.Forms.Button();
            this.GBFiltroAsistencia = new System.Windows.Forms.GroupBox();
            this.CkBFiltros = new System.Windows.Forms.CheckBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LblFecha = new System.Windows.Forms.Label();
            this.CbFecha = new System.Windows.Forms.ComboBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.DgvAsistencias = new System.Windows.Forms.DataGridView();
            this.NroSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_Egreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblTurno = new System.Windows.Forms.Label();
            this.LblActividad = new System.Windows.Forms.Label();
            this.CbTurno = new System.Windows.Forms.ComboBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.CbActividad = new System.Windows.Forms.ComboBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.BtnEliminarAsistencia = new System.Windows.Forms.Button();
            this.BtnConfirmarAsistencia = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PanelFormHijo.SuspendLayout();
            this.GBFiltroAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAsistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelFormHijo
            // 
            this.PanelFormHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.PanelFormHijo.Controls.Add(this.BtnCargarTurno);
            this.PanelFormHijo.Controls.Add(this.BtnMarcarEgreso);
            this.PanelFormHijo.Controls.Add(this.GBFiltroAsistencia);
            this.PanelFormHijo.Controls.Add(this.BtnEliminarAsistencia);
            this.PanelFormHijo.Controls.Add(this.BtnConfirmarAsistencia);
            this.PanelFormHijo.Controls.Add(this.BtnSalir);
            this.PanelFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormHijo.Location = new System.Drawing.Point(0, 0);
            this.PanelFormHijo.Name = "PanelFormHijo";
            this.PanelFormHijo.Size = new System.Drawing.Size(963, 563);
            this.PanelFormHijo.TabIndex = 1;
            // 
            // BtnCargarTurno
            // 
            this.BtnCargarTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCargarTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnCargarTurno.FlatAppearance.BorderSize = 0;
            this.BtnCargarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCargarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnCargarTurno.ForeColor = System.Drawing.Color.LightGray;
            this.BtnCargarTurno.Location = new System.Drawing.Point(12, 521);
            this.BtnCargarTurno.Name = "BtnCargarTurno";
            this.BtnCargarTurno.Size = new System.Drawing.Size(127, 30);
            this.BtnCargarTurno.TabIndex = 39;
            this.BtnCargarTurno.Text = "Cargar Turno";
            this.BtnCargarTurno.UseVisualStyleBackColor = false;
            this.BtnCargarTurno.Click += new System.EventHandler(this.BtnCargarTurno_Click);
            // 
            // BtnMarcarEgreso
            // 
            this.BtnMarcarEgreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnMarcarEgreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnMarcarEgreso.Enabled = false;
            this.BtnMarcarEgreso.FlatAppearance.BorderSize = 0;
            this.BtnMarcarEgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMarcarEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnMarcarEgreso.ForeColor = System.Drawing.Color.LightGray;
            this.BtnMarcarEgreso.Location = new System.Drawing.Point(344, 521);
            this.BtnMarcarEgreso.Name = "BtnMarcarEgreso";
            this.BtnMarcarEgreso.Size = new System.Drawing.Size(149, 30);
            this.BtnMarcarEgreso.TabIndex = 38;
            this.BtnMarcarEgreso.Text = "Marcar Egreso";
            this.BtnMarcarEgreso.UseVisualStyleBackColor = false;
            this.BtnMarcarEgreso.Click += new System.EventHandler(this.BtnMarcarEgreso_Click);
            // 
            // GBFiltroAsistencia
            // 
            this.GBFiltroAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBFiltroAsistencia.Controls.Add(this.CkBFiltros);
            this.GBFiltroAsistencia.Controls.Add(this.BtnLimpiar);
            this.GBFiltroAsistencia.Controls.Add(this.BtnBuscar);
            this.GBFiltroAsistencia.Controls.Add(this.LblFecha);
            this.GBFiltroAsistencia.Controls.Add(this.CbFecha);
            this.GBFiltroAsistencia.Controls.Add(this.TxtApellido);
            this.GBFiltroAsistencia.Controls.Add(this.LblApellido);
            this.GBFiltroAsistencia.Controls.Add(this.DgvAsistencias);
            this.GBFiltroAsistencia.Controls.Add(this.LblTurno);
            this.GBFiltroAsistencia.Controls.Add(this.LblActividad);
            this.GBFiltroAsistencia.Controls.Add(this.CbTurno);
            this.GBFiltroAsistencia.Controls.Add(this.TxtNombre);
            this.GBFiltroAsistencia.Controls.Add(this.CbActividad);
            this.GBFiltroAsistencia.Controls.Add(this.LblNombre);
            this.GBFiltroAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBFiltroAsistencia.ForeColor = System.Drawing.SystemColors.Control;
            this.GBFiltroAsistencia.Location = new System.Drawing.Point(12, 12);
            this.GBFiltroAsistencia.Name = "GBFiltroAsistencia";
            this.GBFiltroAsistencia.Size = new System.Drawing.Size(939, 490);
            this.GBFiltroAsistencia.TabIndex = 34;
            this.GBFiltroAsistencia.TabStop = false;
            this.GBFiltroAsistencia.Text = "Asistencia";
            // 
            // CkBFiltros
            // 
            this.CkBFiltros.AutoSize = true;
            this.CkBFiltros.Location = new System.Drawing.Point(423, 50);
            this.CkBFiltros.Name = "CkBFiltros";
            this.CkBFiltros.Size = new System.Drawing.Size(90, 22);
            this.CkBFiltros.TabIndex = 38;
            this.CkBFiltros.Text = "+ Filtros";
            this.CkBFiltros.UseVisualStyleBackColor = true;
            this.CkBFiltros.CheckedChanged += new System.EventHandler(this.CkBFiltros_CheckedChanged);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnLimpiar.Location = new System.Drawing.Point(838, 24);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 7;
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
            this.BtnBuscar.Location = new System.Drawing.Point(838, 53);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 8;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(293, 25);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(54, 18);
            this.LblFecha.TabIndex = 37;
            this.LblFecha.Text = "Fecha";
            // 
            // CbFecha
            // 
            this.CbFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFecha.FormattingEnabled = true;
            this.CbFecha.Location = new System.Drawing.Point(296, 48);
            this.CbFecha.Name = "CbFecha";
            this.CbFecha.Size = new System.Drawing.Size(121, 26);
            this.CbFecha.TabIndex = 2;
            this.CbFecha.SelectionChangeCommitted += new System.EventHandler(this.CbFecha_SelectionChangeCommitted);
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(152, 50);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(127, 24);
            this.TxtApellido.TabIndex = 6;
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblApellido.ForeColor = System.Drawing.Color.DarkGray;
            this.LblApellido.Location = new System.Drawing.Point(148, 25);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(72, 22);
            this.LblApellido.TabIndex = 10;
            this.LblApellido.Text = "Apellido";
            // 
            // DgvAsistencias
            // 
            this.DgvAsistencias.AllowUserToAddRows = false;
            this.DgvAsistencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvAsistencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvAsistencias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvAsistencias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.DgvAsistencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvAsistencias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvAsistencias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAsistencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAsistencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroSocio,
            this.NombreSocio,
            this.Actividad,
            this.Turno,
            this.Fecha,
            this.Hora_Ingreso,
            this.Hora_Egreso});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvAsistencias.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvAsistencias.EnableHeadersVisualStyles = false;
            this.DgvAsistencias.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DgvAsistencias.Location = new System.Drawing.Point(15, 93);
            this.DgvAsistencias.Margin = new System.Windows.Forms.Padding(50);
            this.DgvAsistencias.MultiSelect = false;
            this.DgvAsistencias.Name = "DgvAsistencias";
            this.DgvAsistencias.ReadOnly = true;
            this.DgvAsistencias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAsistencias.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvAsistencias.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 16F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DgvAsistencias.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvAsistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAsistencias.Size = new System.Drawing.Size(898, 375);
            this.DgvAsistencias.TabIndex = 33;
            this.DgvAsistencias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAsistencias_CellClick);
            // 
            // NroSocio
            // 
            this.NroSocio.HeaderText = "Nro Socio";
            this.NroSocio.Name = "NroSocio";
            this.NroSocio.ReadOnly = true;
            this.NroSocio.Width = 132;
            // 
            // NombreSocio
            // 
            this.NombreSocio.HeaderText = "Nombre";
            this.NombreSocio.Name = "NombreSocio";
            this.NombreSocio.ReadOnly = true;
            this.NombreSocio.Width = 119;
            // 
            // Actividad
            // 
            this.Actividad.HeaderText = "Actividad";
            this.Actividad.Name = "Actividad";
            this.Actividad.ReadOnly = true;
            this.Actividad.Width = 130;
            // 
            // Turno
            // 
            this.Turno.HeaderText = "Turno";
            this.Turno.Name = "Turno";
            this.Turno.ReadOnly = true;
            this.Turno.Width = 95;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 94;
            // 
            // Hora_Ingreso
            // 
            this.Hora_Ingreso.HeaderText = "Hora Ingreso";
            this.Hora_Ingreso.Name = "Hora_Ingreso";
            this.Hora_Ingreso.ReadOnly = true;
            this.Hora_Ingreso.Width = 163;
            // 
            // Hora_Egreso
            // 
            this.Hora_Egreso.HeaderText = "Hora Egreso";
            this.Hora_Egreso.Name = "Hora_Egreso";
            this.Hora_Egreso.ReadOnly = true;
            this.Hora_Egreso.Width = 156;
            // 
            // LblTurno
            // 
            this.LblTurno.AutoSize = true;
            this.LblTurno.Location = new System.Drawing.Point(517, 25);
            this.LblTurno.Name = "LblTurno";
            this.LblTurno.Size = new System.Drawing.Size(52, 18);
            this.LblTurno.TabIndex = 31;
            this.LblTurno.Text = "Turno";
            // 
            // LblActividad
            // 
            this.LblActividad.AutoSize = true;
            this.LblActividad.Location = new System.Drawing.Point(653, 26);
            this.LblActividad.Name = "LblActividad";
            this.LblActividad.Size = new System.Drawing.Size(75, 18);
            this.LblActividad.TabIndex = 30;
            this.LblActividad.Text = "Actividad";
            // 
            // CbTurno
            // 
            this.CbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTurno.FormattingEnabled = true;
            this.CbTurno.Location = new System.Drawing.Point(520, 48);
            this.CbTurno.Name = "CbTurno";
            this.CbTurno.Size = new System.Drawing.Size(121, 26);
            this.CbTurno.TabIndex = 0;
            this.CbTurno.SelectionChangeCommitted += new System.EventHandler(this.CbTurno_SelectionChangeCommitted);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(15, 50);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(127, 24);
            this.TxtNombre.TabIndex = 5;
            // 
            // CbActividad
            // 
            this.CbActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbActividad.FormattingEnabled = true;
            this.CbActividad.Location = new System.Drawing.Point(656, 48);
            this.CbActividad.Name = "CbActividad";
            this.CbActividad.Size = new System.Drawing.Size(121, 26);
            this.CbActividad.TabIndex = 1;
            this.CbActividad.SelectionChangeCommitted += new System.EventHandler(this.CbActividad_SelectionChangeCommitted);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblNombre.ForeColor = System.Drawing.Color.DarkGray;
            this.LblNombre.Location = new System.Drawing.Point(11, 25);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(72, 22);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre";
            // 
            // BtnEliminarAsistencia
            // 
            this.BtnEliminarAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminarAsistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnEliminarAsistencia.Enabled = false;
            this.BtnEliminarAsistencia.FlatAppearance.BorderSize = 0;
            this.BtnEliminarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnEliminarAsistencia.ForeColor = System.Drawing.Color.LightGray;
            this.BtnEliminarAsistencia.Location = new System.Drawing.Point(499, 521);
            this.BtnEliminarAsistencia.Name = "BtnEliminarAsistencia";
            this.BtnEliminarAsistencia.Size = new System.Drawing.Size(182, 30);
            this.BtnEliminarAsistencia.TabIndex = 10;
            this.BtnEliminarAsistencia.Text = "Eliminar Asistencia";
            this.BtnEliminarAsistencia.UseVisualStyleBackColor = false;
            this.BtnEliminarAsistencia.Click += new System.EventHandler(this.BtnEliminarAsistencia_Click);
            // 
            // BtnConfirmarAsistencia
            // 
            this.BtnConfirmarAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnConfirmarAsistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnConfirmarAsistencia.Enabled = false;
            this.BtnConfirmarAsistencia.FlatAppearance.BorderSize = 0;
            this.BtnConfirmarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmarAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnConfirmarAsistencia.ForeColor = System.Drawing.Color.LightGray;
            this.BtnConfirmarAsistencia.Location = new System.Drawing.Point(146, 521);
            this.BtnConfirmarAsistencia.Name = "BtnConfirmarAsistencia";
            this.BtnConfirmarAsistencia.Size = new System.Drawing.Size(192, 30);
            this.BtnConfirmarAsistencia.TabIndex = 9;
            this.BtnConfirmarAsistencia.Text = "Confirmar Asistencia";
            this.BtnConfirmarAsistencia.UseVisualStyleBackColor = false;
            this.BtnConfirmarAsistencia.Click += new System.EventHandler(this.BtnConfirmarAsistencia_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.ForeColor = System.Drawing.Color.LightGray;
            this.BtnSalir.Location = new System.Drawing.Point(854, 521);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(97, 30);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Asistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 563);
            this.Controls.Add(this.PanelFormHijo);
            this.Name = "Asistencias";
            this.Text = "Asistencias";
            this.Load += new System.EventHandler(this.Asistencias_Load);
            this.PanelFormHijo.ResumeLayout(false);
            this.GBFiltroAsistencia.ResumeLayout(false);
            this.GBFiltroAsistencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAsistencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFormHijo;
        private System.Windows.Forms.Button BtnEliminarAsistencia;
        private System.Windows.Forms.Button BtnConfirmarAsistencia;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.GroupBox GBFiltroAsistencia;
        private System.Windows.Forms.Label LblTurno;
        private System.Windows.Forms.Label LblActividad;
        private System.Windows.Forms.ComboBox CbTurno;
        private System.Windows.Forms.ComboBox CbActividad;
        private System.Windows.Forms.DataGridView DgvAsistencias;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.ComboBox CbFecha;
        private System.Windows.Forms.Button BtnMarcarEgreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_Ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_Egreso;
        private System.Windows.Forms.Button BtnCargarTurno;
        private System.Windows.Forms.CheckBox CkBFiltros;
    }
}