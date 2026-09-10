using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NCliente
    {
        private DCliente dCliente = new DCliente();
        public string Registrar(Cliente cliente)
        {
            cliente.Eliminado = false;
            if (dCliente.Existe(cliente))
            {
                return "El DNI debe ser único.";
            }
            if (cliente.Dni.Length != 8)
            {
                return "El DNI debe tener una longitud de 8 caracteres.";
            }
            return dCliente.Registrar(cliente);
        }
        public string Eliminar(int idCliente)
        {
            return dCliente.Eliminar(idCliente);
        }
        public string Modificar(Cliente cliente)
        {
            return dCliente.Modificar(cliente);
        }
        public List<Cliente> ListarTodo()
        {
            return dCliente.ListarTodo();
        }
        public List<Cliente> BusquedaClientesPorAtributo(int atributo, string text)
        {
            return dCliente.BusquedaClientesPorAtributo(atributo, text);
        }
        public List<Cliente> OrdenarClientesPorAtributo(int atributo, bool marcado)
        {
            return dCliente.OrdenarClientesPorAtributo(atributo, marcado);
        }
        public List<Cliente> MostrarClientesQueSeEncuentrenEliminados()
        {
            return dCliente.MostrarClientesQueSeEncuentrenEliminados();
        }
        public List<Cliente> MostrarClientesQueTenganVehiculos()
        {
            return dCliente.MostrarClientesQueTenganVehiculos();
        }
        public int CantidadDeClientesPorEstadoLibre()
        {
            return dCliente.CantidadDeClientesPorEstadoLibre();
        }
        public int CantidadDeClientesPorEstadoEnObservacion()
        {
            return dCliente.CantidadDeClientesPorEstadoEnObservacion();
        }
        public int CantidadDeClientesPorEstadoRestringido()
        {
            return dCliente.CantidadDeClientesPorEstadoRestringido();   
        }
        public List<Cliente> ListartodoGeneral()
        {
            return dCliente.ListartodoGeneral();
        }
    }
}
