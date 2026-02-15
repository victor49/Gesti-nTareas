using AutoMapper;
using gestionTareas.DTOs;
using gestionTareas.Models;
using gestionTareas.Repository;

namespace gestionTareas.Services
{
    public class TareaService : ITareaService
    {
        ITareaRepository _tareaRepository;

        //Mappers
        private readonly IMapper _mapper;

        public TareaService(ITareaRepository tareaRepository, IMapper mapper)
        {
            _tareaRepository = tareaRepository; 
            _mapper = mapper;
        }

        public async Task<IEnumerable<TareaDto>> Get()
        {
            var tareas = await _tareaRepository.Get();

            return tareas.Select(t => new TareaDto
            {
                TareaId = t.TareaId,
                Titulo = t.Titulo,
                Descripcion = t.Descripcion,
                Estado = t.Estado,
                FechaLimite = t.FechaLimite
            });
        }

        public async Task<TareaDto> GetById(int id)
        {
            var tarea = await _tareaRepository.GetById(id);
            
            if(tarea != null)
            {
                var tareaDto = new TareaDto
                {
                    TareaId = tarea.TareaId,
                    Titulo = tarea.Titulo,
                    Descripcion = tarea.Descripcion,
                    Estado = tarea.Estado,
                    FechaLimite = tarea.FechaLimite
                };
                return tareaDto;
            }
            return null;
        }

        public async Task<TareaDto> Add(TareaInsertDto tareaInsertDto)
        {
            var tarea = _mapper.Map<Tarea>(tareaInsertDto);
            await _tareaRepository.Add(tarea);
            await _tareaRepository.Save();

            var tareaDto = _mapper.Map<TareaDto>(tarea);
            return tareaDto;

        }

        public async Task<TareaDto> Update(int id, TareaUpdateDto tareaUpdateDto)
        {
            var tarea = await _tareaRepository.GetById(id);

            if (tarea != null)
            {
                tarea.Descripcion = tareaUpdateDto.Descripcion;
                tarea.Estado = tareaUpdateDto.Estado;
                tarea.FechaLimite =tareaUpdateDto.FechaLimite;

                _tareaRepository.Update(tarea);
                await _tareaRepository.Save();

                var tareaDto = _mapper.Map<TareaDto>(tarea);
                return tareaDto;
            }
            return null;
        }

        public async Task<TareaDto> Delete(int id)
        {
            var tarea = await _tareaRepository.GetById(id);

            if (tarea != null)
            {
                var tareaDto = _mapper.Map<TareaDto>(tarea);

                _tareaRepository.Delete(tarea);
                await _tareaRepository.Save();

                return tareaDto;
            }
            return null;
        }                 
    }
}
