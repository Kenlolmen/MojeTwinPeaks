namespace MojeTwinPeaks.Models
{
    public class Episode
    {
        public int ID { get; set; }
        public int SeasonID { get; set; }
        public int EpisodeNumber { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description  { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public string ImagePath { get; set; } = string.Empty;
        public double ImdbRating { get; set; }
    }
}
