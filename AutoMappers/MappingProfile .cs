using AutoMapper;
using gestionTareas.DTOs;
using gestionTareas.Models;

namespace gestionTareas.AutoMappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {

            //Para Get 
            //Mapper De un Medelo a Dto 
            CreateMap<Tarea, TareaDto>();


            //Para insertar 
            //Mapper de un Dto a un Modelo
            CreateMap<TareaInsertDto, Tarea>();
           

            //---Mapper De un Medelo a Dto Tambien sirve para llaves foraneas 
            //---Cuando Atributos de modelo y Dto son diferentes como (Dtos en ingles/Modelos español)
            //CreateMap<Tarea, TareaDto>()
            //    //Dtos
            //    .ForMember(dto => dto.TareaId,
            //               //Models
            //               m => m.MapFrom(t => t.TareaId));


            //AutoMapper con objeto existente
            //Para el Update de Dto a modelo
            CreateMap<TareaUpdateDto, Tarea>();
        }
    }
}
