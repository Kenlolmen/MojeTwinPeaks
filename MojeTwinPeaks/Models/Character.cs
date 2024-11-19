using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace MojeTwinPeaks.Models
{
    public class Character
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string BiographyPath { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public GenderType Gender { get; set; }
    }

    public enum GenderType
    {
        Male,
        Female,
        Other
    }
}
