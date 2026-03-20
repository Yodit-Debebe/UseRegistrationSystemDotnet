using Microsoft.EntityFrameworkCore;
using UserRegistrationSystem.Application;
using UserRegistrationSystem.Application.Interfaces;
using UserRegistrationSystem.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IUserRepository, SqlUserRepository>();
builder.Services.AddScoped<RegisterUserService>();

builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();