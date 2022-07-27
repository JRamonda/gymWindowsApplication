
namespace PAV1_GYM.InterfacesDeUsuarios.Consultas
{
    partial class ConsultaTurnos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelFormHijo = new System.Windows.Forms.Panel();
            this.BtnDarAlta = new System.Windows.Forms.Button();
            this.BtnEliminarTurno = new System.Windows.Forms.Button();
            this.BtnDarBaja = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.GbListadoTurnos = new System.Windows.Forms.GroupBox();
            this.TxtNombreLista = new System.Windows.Forms.TextBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.LblEstado = new System.Windows.Forms.Label();
            this.DgvTurnos = new System.Windows.Forms.DataGridView();
            this.NroTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblNombre = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.GrupoDatosTurno = new System.Windows.Forms.GroupBox();
            this.TxtHoraFin = new System.Windows.Forms.TextBox();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.TxtHoraInicio = new System.Windows.Forms.TextBox();
            this.LblEstadoBuscado = new System.Windows.Forms.Label();
            this.LblNombreTurno = new System.Windows.Forms.Label();
            this.LblHoraInicio = new System.Windows.Forms.Label();
            this.LblDia = new System.Windows.Forms.Label();
            this.CbDia = new System.Windows.Forms.ComboBox();
            this.CbNombre = new System.Windows.Forms.ComboBox();
            this.PanelFormHijo.SuspendLayout();
            this.GbListadoTurnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTurnos)).BeginInit();
            this.GrupoDatosTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFormHijo
            // 
            this.PanelFormHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.PanelFormHijo.Controls.Add(this.BtnDarAlta);
            this.PanelFormHijo.Controls.Add(this.BtnEliminarTurno);
            this.PanelFormHijo.Controls.Add(this.BtnDarBaja);
            this.PanelFormHijo.Controls.Add(this.BtnNuevo);
            this.PanelFormHijo.Controls.Add(this.button1);
            this.PanelFormHijo.Controls.Add(this.BtnModificar);
            this.PanelFormHijo.Controls.Add(this.GbListadoTurnos);
            this.PanelFormHijo.Controls.Add(this.BtnRegistrar);
            this.PanelFormHijo.Controls.Add(this.GrupoDatosTurno);
            this.PanelFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormHijo.Location = new System.Drawing.Point(0, 0);
            this.PanelFormHijo.Name = "PanelFormHijo";
            this.PanelFormHijo.Size = new System.Drawing.Size(742, 449);
            this.PanelFormHijo.TabIndex = 3;
            // 
            // BtnDarAlta
            // 
            this.BtnDarAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDarAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnDarAlta.FlatAppearance.BorderSize = 0;
            this.BtnDarAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDarAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnDarAlta.ForeColor = System.Drawing.Color.LightGray;
            this.BtnDarAlta.Location = new System.Drawing.Point(210, 397);
            this.BtnDarAlta.Name = "BtnDarAlta";
            this.BtnDarAlta.Size = new System.Drawing.Size(105, 30);
            this.BtnDarAlta.TabIndex = 11;
            this.BtnDarAlta.Text = "Dar de Alta";
            this.BtnDarAlta.UseVisualStyleBackColor = false;
            this.BtnDarAlta.Click += new System.EventHandler(this.BtnDarAlta_Click);
            // 
            // BtnEliminarTurno
            // 
            this.BtnEliminarTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminarTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnEliminarTurno.Enabled = false;
            this.BtnEliminarTurno.FlatAppearance.BorderSize = 0;
            this.BtnEliminarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnEliminarTurno.ForeColor = System.Drawing.Color.LightGray;
            this.BtnEliminarTurno.Location = new System.Drawing.Point(322, 397);
            this.BtnEliminarTurno.Name = "BtnEliminarTurno";
            this.BtnEliminarTurno.Size = new System.Drawing.Size(80, 30);
            this.BtnEliminarTurno.TabIndex = 12;
            this.BtnEliminarTurno.Text = "Eliminar";
            this.BtnEliminarTurno.UseVisualStyleBackColor = false;
            this.BtnEliminarTurno.Click += new System.EventHandler(this.BtnEliminarTurno_Click);
            // 
            // BtnDarBaja
            // 
            this.BtnDarBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDarBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnDarBaja.FlatAppearance.BorderSize = 0;
            this.BtnDarBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDarBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnDarBaja.ForeColor = System.Drawing.Color.LightGray;
            this.BtnDarBaja.Location = new System.Drawing.Point(210, 397);
            this.BtnDarBaja.Name = "BtnDarBaja";
            this.BtnDarBaja.Size = new System.Drawing.Size(105, 30);
            this.BtnDarBaja.TabIndex = 11;
            this.BtnDarBaja.Text = "Dar de baja";
            this.BtnDarBaja.UseVisualStyleBackColor = false;
            this.BtnDarBaja.Click += new System.EventHandler(this.BtnDarBaja_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnNuevo.ForeColor = System.Drawing.Color.LightGray;
            this.BtnNuevo.Location = new System.Drawing.Point(408, 397);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(90, 30);
            this.BtnNuevo.TabIndex = 13;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(636, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnModificar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnModificar.Location = new System.Drawing.Point(114, 397);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(90, 30);
            this.BtnModificar.TabIndex = 10;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // GbListadoTurnos
            // 
            this.GbListadoTurnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbListadoTurnos.Controls.Add(this.TxtNombreLista);
            this.GbListadoTurnos.Controls.Add(this.BtnLimpiar);
            this.GbListadoTurnos.Controls.Add(this.BtnBuscar);
            this.GbListadoTurnos.Controls.Add(this.CbEstado);
            this.GbListadoTurnos.Controls.Add(this.LblEstado);
            this.GbListadoTurnos.Controls.Add(this.DgvTurnos);
            this.GbListadoTurnos.Controls.Add(this.LblNombre);
            this.GbListadoTurnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.GbListadoTurnos.ForeColor = System.Drawing.Color.Gainsboro;
            this.GbListadoTurnos.Location = new System.Drawing.Point(21, 12);
            this.GbListadoTurnos.Name = "GbListadoTurnos";
            this.GbListadoTurnos.Size = new System.Drawing.Size(695, 244);
            this.GbListadoTurnos.TabIndex = 40;
            this.GbListadoTurnos.TabStop = false;
            this.GbListadoTurnos.Text = "Listado de Turnos";
            // 
            // TxtNombreLista
            // 
            this.TxtNombreLista.Location = new System.Drawing.Point(25, 53);
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
            this.BtnLimpiar.Location = new System.Drawing.Point(594, 23);
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
            this.BtnBuscar.Location = new System.Drawing.Point(594, 54);
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
            // DgvTurnos
            // 
            this.DgvTurnos.AllowUserToAddRows = false;
            this.DgvTurnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvTurnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvTurnos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.DgvTurnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvTurnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvTurnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.DgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTurnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroTurno,
            this.Nombre,
            this.HoraInicio,
            this.HoraFin,
            this.Dia,
            this.Estado});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvTurnos.DefaultCellStyle = dataGridViewCellStyle14;
            this.DgvTurnos.EnableHeadersVisualStyles = false;
            this.DgvTurnos.Location = new System.Drawing.Point(25, 103);
            this.DgvTurnos.MultiSelect = false;
            this.DgvTurnos.Name = "DgvTurnos";
            this.DgvTurnos.ReadOnly = true;
            this.DgvTurnos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTurnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.DgvTurnos.RowHeadersVisible = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Calibri", 16F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.DgvTurnos.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.DgvTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTurnos.Size = new System.Drawing.Size(644, 121);
            this.DgvTurnos.TabIndex = 8;
            this.DgvTurnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTurnos_CellClick);
            // 
            // NroTurno
            // 
            this.NroTurno.HeaderText = "Nro Turno";
            this.NroTurno.Name = "NroTurno";
            this.NroTurno.ReadOnly = true;
            this.NroTurno.Visible = false;
            this.NroTurno.Width = 89;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 91;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Hora de Inicio";
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            this.HoraInicio.Width = 124;
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "Hora de Fin";
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.ReadOnly = true;
            this.HoraFin.Width = 88;
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Dia";
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            this.Dia.Width = 56;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 84;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblNombre.ForeColor = System.Drawing.Color.DarkGray;
            this.LblNombre.Location = new System.Drawing.Point(21, 28);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(72, 22);
            this.LblNombre.TabIndex = 6;
            this.LblNombre.Text = "Nombre";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnRegistrar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnRegistrar.Location = new System.Drawing.Point(18, 397);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(90, 30);
            this.BtnRegistrar.TabIndex = 9;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // GrupoDatosTurno
            // 
            this.GrupoDatosTurno.AccessibleName = "";
            this.GrupoDatosTurno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrupoDatosTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.GrupoDatosTurno.Controls.Add(this.CbNombre);
            this.GrupoDatosTurno.Controls.Add(this.CbDia);
            this.GrupoDatosTurno.Controls.Add(this.TxtHoraFin);
            this.GrupoDatosTurno.Controls.Add(this.lblHoraFin);
            this.GrupoDatosTurno.Controls.Add(this.TxtHoraInicio);
            this.GrupoDatosTurno.Controls.Add(this.LblEstadoBuscado);
            this.GrupoDatosTurno.Controls.Add(this.LblNombreTurno);
            this.GrupoDatosTurno.Controls.Add(this.LblHoraInicio);
            this.GrupoDatosTurno.Controls.Add(this.LblDia);
            this.GrupoDatosTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.GrupoDatosTurno.ForeColor = System.Drawing.Color.LightGray;
            this.GrupoDatosTurno.Location = new System.Drawing.Point(21, 262);
            this.GrupoDatosTurno.Name = "GrupoDatosTurno";
            this.GrupoDatosTurno.Size = new System.Drawing.Size(695, 109);
            this.GrupoDatosTurno.TabIndex = 61;
            this.GrupoDatosTurno.TabStop = false;
            this.GrupoDatosTurno.Text = "Datos Turnos";
            // 
            // TxtHoraFin
            // 
            this.TxtHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TxtHoraFin.Location = new System.Drawing.Point(252, 75);
            this.TxtHoraFin.Name = "TxtHoraFin";
            this.TxtHoraFin.Size = new System.Drawing.Size(117, 21);
            this.TxtHoraFin.TabIndex = 7;
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblHoraFin.Location = new System.Drawing.Point(189, 78);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(57, 15);
            this.lblHoraFin.TabIndex = 6;
            this.lblHoraFin.Text = "Hora Fin:";
            // 
            // TxtHoraInicio
            // 
            this.TxtHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TxtHoraInicio.Location = new System.Drawing.Point(91, 75);
            this.TxtHoraInicio.Name = "TxtHoraInicio";
            this.TxtHoraInicio.Size = new System.Drawing.Size(90, 21);
            this.TxtHoraInicio.TabIndex = 6;
            // 
            // LblEstadoBuscado
            // 
            this.LblEstadoBuscado.AutoSize = true;
            this.LblEstadoBuscado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblEstadoBuscado.Location = new System.Drawing.Point(384, 43);
            this.LblEstadoBuscado.Name = "LblEstadoBuscado";
            this.LblEstadoBuscado.Size = new System.Drawing.Size(48, 15);
            this.LblEstadoBuscado.TabIndex = 3;
            this.LblEstadoBuscado.Text = "Estado:";
            // 
            // LblNombreTurno
            // 
            this.LblNombreTurno.AutoSize = true;
            this.LblNombreTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblNombreTurno.Location = new System.Drawing.Point(16, 40);
            this.LblNombreTurno.Name = "LblNombreTurno";
            this.LblNombreTurno.Size = new System.Drawing.Size(55, 15);
            this.LblNombreTurno.TabIndex = 2;
            this.LblNombreTurno.Text = "Nombre:";
            // 
            // LblHoraInicio
            // 
            this.LblHoraInicio.AutoSize = true;
            this.LblHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblHoraInicio.Location = new System.Drawing.Point(16, 78);
            this.LblHoraInicio.Name = "LblHoraInicio";
            this.LblHoraInicio.Size = new System.Drawing.Size(69, 15);
            this.LblHoraInicio.TabIndex = 1;
            this.LblHoraInicio.Text = "Hora Inicio:";
            // 
            // LblDia
            // 
            this.LblDia.AutoSize = true;
            this.LblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblDia.Location = new System.Drawing.Point(217, 43);
            this.LblDia.Name = "LblDia";
            this.LblDia.Size = new System.Drawing.Size(29, 15);
            this.LblDia.TabIndex = 0;
            this.LblDia.Text = "Dia:";
            // 
            // CbDia
            // 
            this.CbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.CbDia.FormattingEnabled = true;
            this.CbDia.Location = new System.Drawing.Point(252, 37);
            this.CbDia.Name = "CbDia";
            this.CbDia.Size = new System.Drawing.Size(116, 24);
            this.CbDia.TabIndex = 10;
            // 
            // CbNombre
            // 
            this.CbNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.CbNombre.FormattingEnabled = true;
            this.CbNombre.Location = new System.Drawing.Point(77, 37);
            this.CbNombre.Name = "CbNombre";
            this.CbNombre.Size = new System.Drawing.Size(106, 24);
            this.CbNombre.TabIndex = 11;
            // 
            // ConsultaTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 449);
            this.Controls.Add(this.PanelFormHijo);
            this.Name = "ConsultaTurnos";
            this.Text = "ConsultaTurnos";
            this.Load += new System.EventHandler(this.ConsultaTurnos_Load);
            this.PanelFormHijo.ResumeLayout(false);
            this.GbListadoTurnos.ResumeLayout(false);
            this.GbListadoTurnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTurnos)).EndInit();
            this.GrupoDatosTurno.ResumeLayout(false);
            this.GrupoDatosTurno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFormHijo;
        private System.Windows.Forms.Button BtnEliminarTurno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox GbListadoTurnos;
        private System.Windows.Forms.TextBox TxtNombreLista;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.DataGridView DgvTurnos;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button BtnDarAlta;
        private System.Windows.Forms.Button BtnDarBaja;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.GroupBox GrupoDatosTurno;
        private System.Windows.Forms.TextBox TxtHoraFin;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.TextBox TxtHoraInicio;
        private System.Windows.Forms.Label LblEstadoBuscado;
        private System.Windows.Forms.Label LblNombreTurno;
        private System.Windows.Forms.Label LblHoraInicio;
        private System.Windows.Forms.Label LblDia;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.ComboBox CbNombre;
        private System.Windows.Forms.ComboBox CbDia;
    }
}