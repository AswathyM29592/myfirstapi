using AutoMapper;
using myfirstapi.Dtos.Character;
using myfirstapi.Models;

namespace myfirstapi
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile(){
        CreateMap<Character,GetCharacterDto>();
        CreateMap<AddCharacterDto,Character>();
        }
    }
}