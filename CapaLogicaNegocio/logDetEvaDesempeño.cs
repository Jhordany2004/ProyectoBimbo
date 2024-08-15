using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogicaNegocio
{
    public class logDetEvaDesempeño
    {
        #region singleton
        private static readonly logDetEvaDesempeño _instancia = new logDetEvaDesempeño();
        public static logDetEvaDesempeño Instancia
        {
            get { return logDetEvaDesempeño._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entDetEvaDesempeño> ListarDetEvaDesempeño()
        {
            try
            {
                return datDetEvaDesempeño.Instancia.ListarDetEvaDesempeño();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void InsertarDetEvaDesempeño(entDetEvaDesempeño det)
        {
            try
            {
                datDetEvaDesempeño.Instancia.InsertarDetEvaDesempeño(det);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public Boolean EditarDetEvaDesempeño(entDetEvaDesempeño det)
        {
            try
            {
                return datDetEvaDesempeño.Instancia.EditarDetEvaDesempeño(det);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion metodos
    }
}
