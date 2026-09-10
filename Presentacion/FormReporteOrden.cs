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
    public partial class FormReporteOrden : Form
    {
        private NOrden nOrden = new NOrden();
        private NAdministrador nAdministrador = new NAdministrador();
        private NMecanico nMecanico = new NMecanico();
        private NCliente nCliente = new NCliente();
        public FormReporteOrden()
        {
            InitializeComponent();
            MostrarAdministrador(nAdministrador.ListartodoGeneral());
            MostrarCliente(nCliente.ListartodoGeneral());
            MostrarMecanico(nMecanico.ListartodoGeneral());
        }
        private void MostrarAdministrador(List<Administrador> administradores)
        {
            cboBuscarPorAdministrador.DataSource = null;
            if (administradores.Count == 0)
            {
                return;
            }
            else
            {
                cboBuscarPorAdministrador.DataSource = administradores;
                cboBuscarPorAdministrador.ValueMember = "IdAdministrador";
                cboBuscarPorAdministrador.DisplayMember = "Nombre";
            }
        }
        private void MostrarMecanico(List<Mecanico> mecanicos)
        {
            cboBuscarPorMecánico.DataSource = null;
            if (mecanicos.Count == 0)
            {
                return;
            }
            else
            {
                cboBuscarPorMecánico.DataSource = mecanicos;
                cboBuscarPorMecánico.ValueMember = "IdMecanico";
                cboBuscarPorMecánico.DisplayMember = "Nombre";
            }
        }
        private void MostrarCliente(List<Cliente> clientes) 
        {
            cboBuscarPorCliente.DataSource = null;
            if (clientes.Count == 0)
            {
                return;
            }
            else
            {
                cboBuscarPorCliente.DataSource = clientes;
                cboBuscarPorCliente.ValueMember = "IdCliente";
                cboBuscarPorCliente.DisplayMember = "Nombre";
            }
        }
        private void MostrarOrdenes(List<Orden> ordenes)
        {
            dgvOrdenes.DataSource = null;
            if (ordenes.Count == 0)
            {
                return;
            }
            else
            {
                dgvOrdenes.DataSource = ordenes;
                dgvOrdenes.Columns["Administrador"].Visible = false;
                dgvOrdenes.Columns["Mecanico"].Visible = false;
                dgvOrdenes.Columns["Vehiculo"].Visible = false;
            }
        }
        private void btnBuscarOrdenPorFecha_Click(object sender, EventArgs e)
        {
            if (cboBuscarOrdenPorFecha.Text.Trim() == "" || dtpBuscarOrdenesPorFechaMin.Text.Trim() == "" || dtpBuscarOrdenPorFechaMax.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos para buscar una orden por rango de fecha.", "Buscar.");
                return;
            }
            if (dtpBuscarOrdenesPorFechaMin.Value.Date > dtpBuscarOrdenPorFechaMax.Value.Date)
            {
                MessageBox.Show("La fecha máxima debe ser menor a la fecha mínima en un rango de fechas.", "Buscar.");
                return;
            }
            int index = cboBuscarOrdenPorFecha.SelectedIndex;
            DateTime fechaMax = dtpBuscarOrdenPorFechaMax.Value.Date;
            DateTime fechaMin = dtpBuscarOrdenesPorFechaMin.Value.Date;
            MostrarOrdenes(nOrden.BusquedaOrdenesPorFecha(index, fechaMax, fechaMin));
        }

        private void btnBuscarOrdenesPorCostoTotal_Click(object sender, EventArgs e)
        {
            if (txtBuscarOrdenMax.Text.Trim() == "" || txtBuscarOrdenMin.Text.Trim() == "")
            {
                MessageBox.Show("Debe escribir los campos del costo total de la orden para buscar.", "Buscar.");
                return;
            }
            try
            {
                double costoMa = double.Parse(txtBuscarOrdenMax.Text);
                double costoMi = double.Parse(txtBuscarOrdenMin.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los costos totales máximos y mínimos deben ser números de tipo double.", "Buscar.");
                return;
            }
            if (double.Parse(txtBuscarOrdenMax.Text) < double.Parse(txtBuscarOrdenMin.Text))
            {
                MessageBox.Show("El costo total máximo debe ser mayor al costo total mínimo en un rango de costos.", "Buscar.");
                return;
            }
            double costoMax = double.Parse(txtBuscarOrdenMax.Text);
            double costoMin = double.Parse(txtBuscarOrdenMin.Text);
            MostrarOrdenes(nOrden.BusquedaOrdenesPorCostototal(costoMax, costoMin));
        }

        private void btnOrdenarOrden_Click(object sender, EventArgs e)
        {
            if (cboOrdenarOrden.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos para ordenar las órdenes.", "Ordenar.");
                return;
            }
            int index = cboOrdenarOrden.SelectedIndex;
            bool marcado = cbOrdenarOrden.Checked;
            MostrarOrdenes(nOrden.OrdenarOrdenesPorAtributo(index, marcado));
        }

        private void btnBuscarOrdenesPorEstado_Click(object sender, EventArgs e)
        {
            if (cboBuscarOrdenesPorEstado.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos para ordenar las órdenes.", "Ordenar.");
                return;
            }
            string Estado = cboBuscarOrdenesPorEstado.Text;
            MostrarOrdenes(nOrden.BusquedaOrdenesPorEstado(Estado));
        }

        private void btnBuscarPorMecanico_Click(object sender, EventArgs e)
        {
            if (cboBuscarPorMecánico.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos para buscar por mecánicos.", "Reporte.");
                return;
            }
            int idMecanico = int.Parse(cboBuscarPorMecánico.SelectedValue.ToString());
            MostrarOrdenes(nOrden.BusquedaOrdenesPorMecanico(idMecanico));
        }

        private void btnBuscarPorAdministrador_Click(object sender, EventArgs e)
        {
            if (cboBuscarPorAdministrador.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos para buscar por administrador.", "Reporte.");
                return;
            }
            int idAdministrador = int.Parse(cboBuscarPorAdministrador.SelectedValue.ToString());
            MostrarOrdenes(nOrden.BusquedaOrdenesPorAdministrador(idAdministrador));
        }

        private void btnBuscarPorCliente_Click(object sender, EventArgs e)
        {
            if (cboBuscarPorCliente.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos para buscar por clientes.", "Reporte.");
                return;
            }
            int idCliente = int.Parse(cboBuscarPorCliente.SelectedValue.ToString());
            MostrarOrdenes(nOrden.BusquedaOrdenesPorCliente(idCliente));
        }
    }
}
