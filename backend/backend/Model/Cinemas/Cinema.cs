using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Model.Auth;
using backend.Model.Booking;
using backend.Model.Cinemas;
using backend.Model.CinemaRoom;
using backend.Model.Movie;
using backend.Model.Price;
using backend.Model.Product;
using backend.Model.Report;

namespace backend.Model.Cinemas
{
    // Bảng này là bảng rạp chieus phim

    public class Cinema
    {

        // Đây là id của rạp 

        [Key]
        [Column(TypeName = "varchar(100)")]

        public string cinemaId { get; set; } = "";

        // Tên của rạp

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string cinemaName { get; set; } = "";

        // Dịa chỉ của Rạp

        [Column(TypeName = "nvarchar(200)")]
        [Required]
        public string cinemaLocation { get; set; } = "";

        // Ghi chú cua rạp

        [Column(TypeName = "nvarchar(max)")]
        [Required]
        public string cinemaDescription { get; set; } = "";

        // Thông tin số hotline của rạp

        [Column(TypeName = "varchar(10)")]
        [Required]
        public string cinemaContactHotlineNumber { get; set; } = "";

        public List<cinemaRoom> cinemaRoom { get; set; } = null!;

        public List<movieSchedule> movieSchedule { get; set; } = [];

        public List<materialReport> materialReport { get; set; } = [];

        public List<modificationRequest> modificationRequest { get; set; } = [];


    }
}
