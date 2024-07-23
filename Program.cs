using Microsoft.EntityFrameworkCore;
using ReviewApp;
using ReviewApp.Data;
using ReviewApp.Interfaces;
using ReviewApp.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Mapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); 

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Scope HTTP
builder.Services.AddScoped<IPokemonRepository, PokemonRepository>();
// add DbContext with SQL Server
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

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
