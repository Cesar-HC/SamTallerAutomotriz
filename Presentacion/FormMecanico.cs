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
    public partial class FormMecanico : Form
    {
        private NEspecialidad nEspecialidad = new NEspecialidad();
        private NMecanico nMecanico = new NMecanico();

        public FormMecanico()
        {
            InitializeComponent();
            MostrarMecanicos(nMecanico.listartodo());
            MostrarEspecialidades(nEspecialidad.ListarTodo());
        }
        private void MostrarEspecialidades(List<TipoEspecialidad> especialidades)
        {
            cboEspecialidad.DataSource = null;
            if (especialidades.Count == 0)
            {
                return;
            }
            else
            {
                cboEspecialidad.DataSource = especialidades;
                cboEspecialidad.ValueMember = "IdEspecialidad";
                cboEspecialidad.DisplayMember = "NombreEspecialidad";
            }
        }
        
        private void MostrarMecanicos(List<Mecanico> mecanicos)
        {
            dgvMecanicos.DataSource = null;
            if (mecanicos.Count == 0)
            {
                return;
            }
            else
            {
                dgvMecanicos.DataSource = mecanicos;
                dgvMecanicos.Columns["Eliminado"].Visible = false;
                dgvMecanicos.Columns["Orden"].Visible = false;
                dgvMecanicos.Columns["TipoEspecialidad"].Visible = false;
            }
        }
       
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text.Trim() == "" || 
                tbApellido.Text.Trim() == "" || 
                tbDni.Text.Trim() == "" ||
                tbEmail.Text.Trim() == "" ||
                tbTelefono.Text.Trim() == "" || 
                cboEspecialidad.Text.Trim() == "" || cboEstadoMecanico.Text.Trim() == "" )
            {
                MessageBox.Show("Debe completar todos los campos para poder registrar un mecanico.", "Registrar.");
                return;
            }
            int idEspecialidad = int.Parse(cboEspecialidad.SelectedValue.ToString());
            Mecanico mecanico = new Mecanico()
            {
                IdEspecialidad = idEspecialidad,
                Nombre = tbNombre.Text,
                Apellido = tbApellido.Text,
                Dni = tbDni.Text,
                Email = tbEmail.Text,
                Telefono = tbTelefono.Text,
                Estado = cboEstadoMecanico.Text,
            };
            string resultado = nMecanico.Registrar(mecanico);
            MessageBox.Show(resultado);
            MostrarMecanicos(nMecanico.listartodo());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvMecanicos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila del datagrid para modificar un mecanico.", "Modificar.");
                return;
            }
            if (tbNombre.Text.Trim() == "" ||
                tbApellido.Text.Trim() == "" ||
                tbDni.Text.Trim() == "" ||
                tbEmail.Text.Trim() == "" ||
                tbTelefono.Text.Trim() == "" ||
                cboEspecialidad.Text.Trim() == "" || cboEstadoMecanico.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos para poder modificar un mecanico.", "Modificar.");
                return;
            }

            
            int idMecanico = int.Parse(dgvMecanicos.SelectedRows[0].Cells[0].Value.ToString());
            int idEspecialidad = int.Parse(cboEspecialidad.SelectedValue.ToString());

            Mecanico mecanico = new Mecanico()
            {
                IdMecanico = idMecanico,
                Nombre = tbNombre.Text,
                Apellido = tbApellido.Text,
                Dni = tbDni.Text,
                Email = tbEmail.Text,
                Telefono = tbTelefono.Text,
                IdEspecialidad = idEspecialidad,
                Estado = cboEstadoMecanico.Text,
            };
            string resultado = nMecanico.Modificar(mecanico);
            MessageBox.Show(resultado);
            MostrarMecanicos(nMecanico.listartodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMecanicos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila del datagrid para eliminar un mecanico.", "Eliminar.");
                return;
            }
            int idMecanico = int.Parse(dgvMecanicos.SelectedRows[0].Cells[0].Value.ToString());
            string eliminado = nMecanico.eliminar(idMecanico);
            MessageBox.Show(eliminado);
            MostrarMecanicos(nMecanico.listartodo());
        }

    }
}
