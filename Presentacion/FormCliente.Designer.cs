namespace Presentacion
{
    partial class FormCliente
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDistrito = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.cbTipoCliente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.Clientes = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.cboEstadoCliente = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(133, 299);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(102, 23);
            this.btnRegistrar.TabIndex = 31;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboEstadoCliente);
            this.groupBox1.Controls.Add(this.cbDistrito);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbApellidos);
            this.groupBox1.Controls.Add(this.cbTipoCliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbDireccion);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.tbTelefono);
            this.groupBox1.Controls.Add(this.tbDni);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(490, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 339);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Clientes";
            // 
            // cbDistrito
            // 
            this.cbDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDistrito.FormattingEnabled = true;
            this.cbDistrito.Location = new System.Drawing.Point(108, 197);
            this.cbDistrito.Name = "cbDistrito";
            this.cbDistrito.Size = new System.Drawing.Size(127, 21);
            this.cbDistrito.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Distrito";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Estado";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(108, 70);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(127, 20);
            this.tbApellidos.TabIndex = 51;
            // 
            // cbTipoCliente
            // 
            this.cbTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCliente.FormattingEnabled = true;
            this.cbTipoCliente.Items.AddRange(new object[] {
            "Libre,",
            "Observacion,",
            "Restringido,"});
            this.cbTipoCliente.Location = new System.Drawing.Point(108, 224);
            this.cbTipoCliente.Name = "cbTipoCliente";
            this.cbTipoCliente.Size = new System.Drawing.Size(127, 21);
            this.cbTipoCliente.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Tipo de Cliente:";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(108, 171);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(127, 20);
            this.tbDireccion.TabIndex = 47;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(108, 119);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(127, 20);
            this.tbTelefono.TabIndex = 46;
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(108, 93);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(127, 20);
            this.tbDni.TabIndex = 45;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(108, 145);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(127, 20);
            this.tbEmail.TabIndex = 44;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(108, 44);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(127, 20);
            this.tbNombre.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Dni:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Apellidos: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nombre: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Location = new System.Drawing.Point(490, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 80);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(22, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 23);
            this.btnModificar.TabIndex = 35;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(22, 48);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 23);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.Text = "Eliminar ";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Clientes
            // 
            this.Clientes.Controls.Add(this.dgvClientes);
            this.Clientes.Location = new System.Drawing.Point(12, 13);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(466, 425);
            this.Clientes.TabIndex = 39;
            this.Clientes.TabStop = false;
            this.Clientes.Text = "Clientes: ";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(6, 19);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(454, 396);
            this.dgvClientes.TabIndex = 35;
            // 
            // cboEstadoCliente
            // 
            this.cboEstadoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCliente.FormattingEnabled = true;
            this.cboEstadoCliente.Items.AddRange(new object[] {
            "Libre",
            "En Observacion",
            "Restringido"});
            this.cboEstadoCliente.Location = new System.Drawing.Point(108, 251);
            this.cboEstadoCliente.Name = "cboEstadoCliente";
            this.cboEstadoCliente.Size = new System.Drawing.Size(127, 21);
            this.cboEstadoCliente.TabIndex = 56;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.Clientes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCliente";
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.Clientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTipoCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox Clientes;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.ComboBox cbDistrito;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboEstadoCliente;
    }
}