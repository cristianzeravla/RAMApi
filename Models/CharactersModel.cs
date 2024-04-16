namespace RAMAPI.Models
{
    public class CharactersModel
    {
        public Info? Info { get; set; }
        public IEnumerable<CharacterModel>? Results { get; set; }
    }

    public class Info
    {
        public int? Count { get; set; }
        public int? Pages { get; set; }
        public string? Next { get; set; }
        public string? Prev { get; set; }
    }
}