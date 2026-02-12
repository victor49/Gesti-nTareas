namespace gestionTareas.DTOs
{
    public class TareaInsertDto
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public DateOnly FechaLimite { get; set; }
    }
}
