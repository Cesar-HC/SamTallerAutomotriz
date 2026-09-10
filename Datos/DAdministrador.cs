using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAdministrador
    {
        public String Registrar(Administrador administrador)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Administrador.Add(administrador);
                    context.SaveChanges();
                }
                return "Administrador registrado correctamente.";
            }
            catch (Exception ex)
            {
                string mensaje = "Error: " + ex.Message;
                Exception actual = ex.InnerException;
                while (actual != null)
                {
                    mensaje += "\n-> Causa: " + actual.Message;
                    actual = actual.InnerException;
                }
                return mensaje;
            }
        }

        public String Modificar(Administrador administrador)
        {

            try
            {
                using (var context = new BDEFEntities())
                {
                    Administrador temp = context.Administrador.Find(administrador.IdAdministrador);

                    temp.Nombre = administrador.Nombre;
                    temp.Apellido = administrador.Apellido;
                    temp.Dni = administrador.Dni;
                    temp.Email = administrador.Email;
                    temp.Telefono = administrador.Telefono;
                    temp.Contraseña = administrador.Contraseña;
                    temp.Estado = administrador.Estado;


                    context.SaveChanges();
                }
                return "Administrador modificado correctamente.";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int idAdministrador)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Administrador temp = context.Administrador.Find(idAdministrador);
                    temp.Eliminado = true;
                    context.SaveChanges();
                }
                return "Administrador eliminado correctamente.";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public List<Administrador> Listartodo()
        {
            List<Administrador> administradors = new List<Administrador>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    administradors = context.Administrador.Where(m => m.Eliminado == false).ToList();
                }
                return administradors;

            }
            catch (Exception ex)
            {
                return administradors;
            }

        }
        public List<Administrador> ListartodoGeneral()
        {
            List<Administrador> administradors = new List<Administrador>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    administradors = context.Administrador.ToList();
                }
                return administradors;

            }
            catch (Exception ex)
            {
                return administradors;
            }

        }
    }
}
