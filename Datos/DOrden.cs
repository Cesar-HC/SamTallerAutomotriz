using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Datos
{
    public  class DOrden
    {
        public string Registrar(Orden orden)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var vehiculos = context.Vehiculo.Include(v => v.Cliente).Where(v => v.IdVehiculo == orden.IdVehiculo).ToList();
                    var vehiculo = vehiculos[0];
                    if (vehiculo.Cliente.TipoCliente.Contains("Vip"))
                    {
                        orden.CostoTotal = orden.CostoTotal - orden.CostoTotal * 0.30; 
                    }
                    else if (vehiculo.Cliente.TipoCliente.Contains("Empresa"))
                    {
                        orden.CostoTotal = orden.CostoTotal - orden.CostoTotal * 0.10;
                    }
                    else if (vehiculo.Cliente.TipoCliente.Contains("Convenio"))
                    {
                        orden.CostoTotal = orden.CostoTotal - orden.CostoTotal * 0.18;
                    }
                    context.Orden.Add(orden);
                    context.SaveChanges();
                }
                return "Se registró la orden exitosamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Eliminar(int idOrden)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Orden orden = context.Orden.Find(idOrden);
                    orden.Eliminado = true;
                    context.SaveChanges();
                }
                return "Se eliminó la orden exitosamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Modificar(Orden orden)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Orden OrdenTemp = context.Orden.Find(orden.IdOrden);
                    OrdenTemp.FechaIngreso = orden.FechaIngreso;
                    OrdenTemp.FechaSalida = orden.FechaSalida;
                    OrdenTemp.DescripcionServicio = orden.DescripcionServicio;
                    OrdenTemp.Estado = orden.Estado;
                    OrdenTemp.CostoTotal = orden.CostoTotal;
                    OrdenTemp.IdAdministrador = orden.IdAdministrador;
                    OrdenTemp.IdMecanico = orden.IdMecanico;
                    OrdenTemp.IdAdministrador = orden.IdAdministrador;
                    OrdenTemp.TipoServicio = orden.TipoServicio;    
                    context.SaveChanges();
                }
                return "Se modificó la orden exitosamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Orden> ListarTodo()
        {
            List<Orden> orden = new List<Orden>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    orden = context.Orden.Where(a => a.Eliminado == false && a.Estado != "Finalizada").ToList();
                    context.SaveChanges();
                }
                return orden;
            }
            catch (Exception ex)
            {
                return orden;
            }
        }
        public List<Orden> BusquedaOrdenesPorFecha(int atributo, DateTime fechaMax, DateTime fechaMin)
        {
            List<Orden> ordenes = new List<Orden>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    switch (atributo)
                    {
                        case 0:
                            ordenes = context.Orden.Where(c => c.FechaIngreso >= fechaMin && c.FechaIngreso <= fechaMax && c.Eliminado == false).ToList();
                            break;
                        default:
                            ordenes = context.Orden.Where(c => c.FechaSalida >= fechaMin && c.FechaSalida <= fechaMax && c.Eliminado == false).ToList();
                            break;
                    }
                }
                return ordenes;
            }
            catch (Exception ex)
            {
                return ordenes;
            }
        }
        public List<Orden> BusquedaOrdenesPorCostototal(double costoMax, double costoMin)
        {
            List<Orden> ordenes = new List<Orden>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    ordenes = context.Orden.Where(o => o.CostoTotal >= costoMin && o.CostoTotal <= costoMax && o.Eliminado == false).ToList();
                }
                return ordenes;
            }
            catch (Exception ex)
            {
                return ordenes;
            }
        }
        public List<Orden> BusquedaOrdenesPorEstado(string estado)
        {
            List<Orden> ordenes = new List<Orden>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    ordenes = context.Orden.Where(o => o.Estado.Contains(estado) && o.Eliminado == false).ToList();
                }
                return ordenes;
            }
            catch (Exception ex)
            {
                return ordenes;
            }
        }
        public List<Orden> OrdenarOrdenesPorAtributo(int atributo, bool marcado)
        {
            List<Orden> ordenes = new List<Orden>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    switch (atributo)
                    {
                        case 0:
                            ordenes = context.Orden.OrderBy(c => c.FechaIngreso).Where(c => c.Eliminado == false).ToList();
                            if (marcado)
                            {
                                ordenes = context.Orden.OrderByDescending(c => c.FechaIngreso).Where(c => c.Eliminado == false).ToList();
                            }
                            break;
                        case 1:
                            ordenes = context.Orden.OrderBy(c => c.FechaSalida).Where(c => c.Eliminado == false).ToList();
                            if (marcado)
                            {
                                ordenes = context.Orden.OrderByDescending(c => c.FechaSalida).Where(c => c.Eliminado == false).ToList();
                            }
                            break;
                        case 2:
                            ordenes = context.Orden.OrderBy(c => c.CostoTotal).Where(c => c.Eliminado == false).ToList();
                            if (marcado)
                            {
                                ordenes = context.Orden.OrderByDescending(c => c.CostoTotal).Where(c => c.Eliminado == false).ToList();
                            }
                            break;
                        default:
                            ordenes = context.Orden.OrderBy(c => c.Estado).Where(c => c.Eliminado == false).ToList();
                            if (marcado)
                            {
                                ordenes = context.Orden.OrderByDescending(c => c.Estado).Where(c => c.Eliminado == false).ToList();
                            }
                            break;
                    }
                    return ordenes;
                }
            }
            catch (Exception ex)
            {
                return ordenes;
            }
        }
        public List<Orden> BusquedaOrdenesPorAdministrador(int idAdministrador)
        {
            List<Orden> ordenes = new List<Orden>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    ordenes = context.Orden.Where(o => o.Eliminado == false && o.IdAdministrador.Equals(idAdministrador)).ToList();
                }
                return ordenes;
            }
            catch (Exception ex)
            {
                return ordenes;
            }
        }
        public List<Orden> BusquedaOrdenesPorMecanico(int idMecanico)
        {
            List<Orden> ordenes = new List<Orden>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    ordenes = context.Orden.Where(o => o.Eliminado == false && o.IdMecanico.Equals(idMecanico)).ToList();
                }
                return ordenes;
            }
            catch (Exception ex)
            {
                return ordenes;
            }
        }
        public List<Orden> BusquedaOrdenesPorCliente(int idCliente)
        {
            List<Orden> ordenes = new List<Orden>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    ordenes = context.Orden.Where(o => o.Eliminado == false && o.Vehiculo.IdCliente.Equals(idCliente)).ToList();
                }
                return ordenes;
            }
            catch (Exception ex)
            {
                return ordenes;
            }
        }
    }
}
