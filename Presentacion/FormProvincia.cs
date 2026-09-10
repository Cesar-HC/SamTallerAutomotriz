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
    public partial class FormProvincia : Form
    {
        NProvincia nProvincia = new NProvincia();
        public FormProvincia()
        {
            InitializeComponent();
            MostrarProvincias(nProvincia.ListarTodo());
        }
        private void MostrarProvincias(List<Provincia> provincias)
        {
            dgProvincias.DataSource = null;
            if (provincias.Count == 0)
            {
                return;
            }
            else
            {
                dgProvincias.DataSource = provincias;
                dgProvincias.Columns["Eliminado"].Visible = false;
                dgProvincias.Columns["Distrito"].Visible = false;
            }
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbProvincia.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese una provincia");
                return;
            }

            Provincia provincia = new Provincia()
            {
                NombreProvincia = tbProvincia.Text,
            };

            string registrado = nProvincia.Registrar(provincia);
            MessageBox.Show(registrado);
            MostrarProvincias(nProvincia.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgProvincias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para eliminarla");
                return;
            }
            int id_Provincia = int.Parse(dgProvincias.SelectedRows[0].Cells[0].Value.ToString());
            string eliminado = nProvincia.Eliminar(id_Provincia);
            MessageBox.Show(eliminado);
            MostrarProvincias(nProvincia.ListarTodo());
        }

       
    }
}
