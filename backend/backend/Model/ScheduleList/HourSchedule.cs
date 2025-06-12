using backend.Model.Movie;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Model.ScheduleList
{
    // Bảng này là bảng giờ chiếu
    public class HourSchedule
    {
        [Key]
        [Column(TypeName = "varchar(50)")]
        public string HourScheduleID { get; set; } = string.Empty;

        // Giờ chiếu
        // Ví dụ : 8:00 , 10:00 , 20:00

        public string HourScheduleDate { get; set; } = string.Empty;

        public List<movieSchedule> movieSchedule { get; set; } = [];
    }
}
