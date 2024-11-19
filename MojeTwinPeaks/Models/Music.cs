using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace MojeTwinPeaks.Models
{
    public class Music
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Artist { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public string YouTubeUrl { get; set; } = string.Empty;
    }
}
