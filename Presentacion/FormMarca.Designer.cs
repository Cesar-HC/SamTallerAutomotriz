namespace Presentacion
{
    partial class FormMarca
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
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgMarca = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(68, 140);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(172, 52);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(172, 20);
            this.tbMarca.TabIndex = 21;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(68, 111);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 20;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgMarca
            // 
            this.dgMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMarca.Location = new System.Drawing.Point(428, 27);
            this.dgMarca.Name = "dgMarca";
            this.dgMarca.Size = new System.Drawing.Size(307, 396);
            this.dgMarca.TabIndex = 19;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(65, 55);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(94, 13);
            this.label.TabIndex = 18;
            this.label.Text = "Nombre de marca:";
            // 
            // FormMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 437);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgMarca);
            this.Controls.Add(this.label);
            this.Name = "FormMarca";
            this.Text = "Marcas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgMarca;
        private System.Windows.Forms.Label label;
    }
}