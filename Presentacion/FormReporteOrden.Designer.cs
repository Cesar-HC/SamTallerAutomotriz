namespace Presentacion
{
    partial class FormReporteOrden
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbOrdenarOrden = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cboOrdenarOrden = new System.Windows.Forms.ComboBox();
            this.btnOrdenarOrden = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarOrdenMin = new System.Windows.Forms.TextBox();
            this.dtpBuscarOrdenesPorFechaMin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarOrdenesPorCostoTotal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBuscarOrdenPorFechaMax = new System.Windows.Forms.DateTimePicker();
            this.txtBuscarOrdenMax = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cboBuscarOrdenPorFecha = new System.Windows.Forms.ComboBox();
            this.btnBuscarOrdenPorFecha = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cboBuscarOrdenesPorEstado = new System.Windows.Forms.ComboBox();
            this.btnBuscarOrdenesPorEstado = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboBuscarPorMecánico = new System.Windows.Forms.ComboBox();
            this.cboBuscarPorAdministrador = new System.Windows.Forms.ComboBox();
            this.cboBuscarPorCliente = new System.Windows.Forms.ComboBox();
            this.btnBuscarPorMecanico = new System.Windows.Forms.Button();
            this.btnBuscarPorAdministrador = new System.Windows.Forms.Button();
            this.btnBuscarPorCliente = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBuscarPorCliente);
            this.groupBox4.Controls.Add(this.btnBuscarPorAdministrador);
            this.groupBox4.Controls.Add(this.btnBuscarPorMecanico);
            this.groupBox4.Controls.Add(this.cboBuscarPorCliente);
            this.groupBox4.Controls.Add(this.cboBuscarPorAdministrador);
            this.groupBox4.Controls.Add(this.cboBuscarPorMecánico);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Location = new System.Drawing.Point(723, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 307);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reportes";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 13);
            this.label18.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 13);
            this.label19.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbOrdenarOrden);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.cboOrdenarOrden);
            this.groupBox5.Controls.Add(this.btnOrdenarOrden);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Location = new System.Drawing.Point(405, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(312, 307);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ordenamientos";
            // 
            // cbOrdenarOrden
            // 
            this.cbOrdenarOrden.AutoSize = true;
            this.cbOrdenarOrden.Location = new System.Drawing.Point(9, 82);
            this.cbOrdenarOrden.Name = "cbOrdenarOrden";
            this.cbOrdenarOrden.Size = new System.Drawing.Size(158, 17);
            this.cbOrdenarOrden.TabIndex = 10;
            this.cbOrdenarOrden.Text = "Ordenar descendentemente";
            this.cbOrdenarOrden.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 13);
            this.label20.TabIndex = 9;
            // 
            // cboOrdenarOrden
            // 
            this.cboOrdenarOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrdenarOrden.FormattingEnabled = true;
            this.cboOrdenarOrden.Items.AddRange(new object[] {
            "Fecha de ingreso",
            "Fecha de salida",
            "Costo total",
            "Estado"});
            this.cboOrdenarOrden.Location = new System.Drawing.Point(6, 44);
            this.cboOrdenarOrden.Name = "cboOrdenarOrden";
            this.cboOrdenarOrden.Size = new System.Drawing.Size(183, 21);
            this.cboOrdenarOrden.TabIndex = 8;
            // 
            // btnOrdenarOrden
            // 
            this.btnOrdenarOrden.Location = new System.Drawing.Point(221, 80);
            this.btnOrdenarOrden.Name = "btnOrdenarOrden";
            this.btnOrdenarOrden.Size = new System.Drawing.Size(75, 20);
            this.btnOrdenarOrden.TabIndex = 3;
            this.btnOrdenarOrden.Text = "Ordenar";
            this.btnOrdenarOrden.UseVisualStyleBackColor = true;
            this.btnOrdenarOrden.Click += new System.EventHandler(this.btnOrdenarOrden_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(112, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "Atributo seleccionado:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnBuscarOrdenesPorEstado);
            this.groupBox6.Controls.Add(this.cboBuscarOrdenesPorEstado);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.txtBuscarOrdenMin);
            this.groupBox6.Controls.Add(this.dtpBuscarOrdenesPorFechaMin);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.btnBuscarOrdenesPorCostoTotal);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.dtpBuscarOrdenPorFechaMax);
            this.groupBox6.Controls.Add(this.txtBuscarOrdenMax);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.cboBuscarOrdenPorFecha);
            this.groupBox6.Controls.Add(this.btnBuscarOrdenPorFecha);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(387, 307);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Búsquedas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Costo total mínimo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Costo total máximo:";
            // 
            // txtBuscarOrdenMin
            // 
            this.txtBuscarOrdenMin.Location = new System.Drawing.Point(109, 214);
            this.txtBuscarOrdenMin.Name = "txtBuscarOrdenMin";
            this.txtBuscarOrdenMin.Size = new System.Drawing.Size(175, 20);
            this.txtBuscarOrdenMin.TabIndex = 17;
            // 
            // dtpBuscarOrdenesPorFechaMin
            // 
            this.dtpBuscarOrdenesPorFechaMin.Location = new System.Drawing.Point(89, 121);
            this.dtpBuscarOrdenesPorFechaMin.Name = "dtpBuscarOrdenesPorFechaMin";
            this.dtpBuscarOrdenesPorFechaMin.Size = new System.Drawing.Size(195, 20);
            this.dtpBuscarOrdenesPorFechaMin.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fecha mínima:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fecha máxima:";
            // 
            // btnBuscarOrdenesPorCostoTotal
            // 
            this.btnBuscarOrdenesPorCostoTotal.Location = new System.Drawing.Point(300, 214);
            this.btnBuscarOrdenesPorCostoTotal.Name = "btnBuscarOrdenesPorCostoTotal";
            this.btnBuscarOrdenesPorCostoTotal.Size = new System.Drawing.Size(75, 20);
            this.btnBuscarOrdenesPorCostoTotal.TabIndex = 13;
            this.btnBuscarOrdenesPorCostoTotal.Text = "Buscar";
            this.btnBuscarOrdenesPorCostoTotal.UseVisualStyleBackColor = true;
            this.btnBuscarOrdenesPorCostoTotal.Click += new System.EventHandler(this.btnBuscarOrdenesPorCostoTotal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Buscar órdenes por rango de Costos totales:";
            // 
            // dtpBuscarOrdenPorFechaMax
            // 
            this.dtpBuscarOrdenPorFechaMax.Location = new System.Drawing.Point(90, 82);
            this.dtpBuscarOrdenPorFechaMax.Name = "dtpBuscarOrdenPorFechaMax";
            this.dtpBuscarOrdenPorFechaMax.Size = new System.Drawing.Size(195, 20);
            this.dtpBuscarOrdenPorFechaMax.TabIndex = 11;
            // 
            // txtBuscarOrdenMax
            // 
            this.txtBuscarOrdenMax.Location = new System.Drawing.Point(110, 184);
            this.txtBuscarOrdenMax.Name = "txtBuscarOrdenMax";
            this.txtBuscarOrdenMax.Size = new System.Drawing.Size(175, 20);
            this.txtBuscarOrdenMax.TabIndex = 10;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 13);
            this.label22.TabIndex = 9;
            // 
            // cboBuscarOrdenPorFecha
            // 
            this.cboBuscarOrdenPorFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarOrdenPorFecha.FormattingEnabled = true;
            this.cboBuscarOrdenPorFecha.Items.AddRange(new object[] {
            "Fecha de ingreso",
            "Fecha de salida"});
            this.cboBuscarOrdenPorFecha.Location = new System.Drawing.Point(9, 52);
            this.cboBuscarOrdenPorFecha.Name = "cboBuscarOrdenPorFecha";
            this.cboBuscarOrdenPorFecha.Size = new System.Drawing.Size(195, 21);
            this.cboBuscarOrdenPorFecha.TabIndex = 8;
            // 
            // btnBuscarOrdenPorFecha
            // 
            this.btnBuscarOrdenPorFecha.Location = new System.Drawing.Point(300, 121);
            this.btnBuscarOrdenPorFecha.Name = "btnBuscarOrdenPorFecha";
            this.btnBuscarOrdenPorFecha.Size = new System.Drawing.Size(75, 20);
            this.btnBuscarOrdenPorFecha.TabIndex = 3;
            this.btnBuscarOrdenPorFecha.Text = "Buscar";
            this.btnBuscarOrdenPorFecha.UseVisualStyleBackColor = true;
            this.btnBuscarOrdenPorFecha.Click += new System.EventHandler(this.btnBuscarOrdenPorFecha_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 28);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(182, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "Buscar órdenes por rango de fechas:";
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenes.Location = new System.Drawing.Point(12, 325);
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.Size = new System.Drawing.Size(1023, 234);
            this.dgvOrdenes.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Buscar órdenes por Estado:";
            // 
            // cboBuscarOrdenesPorEstado
            // 
            this.cboBuscarOrdenesPorEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarOrdenesPorEstado.FormattingEnabled = true;
            this.cboBuscarOrdenesPorEstado.Items.AddRange(new object[] {
            "Pendiente",
            "En Curso",
            "Finalizada",
            "Cancelada"});
            this.cboBuscarOrdenesPorEstado.Location = new System.Drawing.Point(10, 275);
            this.cboBuscarOrdenesPorEstado.Name = "cboBuscarOrdenesPorEstado";
            this.cboBuscarOrdenesPorEstado.Size = new System.Drawing.Size(195, 21);
            this.cboBuscarOrdenesPorEstado.TabIndex = 21;
            // 
            // btnBuscarOrdenesPorEstado
            // 
            this.btnBuscarOrdenesPorEstado.Location = new System.Drawing.Point(224, 276);
            this.btnBuscarOrdenesPorEstado.Name = "btnBuscarOrdenesPorEstado";
            this.btnBuscarOrdenesPorEstado.Size = new System.Drawing.Size(75, 20);
            this.btnBuscarOrdenesPorEstado.TabIndex = 22;
            this.btnBuscarOrdenesPorEstado.Text = "Buscar";
            this.btnBuscarOrdenesPorEstado.UseVisualStyleBackColor = true;
            this.btnBuscarOrdenesPorEstado.Click += new System.EventHandler(this.btnBuscarOrdenesPorEstado_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mostrar órdenes históricas por Mecánico";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mostrar órdenes históricas registradas por Administrador:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Mostrar órdenes históricas por Cliente:";
            // 
            // cboBuscarPorMecánico
            // 
            this.cboBuscarPorMecánico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarPorMecánico.FormattingEnabled = true;
            this.cboBuscarPorMecánico.Items.AddRange(new object[] {
            "Fecha de ingreso",
            "Fecha de salida",
            "Costo total",
            "Estado"});
            this.cboBuscarPorMecánico.Location = new System.Drawing.Point(6, 52);
            this.cboBuscarPorMecánico.Name = "cboBuscarPorMecánico";
            this.cboBuscarPorMecánico.Size = new System.Drawing.Size(183, 21);
            this.cboBuscarPorMecánico.TabIndex = 11;
            // 
            // cboBuscarPorAdministrador
            // 
            this.cboBuscarPorAdministrador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarPorAdministrador.FormattingEnabled = true;
            this.cboBuscarPorAdministrador.Items.AddRange(new object[] {
            "Fecha de ingreso",
            "Fecha de salida",
            "Costo total",
            "Estado"});
            this.cboBuscarPorAdministrador.Location = new System.Drawing.Point(6, 124);
            this.cboBuscarPorAdministrador.Name = "cboBuscarPorAdministrador";
            this.cboBuscarPorAdministrador.Size = new System.Drawing.Size(183, 21);
            this.cboBuscarPorAdministrador.TabIndex = 14;
            // 
            // cboBuscarPorCliente
            // 
            this.cboBuscarPorCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarPorCliente.FormattingEnabled = true;
            this.cboBuscarPorCliente.Items.AddRange(new object[] {
            "Fecha de ingreso",
            "Fecha de salida",
            "Costo total",
            "Estado"});
            this.cboBuscarPorCliente.Location = new System.Drawing.Point(6, 196);
            this.cboBuscarPorCliente.Name = "cboBuscarPorCliente";
            this.cboBuscarPorCliente.Size = new System.Drawing.Size(183, 21);
            this.cboBuscarPorCliente.TabIndex = 15;
            // 
            // btnBuscarPorMecanico
            // 
            this.btnBuscarPorMecanico.Location = new System.Drawing.Point(211, 52);
            this.btnBuscarPorMecanico.Name = "btnBuscarPorMecanico";
            this.btnBuscarPorMecanico.Size = new System.Drawing.Size(75, 20);
            this.btnBuscarPorMecanico.TabIndex = 11;
            this.btnBuscarPorMecanico.Text = "Mostrar";
            this.btnBuscarPorMecanico.UseVisualStyleBackColor = true;
            this.btnBuscarPorMecanico.Click += new System.EventHandler(this.btnBuscarPorMecanico_Click);
            // 
            // btnBuscarPorAdministrador
            // 
            this.btnBuscarPorAdministrador.Location = new System.Drawing.Point(211, 125);
            this.btnBuscarPorAdministrador.Name = "btnBuscarPorAdministrador";
            this.btnBuscarPorAdministrador.Size = new System.Drawing.Size(75, 20);
            this.btnBuscarPorAdministrador.TabIndex = 16;
            this.btnBuscarPorAdministrador.Text = "Mostrar";
            this.btnBuscarPorAdministrador.UseVisualStyleBackColor = true;
            this.btnBuscarPorAdministrador.Click += new System.EventHandler(this.btnBuscarPorAdministrador_Click);
            // 
            // btnBuscarPorCliente
            // 
            this.btnBuscarPorCliente.Location = new System.Drawing.Point(211, 196);
            this.btnBuscarPorCliente.Name = "btnBuscarPorCliente";
            this.btnBuscarPorCliente.Size = new System.Drawing.Size(75, 20);
            this.btnBuscarPorCliente.TabIndex = 17;
            this.btnBuscarPorCliente.Text = "Mostrar";
            this.btnBuscarPorCliente.UseVisualStyleBackColor = true;
            this.btnBuscarPorCliente.Click += new System.EventHandler(this.btnBuscarPorCliente_Click);
            // 
            // FormReporteOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 571);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.dgvOrdenes);
            this.Name = "FormReporteOrden";
            this.Text = "FormInformeOrden";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbOrdenarOrden;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cboOrdenarOrden;
        private System.Windows.Forms.Button btnOrdenarOrden;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtBuscarOrdenMax;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cboBuscarOrdenPorFecha;
        private System.Windows.Forms.Button btnBuscarOrdenPorFecha;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.DateTimePicker dtpBuscarOrdenPorFechaMax;
        private System.Windows.Forms.Button btnBuscarOrdenesPorCostoTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscarOrdenMin;
        private System.Windows.Forms.DateTimePicker dtpBuscarOrdenesPorFechaMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarOrdenesPorEstado;
        private System.Windows.Forms.ComboBox cboBuscarOrdenesPorEstado;
        private System.Windows.Forms.Button btnBuscarPorMecanico;
        private System.Windows.Forms.ComboBox cboBuscarPorCliente;
        private System.Windows.Forms.ComboBox cboBuscarPorAdministrador;
        private System.Windows.Forms.ComboBox cboBuscarPorMecánico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscarPorCliente;
        private System.Windows.Forms.Button btnBuscarPorAdministrador;
    }
}