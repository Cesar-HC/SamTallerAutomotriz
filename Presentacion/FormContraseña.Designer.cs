namespace Presentacion
{
    partial class FormContraseña
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCrearCuenta);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnRecuperar);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(339, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 560);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(446, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "Modulo de Recuperación de contraseña";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearCuenta.FlatAppearance.BorderSize = 0;
            this.btnCrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.Location = new System.Drawing.Point(124, 394);
            this.btnCrearCuenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(297, 54);
            this.btnCrearCuenta.TabIndex = 5;
            this.btnCrearCuenta.Text = "No tiene una cuenta de administrador? creela haciendo clic aqui.";
            this.btnCrearCuenta.UseVisualStyleBackColor = false;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(105, 218);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '*';
            this.tbEmail.Size = new System.Drawing.Size(294, 26);
            this.tbEmail.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(105, 145);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(294, 26);
            this.tbUsuario.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(104, 280);
            this.btnRecuperar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(207, 35);
            this.btnRecuperar.TabIndex = 2;
            this.btnRecuperar.Text = "Recuperar contraseña";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 505);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Volver a Log In";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormContraseña";
            this.Text = "Recuperar Contraseña";
            this.Load += new System.EventHandler(this.FormContraseña_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.Button button2;
    }
}