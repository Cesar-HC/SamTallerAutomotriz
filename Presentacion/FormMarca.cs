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
    public partial class FormMarca : Form
    {
        private NMarca nMarca = new NMarca();
        public FormMarca()
        {
            InitializeComponent();
            Mostrar(nMarca.ListarTodo());
        }
        private void Mostrar(List<Marca> marcas)
        {
            dgMarca.DataSource = null;
            if (marcas.Count == 0)
            {
                return;
            }
            else
            {
                dgMarca.DataSource = marcas;
                dgMarca.Columns["Eliminado"].Visible = false;
                dgMarca.Columns["Vehiculo"].Visible = false;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbMarca.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar el nombre de la marca para registrar.", "Registrar.");
                return;
            }
            Marca marca = new Marca()
            {
                NombreMarca = tbMarca.Text,
            };
            string resultado = nMarca.Registrar(marca);
            MessageBox.Show(resultado);
            Mostrar(nMarca.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgMarca.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar la fila del datagrid para eliminar la marca.", "Eliminar.");
                return;
            }
            int idMarca = int.Parse(dgMarca.SelectedRows[0].Cells[0].Value.ToString());
            string resultado = nMarca.Eliminar(idMarca);
            MessageBox.Show(resultado);
            Mostrar(nMarca.ListarTodo());
        }
    }
}
