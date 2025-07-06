using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace backend.Model.Price
{
    [Index(nameof(priceAmount), IsUnique =true)]
    public class PriceInformation
    {
        [Key]
        [Column(TypeName = "varchar(100)")]
        public string priceInformationId { get; set; } = "";

        [Required]
        public long priceAmount { get; set; }

        public List<priceInformationForEachUserFilmType> priceInformationForEachUserFilmType { get; set; } = [];
    }
}
