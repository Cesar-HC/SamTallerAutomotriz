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
    public partial class FormDistrito : Form
    {
        NDistrito nDistrito = new NDistrito();
        NProvincia nProvincia = new NProvincia();
        public FormDistrito()
        {
            InitializeComponent();
            MostrarProvincias(nProvincia.ListarTodo());
            MostrarDistritos(nDistrito.ListarTodo());
        }


        private void MostrarDistritos(List<Distrito> distritos)
        {
            dgDistrito.DataSource = null;
            if (distritos.Count == 0)
            {
                return;
            }
            else
            {
                dgDistrito.DataSource = distritos;
                dgDistrito.Columns["Eliminado"].Visible = false;
                dgDistrito.Columns["Cliente"].Visible = false;
                dgDistrito.Columns["Provincia"].Visible = false;
            }
        }
        private void MostrarProvincias(List<Provincia> provincias)
        {
            cbProvincias.DataSource = null;
            if (provincias.Count == 0)
            {
                return;
            }
            else
            {
                cbProvincias.DataSource = provincias;
                cbProvincias.ValueMember = "IdProvincia";
                cbProvincias.DisplayMember = "NombreProvincia";
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbProvincias.Text == "" || tbDistrito.Text == "")
            {
                MessageBox.Show("Complete los campos de Provincia y Distrito");
                return;
            }
            int id_Provincia = int.Parse(cbProvincias.SelectedValue.ToString());
            Distrito distrito = new Distrito()
            {
                IdProvincia = id_Provincia,
                NombreDistrito = tbDistrito.Text,
            };
            
            string registrado = nDistrito.Registrar(distrito);
            MessageBox.Show(registrado);
            MostrarDistritos(nDistrito.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgDistrito.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un distrito para eliminarlo");
                return;
            }
            int id_Provincia = int.Parse(dgDistrito.SelectedRows[0].Cells[0].Value.ToString());
            string eliminado = nDistrito.Eliminar(id_Provincia);
            MessageBox.Show(eliminado);
            MostrarDistritos(nDistrito.ListarTodo());
        }
    }
}
