using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion2
    {
        private static readonly Conexion2 _instancia = new Conexion2();
        public static Conexion2 Instancia
        {
            get { return Conexion2._instancia; }
        }

        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=.; Initial Catalog =bdProyectoBimbo;" +//"User ID=sa; Password=123"; 
                                "Integrated Security=true";

            return cn;
        }
    }
}
