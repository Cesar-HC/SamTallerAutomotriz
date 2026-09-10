using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DDistrito
    {
        public List<Distrito> ListarTodo()
        {
            List<Distrito> distritos = new List<Distrito>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    distritos = context.Distrito.Where(a => a.Eliminado == false).ToList();
                }
                return distritos;
            }
            catch (Exception ex)
            {
                return distritos;
            }
        }
        public string Registrar(Distrito ObjDistrito)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Distrito.Add(ObjDistrito);
                    context.SaveChanges();
                }
                return "La distrito se ha registrado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Eliminar(int id_Distrito)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Distrito distritoTemp = context.Distrito.Find(id_Distrito);
                    distritoTemp.Eliminado = true;
                    context.SaveChanges();
                }
                return "La distrito se ha eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Modificar(Distrito objDistrito)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Distrito distritoTemp = context.Distrito.Find(objDistrito.IdDistrito);
                    distritoTemp.IdDistrito = objDistrito.IdDistrito;
                    distritoTemp.NombreDistrito = objDistrito.NombreDistrito;
                    distritoTemp.IdProvincia = objDistrito.IdProvincia;
                    context.SaveChanges();
                }
                return "La distrito se ha modificado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
