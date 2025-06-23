
using Microsoft.EntityFrameworkCore;
using backend.Model.Auth;
using backend.Model.Booking;
using backend.Model.Cinemas;
using backend.Model.CinemaRoom;
using backend.Model.Movie;
using backend.Model.Price;
using backend.Model.Product;
using backend.Model.ScheduleList;
using System.Text;


namespace backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { 

        }

        public DbSet<Cinema> Cinema { get; set; }
        public DbSet<cinemaRoom> cinemaRoom { get; set; }

        public DbSet<movieCommentDetail> movieCommentDetail { get; set; }   

        public DbSet<Language> Language { get; set; }

        public DbSet<movieGenre> movieGenre { get; set; }

        public DbSet<movieGenreInformation> movieGenreInformation { get; set; }

        public DbSet<movieInformation> movieInformation { get; set; }

        public DbSet<movieVisualFormat> movieVisualFormat { get; set; }

        public DbSet<movieSchedule> movieSchedule { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<orderDetailTicket> TicketOrderDetail { get; set; }

        public DbSet<priceInformationForEachUserFilmType> priceInformationForEachUserFilmType { get; set; }

        public DbSet<roleInformation> roleInformation { get; set; }

        public DbSet<Seats> Seats { get; set; }

        public DbSet<userInformation> userInformation { get; set; }

        public DbSet<userRoleInformation> userRoleInformation { get; set; }

        public DbSet<userType> userType { get; set; }

        public DbSet<foodInformation> foodInformation { get; set; }

        public DbSet<orderDetailFood> FoodOrderDetail { get;set; }

        public DbSet<PriceInformation> priceInformation { get; set; }
        public DbSet<cleaningStatus> cleaningStatus { get; set; }

        public DbSet<movieVisualFormatDetail> movieVisualFormatDetails { get; set; }

        public DbSet<HourSchedule> HourSchedule { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure GUID IDs for all entities and data seeding
            // Cấu hình ID dưới dạng chuỗi GUID và thêm dữ liệu ban đầu (seed data)

            // Seed Data for RoleInformation
            var cashierId = Guid.NewGuid().ToString();
            var customerId = Guid.NewGuid().ToString();
            var DirectorId = Guid.NewGuid().ToString();
            var MovieManagerId = Guid.NewGuid().ToString();
            var ThreaterManagerId = Guid.NewGuid().ToString();
            var FacilitiesManagerId = Guid.NewGuid().ToString();
            var ThreaterCleanerId = Guid.NewGuid().ToString();


            modelBuilder.Entity<roleInformation>().HasData(
                new roleInformation { roleId = customerId, roleName = "Customer" },
                new roleInformation { roleId = cashierId, roleName = "Cashier" },
                new roleInformation { roleId = DirectorId, roleName = "Director" },
                new roleInformation { roleId = MovieManagerId, roleName = "MovieManager" },
                new roleInformation { roleId = ThreaterManagerId, roleName = "TheaterManager" },
                new roleInformation { roleId = FacilitiesManagerId, roleName = "FacilitiesManager" },
                new roleInformation { roleId = ThreaterCleanerId, roleName = "TheaterCleaner" }
            );

            // Seed Data for UserInformation
            var userId1 = Guid.NewGuid().ToString();
            var userId2 = Guid.NewGuid().ToString();
            modelBuilder.Entity<userInformation>().HasData(
                new userInformation
                {
                    userId = userId1,
                    loginUserEmail = "admin@example.com",
                    loginUserPassword = "hashed_password_admin", // In a real app, hash this password
                    dateOfBirth = new DateTime(1990, 1, 1),
                    phoneNumber = "0123456789",
                    userName = "Admin User",
                    IdentityCode = "123456789012",
                    userPoint = 1000
                },
                new userInformation
                {
                    userId = userId2,
                    loginUserEmail = "user@example.com",
                    loginUserPassword = "hashed_password_user", // In a real app, hash this password
                    dateOfBirth = new DateTime(1995, 5, 10),
                    phoneNumber = "0987654321",
                    userName = "Regular User",
                    IdentityCode = "987654321098",
                    userPoint = 50
                }
            );

            // Seed Data for UserRoleInformation (linking users to roles)
            modelBuilder.Entity<userRoleInformation>().HasData(
                new userRoleInformation { userId = userId1, roleId = MovieManagerId},
                new userRoleInformation { userId = userId2, roleId = customerId }
            );

            // Seed Data for Language
            var langId1 = Guid.NewGuid().ToString();
            var langId2 = Guid.NewGuid().ToString();
            modelBuilder.Entity<Language>().HasData(
                new Language { languageId = langId1, languageDetail = "Vietnamese" },
                new Language { languageId = langId2, languageDetail = "English" }
            );

            // Seed Data for MovieGenre
            var genreId1 = Guid.NewGuid().ToString();
            var genreId2 = Guid.NewGuid().ToString();
            modelBuilder.Entity<movieGenre>().HasData(
                new movieGenre { movieGenreId = genreId1, movieGenreName = "Action" },
                new movieGenre { movieGenreId = genreId2, movieGenreName = "Comedy" }
            );

            // Seed Data for MovieInformation
            var movieId1 = Guid.NewGuid().ToString();
            var movieId2 = Guid.NewGuid().ToString();
            modelBuilder.Entity<movieInformation>().HasData(
                new movieInformation
                {
                    movieId = movieId1,
                    movieName = "Phim Hành Động 1",
                    movieImage = new byte[] { 0x01, 0x02, 0x03 }, // Example byte array
                    movieDescription = "Đây là một bộ phim hành động đầy kịch tính.",
                    movieDirector = "Đạo Diễn A",
                    movieActor = "Diễn Viên X, Diễn Viên Y",
                    movieTrailerUrl = "http://trailer.com/phimhanhdong1",
                    movieDuration = 120, // minutes
                    languageId = langId1
                },
                new movieInformation
                {
                    movieId = movieId2,
                    movieName = "Comedy Film 1",
                    movieImage = new byte[] { 0x04, 0x05, 0x06 }, // Example byte array
                    movieDescription = "A funny movie for the whole family.",
                    movieDirector = "Director B",
                    movieActor = "Actor Z, Actress W",
                    movieTrailerUrl = "http://trailer.com/comedyfilm1",
                    movieDuration = 90, // minutes
                    languageId = langId2
                }
            );

            // Seed Data for MovieGenreInformation
            modelBuilder.Entity<movieGenreInformation>().HasData(
                new movieGenreInformation { movieId = movieId1, movieGenreId = genreId1 },
                new movieGenreInformation { movieId = movieId2, movieGenreId = genreId2 }
            );

            // Seed Data for Cinema
            var cinemaId1 = Guid.NewGuid().ToString();
            modelBuilder.Entity<Cinema>().HasData(
                new Cinema
                {
                    cinemaId = cinemaId1,
                    cinemaName = "Rạp Chiếu Phim ABC",
                    cinemaLocation = "123 Đường XYZ, TP.HCM",
                    cinemaDescription = "Rạp chiếu phim hiện đại với nhiều phòng chiếu.",
                    cinemaContactHotlineNumber = "0901234567",
                    isSupportedIMAX = true
                }
            );

            // Seed Data for CinemaRoom
            var room1Id = Guid.NewGuid().ToString();
            modelBuilder.Entity<cinemaRoom>().HasData(
                new cinemaRoom
                {
                    cinemaRoomId = room1Id,
                    cinemaRoomNumber = 1,
                    isIMAXRoom = true,
                    cinemaId = cinemaId1
                }
            );

            // Seed Data for Seats
            var seat1Id = Guid.NewGuid().ToString();
            var seat2Id = Guid.NewGuid().ToString();
            modelBuilder.Entity<Seats>().HasData(
                new Seats { seatsId = seat1Id, seatsNumber = "A1", isTaken = false, isMiddle = true, cinemaRoomId = room1Id },
                new Seats { seatsId = seat2Id, seatsNumber = "A2", isTaken = false, isMiddle = true, cinemaRoomId = room1Id }
            );

            // Seed Data for DayInWeekendSchedule

            // Seed Data for HourSchedule
            var hour1Id = Guid.NewGuid().ToString();
            var hour2Id = Guid.NewGuid().ToString();
            modelBuilder.Entity<HourSchedule>().HasData(
                new HourSchedule { HourScheduleID = hour1Id, HourScheduleDate = "08:00" },
                new HourSchedule { HourScheduleID = hour2Id, HourScheduleDate = "10:00" }
            );

            // Seed Data for movieSchedule
            var movieScheduleId1 = Guid.NewGuid().ToString();
            modelBuilder.Entity<movieSchedule>().HasData(
                new movieSchedule
                {
                    movieScheduleId = movieScheduleId1,
                    cinemaRoomId = room1Id,
                    movieId = movieId1,
                    HourScheduleID = hour1Id ,
                    cinemaID = cinemaId1 ,
                    IsDelete = false,
                    DayInWeekendSchedule = "Monday" ,
                    ReleaseDate = new DateTime(2025 , 11 , 11)
                }
            );

            // Seed Data for MovieVisualFormat
            var visualFormatId1 = Guid.NewGuid().ToString();
            modelBuilder.Entity<movieVisualFormat>().HasData(
                new movieVisualFormat { movieVisualFormatId = visualFormatId1, movieVisualFormatName = "2D" }
            );

            // Seed Data for PriceInformation
            var priceId1 = Guid.NewGuid().ToString();
            modelBuilder.Entity<PriceInformation>().HasData(
                new PriceInformation { priceInformationId = priceId1, priceAmount = 80000 }
            );

            // Seed Data for UserType
            var userTypeId1 = Guid.NewGuid().ToString();
            modelBuilder.Entity<userType>().HasData(
                new userType { userTypeId = userTypeId1, userTypeDescription = "Adult" }
            );

            // Seed Data for PriceInformationForEachUserFilmType
            modelBuilder.Entity<priceInformationForEachUserFilmType>().HasData(
                new priceInformationForEachUserFilmType
                {
                    userTypeId = userTypeId1,
                    movieVisualFormatId = visualFormatId1,
                    priceInformationID = priceId1
                }
            );

            // Seed Data for FoodInformation
            var foodId1 = Guid.NewGuid().ToString();
            modelBuilder.Entity<foodInformation>().HasData(
                new foodInformation { foodInformationId = foodId1, foodInformationName = "Popcorn", foodPrice = 50000 }
            );
        }
    }
}
