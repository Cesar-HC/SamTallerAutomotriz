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
    public partial class FormRegistrarAdministrador : Form
    {

        private NAdministrador nAdministrador = new NAdministrador();   

        public FormRegistrarAdministrador()
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
                dgvAdministrador.Columns["Estado"].Visible = false;
                dgvAdministrador.Columns["Dni"].Visible = false;
                dgvAdministrador.Columns["Telefono"].Visible = false;
                dgvAdministrador.Columns["Orden"].Visible = false;
                dgvAdministrador.Columns["Eliminado"].Visible = false;

            }
        }
        
        private void btnRegistrar_Click(object sender, EventArgs e)
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

        private void btnVolverLogin_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
        }

       

    }
}
