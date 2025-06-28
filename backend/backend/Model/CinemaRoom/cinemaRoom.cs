using backend.Model.Movie;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Model.Auth;
using backend.Model.Booking;
using backend.Model.Cinemas;
using backend.Model.CinemaRoom;
using backend.Model.Price;
using backend.Model.Product;
using backend.Model.Report;

namespace backend.Model.CinemaRoom
{
    public class cinemaRoom
    {
        // id phòng chiếu 

        [Key]
        [Column(TypeName = "varchar(100)")]

        public string cinemaRoomId { get; set; } = "";

        // Số của phòng chiếu

        [Required]
        public int cinemaRoomNumber { get; set; }
        // Khóa ngoại

        [Column(TypeName = "varchar(100)")]
        [Required]
        [ForeignKey("Cinema")]
        public string cinemaId { get; set; } = "";

        [Column(TypeName = "varchar(100)")]
        [ForeignKey("movieVisualFormat")]
        [Required]
        public string movieVisualFormatID { get; set; } = string.Empty;

        public bool isDeleted { get; set; }


        public Cinema Cinema { get; set; } = null!;

        public movieVisualFormat movieVisualFormat { get; set; } = null!;

        public List<movieSchedule> movieSchedule { get; set; } = null!;

        public List<Seats> Seats { get; set; } = [];

        public List<cleaningStatus> cleaningStatus { get; set; } = [];

        public List<materialReport> materialReport { get; set; } = [];

        public List<modificationRequest> modificationRequest { get; set; } = [];
    }
}
