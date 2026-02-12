using gestionTareas.DTOs;

namespace gestionTareas.Services
{
    public interface ITareaService
    {
        Task<IEnumerable<TareaDto>> Get();
        Task<TareaDto> GetById(int id);
        Task<TareaDto> Add(TareaInsertDto tareaInsertDto);
        Task<TareaDto> Update(int id, TareaUpdateDto tareaUpdateDto);
        Task<TareaDto> Delete(int id);
    }
}
