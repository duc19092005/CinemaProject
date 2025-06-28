using backend.Model.Auth;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Model.CinemaRoom
{
    public partial class cleaningStatus
    {
        [Column(TypeName = "varchar(100)")]
        public string roomID { get; set; } = string.Empty;

        [Column(TypeName = "varchar(100)")]
        public string staffID {  get; set; } = string.Empty;


        public DateTime startedTime {  get; set; }

        public DateTime endedTime { get; set; }


        public cinemaRoom cinemaRoom { get; set; } = null!;

        public userInformation userInformation { get; set; } = null!;
    }

    [PrimaryKey(nameof(roomID) , nameof(staffID) , nameof(startedTime))]
    public partial class cleaningStatus
    {

    }
}
