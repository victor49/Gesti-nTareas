
namespace gestionTareas.DTOs
{
    public class TareaDto
    {
        public int TareaId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public DateOnly FechaLimite { get; set; }
    }
}
