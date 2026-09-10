namespace Presentacion
{
    partial class FormMecanico
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
            this.dgvMecanicos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEstadoMecanico = new System.Windows.Forms.ComboBox();
            this.Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMecanicos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clientes
            // 
            this.Clientes.Controls.Add(this.dgvMecanicos);
            this.Clientes.Location = new System.Drawing.Point(12, 12);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(466, 425);
            this.Clientes.TabIndex = 45;
            this.Clientes.TabStop = false;
            this.Clientes.Text = "Mecánicos: ";
            // 
            // dgvMecanicos
            // 
            this.dgvMecanicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMecanicos.Location = new System.Drawing.Point(6, 19);
            this.dgvMecanicos.Name = "dgvMecanicos";
            this.dgvMecanicos.Size = new System.Drawing.Size(454, 396);
            this.dgvMecanicos.TabIndex = 35;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Location = new System.Drawing.Point(490, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 80);
            this.groupBox2.TabIndex = 44;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboEstadoMecanico);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbTelefono);
            this.groupBox1.Controls.Add(this.cboEspecialidad);
            this.groupBox1.Controls.Add(this.tbApellido);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.tbDni);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(490, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 339);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Mecánicos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 201);
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
            // cboEspecialidad
            // 
            this.cboEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.Location = new System.Drawing.Point(108, 172);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(127, 21);
            this.cboEspecialidad.TabIndex = 56;
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
            this.btnRegistrar.Location = new System.Drawing.Point(133, 299);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Especialidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 148);
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
            // cboEstadoMecanico
            // 
            this.cboEstadoMecanico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoMecanico.FormattingEnabled = true;
            this.cboEstadoMecanico.Items.AddRange(new object[] {
            "Junior",
            "Intermedio",
            "Experto",
            "Maestro"});
            this.cboEstadoMecanico.Location = new System.Drawing.Point(108, 199);
            this.cboEstadoMecanico.Name = "cboEstadoMecanico";
            this.cboEstadoMecanico.Size = new System.Drawing.Size(127, 21);
            this.cboEstadoMecanico.TabIndex = 59;
            // 
            // FormMecanico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.Clientes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMecanico";
            this.Text = "Mecanicos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Clientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMecanicos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Clientes;
        private System.Windows.Forms.DataGridView dgvMecanicos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboEspecialidad;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboEstadoMecanico;
    }
}