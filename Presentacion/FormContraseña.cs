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
    public partial class FormContraseña : Form
    {
        private NAdministrador NAdministrador = new NAdministrador();
        public FormContraseña()
        {
            InitializeComponent();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {

            string nombre = tbUsuario.Text.Trim();
            string correo = tbEmail.Text.Trim();

            List<Administrador> lista = NAdministrador.ListarTodo();

            foreach (Administrador admin in lista)
            {
                if (admin.Nombre == nombre && admin.Email == correo)
                {
                    MessageBox.Show("Tu contraseña es: " + admin.Contraseña, "Recuperación de Contraseña");
                    return;
                }
            }

            MessageBox.Show("No se encontró una cuenta con esos datos.", "Error");
        }
        

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            FormRegistrarAdministrador formRegistrarAdministrador = new FormRegistrarAdministrador();   
            formRegistrarAdministrador.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void FormContraseña_Load(object sender, EventArgs e)
        {

        }
    }
}
