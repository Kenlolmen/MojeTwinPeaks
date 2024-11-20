namespace MojeTwinPeaks.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string PlotPath { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public DateTime PublicationDate { get; set; }
    }
}
