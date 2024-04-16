using Microsoft.AspNetCore.Mvc;
using RAMAPI.Services;
using System.Threading.Tasks;

namespace RAMAPI.Controllers
{
    public class CharactersController : Controller
    {
        private readonly CharacterService _characterService;

        public CharactersController(CharacterService characterService)
        {
            _characterService = characterService;
        }

        public async Task<IActionResult> Index(string searchTerm = "", int page = 1, int pageSize = 20)
        {
            var characters = await _characterService.GetCharacters(searchTerm, page, pageSize);
            return View(characters);
        }
    }
}