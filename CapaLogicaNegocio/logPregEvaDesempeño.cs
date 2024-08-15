using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogicaNegocio
{
    public class logPregEvaDesempeño
    {
        #region singleton
        private static readonly logPregEvaDesempeño _instancia = new logPregEvaDesempeño();
        public static logPregEvaDesempeño Instancia
        {
            get { return logPregEvaDesempeño._instancia; }
        }
        #endregion singleton

        #region metodos

        public List<entPregEvaDesempeño> ListarPregEvaDesempeño()
        {
            try
            {
                return datPregEvaDesempeño.Instancia.ListarPregEvaDesempeño();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void InsertarPregEvaDesempeño(entPregEvaDesempeño preg)
        {
            try
            {
                datPregEvaDesempeño.Instancia.InsertarPregEvaDesempeño(preg);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void EliminarPregEvaDesempeño(entPregEvaDesempeño preg)
        {
            datPregEvaDesempeño.Instancia.EliminarPregEvaDesempeño(preg);
        }
        public Boolean EditarPregEvaDesempeño(entPregEvaDesempeño preg)
        {
            try
            {
                return datPregEvaDesempeño.Instancia.EditarPregEvaDesempeño(preg);
            }
            catch (Exception e) { throw e; }
        }
        #endregion metodos
    }
}
