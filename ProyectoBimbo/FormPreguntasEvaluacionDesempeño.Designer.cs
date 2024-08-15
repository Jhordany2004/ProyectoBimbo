
namespace ProyectoBimbo
{
    partial class FormPreguntasEvaluacionDesempeño
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gboxPregunta = new System.Windows.Forms.GroupBox();
            this.cbOp4 = new System.Windows.Forms.CheckBox();
            this.cbOp3 = new System.Windows.Forms.CheckBox();
            this.cbOp2 = new System.Windows.Forms.CheckBox();
            this.cbOp1 = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOpcion2 = new System.Windows.Forms.TextBox();
            this.txtOpcion3 = new System.Windows.Forms.TextBox();
            this.txtOpcion1 = new System.Windows.Forms.TextBox();
            this.txtOpcion4 = new System.Windows.Forms.TextBox();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.txtidEvaDesempeño = new System.Windows.Forms.TextBox();
            this.txtidPregEvaDesempeño = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvPregEvaDesempeño = new System.Windows.Forms.DataGridView();
            this.gboxPregunta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregEvaDesempeño)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 566);
            this.label1.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.Location = new System.Drawing.Point(286, 454);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(81, 27);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(12, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(421, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "PREGUNTAS - EVALUACION DESEMPEÑO";
            // 
            // gboxPregunta
            // 
            this.gboxPregunta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gboxPregunta.Controls.Add(this.cbOp4);
            this.gboxPregunta.Controls.Add(this.cbOp3);
            this.gboxPregunta.Controls.Add(this.cbOp2);
            this.gboxPregunta.Controls.Add(this.cbOp1);
            this.gboxPregunta.Controls.Add(this.label6);
            this.gboxPregunta.Controls.Add(this.label4);
            this.gboxPregunta.Controls.Add(this.label5);
            this.gboxPregunta.Controls.Add(this.label3);
            this.gboxPregunta.Controls.Add(this.label8);
            this.gboxPregunta.Controls.Add(this.label2);
            this.gboxPregunta.Controls.Add(this.txtOpcion2);
            this.gboxPregunta.Controls.Add(this.txtOpcion3);
            this.gboxPregunta.Controls.Add(this.txtOpcion1);
            this.gboxPregunta.Controls.Add(this.txtOpcion4);
            this.gboxPregunta.Controls.Add(this.txtPregunta);
            this.gboxPregunta.Controls.Add(this.txtidEvaDesempeño);
            this.gboxPregunta.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxPregunta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gboxPregunta.Location = new System.Drawing.Point(32, 146);
            this.gboxPregunta.Name = "gboxPregunta";
            this.gboxPregunta.Size = new System.Drawing.Size(393, 279);
            this.gboxPregunta.TabIndex = 24;
            this.gboxPregunta.TabStop = false;
            this.gboxPregunta.Text = "Creacion de Preguntas";
            // 
            // cbOp4
            // 
            this.cbOp4.AutoSize = true;
            this.cbOp4.Location = new System.Drawing.Point(320, 249);
            this.cbOp4.Name = "cbOp4";
            this.cbOp4.Size = new System.Drawing.Size(15, 14);
            this.cbOp4.TabIndex = 10;
            this.cbOp4.UseVisualStyleBackColor = true;
            // 
            // cbOp3
            // 
            this.cbOp3.AutoSize = true;
            this.cbOp3.Location = new System.Drawing.Point(320, 207);
            this.cbOp3.Name = "cbOp3";
            this.cbOp3.Size = new System.Drawing.Size(15, 14);
            this.cbOp3.TabIndex = 10;
            this.cbOp3.UseVisualStyleBackColor = true;
            // 
            // cbOp2
            // 
            this.cbOp2.AutoSize = true;
            this.cbOp2.Location = new System.Drawing.Point(320, 171);
            this.cbOp2.Name = "cbOp2";
            this.cbOp2.Size = new System.Drawing.Size(15, 14);
            this.cbOp2.TabIndex = 10;
            this.cbOp2.UseVisualStyleBackColor = true;
            // 
            // cbOp1
            // 
            this.cbOp1.AutoSize = true;
            this.cbOp1.Location = new System.Drawing.Point(320, 133);
            this.cbOp1.Name = "cbOp1";
            this.cbOp1.Size = new System.Drawing.Size(15, 14);
            this.cbOp1.TabIndex = 10;
            this.cbOp1.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Location = new System.Drawing.Point(254, 26);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 33);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificar.Location = new System.Drawing.Point(143, 24);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 33);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Location = new System.Drawing.Point(31, 24);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 33);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(89, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Opcion 4:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(89, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Opcion 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(89, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Opcion 3:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(28, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pregunta: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(28, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "idEvaluacion desempeño:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(89, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opcion 1:";
            // 
            // txtOpcion2
            // 
            this.txtOpcion2.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpcion2.Location = new System.Drawing.Point(172, 167);
            this.txtOpcion2.Name = "txtOpcion2";
            this.txtOpcion2.Size = new System.Drawing.Size(130, 21);
            this.txtOpcion2.TabIndex = 0;
            // 
            // txtOpcion3
            // 
            this.txtOpcion3.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpcion3.Location = new System.Drawing.Point(172, 203);
            this.txtOpcion3.Name = "txtOpcion3";
            this.txtOpcion3.Size = new System.Drawing.Size(130, 21);
            this.txtOpcion3.TabIndex = 0;
            // 
            // txtOpcion1
            // 
            this.txtOpcion1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpcion1.Location = new System.Drawing.Point(172, 129);
            this.txtOpcion1.Name = "txtOpcion1";
            this.txtOpcion1.Size = new System.Drawing.Size(130, 21);
            this.txtOpcion1.TabIndex = 0;
            // 
            // txtOpcion4
            // 
            this.txtOpcion4.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpcion4.Location = new System.Drawing.Point(172, 241);
            this.txtOpcion4.Name = "txtOpcion4";
            this.txtOpcion4.Size = new System.Drawing.Size(130, 21);
            this.txtOpcion4.TabIndex = 0;
            // 
            // txtPregunta
            // 
            this.txtPregunta.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPregunta.Location = new System.Drawing.Point(105, 90);
            this.txtPregunta.Multiline = true;
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(256, 23);
            this.txtPregunta.TabIndex = 0;
            // 
            // txtidEvaDesempeño
            // 
            this.txtidEvaDesempeño.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidEvaDesempeño.Location = new System.Drawing.Point(203, 35);
            this.txtidEvaDesempeño.Name = "txtidEvaDesempeño";
            this.txtidEvaDesempeño.Size = new System.Drawing.Size(156, 21);
            this.txtidEvaDesempeño.TabIndex = 0;
            // 
            // txtidPregEvaDesempeño
            // 
            this.txtidPregEvaDesempeño.Location = new System.Drawing.Point(91, 461);
            this.txtidPregEvaDesempeño.Name = "txtidPregEvaDesempeño";
            this.txtidPregEvaDesempeño.Size = new System.Drawing.Size(174, 20);
            this.txtidPregEvaDesempeño.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(32, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 14);
            this.label9.TabIndex = 23;
            this.label9.Text = "idPreguntasEvaluacion desempeño:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 487);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 67);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccion";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(321, 90);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(112, 40);
            this.btnActualizar.TabIndex = 30;
            this.btnActualizar.Text = "Actualizar Tabla";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(175, 94);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 33);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(63, 94);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 33);
            this.btnNuevo.TabIndex = 28;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvPregEvaDesempeño
            // 
            this.dgvPregEvaDesempeño.AllowUserToAddRows = false;
            this.dgvPregEvaDesempeño.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPregEvaDesempeño.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPregEvaDesempeño.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvPregEvaDesempeño.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregEvaDesempeño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPregEvaDesempeño.Location = new System.Drawing.Point(455, 12);
            this.dgvPregEvaDesempeño.MultiSelect = false;
            this.dgvPregEvaDesempeño.Name = "dgvPregEvaDesempeño";
            this.dgvPregEvaDesempeño.ReadOnly = true;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPregEvaDesempeño.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvPregEvaDesempeño.Size = new System.Drawing.Size(611, 542);
            this.dgvPregEvaDesempeño.TabIndex = 56;
            // 
            // FormPreguntasEvaluacionDesempeño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1078, 566);
            this.Controls.Add(this.dgvPregEvaDesempeño);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gboxPregunta);
            this.Controls.Add(this.txtidPregEvaDesempeño);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPreguntasEvaluacionDesempeño";
            this.Text = "FormPreguntasEvaluacionDesempeño";
            this.gboxPregunta.ResumeLayout(false);
            this.gboxPregunta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregEvaDesempeño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gboxPregunta;
        private System.Windows.Forms.CheckBox cbOp4;
        private System.Windows.Forms.CheckBox cbOp3;
        private System.Windows.Forms.CheckBox cbOp2;
        private System.Windows.Forms.CheckBox cbOp1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOpcion2;
        private System.Windows.Forms.TextBox txtOpcion3;
        private System.Windows.Forms.TextBox txtOpcion1;
        private System.Windows.Forms.TextBox txtOpcion4;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.TextBox txtidEvaDesempeño;
        private System.Windows.Forms.TextBox txtidPregEvaDesempeño;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvPregEvaDesempeño;
    }
}