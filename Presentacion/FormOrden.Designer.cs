namespace Presentacion
{
    partial class FormOrden
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
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboEstadoOrden = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.cboTipoServicio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboVehiculos = new System.Windows.Forms.ComboBox();
            this.cboMecanico = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboAdministrador = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbCostoFinal = new System.Windows.Forms.TextBox();
            this.tbDescripcionServicio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clientes
            // 
            this.Clientes.Controls.Add(this.dgvOrdenes);
            this.Clientes.Location = new System.Drawing.Point(12, 12);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(388, 425);
            this.Clientes.TabIndex = 48;
            this.Clientes.TabStop = false;
            this.Clientes.Text = "Ordenes de Servicio: ";
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenes.Location = new System.Drawing.Point(6, 19);
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.Size = new System.Drawing.Size(374, 396);
            this.dgvOrdenes.TabIndex = 35;
            this.dgvOrdenes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdenes_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Location = new System.Drawing.Point(406, 379);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 58);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(44, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 23);
            this.btnModificar.TabIndex = 35;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(193, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 23);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.Text = "Eliminar ";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboEstadoOrden);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtpFechaSalida);
            this.groupBox1.Controls.Add(this.dtpFechaIngreso);
            this.groupBox1.Controls.Add(this.cboTipoServicio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboVehiculos);
            this.groupBox1.Controls.Add(this.cboMecanico);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboAdministrador);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.tbCostoFinal);
            this.groupBox1.Controls.Add(this.tbDescripcionServicio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(406, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 361);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Ordenes de Servicio";
            // 
            // cboEstadoOrden
            // 
            this.cboEstadoOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoOrden.FormattingEnabled = true;
            this.cboEstadoOrden.Items.AddRange(new object[] {
            "Pendiente",
            "En Curso",
            "Finalizada",
            "Cancelada"});
            this.cboEstadoOrden.Location = new System.Drawing.Point(180, 259);
            this.cboEstadoOrden.Name = "cboEstadoOrden";
            this.cboEstadoOrden.Size = new System.Drawing.Size(127, 21);
            this.cboEstadoOrden.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Estado:";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSalida.Location = new System.Drawing.Point(117, 45);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaSalida.TabIndex = 64;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(117, 19);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIngreso.TabIndex = 63;
            // 
            // cboTipoServicio
            // 
            this.cboTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoServicio.FormattingEnabled = true;
            this.cboTipoServicio.Location = new System.Drawing.Point(180, 151);
            this.cboTipoServicio.Name = "cboTipoServicio";
            this.cboTipoServicio.Size = new System.Drawing.Size(127, 21);
            this.cboTipoServicio.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Tipo Servicio:";
            // 
            // cboVehiculos
            // 
            this.cboVehiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehiculos.FormattingEnabled = true;
            this.cboVehiculos.Location = new System.Drawing.Point(180, 178);
            this.cboVehiculos.Name = "cboVehiculos";
            this.cboVehiculos.Size = new System.Drawing.Size(127, 21);
            this.cboVehiculos.TabIndex = 60;
            // 
            // cboMecanico
            // 
            this.cboMecanico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMecanico.FormattingEnabled = true;
            this.cboMecanico.Location = new System.Drawing.Point(180, 232);
            this.cboMecanico.Name = "cboMecanico";
            this.cboMecanico.Size = new System.Drawing.Size(127, 21);
            this.cboMecanico.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Mecanico:";
            // 
            // cboAdministrador
            // 
            this.cboAdministrador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdministrador.FormattingEnabled = true;
            this.cboAdministrador.Location = new System.Drawing.Point(180, 205);
            this.cboAdministrador.Name = "cboAdministrador";
            this.cboAdministrador.Size = new System.Drawing.Size(127, 21);
            this.cboAdministrador.TabIndex = 56;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(15, 328);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(102, 23);
            this.btnRegistrar.TabIndex = 31;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // tbCostoFinal
            // 
            this.tbCostoFinal.Location = new System.Drawing.Point(180, 284);
            this.tbCostoFinal.Name = "tbCostoFinal";
            this.tbCostoFinal.Size = new System.Drawing.Size(127, 20);
            this.tbCostoFinal.TabIndex = 46;
            // 
            // tbDescripcionServicio
            // 
            this.tbDescripcionServicio.Location = new System.Drawing.Point(15, 98);
            this.tbDescripcionServicio.Multiline = true;
            this.tbDescripcionServicio.Name = "tbDescripcionServicio";
            this.tbDescripcionServicio.Size = new System.Drawing.Size(302, 47);
            this.tbDescripcionServicio.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Administrador a cargo: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Vehiculo:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(23, 287);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(64, 13);
            this.label.TabIndex = 40;
            this.label.Text = "Costo Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Descripcion Servicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Fecha Salida:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Fecha Ingreso: ";
            // 
            // FormOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.Clientes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormOrden";
            this.Text = "Ordenes de Servicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Clientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Clientes;
        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboAdministrador;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox tbCostoFinal;
        private System.Windows.Forms.TextBox tbDescripcionServicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboVehiculos;
        private System.Windows.Forms.ComboBox cboMecanico;
        private System.Windows.Forms.ComboBox cboTipoServicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboEstadoOrden;
    }
}