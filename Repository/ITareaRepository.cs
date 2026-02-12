using gestionTareas.Models;

namespace gestionTareas.Repository
{
    public interface ITareaRepository
    {
        Task<IEnumerable<Tarea>> Get();
        Task<Tarea> GetById(int id);
        Task Add(Tarea tarea);
        void Update(Tarea tarea);
        void Delete(Tarea tarea);
        Task Save();
    }
}
