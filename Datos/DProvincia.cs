using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos

{
    public class DProvincia
    {
        public List<Provincia> ListarTodo()
        {
            List<Provincia> provincias = new List<Provincia>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    provincias = context.Provincia.Where(a => a.Eliminado == false).ToList();
                }
                return provincias;
            }
            catch (Exception ex)
            {
                return provincias;
            }
        }
        public string Registrar(Provincia ObjProvincia)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Provincia.Add(ObjProvincia);
                    context.SaveChanges();
                }
                return "La provincia se ha registrado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Eliminar(int id_Provincia)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Provincia provinciaTemp = context.Provincia.Find(id_Provincia);
                    provinciaTemp.Eliminado = true;
                    context.SaveChanges();
                }
                return "La provincia se ha eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Modificar(Provincia objProvincia)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Provincia provinciaTemp = context.Provincia.Find(objProvincia.IdProvincia);
                    provinciaTemp.IdProvincia = objProvincia.IdProvincia;
                    provinciaTemp.NombreProvincia = objProvincia.NombreProvincia;
                    context.SaveChanges();
                }
                return "La provincia se ha modificado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
