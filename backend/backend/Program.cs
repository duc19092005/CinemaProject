
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

app.UseSwagger();
app.UseSwaggerUI();


app.UseAuthorization();

app.MapControllers();

app.Run();



