using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NEspecialidad
    {
        private DEspecialidad dEspecialidad = new DEspecialidad();

        public String Registrar(TipoEspecialidad tipoEspecialidad)
        {
            tipoEspecialidad.Eliminado = false;
            return dEspecialidad.Registrar(tipoEspecialidad);
        }

        public String Modificar(TipoEspecialidad tipoEspecialidad)
        {
            return dEspecialidad.Modificar(tipoEspecialidad);
        }

        public String Eliminar(int idtipo)
        {
            return dEspecialidad.Eliminar(idtipo);
        }

        public List<TipoEspecialidad> ListarTodo()
        {
            return dEspecialidad.ListarTodo();
        }
    }
}
