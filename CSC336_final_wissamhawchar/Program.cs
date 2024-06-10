using _final_BLL.Mapping;
using _final_BLL.Services.Airplanes;
using _final_BLL.Services.Flights;
using _final_BLL.Services.Passengers;
using _final_BLL.Services.Pilots;
using _final_BLL.Services.Reservations;
using _final_DAL.Models;
using _final_DAL.Repositries.Airplanes;
using _final_DAL.Repositries.Flights;
using _final_DAL.Repositries.Passengers;
using _final_DAL.Repositries.Pilots;
using _final_DAL.Repositries.Reservations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", policy =>
    {
        policy.AllowAnyHeader()
              .AllowAnyMethod()
              .AllowAnyOrigin();
    });
});
builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile(new MappingProfile());
}, typeof(Program));
builder.Services.AddDbContext<AirplaneSystemContext>();
builder.Services.AddScoped<IAirplaneRepository, AirplaneRepository>();
builder.Services.AddScoped<IFlightRepository, FlightRepository>();
builder.Services.AddScoped<IPassengerRepository, PassengerRepository>();
builder.Services.AddScoped<IPilotRepository, PilotRepository>();
builder.Services.AddScoped<IReservationRepository, ReservationRepository>();
builder.Services.AddScoped<IAirplaneService, AirplaneService>();
builder.Services.AddScoped<IFlightService, FlightService>();
builder.Services.AddScoped<IPassengerService, PassengerService>();
builder.Services.AddScoped<IPilotService, PilotService>();
builder.Services.AddScoped<IReservationService, ReservationService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
