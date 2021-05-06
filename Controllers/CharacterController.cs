using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myfirstapi.Dtos.Character;
using myfirstapi.Models;
using myfirstapi.Services;

namespace myfirstapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }


        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<GetCharacterDto>> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }


        [HttpPost]
        public async Task<IActionResult> AddCharacter(AddCharacterDto character)
        {           
            return Ok(await _characterService.AddCharacter(character));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCharacter(UpdateCharacterDto character)
        {
            var response = await _characterService.UpdateCharacter(character);
            if(response.data == null){
                return NotFound(response);
            }
            return Ok(response);
        }

         [HttpDelete]
        public async Task<IActionResult> DeleteCharacter(int id)
        {
            var response = await _characterService.DeleteCharacter(id);
            if(response.data == null){
                return NotFound(response);
            }
            return Ok(response);
        }
    }

}