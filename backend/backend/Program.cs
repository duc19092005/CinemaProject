
using backend.Data;
using backend.Interface.Auth;
using backend.Interface.Customter;
using backend.Model.Auth;
using backend.Services.Auth;
using backend.Services.CustomerServices;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using backend.Services.MovieServices;
using backend;
using backend.Interface.GenericsInterface;
using backend.ModelDTO.MoviesDTO.MovieRequest;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add thêm DI của các services
// Auth services
builder.Services.AddScoped<IAuth, AuthService>();

// Add thêm DI của services Movie dạng Scoped

builder.Services.AddScoped<GenericInterface<MovieRequestDTO>, movieServices>();

// Add thêm DI của Service user

builder.Services.AddScoped<IOrderDetail, OrderDetailServices>();

Console.WriteLine(builder.Configuration.GetConnectionString("DefaultConnection"));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();


app.UseAuthorization();

app.MapControllers();

app.Run();



