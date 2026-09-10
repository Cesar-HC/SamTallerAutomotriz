namespace Presentacion
{
    partial class FormTipoVehiculo
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tbTipoVehiculo = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgTipoVehiculo = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTipoVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(18, 125);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tbTipoVehiculo
            // 
            this.tbTipoVehiculo.Location = new System.Drawing.Point(122, 37);
            this.tbTipoVehiculo.Name = "tbTipoVehiculo";
            this.tbTipoVehiculo.Size = new System.Drawing.Size(172, 20);
            this.tbTipoVehiculo.TabIndex = 16;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(18, 96);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgTipoVehiculo
            // 
            this.dgTipoVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTipoVehiculo.Location = new System.Drawing.Point(378, 12);
            this.dgTipoVehiculo.Name = "dgTipoVehiculo";
            this.dgTipoVehiculo.Size = new System.Drawing.Size(307, 396);
            this.dgTipoVehiculo.TabIndex = 14;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(15, 40);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(92, 13);
            this.label.TabIndex = 13;
            this.label.Text = "Tipo de Vehículo:";
            // 
            // FormTipoVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 426);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.tbTipoVehiculo);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgTipoVehiculo);
            this.Controls.Add(this.label);
            this.Name = "FormTipoVehiculo";
            this.Text = "Tipos de Vehiculos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgTipoVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox tbTipoVehiculo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgTipoVehiculo;
        private System.Windows.Forms.Label label;
    }
}