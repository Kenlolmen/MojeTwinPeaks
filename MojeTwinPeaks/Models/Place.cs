namespace MojeTwinPeaks.Models
{
    public class Place
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public PlaceType Type { get; set; }
        public string ImagePath { get; set; } = string.Empty;
    }
    public enum PlaceType
    {
        Supernatural,
        City,
        Hotel,
        Restaurant,
        House,
        Country,
        State,
        Bar,
        School,
        Department
    }
    
}
