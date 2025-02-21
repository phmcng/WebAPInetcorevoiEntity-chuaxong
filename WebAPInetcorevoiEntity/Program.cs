using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ett1_web_api.Data; // ch?a khai báo StudentContext
using System;

var builder = WebApplication.CreateBuilder(args);

if (1 < 0) // gán c?ng b?ng l?nh
    builder.Services.AddDbContext<StudentContext>(options =>
                options.UseSqlServer("Server=DESKTOP-PTTBFU9\BICHHUONG; Database=StudentDB;User Id=dba;Password=demo123456;"));
else // l?y t? c?u hình appsettings.json
    builder.Services.AddDbContext<StudentContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("StudentDBConnectionString")));

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
