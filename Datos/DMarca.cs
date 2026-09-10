using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DMarca
    {
        public string Registrar(Marca marca)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Marca.Add(marca);
                    context.SaveChanges();
                }
                return "Se registró la marca exitosamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Eliminar(int idMarca)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Marca marca = context.Marca.Find(idMarca);
                    marca.Eliminado = true;
                    context.SaveChanges();
                }
                return "Se eliminó la marca exitosamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Modificar(Marca marca)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Marca marcaTemp = context.Marca.Find(marca.IdMarca);
                    marcaTemp.NombreMarca = marca.NombreMarca;
                    context.SaveChanges();
                }
                return "Se modificó la marca exitosamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Marca> ListarTodo()
        {
            List<Marca> marca = new List<Marca>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    marca = context.Marca.Where(a => a.Eliminado == false).ToList();
                    context.SaveChanges();
                }
                return marca;
            }
            catch (Exception ex)
            {
                return marca;
            }
        }
    }
}
