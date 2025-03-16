using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTRLightsPublicAPI.Data.Models
{
    public class EspDevice
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(17)]
        public string MacAddress { get; set; } = string.Empty;

        [Required]
        [ForeignKey(nameof(airQuality))]
        public int AirQualityId { get; set; }
        public AirQuality airQuality { get; set; }
    }
}
