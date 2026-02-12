using gestionTareas.Models;
using Microsoft.EntityFrameworkCore;

namespace gestionTareas.Repository
{
    public class TareaRepository : ITareaRepository
    {
        TareaContext _context;

        public TareaRepository(TareaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Tarea>> Get()
            => await _context.Tareas.ToListAsync();

        public async Task<Tarea> GetById(int id)
            => await _context.Tareas.FindAsync(id);
        public async Task Add(Tarea tarea)
            => await _context.Tareas.AddAsync(tarea);
        public void Update(Tarea tarea)
        {
            _context.Tareas.Attach(tarea);
            _context.Tareas.Entry(tarea).State = EntityState.Modified;
        }
        public void Delete(Tarea tarea)
            => _context.Tareas.Remove(tarea);
        public async Task Save()
            => await _context.SaveChangesAsync();
    }
}
