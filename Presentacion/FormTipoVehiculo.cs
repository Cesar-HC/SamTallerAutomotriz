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
    public partial class FormTipoVehiculo : Form
    {
        private NTipoVehiculo nTipoVehiculo = new NTipoVehiculo();
        public FormTipoVehiculo()
        {
            InitializeComponent();
            Mostrar(nTipoVehiculo.ListarTodo());
        }
        private void Mostrar(List<TipoVehiculo> tipoVehiculos)
        {
            dgTipoVehiculo.DataSource = null;
            if (tipoVehiculos.Count == 0)
            {
                return;
            }
            else
            {
                dgTipoVehiculo.DataSource = tipoVehiculos;
                dgTipoVehiculo.Columns["Eliminado"].Visible = false;
                dgTipoVehiculo.Columns["Vehiculo"].Visible = false;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbTipoVehiculo.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar el nombre del tipo de vehículo para registrar.", "Registrar.");
                return;
            }
            TipoVehiculo tipoVehiculo = new TipoVehiculo()
            {
                NombreTipoVehiculo = tbTipoVehiculo.Text,
            };
            string resultado = nTipoVehiculo.Registrar(tipoVehiculo);
            MessageBox.Show(resultado);
            Mostrar(nTipoVehiculo.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgTipoVehiculo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar la fila del datagrid para eliminar el tipo de vehículo.", "Eliminar.");
                return;
            }
            int idTipoVehiculo = int.Parse(dgTipoVehiculo.SelectedRows[0].Cells[0].Value.ToString());
            string resultado = nTipoVehiculo.Eliminar(idTipoVehiculo);
            MessageBox.Show(resultado);
            Mostrar(nTipoVehiculo.ListarTodo());
        }
    }
}
