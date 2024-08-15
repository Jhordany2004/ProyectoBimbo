using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogicaNegocio
{
    public class logCronograma
    {
        private datCronograma CronogramaDatos;

        public logCronograma()
        {
            CronogramaDatos = new datCronograma();
        }

        public void CrearCronograma(entCronograma Cronograma)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            CronogramaDatos.CrearCronograma(Cronograma);
        }

        public List<entCronograma> LeerCronograma()
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            return CronogramaDatos.LeerCronograma();
        }

        public entCronograma LeerCronogramaPorID(int idCronograma)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            return CronogramaDatos.LeerCronogramaPorID(idCronograma);
        }

        public void ActualizarCronograma(entCronograma Cronograma)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            CronogramaDatos.ActualizarCronograma(Cronograma);
        }

        public void EliminarCronograma(int idCronograma)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            CronogramaDatos.EliminarCronograma(idCronograma);
        }
    }
}
