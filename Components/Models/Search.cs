namespace gamespace.Components.Models
{
    public class SearchRequest {
        public List<string> Genres { get; set; } = new List<string>();
        public List<string> Platforms { get; set; } = new List<string>();
        public string Search { get; set; } = "";
    }
}