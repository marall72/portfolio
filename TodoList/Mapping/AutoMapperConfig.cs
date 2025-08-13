using AutoMapper;
using TodoList.Dto;
using TodoList.Model;

namespace TodoList.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<TodoInsertDto, Todo>();
            CreateMap<Todo, TodoGetDto>()
    .ForMember(dest => dest.StatusTitle,
               opt => opt.MapFrom(src => src.Status.ToString()))
    .ForMember(dest => dest.CreateDate,
               opt => opt.MapFrom(src => $"{src.CreateDate.ToLongDateString()} {src.CreateDate.ToShortTimeString()}"))
    .ForMember(dest => dest.UpdateDate,
               opt => opt.MapFrom(src => $"{src.UpdateDate.ToLongDateString()} {src.UpdateDate.ToShortTimeString()}"));
        }
    }
}