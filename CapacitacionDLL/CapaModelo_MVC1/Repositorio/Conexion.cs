using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_MVC1.Repositorio
{
    public class Conexion
    {
        
            public readonly string connectionString;
            public Conexion()
            {
                connectionString = "Dsn=umg_didactica_capacitacion";

            }
            protected OdbcConnection ObtenerConexion()
            {
                return new OdbcConnection(connectionString);
            }
        
    }
}
