namespace gamespace.Components.Models
{
public class Game
    {
        public int Id { get; set; } = 0;
        public Cover Cover { get; set; } = new Cover();
        public List<Genre> Genres { get; set; } = new List<Genre>();
        public string Name { get; set; } = "";
        public List<Platform> Platforms { get; set; } = new List<Platform>();
        public double Rating { get; set; } = 0;
        public List<int> Similar_Games { get; set; } = new List<int>();
        public string Summary { get; set; } = "";
        public List<Video> Videos { get; set; } = new List<Video>();
        public List<Website> Websites { get; set; } = new List<Website>();
        public List<Artwork> Artworks { get; set; } = new List<Artwork>();
        public List<Screenshot> Screenshots { get; set; } = new List<Screenshot>();
    }

    public class Artwork
    {
        public int Id { get; set; } = 0;
        public string Image_Id { get; set; } = "";
    }
    
    public class Screenshot
    {
        public int Id { get; set; } = 0;
        public string Image_Id { get; set; } = "";
    }

    public class Video 
    {
        public int Id { get; set; } = 0;
        public string Video_Id { get; set; } = "";
    }

    public class Website
    {
        public int Id { get; set; } = 0;
        public string Url { get; set; } = "";
    }

    public class Platform 
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
    }

    public class Cover
    {
        public int Id { get; set; } = 0;
        public string Image_Id { get; set; } = "";
    }

    public class Genre
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
    }
}
