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
    public partial class FormEspecialidadMecanico : Form
    {
        NEspecialidad nEspecialidad = new NEspecialidad();  
        public FormEspecialidadMecanico()
        {
            InitializeComponent();
            MostrarEspecialidad(nEspecialidad.ListarTodo());
        }
        private void MostrarEspecialidad(List<TipoEspecialidad> especialidades)
        {
            dgEspecialidadMecanico.DataSource = null;
            if (especialidades.Count == 0)
            {
                return;
            }
            else
            {
                dgEspecialidadMecanico.DataSource = especialidades;
                dgEspecialidadMecanico.Columns["Eliminado"].Visible = false;
                dgEspecialidadMecanico.Columns["Mecanico"].Visible = false;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbEspecialidadMecanico.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar el nombre de la especialidad para registrar.", "Registrar.");
                return;
            }
            TipoEspecialidad especialidad = new TipoEspecialidad()
            {
                NombreEspecialidad = tbEspecialidadMecanico.Text,
            };
            string resultado = nEspecialidad.Registrar(especialidad);
            MessageBox.Show(resultado);
            MostrarEspecialidad(nEspecialidad.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgEspecialidadMecanico.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar la fila del datagrid para eliminar la especialidad.", "Eliminar.");
                return;
            }
            int id_Especialidad = int.Parse(dgEspecialidadMecanico.SelectedRows[0].Cells[0].Value.ToString());
            string resultado = nEspecialidad.Eliminar(id_Especialidad);
            MessageBox.Show(resultado);
            MostrarEspecialidad(nEspecialidad.ListarTodo());
        }
       
    }
}
