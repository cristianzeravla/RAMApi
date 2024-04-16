using Newtonsoft.Json;
using RAMAPI.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace RAMAPI.Services
{
    public class CharacterService
    {
        private readonly HttpClient _httpClient;

        public CharacterService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<CharactersModel?> GetCharacters(string searchTerm = "", int page = 1, int pageSize = 10)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"https://rickandmortyapi.com/api/character/?name={searchTerm}&page={page}&pageSize={pageSize}");
                response.EnsureSuccessStatusCode();

                string jsonString = await response.Content.ReadAsStringAsync();

                var characters = JsonConvert.DeserializeObject<CharactersModel>(jsonString);
                return characters;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de personajes.", ex);
            }
        }
    }
}
