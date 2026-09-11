using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_MVC1.Repositorio
{
    public abstract class Sentencias : Conexion
    {
        private DataTable dtTablaDatos; //Establece la tabla de datos para las consultas (lo tengo que cambiar)
        public int EjecucionNonQuery(string _ComandoTexto, List<OdbcParameter> _Parametros, CommandType _ComandoTipo)
        {
            using (var Conexion = ObtenerConexion())
            {
                Conexion.Open();
                using (var ocComando = new OdbcCommand())
                {
                    ocComando.Connection = Conexion;
                    ocComando.CommandText = _ComandoTexto;
                    ocComando.CommandType = _ComandoTipo;
                    ocComando.Parameters.AddRange(_Parametros.ToArray()); //Agregar la conexion de parametros
                    return ocComando.ExecuteNonQuery();
                }
            }
        }
        public DataTable EjecucionConsulta(String _ComandoTexto, CommandType _ComandoTipo)
        {
            dtTablaDatos = new DataTable();
            using (var Conexion = ObtenerConexion())//obtener la conexion a la BD
            {
                Conexion.Open();
                using (var ocComando = new OdbcCommand())
                {
                    ocComando.Connection = Conexion;
                    ocComando.CommandText = _ComandoTexto;
                    ocComando.CommandType = _ComandoTipo;
                    using (var reader = ocComando.ExecuteReader())
                        dtTablaDatos.Load(reader); //llenar la tabla de datos
                }
                return dtTablaDatos; //retorno de la tabla de datos
            }
        }
    }
}
