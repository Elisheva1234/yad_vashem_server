using DataAccess.Repositories;
using BuisnessLogic.Services;
using DataAccess.Models;
using AutoMapper;
using ReviewProject;
using Serilog;
//using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IJSONRepository, JSONRepository>();
builder.Services.AddScoped<IJSONService, JSONService>();
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod()
      .AllowAnyHeader());
});
Serilog.Log.Logger = new LoggerConfiguration().MinimumLevel.Warning().WriteTo.File("loggingFile.txt").CreateLogger();

builder.Logging.ClearProviders();
builder.Services.AddLogging(loggingBuilder => { loggingBuilder.AddSerilog(dispose: true); });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
