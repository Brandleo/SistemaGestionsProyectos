namespace SistemaGestionsProyectos.Forms
{
    partial class Pruebas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuProyectos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.botonCrear = new System.Windows.Forms.Button();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDenominacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreClave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscarPornombre = new System.Windows.Forms.TextBox();
            this.dtgProyectos = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnPromotor = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dgtProyectos = new System.Windows.Forms.DataGridView();
            this.txtBuscarProyectoSinProm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuProyectos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProyectos)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtProyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 70);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROYECTOS";
            // 
            // menuProyectos
            // 
            this.menuProyectos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuProyectos.Controls.Add(this.tabPage1);
            this.menuProyectos.Controls.Add(this.tabPage2);
            this.menuProyectos.Controls.Add(this.tabPage3);
            this.menuProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProyectos.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.menuProyectos.Location = new System.Drawing.Point(0, 75);
            this.menuProyectos.Margin = new System.Windows.Forms.Padding(2);
            this.menuProyectos.Multiline = true;
            this.menuProyectos.Name = "menuProyectos";
            this.menuProyectos.SelectedIndex = 0;
            this.menuProyectos.Size = new System.Drawing.Size(864, 562);
            this.menuProyectos.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.menuProyectos.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleName = "CREAR PROYECTOS";
            this.tabPage1.BackColor = System.Drawing.Color.LightYellow;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.botonCrear);
            this.tabPage1.Controls.Add(this.dtpFechaFin);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dtpFechaInicio);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtDenominacion);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtNombreClave);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(856, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CREAR PROYECTOS";
            // 
            // botonCrear
            // 
            this.botonCrear.BackColor = System.Drawing.Color.DodgerBlue;
            this.botonCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCrear.FlatAppearance.BorderSize = 0;
            this.botonCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCrear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonCrear.Location = new System.Drawing.Point(10, 249);
            this.botonCrear.Margin = new System.Windows.Forms.Padding(2);
            this.botonCrear.Name = "botonCrear";
            this.botonCrear.Size = new System.Drawing.Size(172, 43);
            this.botonCrear.TabIndex = 28;
            this.botonCrear.Text = "CREAR PROYECTO";
            this.botonCrear.UseVisualStyleBackColor = false;
            this.botonCrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(353, 167);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(281, 23);
            this.dtpFechaFin.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(351, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Fecha Finalización";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(10, 167);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(281, 23);
            this.dtpFechaInicio.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Fecha Inicio";
            // 
            // txtDenominacion
            // 
            this.txtDenominacion.BackColor = System.Drawing.Color.White;
            this.txtDenominacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDenominacion.Location = new System.Drawing.Point(353, 46);
            this.txtDenominacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDenominacion.Multiline = true;
            this.txtDenominacion.Name = "txtDenominacion";
            this.txtDenominacion.Size = new System.Drawing.Size(280, 34);
            this.txtDenominacion.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Denominación comercial";
            // 
            // txtNombreClave
            // 
            this.txtNombreClave.BackColor = System.Drawing.Color.White;
            this.txtNombreClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreClave.Location = new System.Drawing.Point(10, 46);
            this.txtNombreClave.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreClave.Multiline = true;
            this.txtNombreClave.Name = "txtNombreClave";
            this.txtNombreClave.Size = new System.Drawing.Size(280, 34);
            this.txtNombreClave.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre en clave del proyecto";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightYellow;
            this.tabPage2.Controls.Add(this.btnActualizar);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtBuscarPornombre);
            this.tabPage2.Controls.Add(this.dtgProyectos);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(856, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "VER PROYECTOS";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.Location = new System.Drawing.Point(655, 50);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(172, 43);
            this.btnActualizar.TabIndex = 29;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Buscar por nombre:";
            // 
            // txtBuscarPornombre
            // 
            this.txtBuscarPornombre.BackColor = System.Drawing.Color.White;
            this.txtBuscarPornombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarPornombre.Location = new System.Drawing.Point(27, 59);
            this.txtBuscarPornombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarPornombre.Multiline = true;
            this.txtBuscarPornombre.Name = "txtBuscarPornombre";
            this.txtBuscarPornombre.Size = new System.Drawing.Size(280, 34);
            this.txtBuscarPornombre.TabIndex = 22;
            this.txtBuscarPornombre.TextChanged += new System.EventHandler(this.txtBuscarPornombre_TextChanged);
            // 
            // dtgProyectos
            // 
            this.dtgProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProyectos.Location = new System.Drawing.Point(27, 115);
            this.dtgProyectos.Margin = new System.Windows.Forms.Padding(2);
            this.dtgProyectos.Name = "dtgProyectos";
            this.dtgProyectos.RowHeadersWidth = 51;
            this.dtgProyectos.RowTemplate.Height = 24;
            this.dtgProyectos.Size = new System.Drawing.Size(800, 283);
            this.dtgProyectos.TabIndex = 0;
            this.dtgProyectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProyectos_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightYellow;
            this.tabPage3.Controls.Add(this.btnPromotor);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.dgtProyectos);
            this.tabPage3.Controls.Add(this.txtBuscarProyectoSinProm);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(856, 532);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ASIGNAR PROMOTOR";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnPromotor
            // 
            this.btnPromotor.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPromotor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPromotor.FlatAppearance.BorderSize = 0;
            this.btnPromotor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromotor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPromotor.Location = new System.Drawing.Point(23, 451);
            this.btnPromotor.Margin = new System.Windows.Forms.Padding(2);
            this.btnPromotor.Name = "btnPromotor";
            this.btnPromotor.Size = new System.Drawing.Size(224, 43);
            this.btnPromotor.TabIndex = 35;
            this.btnPromotor.Text = "Buscar Promotor";
            this.btnPromotor.UseVisualStyleBackColor = false;
            this.btnPromotor.Click += new System.EventHandler(this.btnPromotor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 79);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 15);
            this.label10.TabIndex = 34;
            this.label10.Text = "Proyectos sin promotor";
            // 
            // dgtProyectos
            // 
            this.dgtProyectos.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgtProyectos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgtProyectos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtProyectos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgtProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgtProyectos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgtProyectos.EnableHeadersVisualStyles = false;
            this.dgtProyectos.GridColor = System.Drawing.Color.Orange;
            this.dgtProyectos.Location = new System.Drawing.Point(22, 121);
            this.dgtProyectos.Margin = new System.Windows.Forms.Padding(2);
            this.dgtProyectos.Name = "dgtProyectos";
            this.dgtProyectos.RowHeadersWidth = 51;
            this.dgtProyectos.RowTemplate.Height = 24;
            this.dgtProyectos.Size = new System.Drawing.Size(781, 285);
            this.dgtProyectos.StandardTab = true;
            this.dgtProyectos.TabIndex = 26;
            // 
            // txtBuscarProyectoSinProm
            // 
            this.txtBuscarProyectoSinProm.BackColor = System.Drawing.Color.White;
            this.txtBuscarProyectoSinProm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarProyectoSinProm.Location = new System.Drawing.Point(450, 78);
            this.txtBuscarProyectoSinProm.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarProyectoSinProm.Multiline = true;
            this.txtBuscarProyectoSinProm.Name = "txtBuscarProyectoSinProm";
            this.txtBuscarProyectoSinProm.Size = new System.Drawing.Size(222, 34);
            this.txtBuscarProyectoSinProm.TabIndex = 25;
            this.txtBuscarProyectoSinProm.TextChanged += new System.EventHandler(this.txtBuscarProyectoSinProm_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(423, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Buscar Proyecto por Nombre en Clave";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Pruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(864, 634);
            this.Controls.Add(this.menuProyectos);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Pruebas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pruebas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuProyectos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProyectos)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtProyectos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl menuProyectos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button botonCrear;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDenominacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreClave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgProyectos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscarPornombre;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtBuscarProyectoSinProm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgtProyectos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPromotor;
    }
}