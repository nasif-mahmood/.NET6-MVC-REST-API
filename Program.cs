using Commander.Data;
using Commander.Models;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Newtonsoft.Json.Serialization;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

var server = builder.Configuration["DBServer"] ?? "localhost";
var port = builder.Configuration["DBPort"] ?? "1433";
// user and password should be here
var database = builder.Configuration["Database"] ?? "Commands";


builder.Services.AddDbContext<CommanderContext>(opt => opt.UseSqlServer($"Server={server},{port};Initial Catalog={database};User ID={user};Password={password}"));
builder.Services.AddControllers().AddNewtonsoftJson(s =>
{
    s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.EnableAnnotations();
});
builder.Services.AddScoped<ICommanderRepo, SqlCommanderRepo>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
var app = builder.Build();
PrepDB.PrepPopulation(app);


app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.RoutePrefix="";
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Commander API V1");
});


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
