namespace Presentacion
{
    partial class FormEspecialidadMecanico
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
            this.dgEspecialidadMecanico = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tbEspecialidadMecanico = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEspecialidadMecanico)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgEspecialidadMecanico
            // 
            this.dgEspecialidadMecanico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEspecialidadMecanico.Location = new System.Drawing.Point(428, 27);
            this.dgEspecialidadMecanico.Name = "dgEspecialidadMecanico";
            this.dgEspecialidadMecanico.Size = new System.Drawing.Size(307, 396);
            this.dgEspecialidadMecanico.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.tbEspecialidadMecanico);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 175);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Especialidad";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(21, 116);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tbEspecialidadMecanico
            // 
            this.tbEspecialidadMecanico.Location = new System.Drawing.Point(149, 32);
            this.tbEspecialidadMecanico.Name = "tbEspecialidadMecanico";
            this.tbEspecialidadMecanico.Size = new System.Drawing.Size(172, 20);
            this.tbEspecialidadMecanico.TabIndex = 34;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(21, 77);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 33;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(18, 35);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(125, 13);
            this.label.TabIndex = 32;
            this.label.Text = "Nombre de Especialidad:";
            // 
            // FormEspecialidadMecanico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgEspecialidadMecanico);
            this.Name = "FormEspecialidadMecanico";
            this.Text = "Especialidades";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgEspecialidadMecanico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgEspecialidadMecanico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox tbEspecialidadMecanico;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label;
    }
}