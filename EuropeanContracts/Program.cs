using EuropeanContracts.Extentions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using EuropeanContracts.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationDbContex(builder.Configuration);
builder.Services.AddApplicationIdentity();
builder.Services.AddApplicationServices();

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

await app.RunAsync();
