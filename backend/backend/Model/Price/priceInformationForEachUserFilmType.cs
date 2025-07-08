using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Model.Auth;
using backend.Model.Booking;
using backend.Model.Cinemas;
using backend.Model.CinemaRoom;
using backend.Model.Movie;
using backend.Model.Price;
using backend.Model.Product;
using Microsoft.EntityFrameworkCore;

namespace backend.Model.Price
{
    public partial class priceInformationForEachUserFilmType
    {


        [Column(TypeName = "varchar(100)")]
        [ForeignKey("userType")]
        public string userTypeId { get; set; } = "";


        [Column(TypeName = "varchar(100)")]
        [ForeignKey("movieVisualFormat")]
        public string movieVisualFormatId { get; set; } = "";

        [Column(TypeName = "varchar(100)")]
        [ForeignKey("PriceInformation")]
        public string priceInformationID { get; set; } = String.Empty;

        public userType userType { get; set; } = null!;

        public movieVisualFormat movieVisualFormat { get; set; } = null!;

        public PriceInformation PriceInformation { get; set; } = null!;

        public List<orderDetailTicket> orderDetail = [];

    }

    [PrimaryKey(nameof(userTypeId) , nameof(movieVisualFormatId) , nameof(priceInformationID))]
    public partial class priceInformationForEachUserFilmType
    {

    }
}
