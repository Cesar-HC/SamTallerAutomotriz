using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        private string usuario;
        public FormPrincipal(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblAdministrador.Text = usuario; 
        }

        private void ordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProvincia frm = new FormProvincia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void distritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDistrito frm = new FormDistrito();
            frm.MdiParent = this;
            frm.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipoVehiculo frm = new FormTipoVehiculo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMarca frm = new FormMarca();
            frm.MdiParent = this;
            frm.Show();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVehiculo frm = new FormVehiculo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tipoDeEspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEspecialidadMecanico frm = new FormEspecialidadMecanico();
            frm.MdiParent = this;
            frm.Show();
        }

        private void distritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente frm = new FormCliente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void provinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMecanico frm = new FormMecanico();
            frm.MdiParent = this;
            frm.Show();
        }

        private void especialidadesDeMecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdministrador frm = new FormAdministrador();        
            frm.MdiParent = this; 
            frm.Show();
        }

        private void ordenesDeServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrden frm = new FormOrden();    
            frm.MdiParent = this;   
            frm.Show();
        }

        private void informeDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteCliente frm = new FormReporteCliente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void informeDeVehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteVehiculo frm = new FormReporteVehiculo(); 
            frm.MdiParent = this;
            frm.Show();
        }

        private void informeDeOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteOrden frm = new FormReporteOrden();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
