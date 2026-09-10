using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NDistrito
    {
        private DDistrito dDistrito = new DDistrito();
        public string Registrar(Distrito distrito)
        {
            distrito.Eliminado = false;
            return dDistrito.Registrar(distrito);
        }
        public string Eliminar(int idDistrito)
        {
            return dDistrito.Eliminar(idDistrito);
        }
        public string Modificar(Distrito distrito)
        {
            return dDistrito.Modificar(distrito);
        }
        public List<Distrito> ListarTodo()
        {
            return dDistrito.ListarTodo();
        }
    }
}
