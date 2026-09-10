using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DVehiculo
    {
        public bool Existe(Vehiculo vehiculo)
        {
            bool existe = false;
            try
            {
                using (var context = new BDEFEntities())
                {
                    existe = context.Vehiculo.Any(v => v.Placa.Contains(vehiculo.Placa));
                }
                return existe;
            }
            catch (Exception ex)
            {
                return existe;
            }
        }
        public string Registrar(Vehiculo vehiculo)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Vehiculo.Add(vehiculo);
                    context.SaveChanges();
                }
                return "Se registró el vehículo exitosamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Eliminar(int idVehiculo)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Vehiculo vehiculo = context.Vehiculo.Find(idVehiculo);
                    vehiculo.Eliminado = true;
                    context.SaveChanges();
                }
                return "Se eliminó el vehículo exitosamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Modificar(Vehiculo vehiculo)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Vehiculo VehiculoTemp = context.Vehiculo.Find(vehiculo.IdVehiculo);
                    VehiculoTemp.Año = vehiculo.Año;
                    VehiculoTemp.Color = vehiculo.Color;
                    VehiculoTemp.Placa = vehiculo.Placa;
                    VehiculoTemp.Estado = vehiculo.Estado;
                    VehiculoTemp.IdTipoVehiculo = vehiculo.IdTipoVehiculo;
                    VehiculoTemp.IdMarca = vehiculo.IdMarca;
                    VehiculoTemp.IdCliente = vehiculo.IdCliente;
                    context.SaveChanges();
                }
                return "Se modificó el vehículo exitosamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Vehiculo> ListarTodo()
        {
            List<Vehiculo> vehiculo = new List<Vehiculo>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    vehiculo = context.Vehiculo.Where(a => a.Eliminado == false && a.Cliente.Eliminado == false).ToList();
                    context.SaveChanges();
                }
                return vehiculo;
            }
            catch (Exception ex)
            {
                return vehiculo;
            }
        }
        public List<Vehiculo> BusquedaVehiculosPorAtributo(int atributo, string text)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    switch (atributo)
                    {
                        case 0:
                            int valor = int.Parse(text);
                            vehiculos = context.Vehiculo.Where(c => c.Año.Equals(valor) && c.Eliminado == false && c.Cliente.Eliminado == false).ToList();
                            break;
                        case 1:
                            vehiculos = context.Vehiculo.Where(c => c.Color.Contains(text) && c.Eliminado == false && c.Cliente.Eliminado == false).ToList();
                            break;
                        case 2:
                            vehiculos = context.Vehiculo.Where(c => c.Placa.Contains(text) && c.Eliminado == false && c.Cliente.Eliminado == false).ToList();
                            break;
                        default:
                            vehiculos = context.Vehiculo.Where(c => c.Estado.Contains(text) && c.Eliminado == false && c.Cliente.Eliminado == false).ToList();
                            break;
                    }
                }
                return vehiculos;
            }
            catch (Exception ex)
            {
                return vehiculos;
            }
        }
        public List<Vehiculo> OrdenarVehiculosPorAtributo(int atributo, bool marcado)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    switch (atributo)
                    {
                        case 0:
                            vehiculos = context.Vehiculo.OrderBy(c => c.Año).Where(c => c.Eliminado == false && c.Cliente.Eliminado == false).ToList();
                            if (marcado)
                            {
                                vehiculos = context.Vehiculo.OrderByDescending(c => c.Año).Where(c => c.Eliminado == false && c.Cliente.Eliminado == false).ToList();
                            }
                            break;
                        case 1:
                            vehiculos = context.Vehiculo.OrderBy(c => c.Color).Where(c => c.Eliminado == false && c.Cliente.Eliminado == false).ToList();
                            if (marcado)
                            {
                                vehiculos = context.Vehiculo.OrderByDescending(c => c.Color).Where(c => c.Eliminado == false && c.Cliente.Eliminado == false).ToList();
                            }
                            break;
                        case 2:
                            vehiculos = context.Vehiculo.OrderBy(c => c.Placa).Where(c => c.Eliminado == false && c.Cliente.Eliminado == false).ToList();
                            if (marcado)
                            {
                                vehiculos = context.Vehiculo.OrderByDescending(c => c.Placa).Where(c => c.Eliminado == false && c.Cliente.Eliminado == false).ToList();
                            }
                            break;
                        default:
                            vehiculos = context.Vehiculo.OrderBy(c => c.Estado).Where(c => c.Eliminado == false && c.Cliente.Eliminado == false).ToList();
                            if (marcado)
                            {
                                vehiculos = context.Vehiculo.OrderByDescending(c => c.Estado).Where(c => c.Eliminado == false && c.Cliente.Eliminado == false).ToList();
                            }
                            break;
                    }
                    return vehiculos;
                }
            }
            catch (Exception ex)
            {
                return vehiculos;
            }
        }
        public List<Vehiculo> MostrarVehiculosConOrdenesPendientes()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    vehiculos = context.Vehiculo.Where(v => v.Eliminado == false && v.Cliente.Eliminado == false && v.Orden.Any(o => o.Estado.Equals("Pendiente"))).ToList();
                    return vehiculos;
                }
            }
            catch (Exception ex)
            {
                return vehiculos;
            }
        }
        public List<Vehiculo> MostrarVehiculosQueTenganOrdenes()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    vehiculos = context.Vehiculo.Where(v => v.Eliminado == false && v.Cliente.Eliminado == false && v.Orden.Count > 0).ToList();
                    return vehiculos;
                }
            }
            catch (Exception ex)
            {
                return vehiculos;
            }
        }
        public List<Vehiculo> MostrarVehiculosPorCliente(int idCLiente)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    vehiculos = context.Vehiculo.Where(v => v.Eliminado == false && v.IdCliente == idCLiente && v.Cliente.Eliminado == false).ToList();
                    return vehiculos;
                }
            }
            catch (Exception ex)
            {
                return vehiculos;
            }
        }
    }
}
