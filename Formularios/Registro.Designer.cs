namespace Implementacion_DSI_Grupo10
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.titulo1 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dg_registros = new System.Windows.Forms.DataGridView();
            this.visitantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechareserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exposicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Escuela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_registros)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo1
            // 
            this.titulo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titulo1.BackColor = System.Drawing.Color.SaddleBrown;
            this.titulo1.Font = new System.Drawing.Font("Engravers MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titulo1.Location = new System.Drawing.Point(-1, 0);
            this.titulo1.Name = "titulo1";
            this.titulo1.Size = new System.Drawing.Size(802, 153);
            this.titulo1.TabIndex = 2;
            this.titulo1.Text = "Museo Pictórico";
            this.titulo1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titulo
            // 
            this.titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titulo.BackColor = System.Drawing.Color.SaddleBrown;
            this.titulo.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titulo.Location = new System.Drawing.Point(3, 77);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(801, 28);
            this.titulo.TabIndex = 3;
            this.titulo.Text = "Registro";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 30);
            this.button1.TabIndex = 27;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dg_registros
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_registros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_registros.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dg_registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_registros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Escuela,
            this.exposicion,
            this.numero,
            this.fechareserva,
            this.estado,
            this.visitantes});
            this.dg_registros.Location = new System.Drawing.Point(15, 30);
            this.dg_registros.Name = "dg_registros";
            this.dg_registros.Size = new System.Drawing.Size(651, 150);
            this.dg_registros.TabIndex = 28;
            // 
            // visitantes
            // 
            this.visitantes.HeaderText = "visitantes";
            this.visitantes.Name = "visitantes";
            // 
            // estado
            // 
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            // 
            // fechareserva
            // 
            this.fechareserva.HeaderText = "fechareserva";
            this.fechareserva.Name = "fechareserva";
            // 
            // numero
            // 
            this.numero.HeaderText = "numero";
            this.numero.Name = "numero";
            // 
            // exposicion
            // 
            this.exposicion.HeaderText = "exposicion";
            this.exposicion.Name = "exposicion";
            // 
            // Escuela
            // 
            this.Escuela.HeaderText = "escuela";
            this.Escuela.Name = "Escuela";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.dg_registros);
            this.groupBox6.Font = new System.Drawing.Font("Engravers MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(7, 108);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(693, 199);
            this.groupBox6.TabIndex = 26;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Registros";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.titulo1);
            this.Name = "Registro";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dg_registros)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titulo1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dg_registros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Escuela;
        private System.Windows.Forms.DataGridViewTextBoxColumn exposicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechareserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitantes;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}