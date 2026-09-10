using Datos;
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
    public partial class FormReporteCliente : Form
    {
        private NCliente nCliente = new NCliente();
        public FormReporteCliente()
        {
            InitializeComponent();
            lblReporte3.Text = nCliente.CantidadDeClientesPorEstadoLibre().ToString();
            lblReporte4.Text = nCliente.CantidadDeClientesPorEstadoEnObservacion().ToString();
            lblReporte5.Text = nCliente.CantidadDeClientesPorEstadoRestringido().ToString();
        }
        private void MostrarClientes(List<Cliente> clientes)
        {
            dgvClientes.DataSource = null;
            if (clientes.Count == 0)
            {
                return;
            }
            else
            {
                dgvClientes.DataSource = clientes;
                dgvClientes.Columns["Distrito"].Visible = false;
                dgvClientes.Columns["Vehiculo"].Visible = false;
            }
        }
        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {
            if (txtBuscarCliente.Text.Trim() == "" || cboBuscarClientes.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos para buscar un cliente.", "Buscar.");
                return;
            }
            string texto = txtBuscarCliente.Text;
            int valor = cboBuscarClientes.SelectedIndex;
            MostrarClientes(nCliente.BusquedaClientesPorAtributo(valor, texto));
        }

        private void btnOrdenarClientes_Click(object sender, EventArgs e)
        {
            if (cboOrdenarClientes.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos para ordenar un cliente.", "Ordenar.");
                return;
            }
            int valor = cboOrdenarClientes.SelectedIndex;
            bool marcado = cbOrdenarClientes.Checked;
            MostrarClientes(nCliente.OrdenarClientesPorAtributo(valor, marcado));
        }

        private void btnReporteClientes_Click(object sender, EventArgs e)
        {
            int valor = cboReporteCliente.SelectedIndex;
            switch (valor)
            {
                case 0:
                    MostrarClientes(nCliente.MostrarClientesQueSeEncuentrenEliminados());
                    break;
                default:
                    MostrarClientes(nCliente.MostrarClientesQueTenganVehiculos());
                    break;
            }
        }
    }
}
