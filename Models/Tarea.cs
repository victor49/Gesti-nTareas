using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestionTareas.Models
{
    public class Tarea
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TareaId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public DateOnly FechaLimite { get; set;}

    }
}
