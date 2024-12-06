using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace MojeTwinPeaks.Models
{
    public class Character
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Born { get; set; } = string.Empty;
        public string Biography { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public GenderType Gender { get; set; }
        public string Actor { get; set; } = string.Empty;
        public enum GenderType
        {
            Male,
            Female,
            Other
        }
    }
}
