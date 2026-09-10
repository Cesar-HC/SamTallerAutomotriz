using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NAdministrador
    {
        private DAdministrador dAdministrador = new DAdministrador();
        public string Registrar(Administrador administrador)
        {
            administrador.Eliminado = false;
            if (administrador.Dni.Length != 8)
            {
                return "El DNI debe tener una longitud de 8 caracteres.";
            }
            return dAdministrador.Registrar(administrador);
        }
        public string Eliminar(int idAdministrador)
        {
            return dAdministrador.Eliminar(idAdministrador);
        }
        public string Modificar(Administrador administrador)
        {
            return dAdministrador.Modificar(administrador);
        }
        public List<Administrador> ListarTodo()
        {
            return dAdministrador.Listartodo();
        }
        public List<Administrador> ListartodoGeneral()
        {
            return dAdministrador.ListartodoGeneral();
        }
    }
}
