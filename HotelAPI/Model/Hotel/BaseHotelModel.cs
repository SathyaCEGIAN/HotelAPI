using System.ComponentModel.DataAnnotations;

namespace HotelAPI.Model.Hotel
{
    public abstract class BaseHotelModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public double? Rating { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int countryId { get; set; }
    }
}
