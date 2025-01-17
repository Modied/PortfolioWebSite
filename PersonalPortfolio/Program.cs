using Microsoft.EntityFrameworkCore;
using PortfolioRepository.Core.Interfaces;
using PortfolioRepository.Core.Models;
using PortfolioService.Services;
using PortfolioWOF.EF.Data;
using PortfolioWOF.EF.Repositories;
using System.ComponentModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(Program));
/*******************************/
var connectionString = builder.Configuration.GetConnectionString("DefualtConnection");
builder.Services.AddDbContext<PortfolioDBContext>(option => option.UseSqlServer(connectionString));

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IProfile, ProfileService>();
//builder.Services.AddScoped<IWebHostEnvironment>();

/*******************************/
var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=PersonalInfo}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
