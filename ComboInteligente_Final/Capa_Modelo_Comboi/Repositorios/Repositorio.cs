using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_Comboi.Repositorios
{
    public class Repositorio
    {
        public readonly string connectionString;
        public Repositorio()
        {
            connectionString = "Dsn=umg_didactica_capacitacion";

        }
        protected OdbcConnection ObtenerConexion()
        {
            return new OdbcConnection(connectionString);
        }

    }
}
