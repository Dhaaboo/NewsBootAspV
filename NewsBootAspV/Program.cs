using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NewsBootAspV.Data;

var _blder = WebApplication.CreateBuilder(args);
var _Src = _blder.Services;
// Add services to the container.
var _CStr = _blder.Configuration.GetConnectionString("NewsBootAspV") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
_Src.AddDbContext<APPDBC>(options => options.UseSqlServer(_CStr));
_Src.AddDatabaseDeveloperPageExceptionFilter();

_Src.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<APPDBC>();
_Src.AddControllersWithViews();

var app = _blder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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

app.MapRazorPages()
   .WithStaticAssets();

app.Run();
