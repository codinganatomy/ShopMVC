using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopMVC.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ShopMVCContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ShopMVCContext") ?? throw new InvalidOperationException("Connection string 'ShopMVCContext' not found.")));

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
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

//app.MapControllerRoute(
//    name: "blog",
//    pattern: "blog/{year}/{month}/{day}/{slug}",
//    defaults: new { controller = "Blog", action = "Post" },
//    constraints: new { year = @"\d{4}", month = @"\d{2}", day = @"\d{2}" }
//);


app.Run();
