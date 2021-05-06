using myfirstapi.Dtos.Character;
using myfirstapi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace myfirstapi.Services
{
    public interface ICharacterService
    {
         Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
         Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
         Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);

         Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);

         Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);

    }
}