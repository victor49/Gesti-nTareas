using FluentValidation;
using gestionTareas.DTOs;

namespace gestionTareas.Validators
{
    public class TareaInsertValidator : AbstractValidator<TareaInsertDto>
    {
        public TareaInsertValidator() 
        {
            RuleFor(x => x.Titulo).NotEmpty().WithMessage("El tiiitulo es obligatorio");
        }
    }
}
