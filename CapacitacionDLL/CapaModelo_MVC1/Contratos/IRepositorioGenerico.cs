using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_MVC1.Contratos
{
    public interface IRepositorioGenerico <Entity> where Entity : class
    {
        int Agregar(Entity Entidad);
        int Editar(Entity Entidad);
        int Remover(Entity Entidad);
        IEnumerable<Entity> GetAll();
    }
}
