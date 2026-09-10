namespace Presentacion
{
    partial class FormRegistrarAdministrador
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
            this.Clientes = new System.Windows.Forms.GroupBox();
            this.dgvAdministrador = new System.Windows.Forms.DataGridView();
            this.btnVolverLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboEstadoAdministrador = new System.Windows.Forms.ComboBox();
            this.tbContraseñaConfirmacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministrador)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clientes
            // 
            this.Clientes.Controls.Add(this.dgvAdministrador);
            this.Clientes.Location = new System.Drawing.Point(12, 13);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(466, 425);
            this.Clientes.TabIndex = 48;
            this.Clientes.TabStop = false;
            this.Clientes.Text = "Administrador:";
            // 
            // dgvAdministrador
            // 
            this.dgvAdministrador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdministrador.Location = new System.Drawing.Point(6, 19);
            this.dgvAdministrador.Name = "dgvAdministrador";
            this.dgvAdministrador.Size = new System.Drawing.Size(454, 396);
            this.dgvAdministrador.TabIndex = 35;
            // 
            // btnVolverLogin
            // 
            this.btnVolverLogin.Location = new System.Drawing.Point(490, 398);
            this.btnVolverLogin.Name = "btnVolverLogin";
            this.btnVolverLogin.Size = new System.Drawing.Size(258, 30);
            this.btnVolverLogin.TabIndex = 64;
            this.btnVolverLogin.Text = "Regresar a Log In";
            this.btnVolverLogin.UseVisualStyleBackColor = true;
            this.btnVolverLogin.Click += new System.EventHandler(this.btnVolverLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboEstadoAdministrador);
            this.groupBox1.Controls.Add(this.tbContraseñaConfirmacion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbContraseña);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbTelefono);
            this.groupBox1.Controls.Add(this.tbApellido);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.tbDni);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(490, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 379);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Adminstrador:";
            // 
            // cboEstadoAdministrador
            // 
            this.cboEstadoAdministrador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoAdministrador.FormattingEnabled = true;
            this.cboEstadoAdministrador.Items.AddRange(new object[] {
            "Libre",
            "Observacion",
            "Restringido"});
            this.cboEstadoAdministrador.Location = new System.Drawing.Point(108, 172);
            this.cboEstadoAdministrador.Name = "cboEstadoAdministrador";
            this.cboEstadoAdministrador.Size = new System.Drawing.Size(127, 21);
            this.cboEstadoAdministrador.TabIndex = 64;
            // 
            // tbContraseñaConfirmacion
            // 
            this.tbContraseñaConfirmacion.Location = new System.Drawing.Point(28, 270);
            this.tbContraseñaConfirmacion.Name = "tbContraseñaConfirmacion";
            this.tbContraseñaConfirmacion.PasswordChar = '*';
            this.tbContraseñaConfirmacion.Size = new System.Drawing.Size(207, 20);
            this.tbContraseñaConfirmacion.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Escriba nuevamente la contraseña:";
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(28, 223);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.PasswordChar = '*';
            this.tbContraseña.Size = new System.Drawing.Size(207, 20);
            this.tbContraseña.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Constraseña:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Estado:";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(108, 146);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(127, 20);
            this.tbTelefono.TabIndex = 57;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(108, 70);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(127, 20);
            this.tbApellido.TabIndex = 51;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(133, 337);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(102, 23);
            this.btnRegistrar.TabIndex = 31;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(108, 119);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(127, 20);
            this.tbEmail.TabIndex = 46;
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(108, 93);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(127, 20);
            this.tbDni.TabIndex = 45;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(108, 44);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(127, 20);
            this.tbNombre.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Telefono: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Dni:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Apellido: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nombre:";
            // 
            // FormRegistrarAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.btnVolverLogin);
            this.Controls.Add(this.Clientes);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRegistrarAdministrador";
            this.Text = "Registrar Cuenta Administrador";
            this.Clientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministrador)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Clientes;
        private System.Windows.Forms.DataGridView dgvAdministrador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbContraseñaConfirmacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnVolverLogin;
        private System.Windows.Forms.ComboBox cboEstadoAdministrador;
    }
}