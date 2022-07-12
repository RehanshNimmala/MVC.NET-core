using Microsoft.EntityFrameworkCore;
using NimmalaWeek5.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Dependency Injection: is app.services object pass the connection string object to the context class,which was created later after connection string 
//object is created

//get the output directory
var path =Directory.GetCurrentDirectory();

//Get access to the connection string object through configuration setting
IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsetting.json").Build();

//DI passes the connstring to the context object with correct directory path
builder.Services.AddDbContext<NPGoldContext>(Option => Option.UseSqlServer(configuration.GetConnectionString
    ("NPGoldConnString").Replace("|DataDirectory|", path)));








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
