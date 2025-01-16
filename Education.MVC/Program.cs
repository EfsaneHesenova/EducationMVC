using Education.BL.Profiles.CategoryProfiles;
using Education.BL.Services.Abstractions;
using Education.BL.Services.Implementations;
using Education.DAL.Contexts;
using Education.DAL.Repositories.Abstractions;
using Education.DAL.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();



builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("MsSql"));
});

builder.Services.AddAutoMapper(typeof(CategoryProfile).Assembly);
builder.Services.AddScoped<INewsService, NewsService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<INewsRepository, NewsRepository>();

var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
          );

app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}"
          );

app.Run();
