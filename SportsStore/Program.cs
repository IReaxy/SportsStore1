using Microsoft.EntityFrameworkCore;
using SportsStore.Models;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IStoreRepository, EFStoreRepository>();

builder.Services.AddDbContext<StoreDbContext>(opts =>
{
    opts.UseSqlServer(
        builder.Configuration["ConnetionStrings:SportsStoreConnection"]);

});


var app = builder.Build();



app.UseStaticFiles();
app.MapDefaultControllerRoute();

SeedData.EnsurePopulated(app);

app.Run();
