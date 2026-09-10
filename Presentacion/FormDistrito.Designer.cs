namespace Presentacion
{
    partial class FormDistrito
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
            this.tbDistrito = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgDistrito = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProvincias = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDistrito)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(23, 125);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tbDistrito
            // 
            this.tbDistrito.Location = new System.Drawing.Point(95, 57);
            this.tbDistrito.Name = "tbDistrito";
            this.tbDistrito.Size = new System.Drawing.Size(172, 20);
            this.tbDistrito.TabIndex = 9;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(23, 96);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgDistrito
            // 
            this.dgDistrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDistrito.Location = new System.Drawing.Point(383, 12);
            this.dgDistrito.Name = "dgDistrito";
            this.dgDistrito.Size = new System.Drawing.Size(307, 396);
            this.dgDistrito.TabIndex = 7;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(47, 60);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(42, 13);
            this.label.TabIndex = 6;
            this.label.Text = "Distrito:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Provincia: ";
            // 
            // cbProvincias
            // 
            this.cbProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvincias.FormattingEnabled = true;
            this.cbProvincias.Location = new System.Drawing.Point(95, 30);
            this.cbProvincias.Name = "cbProvincias";
            this.cbProvincias.Size = new System.Drawing.Size(172, 21);
            this.cbProvincias.TabIndex = 12;
            // 
            // FormDistrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 422);
            this.Controls.Add(this.cbProvincias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.tbDistrito);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgDistrito);
            this.Controls.Add(this.label);
            this.Name = "FormDistrito";
            this.Text = "Distritos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgDistrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox tbDistrito;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgDistrito;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProvincias;
    }
}