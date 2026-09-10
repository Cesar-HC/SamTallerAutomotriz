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
using static System.Net.Mime.MediaTypeNames;

namespace Presentacion
{
    public partial class FormReporteVehiculo : Form
    {
        private NVehiculo nVehiculo = new NVehiculo();
        private NCliente nCliente = new NCliente();
        public FormReporteVehiculo()
        {
            InitializeComponent();
            MostrarClientes(nCliente.ListarTodo());
        }
        private void MostrarClientes(List<Cliente> clientes)
        {
            cboCliente.DataSource = null;
            if (clientes.Count == 0)
            {
                return;
            }
            else
            {
                cboCliente.DataSource = clientes;
                cboCliente.ValueMember = "IdCliente";
                cboCliente.DisplayMember = "Nombre";
            }
        }
        private void MostrarVehiculos(List<Vehiculo> vehiculos)
        {
            dgvVehiculos.DataSource = null;
            if (vehiculos.Count == 0)
            {
                return;
            }
            else
            {
                dgvVehiculos.DataSource = vehiculos;
                dgvVehiculos.Columns["TipoVehiculo"].Visible = false;
                dgvVehiculos.Columns["Marca"].Visible = false;
                dgvVehiculos.Columns["Cliente"].Visible = false;
                dgvVehiculos.Columns["Orden"].Visible = false;
            }
        }
        private void btnBuscarVehiculos_Click(object sender, EventArgs e)
        {
            if (txtBuscarVehiculos.Text.Trim() == "" || cboBuscarVehiculos.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos para buscar un vehículo.", "Buscar.");
                return;
            }
            string text = txtBuscarVehiculos.Text;
            int index = cboBuscarVehiculos.SelectedIndex;
            MostrarVehiculos(nVehiculo.BusquedaVehiculosPorAtributo(index, text));
        }

        private void btnOrdenarVehiculos_Click(object sender, EventArgs e)
        {
            if (cboOrdenarVehiculos.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos para ordenar los vehículos.", "Ordenar.");
                return;
            }
            int index = cboOrdenarVehiculos.SelectedIndex;
            bool marcado = cbOrdenarVehiculos.Checked;
            MostrarVehiculos(nVehiculo.OrdenarVehiculosPorAtributo(index, marcado));
        }

        private void btnReporte3_Click(object sender, EventArgs e)
        {
            if (cboCliente.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar un cliente para realizar el reporte.", "Reporte.");
                return;
            }
            int idCliente = int.Parse(cboCliente.SelectedValue.ToString());
            MostrarVehiculos(nVehiculo.MostrarVehiculosPorCliente(idCliente));
        }

        private void btnReporte1_Click(object sender, EventArgs e)
        {
            MostrarVehiculos(nVehiculo.MostrarVehiculosConOrdenesPendientes());
        }

        private void btnReporte2_Click_1(object sender, EventArgs e)
        {
            MostrarVehiculos(nVehiculo.MostrarVehiculosQueTenganOrdenes());
        }
    }
}
