using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new() {
            new Character(),
            new Character{Id = 1, Name = "Emanuele"}
        };
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(_characterService.GetAllCharaters());
        }

        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id)
        {
            return Ok(_characterService.GetCharacterById(id));
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter) {
            return Ok(_characterService.AddCharacter(newCharacter));
        }

        [HttpDelete]
        public ActionResult<List<Character>> DeleteCharacter(int index) {
            characters.RemoveRange(index, 1);
            return Ok(characters);
        }
    }
}