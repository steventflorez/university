
using Microsoft.EntityFrameworkCore;
using university_backent.dataAccess;

var builder = WebApplication.CreateBuilder(args);

const String CONNECTIONNAME = "UniversityDB";  
var conectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

builder.Services.AddDbContext<UniversityContext>(options => options.UseSqlServer(conectionString));

// Add services to the container.

builder.Services.AddControllers();
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
