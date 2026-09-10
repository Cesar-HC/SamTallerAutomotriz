namespace Presentacion
{
    partial class FormProvincia
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
            this.label = new System.Windows.Forms.Label();
            this.dgProvincias = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbProvincia = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProvincias)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(17, 25);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(51, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Provincia";
            // 
            // dgProvincias
            // 
            this.dgProvincias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProvincias.Location = new System.Drawing.Point(374, 12);
            this.dgProvincias.Name = "dgProvincias";
            this.dgProvincias.Size = new System.Drawing.Size(307, 396);
            this.dgProvincias.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(20, 48);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tbProvincia
            // 
            this.tbProvincia.Location = new System.Drawing.Point(74, 22);
            this.tbProvincia.Name = "tbProvincia";
            this.tbProvincia.Size = new System.Drawing.Size(172, 20);
            this.tbProvincia.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(20, 77);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 421);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.tbProvincia);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgProvincias);
            this.Controls.Add(this.label);
            this.Name = "FormProvincia";
            this.Text = "Provincias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgProvincias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView dgProvincias;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox tbProvincia;
        private System.Windows.Forms.Button btnEliminar;
    }
}