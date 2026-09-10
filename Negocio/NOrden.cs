using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NOrden
    {
        private DOrden dOrden = new DOrden();
        public string Registrar(Orden orden)
        {
            orden.Eliminado = false;
            if (orden.FechaIngreso >= orden.FechaSalida)
            {
                return "La fecha de ingreso debe ser menor a la fecha de salida.";
            }
            if (orden.CostoTotal < 0)
            {
                return "El costo no puede ser un valor negativo.";
            }
            return dOrden.Registrar(orden);
        }
        public string Eliminar(int idOrden)
        {
            return dOrden.Eliminar(idOrden);
        }
        public string Modificar(Orden orden)
        {
            return dOrden.Modificar(orden);
        }
        public List<Orden> ListarTodo()
        {
            return dOrden.ListarTodo();
        }
        public List<Orden> BusquedaOrdenesPorFecha(int atributo, DateTime fechaMax, DateTime fechaMin)
        {
            return dOrden.BusquedaOrdenesPorFecha(atributo, fechaMax, fechaMin);
        }
        public List<Orden> BusquedaOrdenesPorCostototal(double costoMax, double costoMin)
        {
            return dOrden.BusquedaOrdenesPorCostototal(costoMax, costoMin);
        }
        public List<Orden> BusquedaOrdenesPorEstado(string estado)
        {
            return dOrden.BusquedaOrdenesPorEstado(estado);
        }
        public List<Orden> OrdenarOrdenesPorAtributo(int atributo, bool marcado)
        {
            return dOrden.OrdenarOrdenesPorAtributo(atributo, marcado);
        }
        public List<Orden> BusquedaOrdenesPorAdministrador(int idAdministrador)
        {
            return dOrden.BusquedaOrdenesPorAdministrador(idAdministrador);
        }
        public List<Orden> BusquedaOrdenesPorMecanico(int idMecanico)
        {
            return dOrden.BusquedaOrdenesPorMecanico(idMecanico);
        }
        public List<Orden> BusquedaOrdenesPorCliente(int idCliente)
        {
            return dOrden.BusquedaOrdenesPorCliente(idCliente);
        }
    }
}
