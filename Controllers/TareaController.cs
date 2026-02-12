using gestionTareas.DTOs;
using gestionTareas.Services;
using Microsoft.AspNetCore.Mvc;

namespace gestionTareas.Controllers
{
    [ApiController]
    [Route("[controller]")]    
    public class TareaController : ControllerBase
    {
        ITareaService _tareaService;
        public TareaController(ITareaService tareaService)
        {
            _tareaService = tareaService;
        }

        [HttpGet]
        public async Task<IEnumerable<TareaDto>> Get() =>
            await _tareaService.Get();

        [HttpGet("{id}")]
        public async Task<ActionResult<TareaDto>> GetById(int id)
        {
            var tareaDto = await _tareaService.GetById(id);

            return tareaDto == null ? NotFound() : Ok(tareaDto);
        }

        [HttpPost]
        public async Task<ActionResult<TareaDto>> Add(TareaInsertDto tareaInsertDto)
        {
            await _tareaService.Add(tareaInsertDto);
            return Ok();

        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TareaDto>> Update(int id, TareaUpdateDto tareaUpdateDto)
        {
            var tareaDto = await _tareaService.Update(id, tareaUpdateDto);

            return tareaDto == null ? NotFound() : Ok(tareaDto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TareaDto>> Delete(int id)
        {
            var tareaDto = await _tareaService.Delete(id);

            return tareaDto == null ? NotFound() : Ok();
        }
    }
}
