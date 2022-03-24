using SearchProductList.Tool;
using SearchProductList.Models;
using SearchProductList.Repository;
using SearchProductList.Repository.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<Service>();
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IGetTokenRepository, GetTokenRepository>();
builder.Services.AddSingleton<IGetProductListRepository, GetProductListRepository>();
builder.Services.Configure<DatabaseSettingsModel>(builder.Configuration.GetSection("MongoDatabase"));

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
