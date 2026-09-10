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
    public partial class FormLogin : Form
    {
        
        private NAdministrador nAdministrador = new NAdministrador();

        public FormLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnIngresar;
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            FormRegistrarAdministrador frm = new FormRegistrarAdministrador();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text.Trim();
            string clave = tbContraseña.Text.Trim();


            List<Administrador> listaAdmins = nAdministrador.ListarTodo();
            foreach (Administrador admin in listaAdmins)
            {
                if (admin.Nombre == usuario && admin.Contraseña == clave)
                {
                    MessageBox.Show("Inicio de sesión exitoso", "Login");
                    FormPrincipal form = new FormPrincipal(usuario);
                    form.Show();
                    return; 
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Login");
                    return;
                }
            }
            Application.Exit();
        }

        private void btnRecuperarContraseña_Click(object sender, EventArgs e)
        {
            FormContraseña frm = new FormContraseña();    
            frm.Show();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
