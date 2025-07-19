using backend.Model.Auth;
using backend.Model.Booking;
using backend.Model.CinemaRoom;
using backend.Model.Movie;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend.ModelDTO.Account.AccountRespond
{
    public class profileRequest
    {

        public DateTime? dateOfBirth { get; set; }

        public string phoneNumber { get; set; } = "";

        public string userName { get; set; } = "";
       
    }
}
