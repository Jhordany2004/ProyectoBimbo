
namespace ProyectoBimbo
{
    partial class FormEstandarCompetencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificador = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbxDescripciónEstandar = new System.Windows.Forms.GroupBox();
            this.cbxNivelRequerido = new System.Windows.Forms.ComboBox();
            this.cbxArea = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GrupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEstandarCompetencia = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdEstandar = new System.Windows.Forms.TextBox();
            this.gbxDescripciónEstandar.SuspendLayout();
            this.GrupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstandarCompetencia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 479);
            this.label1.TabIndex = 3;
            // 
            // btnModificador
            // 
            this.btnModificador.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificador.Location = new System.Drawing.Point(260, 52);
            this.btnModificador.Name = "btnModificador";
            this.btnModificador.Size = new System.Drawing.Size(97, 37);
            this.btnModificador.TabIndex = 48;
            this.btnModificador.Text = "Modificar";
            this.btnModificador.UseVisualStyleBackColor = true;
            this.btnModificador.Click += new System.EventHandler(this.btnModificador_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNuevo.Location = new System.Drawing.Point(88, 52);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(97, 37);
            this.btnNuevo.TabIndex = 47;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbxDescripciónEstandar
            // 
            this.gbxDescripciónEstandar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxDescripciónEstandar.Controls.Add(this.cbxNivelRequerido);
            this.gbxDescripciónEstandar.Controls.Add(this.cbxArea);
            this.gbxDescripciónEstandar.Controls.Add(this.label5);
            this.gbxDescripciónEstandar.Controls.Add(this.label3);
            this.gbxDescripciónEstandar.Controls.Add(this.txtDescripcion);
            this.gbxDescripciónEstandar.Controls.Add(this.label2);
            this.gbxDescripciónEstandar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDescripciónEstandar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxDescripciónEstandar.Location = new System.Drawing.Point(44, 105);
            this.gbxDescripciónEstandar.Name = "gbxDescripciónEstandar";
            this.gbxDescripciónEstandar.Size = new System.Drawing.Size(343, 268);
            this.gbxDescripciónEstandar.TabIndex = 46;
            this.gbxDescripciónEstandar.TabStop = false;
            this.gbxDescripciónEstandar.Text = "Descripcion de estandar";
            this.gbxDescripciónEstandar.Enter += new System.EventHandler(this.gbxDescripciónEstandar_Enter);
            // 
            // cbxNivelRequerido
            // 
            this.cbxNivelRequerido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNivelRequerido.FormattingEnabled = true;
            this.cbxNivelRequerido.Items.AddRange(new object[] {
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbxNivelRequerido.Location = new System.Drawing.Point(45, 153);
            this.cbxNivelRequerido.Name = "cbxNivelRequerido";
            this.cbxNivelRequerido.Size = new System.Drawing.Size(206, 24);
            this.cbxNivelRequerido.TabIndex = 33;
            // 
            // cbxArea
            // 
            this.cbxArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxArea.FormattingEnabled = true;
            this.cbxArea.Items.AddRange(new object[] {
            "Area 01",
            "Area 02",
            "Area 03",
            "Area 04",
            "Area 05",
            "Area 06"});
            this.cbxArea.Location = new System.Drawing.Point(45, 213);
            this.cbxArea.Name = "cbxArea";
            this.cbxArea.Size = new System.Drawing.Size(206, 24);
            this.cbxArea.TabIndex = 32;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.Location = new System.Drawing.Point(240, 18);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 49);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditar.Location = new System.Drawing.Point(127, 18);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(107, 49);
            this.btnEditar.TabIndex = 30;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardar.Location = new System.Drawing.Point(9, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 48);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(42, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Area:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(42, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nivel Requerido:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(45, 61);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(261, 57);
            this.txtDescripcion.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(42, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(423, 29);
            this.label4.TabIndex = 45;
            this.label4.Text = "CRUD - Estándar de Competencia";
            // 
            // GrupBox1
            // 
            this.GrupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GrupBox1.Controls.Add(this.btnGuardar);
            this.GrupBox1.Controls.Add(this.btnEditar);
            this.GrupBox1.Controls.Add(this.btnEliminar);
            this.GrupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupBox1.Location = new System.Drawing.Point(35, 379);
            this.GrupBox1.Name = "GrupBox1";
            this.GrupBox1.Size = new System.Drawing.Size(364, 88);
            this.GrupBox1.TabIndex = 49;
            this.GrupBox1.TabStop = false;
            this.GrupBox1.Text = "Eleccion";
            // 
            // dgvEstandarCompetencia
            // 
            this.dgvEstandarCompetencia.AllowUserToAddRows = false;
            this.dgvEstandarCompetencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstandarCompetencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstandarCompetencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstandarCompetencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvEstandarCompetencia.Location = new System.Drawing.Point(451, 99);
            this.dgvEstandarCompetencia.MultiSelect = false;
            this.dgvEstandarCompetencia.Name = "dgvEstandarCompetencia";
            this.dgvEstandarCompetencia.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEstandarCompetencia.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEstandarCompetencia.Size = new System.Drawing.Size(576, 368);
            this.dgvEstandarCompetencia.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(445, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(591, 84);
            this.label6.TabIndex = 56;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Location = new System.Drawing.Point(853, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 28);
            this.btnBuscar.TabIndex = 59;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(567, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 58;
            this.label7.Text = "ID Estándar:";
            // 
            // txtIdEstandar
            // 
            this.txtIdEstandar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEstandar.Location = new System.Drawing.Point(659, 28);
            this.txtIdEstandar.Multiline = true;
            this.txtIdEstandar.Name = "txtIdEstandar";
            this.txtIdEstandar.Size = new System.Drawing.Size(168, 24);
            this.txtIdEstandar.TabIndex = 57;
            // 
            // FormEstandarCompetencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1036, 479);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdEstandar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvEstandarCompetencia);
            this.Controls.Add(this.GrupBox1);
            this.Controls.Add(this.btnModificador);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbxDescripciónEstandar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEstandarCompetencia";
            this.Text = "FormEstandarCompetencia";
            this.Load += new System.EventHandler(this.FormEstandarCompetencia_Load);
            this.gbxDescripciónEstandar.ResumeLayout(false);
            this.gbxDescripciónEstandar.PerformLayout();
            this.GrupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstandarCompetencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificador;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbxDescripciónEstandar;
        private System.Windows.Forms.ComboBox cbxNivelRequerido;
        private System.Windows.Forms.ComboBox cbxArea;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GrupBox1;
        private System.Windows.Forms.DataGridView dgvEstandarCompetencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdEstandar;
    }
}