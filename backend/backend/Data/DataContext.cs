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
using backend.Model.Staff_Customer;
using backend.Model.MinimumAge;
using System; // Thêm namespace này cho Guid

namespace backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        // --- Các DbSet của bạn (giữ nguyên) ---
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
        public DbSet<orderDetailFood> FoodOrderDetail { get; set; }
        public DbSet<PriceInformation> priceInformation { get; set; }
        public DbSet<movieVisualFormatDetail> movieVisualFormatDetails { get; set; }
        public DbSet<HourSchedule> HourSchedule { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<minimumAge> minimumAges { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // --- Cấu hình Index (giữ nguyên) ---
            modelBuilder.Entity<movieSchedule>()
                .HasIndex(ms => new { ms.cinemaRoomId, ms.ScheduleDate })
                .IsUnique();
            modelBuilder.Entity<Customer>()
                .HasIndex(ms => new { ms.userID })
                .IsUnique();
            modelBuilder.Entity<Staff>()
                .HasIndex(ms => new { ms.userID })
                .IsUnique();

            // --- Cấu hình ID dưới dạng chuỗi GUID và thêm dữ liệu ban đầu (seed data) ---
            // =====================================================================
            // THAY THẾ CÁC GUID NÀY BẰNG CÁC GIÁ TRỊ GUID THẬT CỦA BẠN ĐƯỢC TẠO 1 LẦN
            // =====================================================================

            // Seed Data for RoleInformation
            var cashierId = "1a8f7b9c-d4e5-4f6a-b7c8-9d0e1f2a3b4c"; // Example GUID
            var customerId = "2b9c8d0e-f5a6-7b8c-d9e0-1f2a3b4c5d6e"; // Example GUID
            var DirectorId = "3c0d9e1f-a6b7-c8d9-e0f1-2a3b4c5d6e7f"; // Example GUID
            var MovieManagerId = "4d1e0f2a-b7c8-d9e0-f1a2-3b4c5d6e7f8g"; // Example GUID
            var TheaterManagerId = "5e2f1a3b-c8d9-e0f1-a2b3-4c5d6e7f8g9h"; // Example GUID
            var FacilitiesManagerId = "6f3a2b4c-d9e0-f1a2-b3c4-d5e6f7a8b9c0"; // Example GUID


            modelBuilder.Entity<roleInformation>().HasData(
                new roleInformation { roleId = customerId, roleName = "Customer" },
                new roleInformation { roleId = cashierId, roleName = "Cashier" },
                new roleInformation { roleId = DirectorId, roleName = "Director" },
                new roleInformation { roleId = MovieManagerId, roleName = "MovieManager" },
                new roleInformation { roleId = TheaterManagerId, roleName = "TheaterManager" },
                new roleInformation { roleId = FacilitiesManagerId, roleName = "FacilitiesManager" }
            );

            // Seed Data for UserInformation
            var userId1 = "a1b2c3d4-e5f6-7a8b-c9d0-e1f2a3b4c5d6"; // Example GUID
            var userId2 = "b2c3d4e5-f6a7-8b9c-d0e1-f2a3b4c5d6e7"; // Example GUID
            modelBuilder.Entity<userInformation>().HasData(
                new userInformation
                {
                    userId = userId1,
                    loginUserEmail = "admin@example.com",
                    loginUserPassword = "hashed_password_admin", // In a real app, hash this password
                },
                new userInformation
                {
                    userId = userId2,
                    loginUserEmail = "user@example.com",
                    loginUserPassword = "hashed_password_user", // In a real app, hash this password
                }
            );

            var customerID = "a1b2c3d4-e5f6-7a8b-c9d0-e1f2a3b4c5e1";

            modelBuilder.Entity<Customer>().HasData(
                new Customer()
                {
                    Id = customerID,
                    userID = userId2,
                    dateOfBirth = new DateTime(2005, 09, 19),
                    IdentityCode = "0123456789",
                    Name = "Trần Anh Đức",
                    phoneNumber = "1234567890"
                });

            // Seed Data for UserRoleInformation (linking users to roles)
            modelBuilder.Entity<userRoleInformation>().HasData(
                new userRoleInformation { userId = userId1, roleId = MovieManagerId },
                new userRoleInformation { userId = userId2, roleId = customerId }
            );

            // Seed Data for Language
            var langId1 = "c3d4e5f6-a7b8-c9d0-e1f2-a3b4c5d6e7f8"; // Example GUID
            var langId2 = "d4e5f6a7-b8c9-d0e1-f2a3-b4c5d6e7f8a9"; // Example GUID
            modelBuilder.Entity<Language>().HasData(
                new Language { languageId = langId1, languageDetail = "Vietnamese" },
                new Language { languageId = langId2, languageDetail = "English" }
            );

            // Seed Data for MovieGenre
            var genreId1 = "e5f6a7b8-c9d0-e1f2-a3b4-c5d6e7f8a9b0"; // Example GUID
            var genreId2 = "f6a7b8c9-d0e1-f2a3-b4c5-d6e7f8a9b0c1"; // Example GUID
            modelBuilder.Entity<movieGenre>().HasData(
                new movieGenre { movieGenreId = genreId1, movieGenreName = "Action" },
                new movieGenre { movieGenreId = genreId2, movieGenreName = "Comedy" }
            );

            string minAge13Id = "7a8b9c0d-1e2f-3a4b-5c6d-7e8f9a0b1c2d"; // Example GUID
            string minAge16Id = "8b9c0d1e-2f3a-4b5c-6d7e-8f9a0b1c2d3e"; // Example GUID
            string minAge18Id = "9c0d1e2f-3a4b-5c6d-7e8f-9a0b1c2d3e4f"; // Example GUID

            // Seed dữ liệu cho minimumAge, sử dụng các biến đã lưu trữ
            modelBuilder.Entity<minimumAge>().HasData(
                new minimumAge
                {
                    minimumAgeID = minAge13Id,
                    minimumAgeInfo = 13,
                    minimumAgeDescription = "Phim dành cho khán giả từ 13 tuổi trở lên."
                },
                new minimumAge
                {
                    minimumAgeID = minAge16Id,
                    minimumAgeInfo = 16,
                    minimumAgeDescription = "Phim dành cho khán giả từ 16 tuổi trở lên."
                },
                new minimumAge
                {
                    minimumAgeID = minAge18Id,
                    minimumAgeInfo = 18,
                    minimumAgeDescription = "Phim dành cho khán giả từ 18 tuổi trở lên."
                }
            );

            // Seed Data for MovieInformation
            var movieId1 = "0d1e2f3a-4b5c-6d7e-8f9a-0b1c2d3e4f5a"; // Example GUID
            var movieId2 = "1e2f3a4b-5c6d-7e8f-9a0b-1c2d3e4f5a6b"; // Example GUID
            modelBuilder.Entity<movieInformation>().HasData(
                new movieInformation
                {
                    movieId = movieId1,
                    movieName = "Phim Hành Động 1",
                    movieImage = "aa.com", // Example string
                    movieDescription = "Đây là một bộ phim hành động đầy kịch tính.",
                    movieDirector = "Đạo Diễn A",
                    movieActor = "Diễn Viên X, Diễn Viên Y",
                    movieTrailerUrl = "http://trailer.com/phimhanhdong1",
                    movieDuration = 120, // minutes
                    minimumAgeID = minAge13Id,
                    languageId = langId1,
                    ReleaseDate = new DateTime(2020, 11, 01),
                    isDelete = false
                },
                new movieInformation
                {
                    movieId = movieId2,
                    movieName = "Comedy Film 1",
                    movieImage = "aa.com.vn", // Example string
                    movieDescription = "A funny movie for the whole family.",
                    movieDirector = "Director B",
                    movieActor = "Actor Z, Actress W",
                    movieTrailerUrl = "http://trailer.com/comedyfilm1",
                    movieDuration = 90, // minutes
                    languageId = langId2,
                    minimumAgeID = minAge18Id,
                    ReleaseDate = new DateTime(2025, 12, 01),
                    isDelete = false
                }
            );

            // Seed Data for MovieGenreInformation
            modelBuilder.Entity<movieGenreInformation>().HasData(
                new movieGenreInformation { movieId = movieId1, movieGenreId = genreId1 },
                new movieGenreInformation { movieId = movieId2, movieGenreId = genreId2 }
            );

            // Seed Data for Cinema
            var cinemaId1 = "2f3a4b5c-6d7e-8f9a-0b1c-2d3e4f5a6b7c"; // Example GUID
            modelBuilder.Entity<Cinema>().HasData(
                new Cinema
                {
                    cinemaId = cinemaId1,
                    cinemaName = "Rạp Chiếu Phim ABC",
                    cinemaLocation = "123 Đường XYZ, TP.HCM",
                    cinemaDescription = "Rạp chiếu phim hiện đại với nhiều phòng chiếu.",
                    cinemaContactHotlineNumber = "0901234567",
                }
            );

            // Seed Data for HourSchedule
            var hour1Id = "3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d"; // Example GUID
            var hour2Id = "4b5c6d7e-8f9a-0b1c-2d3e-4f5a6b7c8d9e"; // Example GUID
            modelBuilder.Entity<HourSchedule>().HasData(
                new HourSchedule { HourScheduleID = hour1Id, HourScheduleShowTime = "08:00" },
                new HourSchedule { HourScheduleID = hour2Id, HourScheduleShowTime = "10:00" }
            );

            // Seed Data for MovieVisualFormat
            var visualFormatId1 = "5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f"; // Example GUID
            modelBuilder.Entity<movieVisualFormat>().HasData(
                new movieVisualFormat { movieVisualFormatId = visualFormatId1, movieVisualFormatName = "2D" }
            );

            // Seed Data for CinemaRoom
            var room1Id = "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a"; // Example GUID
            modelBuilder.Entity<cinemaRoom>().HasData(
                new cinemaRoom
                {
                    cinemaRoomId = room1Id,
                    cinemaRoomNumber = 1,
                    cinemaId = cinemaId1,
                    movieVisualFormatID = visualFormatId1
                }
            );

            // Seed Data for movieSchedule
            var movieScheduleId1 = "7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b"; // Example GUID
            modelBuilder.Entity<movieSchedule>().HasData(
                new movieSchedule
                {
                    movieScheduleId = movieScheduleId1,
                    cinemaRoomId = room1Id,
                    movieId = movieId1,
                    movieVisualFormatID = visualFormatId1,
                    HourScheduleID = hour1Id,
                    IsDelete = false,
                    DayInWeekendSchedule = "Monday",
                    ScheduleDate = new DateTime(2025, 11, 11)
                }
            );

            // Seed Data for Seats
            var seat1Id = "8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c"; // Example GUID
            var seat2Id = "9a0b1c2d-3e4f-5a6b-7c8d-9e0f1a2b3c4d"; // Example GUID
            modelBuilder.Entity<Seats>().HasData(
                new Seats { seatsId = seat1Id, seatsNumber = "A1", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = seat2Id, seatsNumber = "A2", isTaken = false, cinemaRoomId = room1Id }
            );

            modelBuilder.Entity<Seats>().HasData(
                new Seats { seatsId = "a1b2c3d4-e5f6-7a8b-9c0d-1e2f3a4b5c6d", seatsNumber = "A3", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "b2c3d4e5-f6a7-8b9c-0d1e-2f3a4b5c6d7e", seatsNumber = "A4", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "c3d4e5f6-a7b8-9c0d-1e2f-3a4b5c6d7e8f", seatsNumber = "A5", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "d4e5f6a7-b8c9-0d1e-2f3a-4b5c6d7e8f9a", seatsNumber = "A6", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "e5f6a7b8-c9d0-1e2f-3a4b-5c6d7e8f9a0b", seatsNumber = "A7", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "f6a7b8c9-d0e1-2f3a-4b5c-6d7e8f9a0b1c", seatsNumber = "A8", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "a7b8c9d0-e1f2-3a4b-5c6d-7e8f9a0b1c2d", seatsNumber = "A9", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "b8c9d0e1-f2a3-4b5c-6d7e-8f9a0b1c2d3e", seatsNumber = "A10", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "c9d0e1f2-a3b4-5c6d-7e8f-9a0b1c2d3e4f", seatsNumber = "A11", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "d0e1f2a3-b4c5-6d7e-8f9a-0b1c2d3e4f5a", seatsNumber = "A12", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "e1f2a3b4-c5d6-7e8f-9a0b-1c2d3e4f5a6b", seatsNumber = "A13", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "f2a3b4c5-d6e7-8f9a-0b1c-2d3e4f5a6b7c", seatsNumber = "A14", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "a3b4c5d6-e7f8-9a0b-1c2d-3e4f5a6b7c8d", seatsNumber = "A15", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "b4c5d6e7-f8a9-0b1c-2d3e-4f5a6b7c8d9e", seatsNumber = "A16", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "c5d6e7f8-a9b0-1c2d-3e4f-5a6b7c8d9e0f", seatsNumber = "A17", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "d6e7f8a9-b0c1-2c3d-4e5f-6a7b8c9d0e1f", seatsNumber = "A18", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "e7f8a9b0-c1d2-3d4e-5f6a-7b8c9d0e1f2a", seatsNumber = "A19", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "f8a9b0c1-d2e3-4e5f-6a7b-8c9d0e1f2a3b", seatsNumber = "A20", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "a9b0c1d2-e3f4-5f6a-7b8c-9d0e1f2a3b4c", seatsNumber = "A21", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "b0c1d2e3-f4a5-6a7b-8c9d-0e1f2a3b4c5d", seatsNumber = "A22", isTaken = false, cinemaRoomId = room1Id }
            );

            // Seed Data for PriceInformation
            var priceId1 = "0b1c2d3e-4f5a-6b7c-8d9e-0f1a2b3c4d5e"; // Example GUID
            modelBuilder.Entity<PriceInformation>().HasData(
                new PriceInformation { priceInformationId = priceId1, priceAmount = 80000 }
            );

            // Seed Data for UserType
            var userTypeId1 = "1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f"; // Example GUID
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
            var foodId1 = "2d3e4f5a-6b7c-8d9e-0f1a-2b3c4d5e6f7a"; // Example GUID
            modelBuilder.Entity<foodInformation>().HasData(
                new foodInformation { foodInformationId = foodId1, foodInformationName = "Popcorn", foodPrice = 50000 }
            );
        }
    }
}