using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NMarca
    {
        private DMarca dMarca = new DMarca();
        public string Registrar(Marca marca)
        {
            marca.Eliminado = false;
            return dMarca.Registrar(marca);
        }
        public string Eliminar(int idMarca)
        {
            return dMarca.Eliminar(idMarca);
        }
        public string Modificar(Marca marca)
        {
            return dMarca.Modificar(marca);
        }
        public List<Marca> ListarTodo()
        {
            return dMarca.ListarTodo();
        }
    }
}
