using ASP.SocialNetwork;
using ASP.SocialNetwork.Controllers;
using ASP.SocialNetwork.Controllers.Repository;
using ASP.SocialNetwork.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using System.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
string connection = "Server=.\\SQLEXPRESS;Database=HOME-PC\\SQLEXPRESS;Trusted_Connection=True;TrustServerCertificate=True";
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(connection));
builder.Services.AddIdentity<User, IdentityRole>()
        .AddEntityFrameworkStores<ApplicationDbContext>()
        .AddDefaultTokenProviders();
var mapperConfig = new MapperConfiguration((v) =>
{
    v.AddProfile(new MappingProfile());
});
IMapper mapper = mapperConfig.CreateMapper();

builder.Services.AddSingleton(mapper);


builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
// Add services to the container.
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
