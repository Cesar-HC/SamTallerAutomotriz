namespace Presentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeEspecialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provinciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadesDeMecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeVehículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeOrdenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.reportesToolStripMenuItem1,
            this.reportesToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.vehiculoToolStripMenuItem,
            this.ordenToolStripMenuItem,
            this.distritoToolStripMenuItem,
            this.tipoDeEspecialidadToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(148, 29);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.clienteToolStripMenuItem.Text = "Tipo de Vehiculos";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // vehiculoToolStripMenuItem
            // 
            this.vehiculoToolStripMenuItem.Name = "vehiculoToolStripMenuItem";
            this.vehiculoToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.vehiculoToolStripMenuItem.Text = "Marca";
            this.vehiculoToolStripMenuItem.Click += new System.EventHandler(this.vehiculoToolStripMenuItem_Click);
            // 
            // ordenToolStripMenuItem
            // 
            this.ordenToolStripMenuItem.Name = "ordenToolStripMenuItem";
            this.ordenToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.ordenToolStripMenuItem.Text = "Provincia";
            this.ordenToolStripMenuItem.Click += new System.EventHandler(this.ordenToolStripMenuItem_Click);
            // 
            // distritoToolStripMenuItem
            // 
            this.distritoToolStripMenuItem.Name = "distritoToolStripMenuItem";
            this.distritoToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.distritoToolStripMenuItem.Text = "Distrito";
            this.distritoToolStripMenuItem.Click += new System.EventHandler(this.distritoToolStripMenuItem_Click);
            // 
            // tipoDeEspecialidadToolStripMenuItem
            // 
            this.tipoDeEspecialidadToolStripMenuItem.Name = "tipoDeEspecialidadToolStripMenuItem";
            this.tipoDeEspecialidadToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.tipoDeEspecialidadToolStripMenuItem.Text = "Mec. Especialidad";
            this.tipoDeEspecialidadToolStripMenuItem.Click += new System.EventHandler(this.tipoDeEspecialidadToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.distritosToolStripMenuItem,
            this.provinciasToolStripMenuItem,
            this.especialidadesDeMecToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(186, 29);
            this.reportesToolStripMenuItem.Text = "Gestión de Usuarios";
            // 
            // distritosToolStripMenuItem
            // 
            this.distritosToolStripMenuItem.Name = "distritosToolStripMenuItem";
            this.distritosToolStripMenuItem.Size = new System.Drawing.Size(245, 34);
            this.distritosToolStripMenuItem.Text = "Clientes";
            this.distritosToolStripMenuItem.Click += new System.EventHandler(this.distritosToolStripMenuItem_Click);
            // 
            // provinciasToolStripMenuItem
            // 
            this.provinciasToolStripMenuItem.Name = "provinciasToolStripMenuItem";
            this.provinciasToolStripMenuItem.Size = new System.Drawing.Size(245, 34);
            this.provinciasToolStripMenuItem.Text = "Mecánicos";
            this.provinciasToolStripMenuItem.Click += new System.EventHandler(this.provinciasToolStripMenuItem_Click);
            // 
            // especialidadesDeMecToolStripMenuItem
            // 
            this.especialidadesDeMecToolStripMenuItem.Name = "especialidadesDeMecToolStripMenuItem";
            this.especialidadesDeMecToolStripMenuItem.Size = new System.Drawing.Size(245, 34);
            this.especialidadesDeMecToolStripMenuItem.Text = "Administradores";
            this.especialidadesDeMecToolStripMenuItem.Click += new System.EventHandler(this.especialidadesDeMecToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem1
            // 
            this.reportesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiculosToolStripMenuItem,
            this.ordenesDeServicioToolStripMenuItem});
            this.reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1";
            this.reportesToolStripMenuItem1.Size = new System.Drawing.Size(192, 29);
            this.reportesToolStripMenuItem1.Text = "Gestión de Vehiculos";
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos";
            this.vehiculosToolStripMenuItem.Click += new System.EventHandler(this.vehiculosToolStripMenuItem_Click);
            // 
            // ordenesDeServicioToolStripMenuItem
            // 
            this.ordenesDeServicioToolStripMenuItem.Name = "ordenesDeServicioToolStripMenuItem";
            this.ordenesDeServicioToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.ordenesDeServicioToolStripMenuItem.Text = "Ordenes de Servicio";
            this.ordenesDeServicioToolStripMenuItem.Click += new System.EventHandler(this.ordenesDeServicioToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem2
            // 
            this.reportesToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informeDeClientesToolStripMenuItem,
            this.informeDeVehículosToolStripMenuItem,
            this.informeDeOrdenesToolStripMenuItem});
            this.reportesToolStripMenuItem2.Name = "reportesToolStripMenuItem2";
            this.reportesToolStripMenuItem2.Size = new System.Drawing.Size(99, 29);
            this.reportesToolStripMenuItem2.Text = "Informes";
            // 
            // informeDeClientesToolStripMenuItem
            // 
            this.informeDeClientesToolStripMenuItem.Name = "informeDeClientesToolStripMenuItem";
            this.informeDeClientesToolStripMenuItem.Size = new System.Drawing.Size(281, 34);
            this.informeDeClientesToolStripMenuItem.Text = "Informe de Clientes";
            this.informeDeClientesToolStripMenuItem.Click += new System.EventHandler(this.informeDeClientesToolStripMenuItem_Click);
            // 
            // informeDeVehículosToolStripMenuItem
            // 
            this.informeDeVehículosToolStripMenuItem.Name = "informeDeVehículosToolStripMenuItem";
            this.informeDeVehículosToolStripMenuItem.Size = new System.Drawing.Size(281, 34);
            this.informeDeVehículosToolStripMenuItem.Text = "Informe de Vehículos";
            this.informeDeVehículosToolStripMenuItem.Click += new System.EventHandler(this.informeDeVehículosToolStripMenuItem_Click);
            // 
            // informeDeOrdenesToolStripMenuItem
            // 
            this.informeDeOrdenesToolStripMenuItem.Name = "informeDeOrdenesToolStripMenuItem";
            this.informeDeOrdenesToolStripMenuItem.Size = new System.Drawing.Size(281, 34);
            this.informeDeOrdenesToolStripMenuItem.Text = "Informe de Ordenes";
            this.informeDeOrdenesToolStripMenuItem.Click += new System.EventHandler(this.informeDeOrdenesToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(842, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario:";
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Location = new System.Drawing.Point(920, 9);
            this.lblAdministrador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(14, 20);
            this.lblAdministrador.TabIndex = 4;
            this.lblAdministrador.Text = "-";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lblAdministrador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sam Taller Automotriz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distritosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provinciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadesDeMecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeEspecialidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.ToolStripMenuItem informeDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeDeVehículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeDeOrdenesToolStripMenuItem;
    }
}

