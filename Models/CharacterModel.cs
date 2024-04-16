namespace RAMAPI.Models
{
    public class Origin
    {
        public string? Name { get; set; }
        public Uri? Url { get; set; }
    }

    public class Location
    {
        public string? Name { get; set; }
        public Uri? Url { get; set; }
    }

    public class CharacterModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Status { get; set; }
        public string? Species { get; set; }
        public string? Type { get; set; }
        public string? Gender { get; set; }
        public Origin? Origin { get; set; }
        public Location? Location { get; set; }
        public Uri? Image { get; set; }
        public IList<string>? Episode { get; set; }
        public Uri? Url { get; set; }
        public DateTime? Created { get; set; }
    }
}

