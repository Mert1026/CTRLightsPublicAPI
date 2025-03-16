using System.ComponentModel.DataAnnotations;

namespace CTRLightsPublicAPI.Data.Models
{
    public class TrafficLights
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string FreeLaneStatus { get; set; }

        [Required]
        public int TimeSpan { get; set; }

        [Required]
        public int Lane { get; set; }

        [Required]
        public char LightStatus { get; set; }
    }
}
