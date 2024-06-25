using EditorPriceListExemple.Interface;
using EditorPriceListExemple.Models;
using EditorPriceListExemple.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDBContext>(options => options.UseSqlServer(connection));

builder.Services.AddTransient<IGoods, GoodsRepository>();
builder.Services.AddTransient<IPriceList,PriceListRepository>();
builder.Services.AddTransient<IAttribute, AttrebuteRepository>();
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=PriceList}/{action=IndexPriceList}/{id?}");

app.Run();
