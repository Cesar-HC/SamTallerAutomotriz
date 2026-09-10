using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public   class DEspecialidad
    {

        public String Registrar(TipoEspecialidad tipoEspecialidad)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.TipoEspecialidad.Add(tipoEspecialidad);
                    context.SaveChanges();
                }

                return "Tipo de especialidad registrado.";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(TipoEspecialidad tipoEspecialidad)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    TipoEspecialidad temp = context.TipoEspecialidad.Find(tipoEspecialidad.IdEspecialidad);
                    temp.NombreEspecialidad = tipoEspecialidad.NombreEspecialidad;

                    context.SaveChanges();
                }

                return "Tipo de especialidad modificado.";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int idtipo)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    TipoEspecialidad temp = context.TipoEspecialidad.Find(idtipo);
                    temp.Eliminado = true;
                    context.SaveChanges();
                }

                return "Tipo de especialidad eliminado.";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public List<TipoEspecialidad> ListarTodo()
        {
            List<TipoEspecialidad> tipos = new List<TipoEspecialidad>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    tipos = context.TipoEspecialidad.Where(t => t.Eliminado == false).ToList();

                }

                return tipos;

            }
            catch (Exception ex)
            {
                return tipos;
            }

        }

    }
}
