using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ProyDemo1.Data;
using ProyDemo1.Data.Repository;

var builder = WebApplication.CreateBuilder(args);


//var scopeFactory = builder.Services.getService<IserviceEscopeFactory>();
//using (var scope = scopeFactory.CreateScope())

   // var seeder = scope.ServiceProvider.GetServices<SeedDb>();
//seeder.SeedDbAsyn


// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));

builder.Services .AddScoped<IProductRepository , ProductRepository>();  //Para instanciar los repositorios
builder.Services.AddScoped<ICityRepository, CityRepository>();
builder.Services.AddScoped<ICountryRepository, CountryRepository>();

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
