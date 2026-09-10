using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NMecanico
    {
        private DMecanico dMecanico = new DMecanico();

        public String Registrar(Mecanico mecanico)
        {
            mecanico.Eliminado = false;
            if (mecanico.Dni.Length != 8)
            {
                return "El DNI debe tener una longitud de 8 caracteres.";
            }
            return dMecanico.Registrar(mecanico);
        }

        public String Modificar(Mecanico mecanico)
        {
            return dMecanico.Modificar(mecanico);
        }

        public String eliminar(int idMcanico)
        {
            return dMecanico.Eliminar(idMcanico);
        }

        public List<Mecanico> listartodo()
        {
            return dMecanico.Listartodo();
        }
        public List<Mecanico> ListartodoGeneral()
        {
            return dMecanico.ListartodoGeneral();
        }
    }
}


