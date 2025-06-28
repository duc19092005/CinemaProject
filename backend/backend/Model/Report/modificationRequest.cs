using backend.Model.CinemaRoom;
using backend.Model.Cinemas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Model.Report
{
    public class modificationRequest
    {
        [Key]
        [Column(TypeName = "varchar(100)")]
        public string modificationRequestID { get; set; }  = string.Empty;

        public DateTime createDate { get; set; }

        public string materialName { get; set; } = string.Empty;

        public int amount { get; set; }

        [ForeignKey(nameof(cinemaRoom))]
        public string roomID { get; set; } = string.Empty;

        [ForeignKey(nameof(Cinema))]
        public string cinemaID { get; set; } = string.Empty;

        public string note { get; set; } = string.Empty;

        public bool isRequested { get; set; }

        public cinemaRoom cinemaRoom { get; set; } = null!;

        public Cinema Cinema { get; set; } = null!;
    }
}
