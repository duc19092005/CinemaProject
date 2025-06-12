using backend.Model.Movie;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Model.ScheduleList
{
    // Bảng này là bảng liệt kê các thứ trong tuần 
    public class DayInWeekendSchedule
    {
        // ID
        [Key]
        [Column(TypeName = "varchar(50)")]
        public string DayInWeekendScheduleID { get; set; } = string.Empty;

        // Thứ trong tuần VD : thứ 2,3,4,5,6,7.CN
        [Column(TypeName = "nvarchar(20)")]
        public string DayInWeekendScheduleName { get; set; } = string.Empty;

        public List<movieSchedule> movieSchedule { get; set; } = [];
    }
}
