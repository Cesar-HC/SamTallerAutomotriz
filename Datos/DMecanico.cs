using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DMecanico
    {
        public String Registrar(Mecanico mecanico)
        {

            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Mecanico.Add(mecanico);
                    context.SaveChanges();
                }
                return "Mecánico registrado correctamente.";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public String Modificar(Mecanico mecanico)
        {

            try
            {
                using (var context = new BDEFEntities())
                {
                    Mecanico temp = context.Mecanico.Find(mecanico.IdMecanico);

                    temp.Nombre = mecanico.Nombre;
                    temp.Apellido = mecanico.Apellido;
                    temp.Dni = mecanico.Dni;
                    temp.Email = mecanico.Email;
                    temp.Telefono = mecanico.Telefono;
                    temp.IdEspecialidad = mecanico.IdEspecialidad;
                    temp.Estado = mecanico.Estado;


                    context.SaveChanges();
                }
                return "Mecanico modificado correctamente";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int idMecanico)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Mecanico temp = context.Mecanico.Find(idMecanico);
                    temp.Eliminado = true;
                    context.SaveChanges();
                }
                return "Mecanico eliminado correctamente";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public List<Mecanico> Listartodo()
        {
            List<Mecanico> mecanicos = new List<Mecanico>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    mecanicos = context.Mecanico.Where(m => m.Eliminado == false).ToList();
                }
                return mecanicos;

            }
            catch (Exception ex)
            {
                return mecanicos;
            }

        }
        public List<Mecanico> ListartodoGeneral()
        {
            List<Mecanico> mecanicos = new List<Mecanico>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    mecanicos = context.Mecanico.ToList();
                }
                return mecanicos;

            }
            catch (Exception ex)
            {
                return mecanicos;
            }
        }
    }
}
