using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NTipoVehiculo
    {
        private DTipoVehiculo dTipoVehiculo = new DTipoVehiculo();
        public string Registrar(TipoVehiculo tipoVehiculo)
        {
            tipoVehiculo.Eliminado = false;
            return dTipoVehiculo.Registrar(tipoVehiculo);
        }
        public string Eliminar(int idTipoVehiculo)
        {
            return dTipoVehiculo.Eliminar(idTipoVehiculo);
        }
        public string Modificar(TipoVehiculo tipoVehiculo)
        {
            return dTipoVehiculo.Modificar(tipoVehiculo);
        }
        public List<TipoVehiculo> ListarTodo()
        {
            return dTipoVehiculo.ListarTodo();
        }
    }
}
