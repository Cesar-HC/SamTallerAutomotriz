namespace Presentacion
{
    partial class FormVehiculo
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
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.tbAño = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEstadoVehiculo = new System.Windows.Forms.ComboBox();
            this.Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clientes
            // 
            this.Clientes.Controls.Add(this.dgvVehiculos);
            this.Clientes.Location = new System.Drawing.Point(12, 12);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(466, 425);
            this.Clientes.TabIndex = 42;
            this.Clientes.TabStop = false;
            this.Clientes.Text = "Vehículos: ";
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(6, 19);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.Size = new System.Drawing.Size(454, 396);
            this.dgvVehiculos.TabIndex = 35;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Location = new System.Drawing.Point(490, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 80);
            this.groupBox2.TabIndex = 41;
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
            this.groupBox1.Controls.Add(this.cboEstadoVehiculo);
            this.groupBox1.Controls.Add(this.cboTipoVehiculo);
            this.groupBox1.Controls.Add(this.cboMarca);
            this.groupBox1.Controls.Add(this.cboCliente);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbColor);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.tbPlaca);
            this.groupBox1.Controls.Add(this.tbAño);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(490, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 339);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Vehículos";
            // 
            // cboTipoVehiculo
            // 
            this.cboTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoVehiculo.FormattingEnabled = true;
            this.cboTipoVehiculo.Location = new System.Drawing.Point(108, 145);
            this.cboTipoVehiculo.Name = "cboTipoVehiculo";
            this.cboTipoVehiculo.Size = new System.Drawing.Size(127, 21);
            this.cboTipoVehiculo.TabIndex = 57;
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(108, 172);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(127, 21);
            this.cboMarca.TabIndex = 56;
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(108, 197);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(127, 21);
            this.cboCliente.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Cliente:";
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(108, 70);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(127, 20);
            this.tbColor.TabIndex = 51;
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
            // tbPlaca
            // 
            this.tbPlaca.Location = new System.Drawing.Point(108, 93);
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(127, 20);
            this.tbPlaca.TabIndex = 45;
            // 
            // tbAño
            // 
            this.tbAño.Location = new System.Drawing.Point(108, 44);
            this.tbAño.Name = "tbAño";
            this.tbAño.Size = new System.Drawing.Size(127, 20);
            this.tbAño.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Tipo de Vehículo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Placa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Color: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Año: ";
            // 
            // cboEstadoVehiculo
            // 
            this.cboEstadoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoVehiculo.FormattingEnabled = true;
            this.cboEstadoVehiculo.Items.AddRange(new object[] {
            "Buen Estado",
            "Fallas Menores",
            "Fallas Graves",
            "Accidentado"});
            this.cboEstadoVehiculo.Location = new System.Drawing.Point(108, 118);
            this.cboEstadoVehiculo.Name = "cboEstadoVehiculo";
            this.cboEstadoVehiculo.Size = new System.Drawing.Size(127, 21);
            this.cboEstadoVehiculo.TabIndex = 58;
            // 
            // FormVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.Clientes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormVehiculo";
            this.Text = "Vehiculos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Clientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Clientes;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTipoVehiculo;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.TextBox tbAño;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEstadoVehiculo;
    }
}