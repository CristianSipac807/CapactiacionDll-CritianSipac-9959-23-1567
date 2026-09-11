using CapaModelo_MVC1.Contratos;
using CapaModelo_MVC1.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_MVC1.Repositorio
{
    public class RepositorioTipoRuta : Sentencias, IRepositorioTipo_Ruta
    {
        private string selectAll;
        private string Insert;
        private string Update;
        private string Delete;

        public RepositorioTipoRuta()
        {
            selectAll = "SELECT * FROM tipo_ruta";
            Insert = "INSERT INTO tipo_ruta VALUES (?, ?, ?)";
            Update = "UPDATE tipo_ruta SET nombre_tipo_ruta=?, descripcion_tipo_ruta=? WHERE id_tipo_ruta=?";
            Delete = "DELETE FROM tipo_ruta WHERE id_tipo_ruta=?";
        }

        public int Agregar(Tipo_Ruta entidad)
        {
            var _Parametros = new List<OdbcParameter>();
            _Parametros.Add(new OdbcParameter("P_nombreTipoRuta", entidad.nombreTipoRuta));
            _Parametros.Add(new OdbcParameter("P_descripcionTipoRuta", entidad.descripcionTipoRuta));
            return EjecucionNonQuery(Insert, _Parametros, CommandType.Text);
        }

        public int Editar(Tipo_Ruta entidad)
        {
            var _Parametros = new List<OdbcParameter>();
            _Parametros.Add(new OdbcParameter("P_nombreTipoRuta", entidad.nombreTipoRuta));
            _Parametros.Add(new OdbcParameter("P_descripcionTipoRuta", entidad.descripcionTipoRuta));
            _Parametros.Add(new OdbcParameter("P_idTipoRuta", entidad.idTipoRuta));
            return EjecucionNonQuery(Update, _Parametros, CommandType.Text);
        }

        public int Remover(Tipo_Ruta entidad)
        {
            var _Parametros = new List<OdbcParameter>();
            _Parametros.Add(new OdbcParameter("P_idTipoRuta", entidad.idTipoRuta));
            return EjecucionNonQuery(Delete, _Parametros, CommandType.Text);
        }

        public IEnumerable<Tipo_Ruta> GetAll()
        {
            var lstTipoRuta = new List<Tipo_Ruta>();
            var TblTabla = EjecucionConsulta(selectAll, CommandType.Text);
            foreach (DataRow row in TblTabla.Rows)
            {
                var tipoRuta = new Tipo_Ruta();
                tipoRuta.idTipoRuta = Convert.ToInt32(row[0]);
                tipoRuta.nombreTipoRuta = row[1].ToString();
                tipoRuta.descripcionTipoRuta = row[2].ToString();
                lstTipoRuta.Add(tipoRuta);
            }
            TblTabla.Clear();
            TblTabla = null;
            return lstTipoRuta;
        }
    }
}
