using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NProvincia
    {
        private DProvincia dProvincia = new DProvincia();
        public string Registrar(Provincia provincia)
        {
            provincia.Eliminado = false;
            return dProvincia.Registrar(provincia);
        }
        public string Eliminar(int idProvincia)
        {
            return dProvincia.Eliminar(idProvincia);
        }
        public string Modificar(Provincia provincia)
        {
            return dProvincia.Modificar(provincia);
        }
        public List<Provincia> ListarTodo()
        {
            return dProvincia.ListarTodo();
        }
    }
}
