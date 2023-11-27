using MyCollage_EF_Rep_AsyncAwait.Models;
using MyCollage_EF_Rep_AsyncAwait.Repositories;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddScoped<IStudentRepository,StudentRepository>();
builder.Services.AddScoped<ICourseRepository,CourseRepository>();
var ConectionString= builder.Configuration.GetConnectionString("MyConnection");
builder.Services.AddDbContext<MyDbContext>(Options => Options.UseMySql(ConectionString,ServerVersion.AutoDetect(ConectionString)));

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
