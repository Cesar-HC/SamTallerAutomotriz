using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NVehiculo
    {
        private DVehiculo dVehiculo = new DVehiculo();
        public string Registrar(Vehiculo vehiculo)
        {
            vehiculo.Eliminado = false;
            if (dVehiculo.Existe(vehiculo))
            {
                return "La placa del vehículo debe ser única.";
            }
            if (vehiculo.Año < 0 || vehiculo.Año > 9999)
            {
                return "El año debe encontrarse en el intervalo entre 0 a 9999.";
            }
            return dVehiculo.Registrar(vehiculo);
        }
        public string Eliminar(int idVehiculo)
        {
            return dVehiculo.Eliminar(idVehiculo);
        }
        public string Modificar(Vehiculo vehiculo)
        {
            return dVehiculo.Modificar(vehiculo);
        }
        public List<Vehiculo> ListarTodo()
        {
            return dVehiculo.ListarTodo();
        }
        public List<Vehiculo> BusquedaVehiculosPorAtributo(int atributo, string text)
        {
            return dVehiculo.BusquedaVehiculosPorAtributo(atributo, text);
        }
        public List<Vehiculo> OrdenarVehiculosPorAtributo(int atributo, bool marcado)
        {
            return dVehiculo.OrdenarVehiculosPorAtributo(atributo, marcado);
        }
        public List<Vehiculo> MostrarVehiculosConOrdenesPendientes()
        {
            return dVehiculo.MostrarVehiculosConOrdenesPendientes();
        }
        public List<Vehiculo> MostrarVehiculosQueTenganOrdenes()
        {
            return dVehiculo.MostrarVehiculosQueTenganOrdenes();
        }
        public List<Vehiculo> MostrarVehiculosPorCliente(int idCLiente)
        {
            return dVehiculo.MostrarVehiculosPorCliente(idCLiente);
        }
    }
}
