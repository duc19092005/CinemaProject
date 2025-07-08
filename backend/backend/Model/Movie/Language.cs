using backend.Model.Movie;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Model.Auth;
using backend.Model.Booking;
using backend.Model.Cinemas;
using backend.Model.CinemaRoom;
using backend.Model.Price;
using backend.Model.Product;
using Microsoft.EntityFrameworkCore;
using System;
namespace backend.Model.Movie
{
    [Index(nameof(languageDetail) , IsUnique = true)]
    public class Language
    {

        // ID của ngôn ngữ đó

        [Key]
        [Column(TypeName = "varchar(100)")]
        public string languageId { get; set; } = "";

        // chi tiết đó là ngôn ngữ gì

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string languageDetail { get; set; } = "";

        // Khóa ngoại 

        public List<movieInformation> movieInformation { get; set; } = [];


    }
}
