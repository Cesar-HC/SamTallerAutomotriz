using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;

namespace Presentacion
{
    public partial class FormOrden : Form
    {
        private NVehiculo nVehiculo = new NVehiculo();
        private NAdministrador nAdministrador = new NAdministrador();
        private NMecanico nMecanico = new NMecanico();
        private NOrden nOrden = new NOrden();   
        public FormOrden()
        {
            InitializeComponent();
            MostrarOrdenes(nOrden.ListarTodo());
            MostrarAdministrador(nAdministrador.ListarTodo());
            MostrarMecanico(nMecanico.listartodo());
            MostrarVehiculos(nVehiculo.ListarTodo());
            cboTipoServicio.DataSource = Enum.GetValues(typeof(ENUMTipoServicio));
        }
        private void MostrarVehiculos(List<Vehiculo> vehiculos)
        {
            cboVehiculos.DataSource = null;
            if (vehiculos.Count == 0)
            {
                return;
            }
            else
            {
                cboVehiculos.DataSource = vehiculos;
                cboVehiculos.ValueMember = "IdVehiculo";
                cboVehiculos.DisplayMember = "Placa";
            }
        }
        private void MostrarAdministrador(List<Administrador> administradores)
        {
            cboAdministrador.DataSource = null;
            if (administradores.Count == 0)
            {
                return;
            }
            else
            {
                cboAdministrador.DataSource = administradores;
                cboAdministrador.ValueMember = "IdAdministrador";
                cboAdministrador.DisplayMember = "Nombre";
            }
        }
        private void MostrarMecanico(List<Mecanico> mecanicos)
        {
            cboMecanico.DataSource = null;
            if (mecanicos.Count == 0)
            {
                return;
            }
            else
            {
                cboMecanico.DataSource = mecanicos;
                cboMecanico.ValueMember = "IdMecanico";
                cboMecanico.DisplayMember = "Nombre";
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
                dgvOrdenes.Columns["Eliminado"].Visible = false;
                dgvOrdenes.Columns["Administrador"].Visible = false;
                dgvOrdenes.Columns["Mecanico"].Visible = false;
                dgvOrdenes.Columns["Vehiculo"].Visible = false;
            }
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            if (dtpFechaIngreso.Text.Trim() == "" ||
               dtpFechaSalida.Text.Trim() == "" ||
               tbDescripcionServicio.Text.Trim() == "" ||
               tbCostoFinal.Text.Trim() == "" ||
               cboTipoServicio.Text.Trim() == "" ||
               cboAdministrador.Text.Trim() == "" ||
               cboVehiculos.Text.Trim() == "" ||
               cboMecanico.Text.Trim() == "" || 
               cboEstadoOrden.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos para poder registrar una orden.", "Registrar.");
                return;
            }
            try
            {
                double costo = double.Parse(tbCostoFinal.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("El costo total debe ser un dato numérico.", "Registrar.");
                return;
            }
            int idAdministrador = int.Parse(cboAdministrador.SelectedValue.ToString());
            int idVehiculos = int.Parse(cboVehiculos.SelectedValue.ToString());
            int idMecanico = int.Parse(cboMecanico.SelectedValue.ToString());
            Orden orden = new Orden()
            {
                FechaIngreso = dtpFechaIngreso.Value.Date,
                FechaSalida = dtpFechaSalida.Value.Date,
                DescripcionServicio = tbDescripcionServicio.Text,
                CostoTotal = double.Parse(tbCostoFinal.Text),
                TipoServicio = cboTipoServicio.Text,
                IdVehiculo = idVehiculos,
                IdAdministrador = idAdministrador,
                IdMecanico = idMecanico,
                Estado = cboEstadoOrden.Text,
            };
            string resultado = nOrden.Registrar(orden);
            MessageBox.Show(resultado);
            MostrarOrdenes(nOrden.ListarTodo());
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (dtpFechaIngreso.Text.Trim() == "" ||
               dtpFechaSalida.Text.Trim() == "" ||
               tbDescripcionServicio.Text.Trim() == "" ||
               tbCostoFinal.Text.Trim() == "" ||
               cboTipoServicio.Text.Trim() == "" ||
               cboAdministrador.Text.Trim() == "" ||
               cboVehiculos.Text.Trim() == "" ||
               cboMecanico.Text.Trim() == "" ||
               cboEstadoOrden.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos para poder modificar una orden.", "Modificar.");
                return;
            }
            int idAdministrador = int.Parse(cboAdministrador.SelectedValue.ToString());
            int idVehiculos = int.Parse(cboVehiculos.SelectedValue.ToString());
            int idMecanico = int.Parse(cboMecanico.SelectedValue.ToString());
            int idOrden = int.Parse(dgvOrdenes.SelectedRows[0].Cells[0].Value.ToString());
            Orden orden = new Orden()
            {
                IdOrden = idOrden,
                FechaIngreso = dtpFechaIngreso.Value.Date,
                FechaSalida = dtpFechaSalida.Value.Date,
                DescripcionServicio = tbDescripcionServicio.Text,
                CostoTotal = double.Parse(tbCostoFinal.Text),
                TipoServicio = cboTipoServicio.Text,
                IdVehiculo = idVehiculos,
                IdAdministrador = idAdministrador,
                IdMecanico = idMecanico,
                Estado = cboEstadoOrden.Text,
            };

            string resultado = nOrden.Modificar(orden);
            MessageBox.Show(resultado);
            MostrarOrdenes(nOrden.ListarTodo());
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvOrdenes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila del datagrid para eliminar una orden.", "Eliminar.");
                return;
            }
            int idOrden = int.Parse(dgvOrdenes.SelectedRows[0].Cells[0].Value.ToString());
            string resultado = nOrden.Eliminar(idOrden);
            MessageBox.Show(resultado);
            MostrarOrdenes(nOrden.ListarTodo());
        }

        private void dgvOrdenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Orden orden = (Orden)dgvOrdenes.Rows[e.RowIndex].DataBoundItem;
                dtpFechaIngreso.Value = orden.FechaIngreso;
                dtpFechaSalida.Value = orden.FechaSalida;
                tbDescripcionServicio.Text = orden.DescripcionServicio;
                tbCostoFinal.Text = orden.CostoTotal.ToString();
                cboTipoServicio.SelectedItem = orden.TipoServicio;
                cboVehiculos.SelectedValue = orden.IdVehiculo;
                cboAdministrador.SelectedValue = orden.IdAdministrador;
                cboMecanico.SelectedValue = orden.IdMecanico;
                cboEstadoOrden.SelectedItem = orden.Estado.Trim();
            }
        }
    }
}
