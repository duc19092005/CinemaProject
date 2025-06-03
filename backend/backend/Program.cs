
using backend.Data;
using backend.Interface.Auth;
using backend.Model.Auth;
using backend.Services.Auth;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add thêm DI của các services
// Auth services
builder.Services.AddScoped<IAuth, AuthService>();

Console.WriteLine(builder.Configuration.GetConnectionString("DefaultConnection"));

var app = builder.Build();

string user1 = Guid.NewGuid().ToString();
string user2 = Guid.NewGuid().ToString();
string role1 = Guid.NewGuid().ToString();
string role2 = Guid.NewGuid().ToString();   

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var dbContext = services.GetRequiredService<DataContext>();

        // Logic thêm dữ liệu ban đầu (Seeding Data)
        if (!dbContext.userInformation.Any()) // Kiểm tra nếu bảng userInformation rỗng
        {
            var users = new List<userInformation>
            {
                new userInformation()
                {
                    userId = user1,
                    loginUserEmail = "abc@gmail.com",
                    loginUserPassword = "123", // Trong thực tế, KHÔNG LƯU MẬT KHẨU RÕ RÀNG NHƯ VẬY! Cần hash.
                    dateOfBirth = new DateTime(2025, 9, 19),
                    phoneNumber = "0123456789",
                    userName = "duc",
                    IdentityCode = "x",
                    userPoint = 0
                },
                new userInformation()
                {
                    userId = user2,
                    loginUserEmail = "abcd@gmail.com",
                    loginUserPassword = "1234", // KHÔNG LƯU MẬT KHẨU RÕ RÀNG!
                    dateOfBirth = new DateTime(2025, 10, 19),
                    phoneNumber = "0123456789",
                    userName = "duc1",
                    IdentityCode = "x",
                    userPoint = 0
                }
            };
            dbContext.userInformation.AddRange(users);
            dbContext.roleInformation.AddRange(new roleInformation()
            {
                roleId = role1,
                roleName = "Director"
            }, new roleInformation()
            {
                roleId = role2,
                roleName = "User"
            });
            dbContext.userRoleInformation.Add(new userRoleInformation()
            {
                roleId = role1,
                userId = user1
            });
            dbContext.SaveChanges();
            Console.WriteLine("Dữ liệu người dùng ban đầu đã được thêm thành công.");
        }
        else
        {
            Console.WriteLine("Dữ liệu người dùng đã tồn tại. Bỏ qua seeding.");
        }
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Đã xảy ra lỗi khi khởi tạo DB.");
    }
}

app.UseSwagger();
app.UseSwaggerUI();


app.UseAuthorization();

app.MapControllers();

app.Run();



