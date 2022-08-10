using System.ComponentModel.DataAnnotations;

namespace HotelAPI.Model.Country
{
    public abstract class BaseCountryModel
    {
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
