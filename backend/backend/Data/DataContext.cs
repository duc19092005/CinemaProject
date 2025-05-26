
using Microsoft.EntityFrameworkCore;
using backend.Model.Auth;
using backend.Model.Booking;
using backend.Model.Cinemas;
using backend.Model.CinemaRoom;
using backend.Model.Movie;
using backend.Model.Price;
using backend.Model.Product;


namespace backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { 

        }

        public DbSet<Cinema> Cinema { get; set; }

        public DbSet<cinemaMovieInformation> cinemaMovieInformation { get; set; }

        public DbSet<cinemaRoom> cinemaRoom { get; set; }

        public DbSet<Language> Language { get; set; }

        public DbSet<movieGenre> movieGenre { get; set; }

        public DbSet<movieGenreInformation> movieGenreInformation { get; set; }

        public DbSet<movieInformation> movieInformation { get; set; }

        public DbSet<movieSchedule> movieSchedule { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<orderDetailTicket> orderDetail { get; set; }

        public DbSet<priceInformation> priceInformation { get; set; }

        public DbSet<roleInformation> roleInformation { get; set; }

        public DbSet<Seats> Seats { get; set; }

        public DbSet<userInformation> userInformation { get; set; }

        public DbSet<userRoleInformation> userRoleInformation { get; set; }

        public DbSet<userType> userType { get; set; }

        public DbSet<foodInformation> foodInformation { get; set; }

        public DbSet<orderDetailFood> orderDetailFood { get;set; }
    }
}
