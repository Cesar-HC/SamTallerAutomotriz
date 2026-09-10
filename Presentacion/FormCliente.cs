using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormCliente : Form
    {
        private NCliente nCliente = new NCliente();
        private NDistrito nDistrito = new NDistrito();
        
        public FormCliente()
        {
            InitializeComponent();
            MostrarDistritos(nDistrito.ListarTodo());
            MostrarClientes(nCliente.ListarTodo());
            cbTipoCliente.DataSource = Enum.GetValues(typeof(ENUMTipoCliente));
            
        }
        private void MostrarDistritos(List<Distrito> distritos)
        {
            cbDistrito.DataSource = null;
            if (distritos.Count == 0)
            {
                return;
            }
            else
            {
                cbDistrito.DataSource = distritos;
                cbDistrito.ValueMember = "IdDistrito";
                cbDistrito.DisplayMember = "NombreDistrito";
            }
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
                dgvClientes.Columns["Eliminado"].Visible = false;
                dgvClientes.Columns["Vehiculo"].Visible = false;
                dgvClientes.Columns["Distrito"].Visible = false;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbApellidos.Text.Trim() == "" || tbDireccion.Text.Trim() == "" || tbDni.Text.Trim() == "" || tbEmail.Text.Trim() == "" || cboEstadoCliente.Text.Trim() == "" || tbNombre.Text.Trim() == "" || tbTelefono.Text.Trim() == "" || cbDistrito.Text.Trim() == "" || cbTipoCliente.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos para registrar un cliente.", "Registrar.");
                return;
            }
            int idDistrito = int.Parse(cbDistrito.SelectedValue.ToString());
            Cliente cliente = new Cliente() 
            { 
                Apellido = tbApellidos.Text,
                Direccion = tbDireccion.Text,
                Dni = tbDni.Text,
                Email = tbEmail.Text,
                Estado = cboEstadoCliente.Text,
                Nombre = tbNombre.Text,
                Telefono = tbTelefono.Text,
                IdDistrito = idDistrito,
                TipoCliente = cbTipoCliente.Text, //Los ENUMS no tienen id, es solo las palabras
            };
            string resultado = nCliente.Registrar(cliente);
            MessageBox.Show(resultado);
            MostrarClientes(nCliente.ListarTodo());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila del datagrid para modificar un cliente.", "Modificar.");
                return;
            }
            if (tbApellidos.Text.Trim() == "" || tbDireccion.Text.Trim() == "" || tbDni.Text.Trim() == "" || tbEmail.Text.Trim() == "" || cboEstadoCliente.Text.Trim() == "" || tbNombre.Text.Trim() == "" || tbTelefono.Text.Trim() == "" || cbDistrito.Text.Trim() == "" || cbTipoCliente.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos para modificar un cliente.", "Modificar.");
                return;
            }
            int idDistrito = int.Parse(cbDistrito.SelectedValue.ToString());
            int idCliente = int.Parse(dgvClientes.SelectedRows[0].Cells[0].Value.ToString());
            Cliente cliente = new Cliente()
            {
                IdCliente = idCliente,
                Apellido = tbApellidos.Text,
                Direccion = tbDireccion.Text,
                Dni = tbDni.Text,
                Email = tbEmail.Text,
                Estado = cboEstadoCliente.Text,
                Nombre = tbNombre.Text,
                Telefono = tbTelefono.Text,
                IdDistrito = idDistrito,
                TipoCliente = cbTipoCliente.Text, //Los ENUMS no tienen id, es solo las palabras
            };
            string resultado = nCliente.Modificar(cliente);
            MessageBox.Show(resultado);
            MostrarClientes(nCliente.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila del datagrid para eliminar un cliente.", "Eliminar.");
                return;
            }
            int idCliente = int.Parse(dgvClientes.SelectedRows[0].Cells[0].Value.ToString());
            string resultado = nCliente.Eliminar(idCliente);
            MessageBox.Show(resultado);
            MostrarClientes(nCliente.ListarTodo());
        }

      
    }
}
