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

            // =====================================================================
            // KHÔNG CHỈNH SỬA - Dữ liệu vai trò và phân quyền người dùng
            // =====================================================================

            // Seed Data for RoleInformation (KHÔNG THAY ĐỔI)
            var cashierId = "1a8f7b9c-d4e5-4f6a-b7c8-9d0e1f2a3b4c";
            var customerId = "2b9c8d0e-f5a6-7b8c-d9e0-1f2a3b4c5d6e";
            var DirectorId = "3c0d9e1f-a6b7-c8d9-e0f1-2a3b4c5d6e7f";
            var MovieManagerId = "4d1e0f2a-b7c8-d9e0-f1a2-3b4c5d6e7f8g";
            var TheaterManagerId = "5e2f1a3b-c8d9-e0f1-a2b3-4c5d6e7f8g9h";
            var FacilitiesManagerId = "6f3a2b4c-d9e0-f1a2-b3c4-d5e6f7a8b9c0";

            modelBuilder.Entity<roleInformation>().HasData(
                new roleInformation { roleId = customerId, roleName = "Customer" },
                new roleInformation { roleId = cashierId, roleName = "Cashier" },
                new roleInformation { roleId = DirectorId, roleName = "Director" },
                new roleInformation { roleId = MovieManagerId, roleName = "MovieManager" },
                new roleInformation { roleId = TheaterManagerId, roleName = "TheaterManager" },
                new roleInformation { roleId = FacilitiesManagerId, roleName = "FacilitiesManager" }
            );

            // Seed Data for UserInformation
            var userId1 = "a1b2c3d4-e5f6-7a8b-c9d0-e1f2a3b4c5d6";
            var userId2 = "b2c3d4e5-f6a7-8b9c-d0e1-f2a3b4c5d6e7";
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

            // Seed Data for UserRoleInformation (linking users to roles) (KHÔNG THAY ĐỔI)
            modelBuilder.Entity<userRoleInformation>().HasData(
                new userRoleInformation { userId = userId1, roleId = MovieManagerId },
                new userRoleInformation { userId = userId2, roleId = customerId }
            );

            // =====================================================================
            // BẮT ĐẦU PHẦN DỮ LIỆU MỞ RỘNG
            // =====================================================================

            // --- Seed Data for Language ---
            var langId1 = "c3d4e5f6-a7b8-c9d0-e1f2-a3b4c5d6e7f8"; // Vietnamese
            var langId2 = "d4e5f6a7-b8c9-d0e1-f2a3-b4c5d6e7f8a9"; // English
            var langId3 = "11d4e5f6-a7b8-c9d0-e1f2-a3b4c5d6e711"; // Korean
            var langId4 = "22d4e5f6-a7b8-c9d0-e1f2-a3b4c5d6e722"; // Japanese
            modelBuilder.Entity<Language>().HasData(
                new Language { languageId = langId1, languageDetail = "Vietnamese" },
                new Language { languageId = langId2, languageDetail = "English" },
                new Language { languageId = langId3, languageDetail = "Korean" },
                new Language { languageId = langId4, languageDetail = "Japanese" }
            );

            // --- Seed Data for MovieGenre ---
            var genreId1 = "e5f6a7b8-c9d0-e1f2-a3b4-c5d6e7f8a9b0"; // Action
            var genreId2 = "f6a7b8c9-d0e1-f2a3-b4c5-d6e7f8a9b0c1"; // Comedy
            var genreId3 = "a1a7b8c9-d0e1-f2a3-b4c5-d6e7f8a9b0c2"; // Horror
            var genreId4 = "b2b7b8c9-d0e1-f2a3-b4c5-d6e7f8a9b0c3"; // Sci-Fi
            var genreId5 = "c3c7b8c9-d0e1-f2a3-b4c5-d6e7f8a9b0c4"; // Romance
            var genreId6 = "d4d7b8c9-d0e1-f2a3-b4c5-d6e7f8a9b0c5"; // Animation
            modelBuilder.Entity<movieGenre>().HasData(
                new movieGenre { movieGenreId = genreId1, movieGenreName = "Action" },
                new movieGenre { movieGenreId = genreId2, movieGenreName = "Comedy" },
                new movieGenre { movieGenreId = genreId3, movieGenreName = "Horror" },
                new movieGenre { movieGenreId = genreId4, movieGenreName = "Sci-Fi" },
                new movieGenre { movieGenreId = genreId5, movieGenreName = "Romance" },
                new movieGenre { movieGenreId = genreId6, movieGenreName = "Animation" }
            );

            // --- Seed Data for minimumAge ---
            string minAgePId = "6a7b8c9d-0e1f-2a3b-4c5d-6e7f8a9b0c1d"; // P-rated
            string minAge13Id = "7a8b9c0d-1e2f-3a4b-5c6d-7e8f9a0b1c2d"; // 13+
            string minAge16Id = "8b9c0d1e-2f3a-4b5c-6d7e-8f9a0b1c2d3e"; // 16+
            string minAge18Id = "9c0d1e2f-3a4b-5c6d-7e8f-9a0b1c2d3e4f"; // 18+
            modelBuilder.Entity<minimumAge>().HasData(
                new minimumAge { minimumAgeID = minAgePId, minimumAgeInfo = 0, minimumAgeDescription = "Phim phù hợp với mọi lứa tuổi." },
                new minimumAge { minimumAgeID = minAge13Id, minimumAgeInfo = 13, minimumAgeDescription = "Phim dành cho khán giả từ 13 tuổi trở lên." },
                new minimumAge { minimumAgeID = minAge16Id, minimumAgeInfo = 16, minimumAgeDescription = "Phim dành cho khán giả từ 16 tuổi trở lên." },
                new minimumAge { minimumAgeID = minAge18Id, minimumAgeInfo = 18, minimumAgeDescription = "Phim dành cho khán giả từ 18 tuổi trở lên." }
            );

            // --- Seed Data for MovieInformation ---
            var movieId1 = "0d1e2f3a-4b5c-6d7e-8f9a-0b1c2d3e4f5a"; // Phim Hành Động 1
            var movieId2 = "1e2f3a4b-5c6d-7e8f-9a0b-1c2d3e4f5a6b"; // Comedy Film 1
            var movieId3 = "2f3a4b5c-6d7e-8f9a-0b1c2d3e4f5a6b7c"; // The Conjuring
            var movieId4 = "3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d"; // Interstellar
            var movieId5 = "4b5c6d7e-8f9a-0b1c-2d3e-4f5a6b7c8d9e"; // Spirited Away
            modelBuilder.Entity<movieInformation>().HasData(
                new movieInformation
                {
                    movieId = movieId1,
                    movieName = "Phim Hành Động 1",
                    movieImage = "aa.com",
                    movieDescription = "Đây là một bộ phim hành động đầy kịch tính.",
                    movieDirector = "Đạo Diễn A",
                    movieActor = "Diễn Viên X, Diễn Viên Y",
                    movieTrailerUrl = "http://trailer.com/phimhanhdong1",
                    movieDuration = 120,
                    minimumAgeID = minAge13Id,
                    languageId = langId1,
                    ReleaseDate = new DateTime(2020, 11, 01),
                    isDelete = false
                },
                new movieInformation
                {
                    movieId = movieId2,
                    movieName = "Comedy Film 1",
                    movieImage = "aa.com.vn",
                    movieDescription = "A funny movie for the whole family.",
                    movieDirector = "Director B",
                    movieActor = "Actor Z, Actress W",
                    movieTrailerUrl = "http://trailer.com/comedyfilm1",
                    movieDuration = 90,
                    languageId = langId2,
                    minimumAgeID = minAge18Id,
                    ReleaseDate = new DateTime(2025, 12, 01),
                    isDelete = false
                },
                new movieInformation
                {
                    movieId = movieId3,
                    movieName = "Ám Ảnh Kinh Hoàng",
                    movieImage = "conjuring.com",
                    movieDescription = "Dựa trên một câu chuyện có thật, phim theo chân hai nhà điều tra hiện tượng siêu nhiên.",
                    movieDirector = "James Wan",
                    movieActor = "Vera Farmiga, Patrick Wilson",
                    movieTrailerUrl = "http://trailer.com/conjuring",
                    movieDuration = 112,
                    languageId = langId2,
                    minimumAgeID = minAge18Id,
                    ReleaseDate = new DateTime(2013, 07, 19),
                    isDelete = false
                },
                new movieInformation
                {
                    movieId = movieId4,
                    movieName = "Hố Đen Du Hành",
                    movieImage = "interstellar.com",
                    movieDescription = "Một nhóm các nhà du hành vũ trụ đi qua một hố sâu để tìm một ngôi nhà mới cho nhân loại.",
                    movieDirector = "Christopher Nolan",
                    movieActor = "Matthew McConaughey, Anne Hathaway",
                    movieTrailerUrl = "http://trailer.com/interstellar",
                    movieDuration = 169,
                    languageId = langId2,
                    minimumAgeID = minAge13Id,
                    ReleaseDate = new DateTime(2014, 11, 07),
                    isDelete = false
                },
                new movieInformation
                {
                    movieId = movieId5,
                    movieName = "Vùng Đất Linh Hồn",
                    movieImage = "spiritedaway.com",
                    movieDescription = "Trong lúc chuyển nhà, cô bé Chihiro và gia đình đã lạc vào một thế giới của các vị thần.",
                    movieDirector = "Hayao Miyazaki",
                    movieActor = "Rumi Hiiragi, Miyu Irino",
                    movieTrailerUrl = "http://trailer.com/spiritedaway",
                    movieDuration = 125,
                    languageId = langId4,
                    minimumAgeID = minAgePId,
                    ReleaseDate = new DateTime(2001, 07, 20),
                    isDelete = false
                }
            );

            // --- Seed Data for MovieGenreInformation ---
            modelBuilder.Entity<movieGenreInformation>().HasData(
                new movieGenreInformation { movieId = movieId1, movieGenreId = genreId1 },
                new movieGenreInformation { movieId = movieId2, movieGenreId = genreId2 },
                new movieGenreInformation { movieId = movieId3, movieGenreId = genreId3 },
                new movieGenreInformation { movieId = movieId4, movieGenreId = genreId4 },
                new movieGenreInformation { movieId = movieId4, movieGenreId = genreId1 }, // Interstellar is also Action
                new movieGenreInformation { movieId = movieId5, movieGenreId = genreId6 }
            );

            // --- Seed Data for Cinema ---
            var cinemaId1 = "2f3a4b5c-6d7e-8f9a-0b1c-2d3e4f5a6b7c"; // Rạp ABC
            var cinemaId2 = "5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f"; // Rạp LMN
            modelBuilder.Entity<Cinema>().HasData(
                new Cinema
                {
                    cinemaId = cinemaId1,
                    cinemaName = "Rạp Chiếu Phim ABC",
                    cinemaLocation = "123 Đường XYZ, TP.HCM",
                    cinemaDescription = "Rạp chiếu phim hiện đại với nhiều phòng chiếu.",
                    cinemaContactHotlineNumber = "0901234567",
                },
                new Cinema
                {
                    cinemaId = cinemaId2,
                    cinemaName = "Rạp Chiếu Phim LMN",
                    cinemaLocation = "456 Đường UVW, Hà Nội",
                    cinemaDescription = "Không gian ấm cúng, chất lượng hàng đầu.",
                    cinemaContactHotlineNumber = "0987654321",
                }
            );

            // --- Seed Data for MovieVisualFormat ---
            var visualFormatId1 = "5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f"; // 2D
            var visualFormatId2 = "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a"; // 3D
            var visualFormatId3 = "7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b"; // IMAX
            modelBuilder.Entity<movieVisualFormat>().HasData(
                new movieVisualFormat { movieVisualFormatId = visualFormatId1, movieVisualFormatName = "2D" },
                new movieVisualFormat { movieVisualFormatId = visualFormatId2, movieVisualFormatName = "3D" },
                new movieVisualFormat { movieVisualFormatId = visualFormatId3, movieVisualFormatName = "IMAX" }
            );

            // --- Seed Data for CinemaRoom ---
            var room1Id = "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a"; // Room 1 - Cinema 1 (2D)
            var room2Id = "7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b"; // Room 2 - Cinema 1 (3D)
            var room3Id = "8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c"; // Room 1 - Cinema 2 (2D)
            var room4Id = "9a0b1c2d-3e4f-5a6b-7c8d-9e0f1a2b3c4d"; // Room 2 - Cinema 2 (IMAX)
            modelBuilder.Entity<cinemaRoom>().HasData(
                new cinemaRoom { cinemaRoomId = room1Id, cinemaRoomNumber = 1, cinemaId = cinemaId1, movieVisualFormatID = visualFormatId1 },
                new cinemaRoom { cinemaRoomId = room2Id, cinemaRoomNumber = 2, cinemaId = cinemaId1, movieVisualFormatID = visualFormatId2 },
                new cinemaRoom { cinemaRoomId = room3Id, cinemaRoomNumber = 1, cinemaId = cinemaId2, movieVisualFormatID = visualFormatId1 },
                new cinemaRoom { cinemaRoomId = room4Id, cinemaRoomNumber = 2, cinemaId = cinemaId2, movieVisualFormatID = visualFormatId3 }
            );

            // --- Seed Data for HourSchedule ---
            var hour1Id = "3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d"; // 08:00
            var hour2Id = "4b5c6d7e-8f9a-0b1c-2d3e-4f5a6b7c8d9e"; // 10:00
            var hour3Id = "5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f"; // 14:00
            var hour4Id = "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a"; // 16:30
            var hour5Id = "7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b"; // 19:00
            var hour6Id = "8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c"; // 21:30
            modelBuilder.Entity<HourSchedule>().HasData(
                new HourSchedule { HourScheduleID = hour1Id, HourScheduleShowTime = "08:00" },
                new HourSchedule { HourScheduleID = hour2Id, HourScheduleShowTime = "10:00" },
                new HourSchedule { HourScheduleID = hour3Id, HourScheduleShowTime = "14:00" },
                new HourSchedule { HourScheduleID = hour4Id, HourScheduleShowTime = "16:30" },
                new HourSchedule { HourScheduleID = hour5Id, HourScheduleShowTime = "19:00" },
                new HourSchedule { HourScheduleID = hour6Id, HourScheduleShowTime = "21:30" }
            );

            // --- Seed Data for movieSchedule ---
            var movieScheduleId1 = "7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b"; // Phim Hanh Dong 1
            var movieScheduleId2 = "8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c"; // Am Anh Kinh Hoang
            var movieScheduleId3 = "9a0b1c2d-3e4f-5a6b-7c8d-9e0f1a2b3c4d"; // Ho Den Du Hanh
            var movieScheduleId4 = "a1b2c3d4-e5f6-7a8b-c9d0-e1f2a3b4c5d6"; // Vung Dat Linh Hon
            modelBuilder.Entity<movieSchedule>().HasData(
                new movieSchedule { movieScheduleId = movieScheduleId1, cinemaRoomId = room1Id, movieId = movieId1, movieVisualFormatID = visualFormatId1, HourScheduleID = hour1Id, IsDelete = false, DayInWeekendSchedule = "Monday", ScheduleDate = new DateTime(2025, 11, 11) },
                new movieSchedule { movieScheduleId = movieScheduleId2, cinemaRoomId = room1Id, movieId = movieId3, movieVisualFormatID = visualFormatId1, HourScheduleID = hour6Id, IsDelete = false, DayInWeekendSchedule = "Friday", ScheduleDate = new DateTime(2025, 11, 15) },
                new movieSchedule { movieScheduleId = movieScheduleId3, cinemaRoomId = room4Id, movieId = movieId4, movieVisualFormatID = visualFormatId3, HourScheduleID = hour5Id, IsDelete = false, DayInWeekendSchedule = "Saturday", ScheduleDate = new DateTime(2025, 11, 16) },
                new movieSchedule { movieScheduleId = movieScheduleId4, cinemaRoomId = room3Id, movieId = movieId5, movieVisualFormatID = visualFormatId1, HourScheduleID = hour2Id, IsDelete = false, DayInWeekendSchedule = "Sunday", ScheduleDate = new DateTime(2025, 11, 17) }
            );

            // --- Seed Data for Seats ---
            // Seats for Room 1 (đã có)
            modelBuilder.Entity<Seats>().HasData(
                new Seats { seatsId = "8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c", seatsNumber = "A1", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "9a0b1c2d-3e4f-5a6b-7c8d-9e0f1a2b3c4d", seatsNumber = "A2", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "a1b2c3d4-e5f6-7a8b-9c0d-1e2f3a4b5c6d", seatsNumber = "A3", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "b2c3d4e5-f6a7-8b9c-0d1e-2f3a4b5c6d7e", seatsNumber = "A4", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "c3d4e5f6-a7b8-9c0d-1e2f-3a4b5c6d7e8f", seatsNumber = "A5", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "d4e5f6a7-b8c9-0d1e-2f3a-4b5c6d7e8f9a", seatsNumber = "A6", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "e5f6a7b8-c9d0-1e2f-3a4b-5c6d7e8f9a0b", seatsNumber = "A7", isTaken = false, cinemaRoomId = room1Id },
                new Seats { seatsId = "f6a7b8c9-d0e1-2f3a-4b5c-6d7e8f9a0b1c", seatsNumber = "A8", isTaken = false, cinemaRoomId = room1Id }
                //... (giữ các ghế đã có)
            );

            // Seats for Room 2
            modelBuilder.Entity<Seats>().HasData(
                new Seats { seatsId = "11111111-2d3e-4f5a-6b7c-8d9e0f1a2b3c", seatsNumber = "B1", isTaken = false, cinemaRoomId = room2Id },
                new Seats { seatsId = "22222222-3e4f-5a6b-7c8d-9e0f1a2b3c4d", seatsNumber = "B2", isTaken = false, cinemaRoomId = room2Id },
                new Seats { seatsId = "33333333-4f5a-6b7c-8d9e-0f1a2b3c4d5e", seatsNumber = "B3", isTaken = false, cinemaRoomId = room2Id }
            );
            // Seats for Room 3
            modelBuilder.Entity<Seats>().HasData(
                new Seats { seatsId = "44444444-5a6b-7c8d-9e0f-1a2b3c4d5e6f", seatsNumber = "C1", isTaken = false, cinemaRoomId = room3Id },
                new Seats { seatsId = "55555555-6b7c-8d9e-0f1a-2b3c4d5e6f7a", seatsNumber = "C2", isTaken = false, cinemaRoomId = room3Id }
            );
            // Seats for Room 4
            modelBuilder.Entity<Seats>().HasData(
                 new Seats { seatsId = "66666666-7c8d-9e0f-1a2b-3c4d5e6f7a8b", seatsNumber = "D1", isTaken = false, cinemaRoomId = room4Id },
                 new Seats { seatsId = "77777777-8d9e-0f1a-2b3c-4d5e6f7a8b9c", seatsNumber = "D2", isTaken = false, cinemaRoomId = room4Id }
            );


            // --- Seed Data for PriceInformation ---
            var priceId1 = "0b1c2d3e-4f5a-6b7c-8d9e-0f1a2b3c4d5e"; // 80,000 (Adult 2D)
            var priceId2 = "1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f"; // 120,000 (Adult 3D/IMAX)
            var priceId3 = "2d3e4f5a-6b7c-8d9e-0f1a-2b3c4d5e6f7a"; // 70,000 (Student 2D)
            var priceId4 = "3e4f5a6b-7c8d-9e0f-1a2b-3c4d5e6f7a8b"; // 60,000 (Child 2D)
            modelBuilder.Entity<PriceInformation>().HasData(
                new PriceInformation { priceInformationId = priceId1, priceAmount = 80000 },
                new PriceInformation { priceInformationId = priceId2, priceAmount = 120000 },
                new PriceInformation { priceInformationId = priceId3, priceAmount = 70000 },
                new PriceInformation { priceInformationId = priceId4, priceAmount = 60000 }
            );

            // --- Seed Data for UserType ---
            var userTypeId1 = "1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f"; // Adult
            var userTypeId2 = "2d3e4f5a-6b7c-8d9e-0f1a-2b3c4d5e6f7a"; // Child
            var userTypeId3 = "3e4f5a6b-7c8d-9e0f-1a2b-3c4d5e6f7a8b"; // Student
            modelBuilder.Entity<userType>().HasData(
                new userType { userTypeId = userTypeId1, userTypeDescription = "Adult" },
                new userType { userTypeId = userTypeId2, userTypeDescription = "Child" },
                new userType { userTypeId = userTypeId3, userTypeDescription = "Student" }
            );

            // --- Seed Data for PriceInformationForEachUserFilmType ---
            modelBuilder.Entity<priceInformationForEachUserFilmType>().HasData(
                // Adult prices
                new priceInformationForEachUserFilmType { userTypeId = userTypeId1, movieVisualFormatId = visualFormatId1, priceInformationID = priceId1 },
                new priceInformationForEachUserFilmType { userTypeId = userTypeId1, movieVisualFormatId = visualFormatId2, priceInformationID = priceId2 },
                new priceInformationForEachUserFilmType { userTypeId = userTypeId1, movieVisualFormatId = visualFormatId3, priceInformationID = priceId2 },
                // Child prices
                new priceInformationForEachUserFilmType { userTypeId = userTypeId2, movieVisualFormatId = visualFormatId1, priceInformationID = priceId4 },
                // Student prices
                new priceInformationForEachUserFilmType { userTypeId = userTypeId3, movieVisualFormatId = visualFormatId1, priceInformationID = priceId3 }
            );

            // --- Seed Data for FoodInformation ---
            var foodId1 = "2d3e4f5a-6b7c-8d9e-0f1a-2b3c4d5e6f7a"; // Popcorn
            var foodId2 = "3e4f5a6b-7c8d-9e0f-1a2b-3c4d5e6f7a8b"; // Coca-Cola
            var foodId3 = "4f5a6b7c-8d9e-0f1a-2b3c-4d5e6f7a8b9c"; // Nachos
            var foodId4 = "5a6b7c8d-9e0f-1a2b-3c4d-5e6f7a8b9c0d"; // Hot Dog
            modelBuilder.Entity<foodInformation>().HasData(
                new foodInformation { foodInformationId = foodId1, foodInformationName = "Popcorn", foodPrice = 50000 },
                new foodInformation { foodInformationId = foodId2, foodInformationName = "Coca-Cola", foodPrice = 25000 },
                new foodInformation { foodInformationId = foodId3, foodInformationName = "Nachos", foodPrice = 65000 },
                new foodInformation { foodInformationId = foodId4, foodInformationName = "Hot Dog", foodPrice = 45000 }
            );
        }
    }
}