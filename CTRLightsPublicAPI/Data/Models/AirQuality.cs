using System.ComponentModel.DataAnnotations;

namespace CTRLightsPublicAPI.Data.Models
{
    public class AirQuality
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public double Amount { get; set; }
    }
}
