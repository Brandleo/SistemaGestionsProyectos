namespace SistemaGestionsProyectos.Forms
{
    partial class UsuariosForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscarCorreo = new System.Windows.Forms.TextBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.botonCrear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuProyectos = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtBuscarDUI = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtgEmpleados = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.menuProyectos.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 70);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIOS";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightYellow;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtBuscarCorreo);
            this.tabPage2.Controls.Add(this.dgvUsuarios);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(883, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "VER USUARIOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Buscar por correo:";
            // 
            // txtBuscarCorreo
            // 
            this.txtBuscarCorreo.BackColor = System.Drawing.Color.White;
            this.txtBuscarCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarCorreo.Location = new System.Drawing.Point(27, 59);
            this.txtBuscarCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarCorreo.Multiline = true;
            this.txtBuscarCorreo.Name = "txtBuscarCorreo";
            this.txtBuscarCorreo.Size = new System.Drawing.Size(280, 34);
            this.txtBuscarCorreo.TabIndex = 22;
            this.txtBuscarCorreo.TextChanged += new System.EventHandler(this.txtBuscarCorreo_TextChanged);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(27, 115);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(800, 283);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleName = "CREAR PROYECTOS";
            this.tabPage1.BackColor = System.Drawing.Color.LightYellow;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.txtDui);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.comboEstado);
            this.tabPage1.Controls.Add(this.comboRol);
            this.tabPage1.Controls.Add(this.botonCrear);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtContrasena);
            this.tabPage1.Controls.Add(this.txtCorreo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(883, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CREAR USUARIOS";
            // 
            // txtDui
            // 
            this.txtDui.BackColor = System.Drawing.Color.White;
            this.txtDui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDui.Location = new System.Drawing.Point(11, 293);
            this.txtDui.Margin = new System.Windows.Forms.Padding(2);
            this.txtDui.Multiline = true;
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(280, 34);
            this.txtDui.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 267);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 15);
            this.label8.TabIndex = 31;
            this.label8.Text = "Dui de empleado";
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(353, 177);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(279, 25);
            this.comboEstado.TabIndex = 30;
            // 
            // comboRol
            // 
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Location = new System.Drawing.Point(11, 177);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(279, 25);
            this.comboRol.TabIndex = 29;
            // 
            // botonCrear
            // 
            this.botonCrear.BackColor = System.Drawing.Color.DodgerBlue;
            this.botonCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCrear.FlatAppearance.BorderSize = 0;
            this.botonCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCrear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonCrear.Location = new System.Drawing.Point(11, 373);
            this.botonCrear.Margin = new System.Windows.Forms.Padding(2);
            this.botonCrear.Name = "botonCrear";
            this.botonCrear.Size = new System.Drawing.Size(172, 43);
            this.botonCrear.TabIndex = 28;
            this.botonCrear.Text = "CREAR USUARIO";
            this.botonCrear.UseVisualStyleBackColor = false;
            this.botonCrear.Click += new System.EventHandler(this.botonCrear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(351, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Rol del usuario";
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.White;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasena.Location = new System.Drawing.Point(353, 46);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(2);
            this.txtContrasena.Multiline = true;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(280, 34);
            this.txtContrasena.TabIndex = 23;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Location = new System.Drawing.Point(10, 46);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(280, 34);
            this.txtCorreo.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Correo";
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
            this.menuProyectos.Location = new System.Drawing.Point(0, 74);
            this.menuProyectos.Margin = new System.Windows.Forms.Padding(2);
            this.menuProyectos.Multiline = true;
            this.menuProyectos.Name = "menuProyectos";
            this.menuProyectos.SelectedIndex = 0;
            this.menuProyectos.Size = new System.Drawing.Size(891, 510);
            this.menuProyectos.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.menuProyectos.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightYellow;
            this.tabPage3.Controls.Add(this.txtBuscarDUI);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.dtgEmpleados);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(883, 480);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "VER EMPLEADOS";
            // 
            // txtBuscarDUI
            // 
            this.txtBuscarDUI.BackColor = System.Drawing.Color.White;
            this.txtBuscarDUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarDUI.Location = new System.Drawing.Point(408, 22);
            this.txtBuscarDUI.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarDUI.Multiline = true;
            this.txtBuscarDUI.Name = "txtBuscarDUI";
            this.txtBuscarDUI.Size = new System.Drawing.Size(222, 40);
            this.txtBuscarDUI.TabIndex = 42;
            this.txtBuscarDUI.TextChanged += new System.EventHandler(this.txtBuscarDUI_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(265, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 15);
            this.label9.TabIndex = 41;
            this.label9.Text = "Busqueda por DUI";
            // 
            // dtgEmpleados
            // 
            this.dtgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpleados.Location = new System.Drawing.Point(23, 82);
            this.dtgEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.dtgEmpleados.Name = "dtgEmpleados";
            this.dtgEmpleados.RowHeadersWidth = 51;
            this.dtgEmpleados.RowTemplate.Height = 24;
            this.dtgEmpleados.Size = new System.Drawing.Size(607, 324);
            this.dtgEmpleados.TabIndex = 40;
            this.dtgEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmpleados_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "Empleados";
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(915, 595);
            this.Controls.Add(this.menuProyectos);
            this.Controls.Add(this.panel1);
            this.Name = "UsuariosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuariosForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuProyectos.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscarCorreo;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button botonCrear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl menuProyectos;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.ComboBox comboRol;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtBuscarDUI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtgEmpleados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.Label label8;
    }
}