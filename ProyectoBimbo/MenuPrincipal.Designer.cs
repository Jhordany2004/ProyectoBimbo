﻿
namespace ProyectoBimbo
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDetalleEvaDesempeño = new System.Windows.Forms.Button();
            this.btnPlanDesarrolloFormativo = new System.Windows.Forms.Button();
            this.btnDocNecesidadesFormativas = new System.Windows.Forms.Button();
            this.btnPreguntasEncuesta = new System.Windows.Forms.Button();
            this.btnEvaluacionProgreso = new System.Windows.Forms.Button();
            this.btnEvaluacionDesempeño = new System.Windows.Forms.Button();
            this.btnEstandaresCompetencia = new System.Windows.Forms.Button();
            this.btnCronograma = new System.Windows.Forms.Button();
            this.btnEncuestas = new System.Windows.Forms.Button();
            this.btnAreas = new System.Windows.Forms.Button();
            this.btnActividades = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.imagenLogo = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.barraTitulo.Controls.Add(this.btnRestaurar);
            this.barraTitulo.Controls.Add(this.label1);
            this.barraTitulo.Controls.Add(this.btnMinimizar);
            this.barraTitulo.Controls.Add(this.btnMaximizar);
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1327, 38);
            this.barraTitulo.TabIndex = 1;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown_1);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1268, 7);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(534, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sistema de Empleados - Grupo Bimbo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1237, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1268, 7);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1299, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.AutoScroll = true;
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVertical.Controls.Add(this.button1);
            this.MenuVertical.Controls.Add(this.btnDetalleEvaDesempeño);
            this.MenuVertical.Controls.Add(this.btnPlanDesarrolloFormativo);
            this.MenuVertical.Controls.Add(this.btnDocNecesidadesFormativas);
            this.MenuVertical.Controls.Add(this.btnPreguntasEncuesta);
            this.MenuVertical.Controls.Add(this.btnEvaluacionProgreso);
            this.MenuVertical.Controls.Add(this.btnEvaluacionDesempeño);
            this.MenuVertical.Controls.Add(this.btnEstandaresCompetencia);
            this.MenuVertical.Controls.Add(this.btnCronograma);
            this.MenuVertical.Controls.Add(this.btnEncuestas);
            this.MenuVertical.Controls.Add(this.btnAreas);
            this.MenuVertical.Controls.Add(this.btnActividades);
            this.MenuVertical.Controls.Add(this.btnEmpleados);
            this.MenuVertical.Controls.Add(this.imagenLogo);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 38);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(220, 604);
            this.MenuVertical.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 631);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Resol. Progreso";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDetalleEvaDesempeño
            // 
            this.btnDetalleEvaDesempeño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDetalleEvaDesempeño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalleEvaDesempeño.FlatAppearance.BorderSize = 0;
            this.btnDetalleEvaDesempeño.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnDetalleEvaDesempeño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalleEvaDesempeño.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleEvaDesempeño.ForeColor = System.Drawing.Color.White;
            this.btnDetalleEvaDesempeño.Image = ((System.Drawing.Image)(resources.GetObject("btnDetalleEvaDesempeño.Image")));
            this.btnDetalleEvaDesempeño.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalleEvaDesempeño.Location = new System.Drawing.Point(12, 444);
            this.btnDetalleEvaDesempeño.Name = "btnDetalleEvaDesempeño";
            this.btnDetalleEvaDesempeño.Size = new System.Drawing.Size(266, 32);
            this.btnDetalleEvaDesempeño.TabIndex = 12;
            this.btnDetalleEvaDesempeño.Text = "Detalle Eva.Desempeño";
            this.btnDetalleEvaDesempeño.UseVisualStyleBackColor = false;
            this.btnDetalleEvaDesempeño.Click += new System.EventHandler(this.btnDetalleEvaDesempeño_Click);
            // 
            // btnPlanDesarrolloFormativo
            // 
            this.btnPlanDesarrolloFormativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPlanDesarrolloFormativo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlanDesarrolloFormativo.FlatAppearance.BorderSize = 0;
            this.btnPlanDesarrolloFormativo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnPlanDesarrolloFormativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanDesarrolloFormativo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanDesarrolloFormativo.ForeColor = System.Drawing.Color.White;
            this.btnPlanDesarrolloFormativo.Image = ((System.Drawing.Image)(resources.GetObject("btnPlanDesarrolloFormativo.Image")));
            this.btnPlanDesarrolloFormativo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanDesarrolloFormativo.Location = new System.Drawing.Point(12, 558);
            this.btnPlanDesarrolloFormativo.Name = "btnPlanDesarrolloFormativo";
            this.btnPlanDesarrolloFormativo.Size = new System.Drawing.Size(202, 32);
            this.btnPlanDesarrolloFormativo.TabIndex = 11;
            this.btnPlanDesarrolloFormativo.Text = "Plan Des. Forma.";
            this.btnPlanDesarrolloFormativo.UseVisualStyleBackColor = false;
            this.btnPlanDesarrolloFormativo.Click += new System.EventHandler(this.btnPlanDesarrolloFormativo_Click);
            // 
            // btnDocNecesidadesFormativas
            // 
            this.btnDocNecesidadesFormativas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDocNecesidadesFormativas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDocNecesidadesFormativas.FlatAppearance.BorderSize = 0;
            this.btnDocNecesidadesFormativas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnDocNecesidadesFormativas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocNecesidadesFormativas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocNecesidadesFormativas.ForeColor = System.Drawing.Color.White;
            this.btnDocNecesidadesFormativas.Image = ((System.Drawing.Image)(resources.GetObject("btnDocNecesidadesFormativas.Image")));
            this.btnDocNecesidadesFormativas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocNecesidadesFormativas.Location = new System.Drawing.Point(12, 520);
            this.btnDocNecesidadesFormativas.Name = "btnDocNecesidadesFormativas";
            this.btnDocNecesidadesFormativas.Size = new System.Drawing.Size(202, 32);
            this.btnDocNecesidadesFormativas.TabIndex = 10;
            this.btnDocNecesidadesFormativas.Text = "Nec. Formativas";
            this.btnDocNecesidadesFormativas.UseVisualStyleBackColor = false;
            this.btnDocNecesidadesFormativas.Click += new System.EventHandler(this.btnDocNecesidadesFormativas_Click);
            // 
            // btnPreguntasEncuesta
            // 
            this.btnPreguntasEncuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPreguntasEncuesta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreguntasEncuesta.FlatAppearance.BorderSize = 0;
            this.btnPreguntasEncuesta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnPreguntasEncuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreguntasEncuesta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreguntasEncuesta.ForeColor = System.Drawing.Color.White;
            this.btnPreguntasEncuesta.Image = ((System.Drawing.Image)(resources.GetObject("btnPreguntasEncuesta.Image")));
            this.btnPreguntasEncuesta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreguntasEncuesta.Location = new System.Drawing.Point(12, 482);
            this.btnPreguntasEncuesta.Name = "btnPreguntasEncuesta";
            this.btnPreguntasEncuesta.Size = new System.Drawing.Size(240, 32);
            this.btnPreguntasEncuesta.TabIndex = 9;
            this.btnPreguntasEncuesta.Text = "Preguntas Encuesta";
            this.btnPreguntasEncuesta.UseVisualStyleBackColor = false;
            this.btnPreguntasEncuesta.Click += new System.EventHandler(this.btnPreguntasEncuesta_Click_1);
            // 
            // btnEvaluacionProgreso
            // 
            this.btnEvaluacionProgreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEvaluacionProgreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvaluacionProgreso.FlatAppearance.BorderSize = 0;
            this.btnEvaluacionProgreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEvaluacionProgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvaluacionProgreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluacionProgreso.ForeColor = System.Drawing.Color.White;
            this.btnEvaluacionProgreso.Image = ((System.Drawing.Image)(resources.GetObject("btnEvaluacionProgreso.Image")));
            this.btnEvaluacionProgreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvaluacionProgreso.Location = new System.Drawing.Point(12, 596);
            this.btnEvaluacionProgreso.Name = "btnEvaluacionProgreso";
            this.btnEvaluacionProgreso.Size = new System.Drawing.Size(202, 32);
            this.btnEvaluacionProgreso.TabIndex = 8;
            this.btnEvaluacionProgreso.Text = "Eva. Progreso";
            this.btnEvaluacionProgreso.UseVisualStyleBackColor = false;
            this.btnEvaluacionProgreso.Click += new System.EventHandler(this.btnEvaluacionProgreso_Click);
            // 
            // btnEvaluacionDesempeño
            // 
            this.btnEvaluacionDesempeño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEvaluacionDesempeño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvaluacionDesempeño.FlatAppearance.BorderSize = 0;
            this.btnEvaluacionDesempeño.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEvaluacionDesempeño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvaluacionDesempeño.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluacionDesempeño.ForeColor = System.Drawing.Color.White;
            this.btnEvaluacionDesempeño.Image = ((System.Drawing.Image)(resources.GetObject("btnEvaluacionDesempeño.Image")));
            this.btnEvaluacionDesempeño.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvaluacionDesempeño.Location = new System.Drawing.Point(12, 406);
            this.btnEvaluacionDesempeño.Name = "btnEvaluacionDesempeño";
            this.btnEvaluacionDesempeño.Size = new System.Drawing.Size(202, 32);
            this.btnEvaluacionDesempeño.TabIndex = 7;
            this.btnEvaluacionDesempeño.Text = "Eva. Desempeño";
            this.btnEvaluacionDesempeño.UseVisualStyleBackColor = false;
            this.btnEvaluacionDesempeño.Click += new System.EventHandler(this.btnEvaluacionDesempeño_Click);
            // 
            // btnEstandaresCompetencia
            // 
            this.btnEstandaresCompetencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEstandaresCompetencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstandaresCompetencia.FlatAppearance.BorderSize = 0;
            this.btnEstandaresCompetencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEstandaresCompetencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstandaresCompetencia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstandaresCompetencia.ForeColor = System.Drawing.Color.White;
            this.btnEstandaresCompetencia.Image = ((System.Drawing.Image)(resources.GetObject("btnEstandaresCompetencia.Image")));
            this.btnEstandaresCompetencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstandaresCompetencia.Location = new System.Drawing.Point(12, 358);
            this.btnEstandaresCompetencia.Name = "btnEstandaresCompetencia";
            this.btnEstandaresCompetencia.Size = new System.Drawing.Size(202, 32);
            this.btnEstandaresCompetencia.TabIndex = 6;
            this.btnEstandaresCompetencia.Text = "Est. competencia";
            this.btnEstandaresCompetencia.UseVisualStyleBackColor = false;
            this.btnEstandaresCompetencia.Click += new System.EventHandler(this.btnEstandaresCompetencia_Click);
            // 
            // btnCronograma
            // 
            this.btnCronograma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCronograma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCronograma.FlatAppearance.BorderSize = 0;
            this.btnCronograma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCronograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCronograma.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCronograma.ForeColor = System.Drawing.Color.White;
            this.btnCronograma.Image = ((System.Drawing.Image)(resources.GetObject("btnCronograma.Image")));
            this.btnCronograma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCronograma.Location = new System.Drawing.Point(12, 311);
            this.btnCronograma.Name = "btnCronograma";
            this.btnCronograma.Size = new System.Drawing.Size(202, 32);
            this.btnCronograma.TabIndex = 5;
            this.btnCronograma.Text = "Cronograma";
            this.btnCronograma.UseVisualStyleBackColor = false;
            this.btnCronograma.Click += new System.EventHandler(this.btnCronograma_Click);
            // 
            // btnEncuestas
            // 
            this.btnEncuestas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEncuestas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncuestas.FlatAppearance.BorderSize = 0;
            this.btnEncuestas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEncuestas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncuestas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncuestas.ForeColor = System.Drawing.Color.White;
            this.btnEncuestas.Image = ((System.Drawing.Image)(resources.GetObject("btnEncuestas.Image")));
            this.btnEncuestas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncuestas.Location = new System.Drawing.Point(12, 263);
            this.btnEncuestas.Name = "btnEncuestas";
            this.btnEncuestas.Size = new System.Drawing.Size(202, 32);
            this.btnEncuestas.TabIndex = 4;
            this.btnEncuestas.Text = "Encuestas";
            this.btnEncuestas.UseVisualStyleBackColor = false;
            this.btnEncuestas.Click += new System.EventHandler(this.btnEncuestas_Click);
            // 
            // btnAreas
            // 
            this.btnAreas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAreas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAreas.FlatAppearance.BorderSize = 0;
            this.btnAreas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAreas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreas.ForeColor = System.Drawing.Color.White;
            this.btnAreas.Image = ((System.Drawing.Image)(resources.GetObject("btnAreas.Image")));
            this.btnAreas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAreas.Location = new System.Drawing.Point(12, 215);
            this.btnAreas.Name = "btnAreas";
            this.btnAreas.Size = new System.Drawing.Size(202, 32);
            this.btnAreas.TabIndex = 3;
            this.btnAreas.Text = "Areas";
            this.btnAreas.UseVisualStyleBackColor = false;
            this.btnAreas.Click += new System.EventHandler(this.btnAreas_Click_1);
            // 
            // btnActividades
            // 
            this.btnActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnActividades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActividades.FlatAppearance.BorderSize = 0;
            this.btnActividades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActividades.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActividades.ForeColor = System.Drawing.Color.White;
            this.btnActividades.Image = ((System.Drawing.Image)(resources.GetObject("btnActividades.Image")));
            this.btnActividades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActividades.Location = new System.Drawing.Point(12, 167);
            this.btnActividades.Name = "btnActividades";
            this.btnActividades.Size = new System.Drawing.Size(202, 32);
            this.btnActividades.TabIndex = 2;
            this.btnActividades.Text = "Actividades";
            this.btnActividades.UseVisualStyleBackColor = false;
            this.btnActividades.Click += new System.EventHandler(this.btnActividades_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(12, 120);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(202, 32);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // imagenLogo
            // 
            this.imagenLogo.Image = ((System.Drawing.Image)(resources.GetObject("imagenLogo.Image")));
            this.imagenLogo.Location = new System.Drawing.Point(0, 0);
            this.imagenLogo.Name = "imagenLogo";
            this.imagenLogo.Size = new System.Drawing.Size(220, 105);
            this.imagenLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenLogo.TabIndex = 0;
            this.imagenLogo.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 38);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1107, 604);
            this.panelContenedor.TabIndex = 7;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1327, 642);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagenLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDetalleEvaDesempeño;
        private System.Windows.Forms.Button btnPlanDesarrolloFormativo;
        private System.Windows.Forms.Button btnDocNecesidadesFormativas;
        private System.Windows.Forms.Button btnPreguntasEncuesta;
        private System.Windows.Forms.Button btnEvaluacionProgreso;
        private System.Windows.Forms.Button btnEvaluacionDesempeño;
        private System.Windows.Forms.Button btnEstandaresCompetencia;
        private System.Windows.Forms.Button btnCronograma;
        private System.Windows.Forms.Button btnEncuestas;
        private System.Windows.Forms.Button btnAreas;
        private System.Windows.Forms.Button btnActividades;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.PictureBox imagenLogo;
        private System.Windows.Forms.Panel panelContenedor;
    }
}

