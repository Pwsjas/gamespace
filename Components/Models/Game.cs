namespace gamespace.Components.Models
{
public class Game
    {
        public int Id { get; set; }
        public Cover Cover { get; set; }
        public List<Genre> Genres { get; set; }
        public string Name { get; set; }
        public List<Platform> Platforms { get; set; }
        public double Rating { get; set; }
        public List<int> Similar_Games { get; set; }
        public string Summary { get; set; }
        public List<Video> Videos { get; set; }
        public List<Website> Websites { get; set; }
        public List<Artwork> Artworks { get; set; }
        public List<Screenshot> Screenshots { get; set; }
    }

    public class Artwork
    {
        public int Id { get; set; }
        public string Image_Id { get; set; }
    }
    
    public class Screenshot
    {
        public int Id { get; set; }
        public string Image_Id { get; set; }
    }

    public class Video 
    {
        public int Id { get; set; }
        public string Video_Id { get; set; }
    }

    public class Website
    {
        public int Id { get; set; }
        public string Url { get; set; }
    }

    public class Platform 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Cover
    {
        public int Id { get; set; } = 0;
        public string Image_Id { get; set; }
    }

    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
