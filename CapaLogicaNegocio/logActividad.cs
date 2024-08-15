using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogicaNegocio
{
    public class logActividad
    {
        private datActividad ActividadDatos;

        public logActividad()
        {
            ActividadDatos = new datActividad();
        }

        public void CrearActividad(entActividad Actividad)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            ActividadDatos.CrearActividad(Actividad);
        }

        public List<entActividad> LeerActividad()
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            return ActividadDatos.LeerActividad();
        }

        public entActividad LeerActividadPorID(int idActividad)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            return ActividadDatos.LeerActividadPorID(idActividad);
        }

        public void ActualizarActividad(entActividad Actividad)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            ActividadDatos.ActualizarActividad(Actividad);
        }

        public void EliminarActividad(int idActividad)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            ActividadDatos.EliminarActividad(idActividad);
        }
    }
}
