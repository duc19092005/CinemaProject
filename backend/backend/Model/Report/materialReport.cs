using backend.Model.CinemaRoom;
using backend.Model.Cinemas;
using System.ComponentModel.DataAnnotations.Schema;
namespace backend.Model.Report
{
    public class materialReport
    {
        public string materialReportID {  get; set; } = string.Empty;

        public string materialReportName { get; set; } = string.Empty ;

        [ForeignKey(nameof(Cinema))]

        public string cinemaID { get; set; } = string.Empty;

        [ForeignKey("cinemaRoom")]
        public string cinemaRoomId { get; set; } = string.Empty;

        public int amount { get; set; }

        public string note { get; set; } = string.Empty ;

        public bool isReported { get; set; }

        public DateTime createdDate { get; set; }

        public cinemaRoom cinemaRoom { get; set; } = null!;

        public Cinema Cinema { get; set; } = null!;
    }
}
