using CapaControlador_MVC1.Objetos_de_valor.EstadoEntidad;
using CapaModelo_MVC1.Entidades;
using CapaModelo_MVC1.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace CapaControlador_MVC1.Modelos_de_controladores
{
    public class ModeloTipo_Ruta
    {
        private int _idTipoRuta;
        private string _nombreTipoRuta;
        private string _descripcionTipoRuta;
        private RepositorioTipoRuta RepositorioTipoRuta;

        public EstadoEntidad Estado { private get; set; }
        private List<ModeloTipo_Ruta> ListaTipoRuta;

        // Autoincremental
        public int IdTipoRuta { get => _idTipoRuta; set => _idTipoRuta = value; }

        [Required(ErrorMessage = "El campo Nombre de Tipo de Ruta es requerido")]
        [RegularExpression("^[a-zA-Zá-ú\\s]+$", ErrorMessage = "El campo Nombre debe ser solo letras")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "El campo Nombre debe tener entre 10 y 100 caracteres")]
        public string NombreTipoRuta { get => _nombreTipoRuta; set => _nombreTipoRuta = value; }

        [Required(ErrorMessage = "El campo Descripción de Rol es requerido")]
        [RegularExpression("^[a-zA-Zá-ú\\s]+$", ErrorMessage = "El campo Descripción debe ser solo letras")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "El campo Descripción debe tener entre 10 y 100 caracteres")]
        public string DescripcionTipoRuta { get => _descripcionTipoRuta; set => _descripcionTipoRuta = value; }

        public ModeloTipo_Ruta()
        {
            RepositorioTipoRuta = new RepositorioTipoRuta();
        }

        public string GrabarCambios()
        {
            string mensaje = null;
            try
            {
                if (Estado == EstadoEntidad.Modified || Estado == EstadoEntidad.Deleted)
                {
                    if (_idTipoRuta <= 0)
                        return "Debe indicar un Tipo de Ruta válido para esta operación";
                }

                var modeloDatosTipoRuta = new Tipo_Ruta();
                modeloDatosTipoRuta.idTipoRuta = _idTipoRuta;
                modeloDatosTipoRuta.nombreTipoRuta = _nombreTipoRuta;
                modeloDatosTipoRuta.descripcionTipoRuta = _descripcionTipoRuta;

                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        RepositorioTipoRuta.Agregar(modeloDatosTipoRuta);
                        mensaje = "Grabacion exitosa";
                        break;
                    case EstadoEntidad.Modified:
                        RepositorioTipoRuta.Editar(modeloDatosTipoRuta);
                        mensaje = "Actualizacion exitosa";
                        break;
                    case EstadoEntidad.Deleted:
                        RepositorioTipoRuta.Remover(modeloDatosTipoRuta);
                        mensaje = "Eliminacion exitosa";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
            }
            return mensaje;
        }

        public List<ModeloTipo_Ruta> GetAll()
        {
            var modeloDatosTipoRuta = RepositorioTipoRuta.GetAll();
            ListaTipoRuta = new List<ModeloTipo_Ruta>();
            foreach (Tipo_Ruta item in modeloDatosTipoRuta)
            {
                ListaTipoRuta.Add(new ModeloTipo_Ruta
                {
                    _idTipoRuta = item.idTipoRuta,
                    _nombreTipoRuta = item.nombreTipoRuta,
                    _descripcionTipoRuta = item.descripcionTipoRuta
                });
            }
            return ListaTipoRuta;
        }

        public IEnumerable<ModeloTipo_Ruta> FindbyId(int idTipoRuta)
        {
            return ListaTipoRuta.FindAll(e => e._idTipoRuta == idTipoRuta);
        }
    }
}
