using GaziProject.GaziProjectDbContext;
using GaziProject.Models;
using GaziProject.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IOgrenciDersManager, OgrenciDersManager>();
builder.Services.AddScoped<IOgrenciManager, OgrenciManager>();
builder.Services.AddScoped<IBolumManager, BolumManager>();
builder.Services.AddScoped<IDersManager, DersManager>();
builder.Services.AddScoped<GaziProjectContext>();
builder.Services.AddControllersWithViews();

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
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

using (var scope = app.Services.CreateScope())

{

    var dataContext = scope.ServiceProvider.GetRequiredService<GaziProjectContext>();

    dataContext.Database.Migrate();

}
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
