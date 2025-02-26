namespace SistemaGestionsProyectos.Forms
{
    partial class AsignarPromotor
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
            this.txtBuscarDUI = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtgPromotores = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPromotores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarDUI
            // 
            this.txtBuscarDUI.BackColor = System.Drawing.Color.White;
            this.txtBuscarDUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarDUI.Location = new System.Drawing.Point(399, 43);
            this.txtBuscarDUI.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarDUI.Multiline = true;
            this.txtBuscarDUI.Name = "txtBuscarDUI";
            this.txtBuscarDUI.Size = new System.Drawing.Size(222, 40);
            this.txtBuscarDUI.TabIndex = 38;
            this.txtBuscarDUI.TextChanged += new System.EventHandler(this.txtBuscarDUI_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(256, 52);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 15);
            this.label9.TabIndex = 37;
            this.label9.Text = "Busqueda por DUI";
            // 
            // dtgPromotores
            // 
            this.dtgPromotores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPromotores.Location = new System.Drawing.Point(14, 103);
            this.dtgPromotores.Margin = new System.Windows.Forms.Padding(2);
            this.dtgPromotores.Name = "dtgPromotores";
            this.dtgPromotores.RowHeadersWidth = 51;
            this.dtgPromotores.RowTemplate.Height = 24;
            this.dtgPromotores.Size = new System.Drawing.Size(607, 324);
            this.dtgPromotores.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "Promotores disponibles";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAsignar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignar.FlatAppearance.BorderSize = 0;
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAsignar.Location = new System.Drawing.Point(14, 456);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(172, 43);
            this.btnAsignar.TabIndex = 39;
            this.btnAsignar.Text = "ASIGNAR PROMOTOR";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // AsignarPromotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(658, 566);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.txtBuscarDUI);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtgPromotores);
            this.Controls.Add(this.label7);
            this.Name = "AsignarPromotor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsignarPromotor";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPromotores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarDUI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtgPromotores;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAsignar;
    }
}