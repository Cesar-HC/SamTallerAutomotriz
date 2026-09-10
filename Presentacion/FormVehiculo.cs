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
    public partial class FormVehiculo : Form
    {
        private NMarca nMarca = new NMarca();
        private NTipoVehiculo nTipoVehiculo = new NTipoVehiculo();
        private NVehiculo nVehiculo = new NVehiculo();
        private NCliente nCliente = new NCliente();
        public FormVehiculo()
        {
            InitializeComponent();
            MostrarClientes(nCliente.ListarTodo());
            MostrarMarca(nMarca.ListarTodo());
            MostrarTipoVehiculos(nTipoVehiculo.ListarTodo());
            MostrarVehiculos(nVehiculo.ListarTodo());
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
        private void MostrarTipoVehiculos(List<TipoVehiculo> tipoVehiculos)
        {
            cboTipoVehiculo.DataSource = null;
            if (tipoVehiculos.Count == 0)
            {
                return;
            }
            else
            {
                cboTipoVehiculo.DataSource = tipoVehiculos;
                cboTipoVehiculo.ValueMember = "IdTipoVehiculo";
                cboTipoVehiculo.DisplayMember = "NombreTipoVehiculo";
            }
        }
        private void MostrarMarca(List<Marca> marcas)
        {
            cboMarca.DataSource = null;
            if (marcas.Count == 0)
            {
                return;
            }
            else
            {
                cboMarca.DataSource = marcas;
                cboMarca.ValueMember = "IdMarca";
                cboMarca.DisplayMember = "NombreMarca";
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
                dgvVehiculos.Columns["Eliminado"].Visible = false;
                dgvVehiculos.Columns["Cliente"].Visible = false;
                dgvVehiculos.Columns["Marca"].Visible = false;
                dgvVehiculos.Columns["Orden"].Visible = false;
                dgvVehiculos.Columns["TipoVehiculo"].Visible = false;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbAño.Text.Trim() == "" || tbColor.Text.Trim() == "" || cboEstadoVehiculo.Text.Trim() == "" || tbPlaca.Text.Trim() == "" || cboCliente.Text.Trim() == "" || cboMarca.Text.Trim() == "" || cboTipoVehiculo.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos para poder registrar un vehículo.","Registrar.");
                return;
            }
            try
            {
                int anio = int.Parse(tbAño.Text);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("El año debe ser un dato numérico.", "Registrar.");
                return;
            }
            int idMarca = int.Parse(cboMarca.SelectedValue.ToString());
            int idTipoVehiculo = int.Parse(cboTipoVehiculo.SelectedValue.ToString());
            int idCliente = int.Parse(cboCliente.SelectedValue.ToString());
            Vehiculo vehiculo = new Vehiculo() 
            { 
                Año = int.Parse(tbAño.Text), 
                Color = tbColor.Text,
                Estado = cboEstadoVehiculo.Text,
                Placa = tbPlaca.Text,
                IdMarca = idMarca,
                IdTipoVehiculo = idTipoVehiculo,
                IdCliente = idCliente,
            };
            string resultado = nVehiculo.Registrar(vehiculo);
            MessageBox.Show(resultado);
            MostrarVehiculos(nVehiculo.ListarTodo());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila del datagrid para modificar un vehículo.", "Modificar.");
                return;
            }
            if (tbAño.Text.Trim() == "" || tbColor.Text.Trim() == "" || cboEstadoVehiculo.Text.Trim() == "" || tbPlaca.Text.Trim() == "" || cboCliente.Text.Trim() == "" || cboMarca.Text.Trim() == "" || cboTipoVehiculo.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos para poder modificar un vehículo.", "Modificar.");
                return;
            }
            int idMarca = int.Parse(cboMarca.SelectedValue.ToString());
            int idTipoVehiculo = int.Parse(cboTipoVehiculo.SelectedValue.ToString());
            int idVehiculo = int.Parse(dgvVehiculos.SelectedRows[0].Cells[0].Value.ToString());
            int idCliente = int.Parse(cboCliente.SelectedValue.ToString());
            Vehiculo vehiculo = new Vehiculo()
            {
                IdVehiculo = idVehiculo,
                Año = int.Parse(tbAño.Text), //Modificar base de datos porque debe ser entero, no date
                Color = tbColor.Text,
                Estado = cboEstadoVehiculo.Text,
                Placa = tbPlaca.Text,
                IdMarca = idMarca,
                IdTipoVehiculo = idTipoVehiculo,
                IdCliente = idCliente,
            };
            string resultado = nVehiculo.Modificar(vehiculo);
            MessageBox.Show(resultado);
            MostrarVehiculos(nVehiculo.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila del datagrid para eliminar un vehículo.", "Eliminar.");
                return;
            }
            int idVehiculo = int.Parse(dgvVehiculos.SelectedRows[0].Cells[0].Value.ToString());
            string resultado = nVehiculo.Eliminar(idVehiculo);
            MessageBox.Show(resultado);
            MostrarVehiculos(nVehiculo.ListarTodo());
        }

        
    }
}


