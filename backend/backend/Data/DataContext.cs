
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

        public DbSet<movieVisualFormat> movieVisualFormat { get; set; }

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


        public DbSet<cleaningStatus> cleaningStatus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Data for Roles
            string roleDirector = Guid.NewGuid().ToString();
            string roleCashierStaff = Guid.NewGuid().ToString();
            string roleCleaningStaff = Guid.NewGuid().ToString();
            string roleTicketInspectorStaff = Guid.NewGuid().ToString();
            string roleCustomer = Guid.NewGuid().ToString(); // Adding a customer role

            modelBuilder.Entity<roleInformation>().HasData(new roleInformation[]
            {
                new roleInformation { roleId = roleDirector, roleName = "Director" },
                new roleInformation { roleId = roleCashierStaff, roleName = "Cashier Staff" },
                new roleInformation { roleId = roleCleaningStaff, roleName = "Cleaning Staff" },
                new roleInformation { roleId = roleTicketInspectorStaff, roleName = "Ticket Inspector Staff" },
                new roleInformation { roleId = roleCustomer, roleName = "Customer" }
            });

            // Seed Data for User Types
            string userTypeAdult = Guid.NewGuid().ToString();
            string userTypeChild = Guid.NewGuid().ToString();
            string userTypeStudent = Guid.NewGuid().ToString();
            string userTypeSenior = Guid.NewGuid().ToString();

            modelBuilder.Entity<userType>().HasData(new userType[]
            {
                new userType { userTypeId = userTypeAdult, userTypeDescription = "Adult" },
                new userType { userTypeId = userTypeChild, userTypeDescription = "Child" },
                new userType { userTypeId = userTypeStudent, userTypeDescription = "Student" },
                new userType { userTypeId = userTypeSenior, userTypeDescription = "Senior" }
            });

            // Seed Data for Languages
            string langEnglish = Guid.NewGuid().ToString();
            string langVietnamese = Guid.NewGuid().ToString();
            string langKorean = Guid.NewGuid().ToString();

            modelBuilder.Entity<Language>().HasData(new Language[]
            {
                new Language { languageId = langEnglish, languageDetail = "English" },
                new Language { languageId = langVietnamese, languageDetail = "Vietnamese" },
                new Language { languageId = langKorean, languageDetail = "Korean" }
            });

            // Seed Data for Movie Visual Formats
            string format2D = Guid.NewGuid().ToString();
            string format3D = Guid.NewGuid().ToString();
            string formatIMAX = Guid.NewGuid().ToString();

            modelBuilder.Entity<movieVisualFormat>().HasData(new movieVisualFormat[]
            {
                new movieVisualFormat { movieVisualFormatId = format2D, movieVisualFormatName = "2D" },
                new movieVisualFormat { movieVisualFormatId = format3D, movieVisualFormatName = "3D" },
                new movieVisualFormat { movieVisualFormatId = formatIMAX, movieVisualFormatName = "IMAX" }
            });

            // Seed Data for Movie Genres
            string genreAction = Guid.NewGuid().ToString();
            string genreComedy = Guid.NewGuid().ToString();
            string genreHorror = Guid.NewGuid().ToString();
            string genreDrama = Guid.NewGuid().ToString();

            modelBuilder.Entity<movieGenre>().HasData(new movieGenre[]
            {
                new movieGenre { movieGenreId = genreAction, movieGenreName = "Action" },
                new movieGenre { movieGenreId = genreComedy, movieGenreName = "Comedy" },
                new movieGenre { movieGenreId = genreHorror, movieGenreName = "Horror" },
                new movieGenre { movieGenreId = genreDrama, movieGenreName = "Drama" }
            });

            // Seed Data for Cinemas
            string cinemaMegaGS = Guid.NewGuid().ToString();
            string cinemaLotte = Guid.NewGuid().ToString();

            modelBuilder.Entity<Cinema>().HasData(new Cinema[]
            {
                new Cinema
                {
                    cinemaId = cinemaMegaGS,
                    cinemaName = "Mega GS Cao Thang",
                    cinemaLocation = "19 Cao Thang",
                    cinemaDescription = "A modern cinema with multiple screens.",
                    cinemaContactHotlineNumber = "0901234567"
                },
                new Cinema
                {
                    cinemaId = cinemaLotte,
                    cinemaName = "Lotte Cinema Cantavil",
                    cinemaLocation = "12 Cantavil",
                    cinemaDescription = "Comfortable seating and great sound system.",
                    cinemaContactHotlineNumber = "0907654321"
                }
            });

            // Seed Data for Cinema Rooms
            string roomMegaGS1 = Guid.NewGuid().ToString();
            string roomMegaGS2 = Guid.NewGuid().ToString();
            string roomLotte1 = Guid.NewGuid().ToString();

            modelBuilder.Entity<cinemaRoom>().HasData(new cinemaRoom[]
            {
                new cinemaRoom { cinemaRoomId = roomMegaGS1, cinemaRoomNumber = 1, cinemaId = cinemaMegaGS },
                new cinemaRoom { cinemaRoomId = roomMegaGS2, cinemaRoomNumber = 2, cinemaId = cinemaMegaGS },
                new cinemaRoom { cinemaRoomId = roomLotte1, cinemaRoomNumber = 1, cinemaId = cinemaLotte }
            });

            // Seed Data for Seats in Rooms
            string seat1MegaGS1 = Guid.NewGuid().ToString();
            string seat2MegaGS1 = Guid.NewGuid().ToString();
            string seat3MegaGS1 = Guid.NewGuid().ToString();
            string seat4MegaGS1 = Guid.NewGuid().ToString();

            string seat1MegaGS2 = Guid.NewGuid().ToString();
            string seat2MegaGS2 = Guid.NewGuid().ToString();

            string seat1Lotte1 = Guid.NewGuid().ToString();
            string seat2Lotte1 = Guid.NewGuid().ToString();

            modelBuilder.Entity<Seats>().HasData(new Seats[]
            {
                new Seats { seatsId = seat1MegaGS1, seatsNumber = "A1", isTaken = false, isMiddle = true, cinemaRoomId = roomMegaGS1 },
                new Seats { seatsId = seat2MegaGS1, seatsNumber = "A2", isTaken = false, isMiddle = true, cinemaRoomId = roomMegaGS1 },
                new Seats { seatsId = seat3MegaGS1, seatsNumber = "B1", isTaken = false, isMiddle = false, cinemaRoomId = roomMegaGS1 },
                new Seats { seatsId = seat4MegaGS1, seatsNumber = "B2", isTaken = false, isMiddle = false, cinemaRoomId = roomMegaGS1 },

                new Seats { seatsId = seat1MegaGS2, seatsNumber = "C1", isTaken = false, isMiddle = true, cinemaRoomId = roomMegaGS2 },
                new Seats { seatsId = seat2MegaGS2, seatsNumber = "C2", isTaken = false, isMiddle = false, cinemaRoomId = roomMegaGS2 },

                new Seats { seatsId = seat1Lotte1, seatsNumber = "D1", isTaken = false, isMiddle = true, cinemaRoomId = roomLotte1 },
                new Seats { seatsId = seat2Lotte1, seatsNumber = "D2", isTaken = false, isMiddle = false, cinemaRoomId = roomLotte1 }
            });

            // Seed Data for Prices
            string priceAdult2D = Guid.NewGuid().ToString();
            string priceChild2D = Guid.NewGuid().ToString();
            string priceAdult3D = Guid.NewGuid().ToString();

            modelBuilder.Entity<priceInformation>().HasData(new priceInformation[]
            {
                new priceInformation { priceInformationId = priceAdult2D, priceAmount = 100000, userTypeId = userTypeAdult, movieVisualFormatId = format2D },
                new priceInformation { priceInformationId = priceChild2D, priceAmount = 70000, userTypeId = userTypeChild, movieVisualFormatId = format2D },
                new priceInformation { priceInformationId = priceAdult3D, priceAmount = 130000, userTypeId = userTypeAdult, movieVisualFormatId = format3D }
            });

            // Seed Data for Food Information
            string foodPopcorn = Guid.NewGuid().ToString();
            string foodSoda = Guid.NewGuid().ToString();

            modelBuilder.Entity<foodInformation>().HasData(new foodInformation[]
            {
                new foodInformation { foodInformationId = foodPopcorn, foodInformationName = "Popcorn Medium", foodPrice = 50000 },
                new foodInformation { foodInformationId = foodSoda, foodInformationName = "Coca-Cola", foodPrice = 30000 }
            });


            // Seed Data for Users
            string userAdmin = Guid.NewGuid().ToString();
            string userCustomer1 = Guid.NewGuid().ToString();

            modelBuilder.Entity<userInformation>().HasData(new userInformation[]
            {
                new userInformation
                {
                    userId = userAdmin,
                    loginUserEmail = "admin@example.com",
                    loginUserPassword = "password123",
                    dateOfBirth = new DateTime(1990, 1, 1),
                    phoneNumber = "0912345678",
                    userName = "Admin User",
                    IdentityCode = "123456789012",
                    userPoint = 1000
                },
                new userInformation
                {
                    userId = userCustomer1,
                    loginUserEmail = "customer1@example.com",
                    loginUserPassword = "password123",
                    dateOfBirth = new DateTime(1995, 5, 10),
                    phoneNumber = "0987654321",
                    userName = "Nguyen Van A",
                    IdentityCode = "012345678901",
                    userPoint = 250
                }
            });

            // Seed Data for User Roles
            modelBuilder.Entity<userRoleInformation>().HasData(new userRoleInformation[]
            {
                new userRoleInformation { userId = userAdmin, roleId = roleDirector },
                new userRoleInformation { userId = userCustomer1, roleId = roleCustomer }
            });

            // Seed Data for Movies
            string movieDune2 = Guid.NewGuid().ToString();
            string movieGodzillaXKong = Guid.NewGuid().ToString();

            modelBuilder.Entity<movieInformation>().HasData(new movieInformation[]
            {
                new movieInformation
                {
                    movieId = movieDune2,
                    movieName = "Dune: Part Two",
                    movieImage = System.Text.Encoding.UTF8.GetBytes("dune2_image_placeholder"), // Replace with actual byte data
                    movieDescription = "Paul Atreides unites with Chani and the Fremen while seeking revenge against those who destroyed his family.",
                    movieDirector = "Denis Villeneuve",
                    movieActor = "Timothée Chalamet, Zendaya, Rebecca Ferguson",
                    movieTrailerUrl = "https://www.youtube.com/watch?v=Way9Dexny3w",
                    movieDuration = 166, // minutes
                    languageId = langEnglish,
                    movieVisualFormatId = format2D
                },
                new movieInformation
                {
                    movieId = movieGodzillaXKong,
                    movieName = "Godzilla x Kong: The New Empire",
                    movieImage = System.Text.Encoding.UTF8.GetBytes("godzillaxkong_image_placeholder"), // Replace with actual byte data
                    movieDescription = "Godzilla and Kong must unite to fight a colossal undiscovered threat hidden within our world.",
                    movieDirector = "Adam Wingard",
                    movieActor = "Rebecca Hall, Brian Tyree Henry, Dan Stevens",
                    movieTrailerUrl = "https://www.youtube.com/watch?v=EOk9z-WbN5o",
                    movieDuration = 115, // minutes
                    languageId = langEnglish,
                    movieVisualFormatId = format3D
                }
            });

            // Seed Data for Cinema Movie Information (linking movies to cinemas)
            modelBuilder.Entity<cinemaMovieInformation>().HasData(new cinemaMovieInformation[]
            {
                new cinemaMovieInformation { cinemaId = cinemaMegaGS, movieId = movieDune2 },
                new cinemaMovieInformation { cinemaId = cinemaMegaGS, movieId = movieGodzillaXKong },
                new cinemaMovieInformation { cinemaId = cinemaLotte, movieId = movieDune2 }
            });

            // Seed Data for Movie Genre Information (linking movies to genres)
            modelBuilder.Entity<movieGenreInformation>().HasData(new movieGenreInformation[]
            {
                new movieGenreInformation { movieId = movieDune2, movieGenreId = genreAction },
                new movieGenreInformation { movieId = movieDune2, movieGenreId = genreDrama },
                new movieGenreInformation { movieId = movieGodzillaXKong, movieGenreId = genreAction }
            });

            // Seed Data for Movie Schedules
            string scheduleDuneMegaGS1 = Guid.NewGuid().ToString();
            string scheduleGodzillaMegaGS1 = Guid.NewGuid().ToString();
            string scheduleDuneLotte1 = Guid.NewGuid().ToString();

            modelBuilder.Entity<movieSchedule>().HasData(new movieSchedule[]
            {
                new movieSchedule
                {
                    movieScheduleId = scheduleDuneMegaGS1,
                    showDateTime = new DateTime(2025, 6, 5, 10, 0, 0), // Example date/time
                    cinemaRoomId = roomMegaGS1,
                    movieId = movieDune2
                },
                new movieSchedule
                {
                    movieScheduleId = scheduleGodzillaMegaGS1,
                    showDateTime = new DateTime(2025, 6, 5, 14, 30, 0), // Example date/time
                    cinemaRoomId = roomMegaGS1,
                    movieId = movieGodzillaXKong
                },
                new movieSchedule
                {
                    movieScheduleId = scheduleDuneLotte1,
                    showDateTime = new DateTime(2025, 6, 6, 11, 0, 0), // Example date/time
                    cinemaRoomId = roomLotte1,
                    movieId = movieDune2
                }
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
