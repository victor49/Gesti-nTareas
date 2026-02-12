using Microsoft.EntityFrameworkCore;

namespace gestionTareas.Models
{
    public class TareaContext : DbContext
    {
        public DbSet<Tarea> Tareas { get; set; }
        public TareaContext(DbContextOptions<TareaContext> options) : base(options) { }
    }
}
