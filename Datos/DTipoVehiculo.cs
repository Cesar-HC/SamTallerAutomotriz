using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DTipoVehiculo
    {
        public string Registrar(TipoVehiculo tipoVehiculo)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.TipoVehiculo.Add(tipoVehiculo);
                    context.SaveChanges();
                }
                return "Se registró el tipo del vehículo exitosamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Eliminar(int idTipoVehiculo)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    TipoVehiculo tipoVehiculo = context.TipoVehiculo.Find(idTipoVehiculo);
                    tipoVehiculo.Eliminado = true;
                    context.SaveChanges();
                }
                return "Se eliminó el tipo del vehículo exitosamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Modificar(TipoVehiculo tipoVehiculo)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    TipoVehiculo tipoVehiculoTemp = context.TipoVehiculo.Find(tipoVehiculo.IdTipoVehiculo);
                    tipoVehiculoTemp.NombreTipoVehiculo = tipoVehiculo.NombreTipoVehiculo;
                    context.SaveChanges();
                }
                return "Se modificó el tipo del vehículo exitosamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<TipoVehiculo> ListarTodo()
        {
            List<TipoVehiculo> tipoVehiculo = new List<TipoVehiculo>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    tipoVehiculo = context.TipoVehiculo.Where(a => a.Eliminado == false).ToList();
                    context.SaveChanges();
                }
                return tipoVehiculo;
            }
            catch (Exception ex)
            {
                return tipoVehiculo;
            }
        }
    }

    
}
