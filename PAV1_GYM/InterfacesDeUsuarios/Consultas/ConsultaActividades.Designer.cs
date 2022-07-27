
namespace PAV1_GYM.InterfacesDeUsuarios.Consultas
{
    partial class ConsultaActividades
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
            this.BtnDarAlta = new System.Windows.Forms.Button();
            this.BtnDarBaja = new System.Windows.Forms.Button();
            this.GrupoDatosActividad = new System.Windows.Forms.GroupBox();
            this.LnkQuitarTurno = new System.Windows.Forms.LinkLabel();
            this.LBTurnos = new System.Windows.Forms.ListBox();
            this.LnkAgregarTurno = new System.Windows.Forms.LinkLabel();
            this.LblTurno = new System.Windows.Forms.Label();
            this.CbTurno = new System.Windows.Forms.ComboBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtNombreActividad = new System.Windows.Forms.TextBox();
            this.LblEstadoBuscado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.GbListadoActividades = new System.Windows.Forms.GroupBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.LblEstado = new System.Windows.Forms.Label();
            this.DgvActividades = new System.Windows.Forms.DataGridView();
            this.LblNombre = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblDia = new System.Windows.Forms.Label();
            this.CbDia = new System.Windows.Forms.ComboBox();
            this.NroActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelFormHijo.SuspendLayout();
            this.GrupoDatosActividad.SuspendLayout();
            this.GbListadoActividades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelFormHijo
            // 
            this.PanelFormHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.PanelFormHijo.Controls.Add(this.BtnDarAlta);
            this.PanelFormHijo.Controls.Add(this.BtnDarBaja);
            this.PanelFormHijo.Controls.Add(this.GrupoDatosActividad);
            this.PanelFormHijo.Controls.Add(this.BtnNuevo);
            this.PanelFormHijo.Controls.Add(this.BtnModificar);
            this.PanelFormHijo.Controls.Add(this.BtnRegistrar);
            this.PanelFormHijo.Controls.Add(this.BtnEliminar);
            this.PanelFormHijo.Controls.Add(this.GbListadoActividades);
            this.PanelFormHijo.Controls.Add(this.BtnSalir);
            this.PanelFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormHijo.Location = new System.Drawing.Point(0, 0);
            this.PanelFormHijo.Name = "PanelFormHijo";
            this.PanelFormHijo.Size = new System.Drawing.Size(889, 494);
            this.PanelFormHijo.TabIndex = 1;
            // 
            // BtnDarAlta
            // 
            this.BtnDarAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDarAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnDarAlta.FlatAppearance.BorderSize = 0;
            this.BtnDarAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDarAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnDarAlta.ForeColor = System.Drawing.Color.LightGray;
            this.BtnDarAlta.Location = new System.Drawing.Point(219, 426);
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
            this.BtnDarBaja.Location = new System.Drawing.Point(219, 426);
            this.BtnDarBaja.Name = "BtnDarBaja";
            this.BtnDarBaja.Size = new System.Drawing.Size(105, 30);
            this.BtnDarBaja.TabIndex = 10;
            this.BtnDarBaja.Text = "Dar de baja";
            this.BtnDarBaja.UseVisualStyleBackColor = false;
            this.BtnDarBaja.Click += new System.EventHandler(this.BtnDarBaja_Click);
            // 
            // GrupoDatosActividad
            // 
            this.GrupoDatosActividad.AccessibleName = "";
            this.GrupoDatosActividad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrupoDatosActividad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.GrupoDatosActividad.Controls.Add(this.LblDia);
            this.GrupoDatosActividad.Controls.Add(this.CbDia);
            this.GrupoDatosActividad.Controls.Add(this.LnkQuitarTurno);
            this.GrupoDatosActividad.Controls.Add(this.LBTurnos);
            this.GrupoDatosActividad.Controls.Add(this.LnkAgregarTurno);
            this.GrupoDatosActividad.Controls.Add(this.LblTurno);
            this.GrupoDatosActividad.Controls.Add(this.CbTurno);
            this.GrupoDatosActividad.Controls.Add(this.TxtPrecio);
            this.GrupoDatosActividad.Controls.Add(this.TxtDescripcion);
            this.GrupoDatosActividad.Controls.Add(this.TxtNombreActividad);
            this.GrupoDatosActividad.Controls.Add(this.LblEstadoBuscado);
            this.GrupoDatosActividad.Controls.Add(this.label2);
            this.GrupoDatosActividad.Controls.Add(this.LblDescripcion);
            this.GrupoDatosActividad.Controls.Add(this.LblPrecio);
            this.GrupoDatosActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.GrupoDatosActividad.ForeColor = System.Drawing.Color.LightGray;
            this.GrupoDatosActividad.Location = new System.Drawing.Point(28, 283);
            this.GrupoDatosActividad.Name = "GrupoDatosActividad";
            this.GrupoDatosActividad.Size = new System.Drawing.Size(833, 126);
            this.GrupoDatosActividad.TabIndex = 48;
            this.GrupoDatosActividad.TabStop = false;
            this.GrupoDatosActividad.Text = "Datos Actividad";
            // 
            // LnkQuitarTurno
            // 
            this.LnkQuitarTurno.AutoSize = true;
            this.LnkQuitarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LnkQuitarTurno.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LnkQuitarTurno.Location = new System.Drawing.Point(787, 81);
            this.LnkQuitarTurno.Name = "LnkQuitarTurno";
            this.LnkQuitarTurno.Size = new System.Drawing.Size(40, 15);
            this.LnkQuitarTurno.TabIndex = 21;
            this.LnkQuitarTurno.TabStop = true;
            this.LnkQuitarTurno.Text = "Quitar";
            this.LnkQuitarTurno.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkQuitarTurno_LinkClicked);
            // 
            // LBTurnos
            // 
            this.LBTurnos.FormattingEnabled = true;
            this.LBTurnos.ItemHeight = 20;
            this.LBTurnos.Location = new System.Drawing.Point(665, 40);
            this.LBTurnos.Name = "LBTurnos";
            this.LBTurnos.Size = new System.Drawing.Size(116, 64);
            this.LBTurnos.TabIndex = 20;
            // 
            // LnkAgregarTurno
            // 
            this.LnkAgregarTurno.AutoSize = true;
            this.LnkAgregarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LnkAgregarTurno.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LnkAgregarTurno.Location = new System.Drawing.Point(612, 78);
            this.LnkAgregarTurno.Name = "LnkAgregarTurno";
            this.LnkAgregarTurno.Size = new System.Drawing.Size(50, 15);
            this.LnkAgregarTurno.TabIndex = 19;
            this.LnkAgregarTurno.TabStop = true;
            this.LnkAgregarTurno.Text = "Agregar";
            this.LnkAgregarTurno.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkAgregarTurno_LinkClicked);
            // 
            // LblTurno
            // 
            this.LblTurno.AutoSize = true;
            this.LblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblTurno.Location = new System.Drawing.Point(445, 78);
            this.LblTurno.Name = "LblTurno";
            this.LblTurno.Size = new System.Drawing.Size(39, 15);
            this.LblTurno.TabIndex = 11;
            this.LblTurno.Text = "Turno";
            // 
            // CbTurno
            // 
            this.CbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTurno.Enabled = false;
            this.CbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.CbTurno.FormattingEnabled = true;
            this.CbTurno.Location = new System.Drawing.Point(490, 75);
            this.CbTurno.Name = "CbTurno";
            this.CbTurno.Size = new System.Drawing.Size(116, 24);
            this.CbTurno.TabIndex = 10;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TxtPrecio.Location = new System.Drawing.Point(345, 40);
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
            // TxtNombreActividad
            // 
            this.TxtNombreActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TxtNombreActividad.Location = new System.Drawing.Point(77, 40);
            this.TxtNombreActividad.Name = "TxtNombreActividad";
            this.TxtNombreActividad.Size = new System.Drawing.Size(200, 21);
            this.TxtNombreActividad.TabIndex = 5;
            // 
            // LblEstadoBuscado
            // 
            this.LblEstadoBuscado.AutoSize = true;
            this.LblEstadoBuscado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblEstadoBuscado.Location = new System.Drawing.Point(318, 78);
            this.LblEstadoBuscado.Name = "LblEstadoBuscado";
            this.LblEstadoBuscado.Size = new System.Drawing.Size(48, 15);
            this.LblEstadoBuscado.TabIndex = 3;
            this.LblEstadoBuscado.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
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
            this.LblPrecio.Location = new System.Drawing.Point(294, 43);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(45, 15);
            this.LblPrecio.TabIndex = 0;
            this.LblPrecio.Text = "Precio:";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BtnNuevo.ForeColor = System.Drawing.Color.LightGray;
            this.BtnNuevo.Location = new System.Drawing.Point(417, 426);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(90, 30);
            this.BtnNuevo.TabIndex = 12;
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
            this.BtnModificar.Location = new System.Drawing.Point(124, 426);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(90, 30);
            this.BtnModificar.TabIndex = 9;
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
            this.BtnRegistrar.Location = new System.Drawing.Point(28, 426);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(90, 30);
            this.BtnRegistrar.TabIndex = 8;
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
            this.BtnEliminar.Location = new System.Drawing.Point(331, 426);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(80, 30);
            this.BtnEliminar.TabIndex = 11;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // GbListadoActividades
            // 
            this.GbListadoActividades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbListadoActividades.Controls.Add(this.TxtNombre);
            this.GbListadoActividades.Controls.Add(this.BtnLimpiar);
            this.GbListadoActividades.Controls.Add(this.BtnBuscar);
            this.GbListadoActividades.Controls.Add(this.CbEstado);
            this.GbListadoActividades.Controls.Add(this.LblEstado);
            this.GbListadoActividades.Controls.Add(this.DgvActividades);
            this.GbListadoActividades.Controls.Add(this.LblNombre);
            this.GbListadoActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.GbListadoActividades.ForeColor = System.Drawing.Color.Gainsboro;
            this.GbListadoActividades.Location = new System.Drawing.Point(28, 42);
            this.GbListadoActividades.Name = "GbListadoActividades";
            this.GbListadoActividades.Size = new System.Drawing.Size(833, 235);
            this.GbListadoActividades.TabIndex = 21;
            this.GbListadoActividades.TabStop = false;
            this.GbListadoActividades.Text = "Listado de Actividades";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(25, 54);
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
            this.BtnLimpiar.Location = new System.Drawing.Point(732, 23);
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
            this.BtnBuscar.Location = new System.Drawing.Point(732, 54);
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
            this.CbEstado.Location = new System.Drawing.Point(179, 54);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(89, 24);
            this.CbEstado.TabIndex = 2;
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.LblEstado.ForeColor = System.Drawing.Color.DarkGray;
            this.LblEstado.Location = new System.Drawing.Point(176, 29);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(61, 22);
            this.LblEstado.TabIndex = 9;
            this.LblEstado.Text = "Estado";
            // 
            // DgvActividades
            // 
            this.DgvActividades.AllowUserToAddRows = false;
            this.DgvActividades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvActividades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvActividades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvActividades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.DgvActividades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvActividades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvActividades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvActividades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroActividad,
            this.Nombre,
            this.Descripcion,
            this.Precio,
            this.Dias,
            this.Estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvActividades.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvActividades.EnableHeadersVisualStyles = false;
            this.DgvActividades.Location = new System.Drawing.Point(25, 96);
            this.DgvActividades.MultiSelect = false;
            this.DgvActividades.Name = "DgvActividades";
            this.DgvActividades.ReadOnly = true;
            this.DgvActividades.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvActividades.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvActividades.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 16F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DgvActividades.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvActividades.Size = new System.Drawing.Size(782, 112);
            this.DgvActividades.TabIndex = 8;
            this.DgvActividades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvActividades_CellClick);
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
            this.BtnSalir.Location = new System.Drawing.Point(781, 423);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(80, 30);
            this.BtnSalir.TabIndex = 13;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblDia
            // 
            this.LblDia.AutoSize = true;
            this.LblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblDia.Location = new System.Drawing.Point(458, 43);
            this.LblDia.Name = "LblDia";
            this.LblDia.Size = new System.Drawing.Size(26, 15);
            this.LblDia.TabIndex = 23;
            this.LblDia.Text = "Dia";
            // 
            // CbDia
            // 
            this.CbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.CbDia.FormattingEnabled = true;
            this.CbDia.Location = new System.Drawing.Point(490, 40);
            this.CbDia.Name = "CbDia";
            this.CbDia.Size = new System.Drawing.Size(116, 24);
            this.CbDia.TabIndex = 22;
            this.CbDia.SelectionChangeCommitted += new System.EventHandler(this.CbDia_SelectionChangeCommitted);
            // 
            // NroActividad
            // 
            this.NroActividad.HeaderText = "Nro Actividad";
            this.NroActividad.Name = "NroActividad";
            this.NroActividad.ReadOnly = true;
            this.NroActividad.Visible = false;
            this.NroActividad.Width = 112;
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
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 80;
            // 
            // Dias
            // 
            this.Dias.HeaderText = "Dias";
            this.Dias.Name = "Dias";
            this.Dias.ReadOnly = true;
            this.Dias.Width = 65;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 84;
            // 
            // ConsultaActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 494);
            this.Controls.Add(this.PanelFormHijo);
            this.Name = "ConsultaActividades";
            this.Text = "ConsultaActividades";
            this.Load += new System.EventHandler(this.ConsultaActividades_Load);
            this.PanelFormHijo.ResumeLayout(false);
            this.GrupoDatosActividad.ResumeLayout(false);
            this.GrupoDatosActividad.PerformLayout();
            this.GbListadoActividades.ResumeLayout(false);
            this.GbListadoActividades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvActividades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFormHijo;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.GroupBox GbListadoActividades;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.DataGridView DgvActividades;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.GroupBox GrupoDatosActividad;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtNombreActividad;
        private System.Windows.Forms.Label LblEstadoBuscado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnDarBaja;
        private System.Windows.Forms.Button BtnDarAlta;
        private System.Windows.Forms.Label LblTurno;
        private System.Windows.Forms.ComboBox CbTurno;
        private System.Windows.Forms.LinkLabel LnkQuitarTurno;
        private System.Windows.Forms.ListBox LBTurnos;
        private System.Windows.Forms.LinkLabel LnkAgregarTurno;
        private System.Windows.Forms.Label LblDia;
        private System.Windows.Forms.ComboBox CbDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}