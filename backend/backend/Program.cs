using backend.Data;
using backend.Interface.Auth;
using backend.Interface.Customter;
using backend.Model.Auth;
using backend.Services.Auth;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using backend.Services.MovieServices;
using backend;
using backend.Interface.GenericsInterface;
using backend.ModelDTO.MoviesDTO.MovieRequest;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using backend.Interface.MovieInterface;
using backend.Interface.Schedule;
using backend.Services.Schedule;
using backend.Services.BookingHistoryServices;
using backend.Interface.BookingInterface;
using backend.Services.BookingServices;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAuthorization(
    options =>
    {
        options.AddPolicy("Customer", policy =>
        {
            policy.RequireRole("Customer");
        });
    });

builder.Services.AddAuthorization
    (options => 
    options.AddPolicy
    ("Director", policy => policy.RequireRole("Director")));

// Add thêm JWT services

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Iss"],
            ValidAudience = builder.Configuration["Jwt:Aud"],
            IssuerSigningKey = new SymmetricSecurityKey(UTF8Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });
// Add thêm DI của các services
// Auth services
builder.Services.AddScoped<IAuth, AuthService>();

// Add thêm DI của services Movie dạng Scoped

builder.Services.AddScoped<IMovieService, movieServices>();

// Add thêm DI của Service user

builder.Services.AddScoped<IOrderDetail, OrderDetailServices>();

// DI MovieSchedule

builder.Services.AddScoped<IScheduleServices, ScheduleServices>();

// DI của Booking

builder.Services.AddScoped<IBookingServices, BookingServices>();

Console.WriteLine(builder.Configuration.GetConnectionString("DefaultConnection"));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseMiddleware<AuthMiddleware>();


app.UseAuthorization();

app.MapControllers();

app.Run();



