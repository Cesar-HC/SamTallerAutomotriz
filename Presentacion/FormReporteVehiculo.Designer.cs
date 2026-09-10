namespace Presentacion
{
    partial class FormReporteVehiculo
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
            this.btnReporte2 = new System.Windows.Forms.Button();
            this.btnReporte3 = new System.Windows.Forms.Button();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnReporte1 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbOrdenarVehiculos = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cboOrdenarVehiculos = new System.Windows.Forms.ComboBox();
            this.btnOrdenarVehiculos = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtBuscarVehiculos = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cboBuscarVehiculos = new System.Windows.Forms.ComboBox();
            this.btnBuscarVehiculos = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnReporte2);
            this.groupBox4.Controls.Add(this.btnReporte3);
            this.groupBox4.Controls.Add(this.cboCliente);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.btnReporte1);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Location = new System.Drawing.Point(671, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 177);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reportes";
            // 
            // btnReporte2
            // 
            this.btnReporte2.Location = new System.Drawing.Point(48, 28);
            this.btnReporte2.Name = "btnReporte2";
            this.btnReporte2.Size = new System.Drawing.Size(243, 25);
            this.btnReporte2.TabIndex = 16;
            this.btnReporte2.Text = "Mostrar vehículos que tengan órdenes";
            this.btnReporte2.UseVisualStyleBackColor = true;
            this.btnReporte2.Click += new System.EventHandler(this.btnReporte2_Click_1);
            // 
            // btnReporte3
            // 
            this.btnReporte3.Location = new System.Drawing.Point(231, 136);
            this.btnReporte3.Name = "btnReporte3";
            this.btnReporte3.Size = new System.Drawing.Size(75, 23);
            this.btnReporte3.TabIndex = 15;
            this.btnReporte3.Text = "Mostrar";
            this.btnReporte3.UseVisualStyleBackColor = true;
            this.btnReporte3.Click += new System.EventHandler(this.btnReporte3_Click);
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(8, 138);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(207, 21);
            this.cboCliente.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mostrar vehículos por Cliente:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 13);
            this.label18.TabIndex = 9;
            // 
            // btnReporte1
            // 
            this.btnReporte1.Location = new System.Drawing.Point(48, 74);
            this.btnReporte1.Name = "btnReporte1";
            this.btnReporte1.Size = new System.Drawing.Size(243, 25);
            this.btnReporte1.TabIndex = 3;
            this.btnReporte1.Text = "Mostrar vehículos con órdenes pendientes";
            this.btnReporte1.UseVisualStyleBackColor = true;
            this.btnReporte1.Click += new System.EventHandler(this.btnReporte1_Click);
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
            this.groupBox5.Controls.Add(this.cbOrdenarVehiculos);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.cboOrdenarVehiculos);
            this.groupBox5.Controls.Add(this.btnOrdenarVehiculos);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Location = new System.Drawing.Point(342, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(312, 177);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ordenamientos";
            // 
            // cbOrdenarVehiculos
            // 
            this.cbOrdenarVehiculos.AutoSize = true;
            this.cbOrdenarVehiculos.Location = new System.Drawing.Point(9, 82);
            this.cbOrdenarVehiculos.Name = "cbOrdenarVehiculos";
            this.cbOrdenarVehiculos.Size = new System.Drawing.Size(158, 17);
            this.cbOrdenarVehiculos.TabIndex = 10;
            this.cbOrdenarVehiculos.Text = "Ordenar descendentemente";
            this.cbOrdenarVehiculos.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 13);
            this.label20.TabIndex = 9;
            // 
            // cboOrdenarVehiculos
            // 
            this.cboOrdenarVehiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrdenarVehiculos.FormattingEnabled = true;
            this.cboOrdenarVehiculos.Items.AddRange(new object[] {
            "Año",
            "Color",
            "Placa",
            "Estado"});
            this.cboOrdenarVehiculos.Location = new System.Drawing.Point(6, 44);
            this.cboOrdenarVehiculos.Name = "cboOrdenarVehiculos";
            this.cboOrdenarVehiculos.Size = new System.Drawing.Size(183, 21);
            this.cboOrdenarVehiculos.TabIndex = 8;
            // 
            // btnOrdenarVehiculos
            // 
            this.btnOrdenarVehiculos.Location = new System.Drawing.Point(221, 80);
            this.btnOrdenarVehiculos.Name = "btnOrdenarVehiculos";
            this.btnOrdenarVehiculos.Size = new System.Drawing.Size(75, 20);
            this.btnOrdenarVehiculos.TabIndex = 3;
            this.btnOrdenarVehiculos.Text = "Ordenar";
            this.btnOrdenarVehiculos.UseVisualStyleBackColor = true;
            this.btnOrdenarVehiculos.Click += new System.EventHandler(this.btnOrdenarVehiculos_Click);
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
            this.groupBox6.Controls.Add(this.txtBuscarVehiculos);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.cboBuscarVehiculos);
            this.groupBox6.Controls.Add(this.btnBuscarVehiculos);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(312, 177);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Búsquedas";
            // 
            // txtBuscarVehiculos
            // 
            this.txtBuscarVehiculos.Location = new System.Drawing.Point(6, 85);
            this.txtBuscarVehiculos.Name = "txtBuscarVehiculos";
            this.txtBuscarVehiculos.Size = new System.Drawing.Size(183, 20);
            this.txtBuscarVehiculos.TabIndex = 10;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 13);
            this.label22.TabIndex = 9;
            // 
            // cboBuscarVehiculos
            // 
            this.cboBuscarVehiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarVehiculos.FormattingEnabled = true;
            this.cboBuscarVehiculos.Items.AddRange(new object[] {
            "Año",
            "Color",
            "Placa",
            "Estado"});
            this.cboBuscarVehiculos.Location = new System.Drawing.Point(6, 49);
            this.cboBuscarVehiculos.Name = "cboBuscarVehiculos";
            this.cboBuscarVehiculos.Size = new System.Drawing.Size(183, 21);
            this.cboBuscarVehiculos.TabIndex = 8;
            // 
            // btnBuscarVehiculos
            // 
            this.btnBuscarVehiculos.Location = new System.Drawing.Point(221, 85);
            this.btnBuscarVehiculos.Name = "btnBuscarVehiculos";
            this.btnBuscarVehiculos.Size = new System.Drawing.Size(75, 20);
            this.btnBuscarVehiculos.TabIndex = 3;
            this.btnBuscarVehiculos.Text = "Buscar";
            this.btnBuscarVehiculos.UseVisualStyleBackColor = true;
            this.btnBuscarVehiculos.Click += new System.EventHandler(this.btnBuscarVehiculos_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 28);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(112, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "Atributo seleccionado:";
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(12, 195);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.Size = new System.Drawing.Size(971, 234);
            this.dgvVehiculos.TabIndex = 18;
            // 
            // FormReporteVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 442);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.dgvVehiculos);
            this.Name = "FormReporteVehiculo";
            this.Text = "FormInformeVehiculo";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnReporte1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbOrdenarVehiculos;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cboOrdenarVehiculos;
        private System.Windows.Forms.Button btnOrdenarVehiculos;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtBuscarVehiculos;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cboBuscarVehiculos;
        private System.Windows.Forms.Button btnBuscarVehiculos;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.Button btnReporte3;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReporte2;
    }
}