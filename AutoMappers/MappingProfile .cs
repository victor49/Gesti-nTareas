using AutoMapper;
using gestionTareas.DTOs;
using gestionTareas.Models;

namespace gestionTareas.AutoMappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            //Para insertar 
            //Mapper de un Dto a un Modelo
            CreateMap<TareaInsertDto, Tarea>();

            //Para Get 
            //Mapper De un Medelo a Dto 
            CreateMap<Tarea, TareaDto>();
        }
    }
}
