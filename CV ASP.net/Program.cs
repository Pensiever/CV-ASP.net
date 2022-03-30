using CV_ASP.net.Tools;
using Microsoft.AspNetCore.Authorization;
using ModelGlobal_DataAccessLayer.Repositories;
using ModelGlobal_DataAccessLayer.Services;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddHttpContextAccessor();
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.Cookie.Name = "CV_ASP.netCookie";
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
    options.IdleTimeout = TimeSpan.FromMinutes(10);
});

builder.Services.AddScoped<IPersonRepository, PersonService>();
builder.Services.AddScoped<IProfessionRepository, ProfessionService>();
builder.Services.AddScoped<ISkillRepository, SkillService>();

builder.Services.AddScoped<IAppUserRepository, AppUserService>();

builder.Services.AddScoped<SessionManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

#region Configuration pour le décimal dans les formulaires
CultureInfo culture = new CultureInfo("fr-FR");
culture.NumberFormat.NumberDecimalSeparator = ".";

CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;

app.UseRequestLocalization();

#endregion

app.UseSession();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Person}/{action=Index}/{id?}");

app.Run();
