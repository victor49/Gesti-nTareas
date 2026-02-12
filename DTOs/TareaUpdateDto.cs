namespace gestionTareas.DTOs
{
    public class TareaUpdateDto
    {
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public DateOnly FechaLimite { get; set; }
    }
}
