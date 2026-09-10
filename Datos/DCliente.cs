using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCliente
    {
        public bool Existe(Cliente cliente)
        {
            bool existe = false;
            try
            {
                using (var context = new BDEFEntities())
                {
                    existe = context.Cliente.Any(v => v.Dni.Contains(cliente.Dni));
                }
                return existe;
            }
            catch (Exception ex)
            {
                return existe;
            }
        }
        public string Registrar(Cliente cliente)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Cliente.Add(cliente);
                    context.SaveChanges();
                }
                return "El cliente se ha registrado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Eliminar(int id_Cliente)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Cliente cliente = context.Cliente.Find(id_Cliente);
                    cliente.Eliminado = true;
                    context.SaveChanges();
                }
                return "El cliente se ha elimnado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Modificar(Cliente cliente)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Cliente clienteTemp = context.Cliente.Find(cliente.IdCliente);

                    clienteTemp.Nombre = cliente.Nombre;
                    clienteTemp.Apellido = cliente.Apellido;
                    clienteTemp.Dni = cliente.Dni;
                    clienteTemp.Telefono = cliente.Telefono;
                    clienteTemp.Email = cliente.Email;
                    clienteTemp.Direccion = cliente.Direccion;
                    clienteTemp.TipoCliente = cliente.TipoCliente;
                    clienteTemp.Estado = cliente.Estado;
                    clienteTemp.Eliminado = cliente.Eliminado;
                    clienteTemp.IdDistrito = cliente.IdDistrito;
                    clienteTemp.Vehiculo = cliente.Vehiculo;
                    clienteTemp.Distrito = cliente.Distrito;
                    context.SaveChanges();
                }
                return "El cliente se ha modificado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Cliente> ListarTodo()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    clientes = context.Cliente.Where(a => a.Eliminado == false).ToList();
                }
                return clientes;
            }
            catch (Exception ex)
            {
                return clientes;
            }
        }
        public List<Cliente> BusquedaClientesPorAtributo(int atributo, string text)
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    switch (atributo)
                    {
                        case 0:
                            clientes = context.Cliente.Where(c => c.Nombre.Contains(text) && c.Eliminado == false).ToList();
                            break;
                        case 1:
                            clientes = context.Cliente.Where(c => c.Apellido.Contains(text) && c.Eliminado == false).ToList();
                            break;
                        case 2:
                            clientes = context.Cliente.Where(c => c.Dni.Contains(text) && c.Eliminado == false).ToList();
                            break;
                        case 3:
                            clientes = context.Cliente.Where(c => c.Telefono.Contains(text) && c.Eliminado == false).ToList();
                            break;
                        case 4:
                            clientes = context.Cliente.Where(c => c.Email.Contains(text) && c.Eliminado == false).ToList();
                            break;
                        case 5:
                            clientes = context.Cliente.Where(c => c.Direccion.Contains(text) && c.Eliminado == false).ToList();
                            break;
                        default:
                            clientes = context.Cliente.Where(c => c.Estado.Contains(text) && c.Eliminado == false).ToList();
                            break;
                    }
                }
                return clientes;
            }
            catch (Exception ex)
            {
                return clientes;
            }
        }
        public List<Cliente> OrdenarClientesPorAtributo(int atributo, bool marcado)
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    switch (atributo)
                    {
                        case 0:
                            clientes = context.Cliente.OrderBy(c => c.Nombre).Where(c => c.Eliminado == false).ToList();
                            if (marcado)
                            {
                                clientes = context.Cliente.OrderByDescending(c => c.Nombre).Where(c => c.Eliminado == false).ToList();
                            }
                            break;
                        case 1:
                            clientes = context.Cliente.OrderBy(c => c.Apellido).Where(c => c.Eliminado == false).ToList();
                            if (marcado)
                            {
                                clientes = context.Cliente.OrderByDescending(c => c.Apellido).Where(c => c.Eliminado == false).ToList();
                            }
                            break;
                        case 2:
                            clientes = context.Cliente.OrderBy(c => c.Dni).Where(c => c.Eliminado == false).ToList();
                            if (marcado)
                            {
                                clientes = context.Cliente.OrderByDescending(c => c.Dni).Where(c => c.Eliminado == false).ToList();
                            }
                            break;
                        case 3:
                            clientes = context.Cliente.OrderBy(c => c.Telefono).Where(c => c.Eliminado == false).ToList();
                            if (marcado)
                            {
                                clientes = context.Cliente.OrderByDescending(c => c.Telefono).Where(c => c.Eliminado == false).ToList();
                            }
                            break;
                        case 4:
                            clientes = context.Cliente.OrderBy(c => c.Email).Where(c => c.Eliminado == false).ToList();
                            if (marcado)
                            {
                                clientes = context.Cliente.OrderByDescending(c => c.Email).Where(c => c.Eliminado == false).ToList();
                            }
                            break;
                        case 5:
                            clientes = context.Cliente.OrderBy(c => c.Direccion).Where(c => c.Eliminado == false).ToList();
                            if (marcado)
                            {
                                clientes = context.Cliente.OrderByDescending(c => c.Direccion).Where(c => c.Eliminado == false).ToList();
                            }
                            break;
                        default:
                            clientes = context.Cliente.OrderBy(c => c.Estado).Where(c => c.Eliminado == false).ToList();
                            if (marcado)
                            {
                                clientes = context.Cliente.OrderByDescending(c => c.Estado).Where(c => c.Eliminado == false).ToList();
                            }
                            break;
                    }
                }
                return clientes;
            }
            catch (Exception ex)
            {
                return clientes;
            }
        }
        public List<Cliente> MostrarClientesQueSeEncuentrenEliminados()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    clientes = context.Cliente.Where(c => c.Eliminado == true).ToList();
                }
                return clientes;
            }
            catch (Exception ex)
            {
                return clientes;
            }
        }
        public List<Cliente> MostrarClientesQueTenganVehiculos()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    clientes = context.Cliente.Where(c => c.Eliminado == false && c.Vehiculo.Count > 0).ToList();
                }
                return clientes;
            }
            catch (Exception ex)
            {
                return clientes;
            }
        }
        public int CantidadDeClientesPorEstadoLibre()
        {
            int cant = 0;
            foreach (Cliente cliente in ListarTodo())
            {
                if (cliente.Estado.Contains("Libre"))
                {
                    cant++;
                }
            }
            return cant;
        }
        public int CantidadDeClientesPorEstadoEnObservacion()
        {
            int cant = 0;
            foreach (Cliente cliente in ListarTodo())
            {
                if (cliente.Estado.Contains("En Observacion"))
                {
                    cant++;
                }
            }
            return cant;
        }
        public int CantidadDeClientesPorEstadoRestringido()
        {
            int cant = 0;
            foreach (Cliente cliente in ListarTodo())
            {
                if (cliente.Estado.Contains("Restringido"))
                {
                    cant++;
                }
            }
            return cant;
        }
        public List<Cliente> ListartodoGeneral()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    clientes = context.Cliente.ToList();
                }
                return clientes;

            }
            catch (Exception ex)
            {
                return clientes;
            }
        }
    }
}

