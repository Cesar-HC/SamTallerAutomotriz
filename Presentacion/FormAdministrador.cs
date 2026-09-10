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
    public partial class FormAdministrador : Form
    {
        private NAdministrador nAdministrador = new NAdministrador();

        public FormAdministrador()
        {
            InitializeComponent();
            MostrarAdministrador(nAdministrador.ListarTodo());
        }

        private void MostrarAdministrador(List<Administrador> administrador)
        {
            dgvAdministrador.DataSource = null;
            if (administrador.Count == 0)
            {
                return;
            }
            else
            {
                dgvAdministrador.DataSource = administrador;
                dgvAdministrador.Columns["Contraseña"].Visible = false;
                dgvAdministrador.Columns["Email"].Visible = false;
                dgvAdministrador.Columns["Eliminado"].Visible = false;
                dgvAdministrador.Columns["Orden"].Visible = false;
            }
        }
        private void btnVolverLogin_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            if (tbNombre.Text.Trim() == "" ||
                tbApellido.Text.Trim() == "" ||
                tbDni.Text.Trim() == "" ||
                tbEmail.Text.Trim() == "" ||
                tbTelefono.Text.Trim() == "" ||
                tbContraseña.Text.Trim() == "" ||
                cboEstadoAdministrador.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos para poder registrar un administrador.", "Registrar.");
                return;
            }
            if (tbContraseña.Text != tbContraseñaConfirmacion.Text)
            {
                MessageBox.Show("Las contraseña deben coincidir, ingresela de nuevo", "Registrar.");
                return;
            }
            Administrador administrador = new Administrador()
            {
                Nombre = tbNombre.Text,
                Apellido = tbApellido.Text,
                Dni = tbDni.Text,
                Email = tbEmail.Text,
                Telefono = tbTelefono.Text,
                Contraseña = tbContraseña.Text,
                Estado = cboEstadoAdministrador.Text,
            };
            string resultado = nAdministrador.Registrar(administrador);
            MessageBox.Show(resultado);
            MostrarAdministrador(nAdministrador.ListarTodo());
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvAdministrador.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila del datagrid para eliminar un administrador.", "Eliminar.");
                return;
            }
            int idAdministrador = int.Parse(dgvAdministrador.SelectedRows[0].Cells[0].Value.ToString());
            string resultado = nAdministrador.Eliminar(idAdministrador);
            MessageBox.Show(resultado);
            MostrarAdministrador(nAdministrador.ListarTodo());
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (dgvAdministrador.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila del datagrid para modificar un administrador.", "Modificar.");
                return;
            }
            if (tbNombre.Text.Trim() == "" ||
                tbApellido.Text.Trim() == "" ||
                tbDni.Text.Trim() == "" ||
                tbEmail.Text.Trim() == "" ||
                tbTelefono.Text.Trim() == "" ||
                tbContraseña.Text.Trim() == "" ||
                cboEstadoAdministrador.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos para poder modificar un administrador.", "Modificar.");
                return;
            }
            if (tbContraseña.Text != tbContraseñaConfirmacion.Text)
            {
                MessageBox.Show("Las contraseña deben coincidir, ingresela de nuevo", "Modificar.");
                return;
            }
            int idAdministrador = int.Parse(dgvAdministrador.SelectedRows[0].Cells[0].Value.ToString());
            Administrador administrador = new Administrador()
            {
                IdAdministrador = idAdministrador,
                Nombre = tbNombre.Text,
                Apellido = tbApellido.Text,
                Dni = tbDni.Text,
                Email = tbEmail.Text,
                Telefono = tbTelefono.Text,
                Contraseña = tbContraseña.Text,
                Estado = cboEstadoAdministrador.Text,
            };
            string resultado = nAdministrador.Modificar(administrador);
            MessageBox.Show(resultado);
            MostrarAdministrador(nAdministrador.ListarTodo());
        }
    }
}
