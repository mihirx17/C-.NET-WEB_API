using Microsoft.EntityFrameworkCore;
using REST_API_With_SQL_SERVER.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.
    AddDbContext<CollageDBcontext>(options => 
    options.UseSqlServer("Data Source=MIHIR\\SQLSERVER_2;Initial Catalog=DemoDb;Integrated Security=True;Trust Server Certificate=True"));

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
