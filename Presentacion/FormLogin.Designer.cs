namespace Presentacion
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRecuperarContraseña = new System.Windows.Forms.Button();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(198, 283);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(112, 35);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 505);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRecuperarContraseña
            // 
            this.btnRecuperarContraseña.BackColor = System.Drawing.Color.Transparent;
            this.btnRecuperarContraseña.FlatAppearance.BorderSize = 0;
            this.btnRecuperarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperarContraseña.Location = new System.Drawing.Point(108, 377);
            this.btnRecuperarContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecuperarContraseña.Name = "btnRecuperarContraseña";
            this.btnRecuperarContraseña.Size = new System.Drawing.Size(288, 35);
            this.btnRecuperarContraseña.TabIndex = 4;
            this.btnRecuperarContraseña.Text = "Olvido su contraseña? Haga clic aqui";
            this.btnRecuperarContraseña.UseVisualStyleBackColor = false;
            this.btnRecuperarContraseña.Click += new System.EventHandler(this.btnRecuperarContraseña_Click);
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearCuenta.FlatAppearance.BorderSize = 0;
            this.btnCrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.Location = new System.Drawing.Point(104, 422);
            this.btnCrearCuenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(297, 54);
            this.btnCrearCuenta.TabIndex = 5;
            this.btnCrearCuenta.Text = "No tiene una cuenta de administrador? creela haciendo clic aqui.";
            this.btnCrearCuenta.UseVisualStyleBackColor = false;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(105, 145);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(294, 26);
            this.tbUsuario.TabIndex = 6;
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(105, 218);
            this.tbContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.PasswordChar = '*';
            this.tbContraseña.Size = new System.Drawing.Size(294, 26);
            this.tbContraseña.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCrearCuenta);
            this.panel1.Controls.Add(this.tbContraseña);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.btnRecuperarContraseña);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(322, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 560);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 54);
            this.label3.TabIndex = 8;
            this.label3.Text = "Login";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenidos";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRecuperarContraseña;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}