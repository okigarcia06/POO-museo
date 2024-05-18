namespace Implementacion_DSI_Grupo10
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titulo = new System.Windows.Forms.Label();
            this.titulo1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_visitantes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_sede = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_tipoVisita = new System.Windows.Forms.ComboBox();
            this.btn_buscarExpo = new System.Windows.Forms.Button();
            this.dg_exposiciones = new System.Windows.Forms.DataGridView();
            this.id_expo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreExpo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_escuela = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_expo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fecha_hora = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_duracion = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dg_cantidadVisitantes = new System.Windows.Forms.DataGridView();
            this.Sede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visitantes_maximos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_validarVisitante = new System.Windows.Forms.Button();
            this.btn_buscarGuias = new System.Windows.Forms.Button();
            this.list_guias = new System.Windows.Forms.ListBox();
            this.dg_guiasDisponibles = new System.Windows.Forms.DataGridView();
            this.id_emple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_sede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btnAgregarReserva = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_visitantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_exposiciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cantidadVisitantes)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_guiasDisponibles)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titulo.BackColor = System.Drawing.Color.SaddleBrown;
            this.titulo.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titulo.Location = new System.Drawing.Point(-3, 61);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(1218, 19);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Registrar Nueva Reserva  ";
            // 
            // titulo1
            // 
            this.titulo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titulo1.BackColor = System.Drawing.Color.SaddleBrown;
            this.titulo1.Font = new System.Drawing.Font("Engravers MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titulo1.Location = new System.Drawing.Point(-14, 9);
            this.titulo1.Name = "titulo1";
            this.titulo1.Size = new System.Drawing.Size(1229, 38);
            this.titulo1.TabIndex = 1;
            this.titulo1.Text = "Museo Pictórico";
            this.titulo1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titulo1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.SaddleBrown;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escuela: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.SaddleBrown;
            this.label2.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad Visitantes: ";
            // 
            // num_visitantes
            // 
            this.num_visitantes.Location = new System.Drawing.Point(355, 39);
            this.num_visitantes.Name = "num_visitantes";
            this.num_visitantes.Size = new System.Drawing.Size(143, 20);
            this.num_visitantes.TabIndex = 7;
            this.num_visitantes.ValueChanged += new System.EventHandler(this.num_visitantes_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.SaddleBrown;
            this.label3.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sede: ";
            // 
            // cmb_sede
            // 
            this.cmb_sede.FormattingEnabled = true;
            this.cmb_sede.Items.AddRange(new object[] {
            "Central",
            "Sur",
            "Norte"});
            this.cmb_sede.Location = new System.Drawing.Point(355, 62);
            this.cmb_sede.Name = "cmb_sede";
            this.cmb_sede.Size = new System.Drawing.Size(143, 21);
            this.cmb_sede.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.SaddleBrown;
            this.label4.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo Visita: ";
            // 
            // cmb_tipoVisita
            // 
            this.cmb_tipoVisita.AutoCompleteCustomSource.AddRange(new string[] {
            "Completa",
            "Por Exposición"});
            this.cmb_tipoVisita.FormattingEnabled = true;
            this.cmb_tipoVisita.Items.AddRange(new object[] {
            "Completa",
            "Por Exposición"});
            this.cmb_tipoVisita.Location = new System.Drawing.Point(355, 85);
            this.cmb_tipoVisita.Name = "cmb_tipoVisita";
            this.cmb_tipoVisita.Size = new System.Drawing.Size(143, 21);
            this.cmb_tipoVisita.TabIndex = 11;
            this.cmb_tipoVisita.SelectedIndexChanged += new System.EventHandler(this.cmb_tipoVisita_SelectedIndexChanged);
            // 
            // btn_buscarExpo
            // 
            this.btn_buscarExpo.Location = new System.Drawing.Point(6, 19);
            this.btn_buscarExpo.Name = "btn_buscarExpo";
            this.btn_buscarExpo.Size = new System.Drawing.Size(159, 23);
            this.btn_buscarExpo.TabIndex = 12;
            this.btn_buscarExpo.Text = "Buscar Exposiciones";
            this.btn_buscarExpo.UseVisualStyleBackColor = true;
            this.btn_buscarExpo.Click += new System.EventHandler(this.btn_buscarExpo_Click);
            this.btn_buscarExpo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_buscarExpo_MouseClick);
            // 
            // dg_exposiciones
            // 
            this.dg_exposiciones.BackgroundColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_exposiciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_exposiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_exposiciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_expo,
            this.nombreExpo,
            this.fechaHoraInicio,
            this.fechaHoraFin,
            this.horaApertura,
            this.horaCierre});
            this.dg_exposiciones.Location = new System.Drawing.Point(6, 48);
            this.dg_exposiciones.Name = "dg_exposiciones";
            this.dg_exposiciones.Size = new System.Drawing.Size(601, 155);
            this.dg_exposiciones.TabIndex = 13;
            this.dg_exposiciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_exposiciones_CellContentClick);
            // 
            // id_expo
            // 
            this.id_expo.HeaderText = "ID";
            this.id_expo.Name = "id_expo";
            // 
            // nombreExpo
            // 
            this.nombreExpo.HeaderText = "Nombre";
            this.nombreExpo.Name = "nombreExpo";
            // 
            // fechaHoraInicio
            // 
            this.fechaHoraInicio.HeaderText = "Fecha Hora (inicio)";
            this.fechaHoraInicio.Name = "fechaHoraInicio";
            // 
            // fechaHoraFin
            // 
            this.fechaHoraFin.HeaderText = "Fecha Hora (fin)";
            this.fechaHoraFin.Name = "fechaHoraFin";
            // 
            // horaApertura
            // 
            this.horaApertura.HeaderText = "Apertura";
            this.horaApertura.Name = "horaApertura";
            // 
            // horaCierre
            // 
            this.horaCierre.HeaderText = "Cierre";
            this.horaCierre.Name = "horaCierre";
            // 
            // cmb_escuela
            // 
            this.cmb_escuela.FormattingEnabled = true;
            this.cmb_escuela.Items.AddRange(new object[] {
            "Monjas Azules",
            "San José",
            "Monserrat",
            "Jovenes Argentinos"});
            this.cmb_escuela.Location = new System.Drawing.Point(355, 16);
            this.cmb_escuela.Name = "cmb_escuela";
            this.cmb_escuela.Size = new System.Drawing.Size(143, 21);
            this.cmb_escuela.TabIndex = 15;
            this.cmb_escuela.SelectedIndexChanged += new System.EventHandler(this.cmb_escuela_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_escuela);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_tipoVisita);
            this.groupBox1.Controls.Add(this.num_visitantes);
            this.groupBox1.Controls.Add(this.cmb_sede);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(2, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 128);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.SaddleBrown;
            this.label5.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Exposición: ";
            // 
            // cmb_expo
            // 
            this.cmb_expo.FormattingEnabled = true;
            this.cmb_expo.Items.AddRange(new object[] {
            "Memorias Perdidas",
            "Siglo XIX",
            "Siglo XX",
            "Renacimiento",
            "Miló",
            "Da Vinci"});
            this.cmb_expo.Location = new System.Drawing.Point(336, 29);
            this.cmb_expo.Name = "cmb_expo";
            this.cmb_expo.Size = new System.Drawing.Size(202, 21);
            this.cmb_expo.TabIndex = 15;
            this.cmb_expo.SelectedIndexChanged += new System.EventHandler(this.cmb_expo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.SaddleBrown;
            this.label6.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha y Hora: ";
            // 
            // fecha_hora
            // 
            this.fecha_hora.Location = new System.Drawing.Point(336, 53);
            this.fecha_hora.Name = "fecha_hora";
            this.fecha_hora.Size = new System.Drawing.Size(202, 20);
            this.fecha_hora.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.fecha_hora);
            this.groupBox3.Controls.Add(this.cmb_expo);
            this.groupBox3.Location = new System.Drawing.Point(2, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(577, 100);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // btn_duracion
            // 
            this.btn_duracion.Location = new System.Drawing.Point(357, 710);
            this.btn_duracion.Name = "btn_duracion";
            this.btn_duracion.Size = new System.Drawing.Size(159, 23);
            this.btn_duracion.TabIndex = 19;
            this.btn_duracion.Text = "Calcular Duración";
            this.btn_duracion.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_buscarExpo);
            this.groupBox2.Controls.Add(this.dg_exposiciones);
            this.groupBox2.Location = new System.Drawing.Point(597, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 217);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dg_cantidadVisitantes
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_cantidadVisitantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_cantidadVisitantes.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dg_cantidadVisitantes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_cantidadVisitantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_cantidadVisitantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sede,
            this.Visitantes_maximos});
            this.dg_cantidadVisitantes.Location = new System.Drawing.Point(6, 58);
            this.dg_cantidadVisitantes.Name = "dg_cantidadVisitantes";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_cantidadVisitantes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_cantidadVisitantes.Size = new System.Drawing.Size(244, 141);
            this.dg_cantidadVisitantes.TabIndex = 14;
            this.dg_cantidadVisitantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_cantidadVisitantes_CellContentClick);
            // 
            // Sede
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sede.DefaultCellStyle = dataGridViewCellStyle3;
            this.Sede.HeaderText = "Sede";
            this.Sede.Name = "Sede";
            this.Sede.ReadOnly = true;
            // 
            // Visitantes_maximos
            // 
            this.Visitantes_maximos.HeaderText = "Visitantes Máximos";
            this.Visitantes_maximos.Name = "Visitantes_maximos";
            this.Visitantes_maximos.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox4.Controls.Add(this.btn_validarVisitante);
            this.groupBox4.Controls.Add(this.dg_cantidadVisitantes);
            this.groupBox4.Font = new System.Drawing.Font("Engravers MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(2, 342);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(295, 234);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cantidad Visitante Por Sede";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btn_validarVisitante
            // 
            this.btn_validarVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validarVisitante.ForeColor = System.Drawing.Color.Black;
            this.btn_validarVisitante.Location = new System.Drawing.Point(73, 29);
            this.btn_validarVisitante.Name = "btn_validarVisitante";
            this.btn_validarVisitante.Size = new System.Drawing.Size(133, 23);
            this.btn_validarVisitante.TabIndex = 22;
            this.btn_validarVisitante.Text = "Validar Visitantes";
            this.btn_validarVisitante.UseVisualStyleBackColor = true;
            this.btn_validarVisitante.Click += new System.EventHandler(this.btn_validarVisitante_Click);
            // 
            // btn_buscarGuias
            // 
            this.btn_buscarGuias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarGuias.ForeColor = System.Drawing.Color.Black;
            this.btn_buscarGuias.Location = new System.Drawing.Point(6, 19);
            this.btn_buscarGuias.Name = "btn_buscarGuias";
            this.btn_buscarGuias.Size = new System.Drawing.Size(159, 23);
            this.btn_buscarGuias.TabIndex = 21;
            this.btn_buscarGuias.Text = "Buscar Guias";
            this.btn_buscarGuias.UseVisualStyleBackColor = true;
            this.btn_buscarGuias.Click += new System.EventHandler(this.btn_buscarGuias_Click);
            // 
            // list_guias
            // 
            this.list_guias.FormattingEnabled = true;
            this.list_guias.Items.AddRange(new object[] {
            "Martinez Miguel",
            "Paraje Juan",
            "Romeau Tomas",
            "Lescano Octavio"});
            this.list_guias.Location = new System.Drawing.Point(965, 445);
            this.list_guias.Name = "list_guias";
            this.list_guias.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.list_guias.Size = new System.Drawing.Size(165, 69);
            this.list_guias.TabIndex = 24;
            this.list_guias.SelectedIndexChanged += new System.EventHandler(this.list_guias_SelectedIndexChanged);
            // 
            // dg_guiasDisponibles
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dg_guiasDisponibles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_guiasDisponibles.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dg_guiasDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_guiasDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_emple,
            this.apellido,
            this.nombre,
            this.cuit,
            this.dni,
            this.domicilio,
            this.telefono,
            this.id_cargo,
            this.id_sede});
            this.dg_guiasDisponibles.Location = new System.Drawing.Point(6, 50);
            this.dg_guiasDisponibles.Name = "dg_guiasDisponibles";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dg_guiasDisponibles.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dg_guiasDisponibles.Size = new System.Drawing.Size(601, 178);
            this.dg_guiasDisponibles.TabIndex = 21;
            // 
            // id_emple
            // 
            this.id_emple.HeaderText = "ID";
            this.id_emple.Name = "id_emple";
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // cuit
            // 
            this.cuit.HeaderText = "CUIT";
            this.cuit.Name = "cuit";
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            // 
            // domicilio
            // 
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.Name = "domicilio";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            // 
            // id_cargo
            // 
            this.id_cargo.HeaderText = "id_cargo";
            this.id_cargo.Name = "id_cargo";
            // 
            // id_sede
            // 
            this.id_sede.HeaderText = "Id_sede";
            this.id_sede.Name = "id_sede";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.dg_guiasDisponibles);
            this.groupBox6.Controls.Add(this.btn_buscarGuias);
            this.groupBox6.Font = new System.Drawing.Font("Engravers MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(326, 343);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(614, 234);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(555, 618);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(94, 24);
            this.btn_registrar.TabIndex = 26;
            this.btn_registrar.Text = "Registrar Reserva";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btnAgregarReserva
            // 
            this.btnAgregarReserva.Location = new System.Drawing.Point(1034, 618);
            this.btnAgregarReserva.Name = "btnAgregarReserva";
            this.btnAgregarReserva.Size = new System.Drawing.Size(133, 23);
            this.btnAgregarReserva.TabIndex = 27;
            this.btnAgregarReserva.Text = "Agregar reserva";
            this.btnAgregarReserva.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(49, 618);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1211, 694);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarReserva);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.list_guias);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_duracion);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.titulo1);
            this.Controls.Add(this.titulo);
            this.Name = "Form1";
            this.Text = "Registrar Reserva Visita";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_visitantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_exposiciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_cantidadVisitantes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_guiasDisponibles)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label titulo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_visitantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_sede;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_tipoVisita;
        private System.Windows.Forms.Button btn_buscarExpo;
        private System.Windows.Forms.DataGridView dg_exposiciones;
        private System.Windows.Forms.ComboBox cmb_escuela;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_expo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker fecha_hora;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_duracion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dg_cantidadVisitantes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_validarVisitante;
        private System.Windows.Forms.Button btn_buscarGuias;
        private System.Windows.Forms.ListBox list_guias;
        private System.Windows.Forms.DataGridView dg_guiasDisponibles;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sede;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visitantes_maximos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_expo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreExpo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_emple;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sede;
        private System.Windows.Forms.Button btnAgregarReserva;
        private System.Windows.Forms.Button btnCancelar;
    }
}

