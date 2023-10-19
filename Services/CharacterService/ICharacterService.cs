using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        List<Character> GetAllCharaters();
        Character GetCharacterById(int id);
        List<Character> AddCharacter(Character newCharacter);
    }
}