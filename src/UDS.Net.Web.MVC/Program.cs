using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UDS.Net.API.Client;
using UDS.Net.Services;
using UDS.Net.Web.MVC.Data;
using UDS.Net.Web.MVC.Services;
using Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
// Replace identity service with your preferred provider rather than using this one. Roles required:
// Administrator
// SuperUser
// Examiner\
var connectionString = configuration.GetConnectionString("AuthServiceConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

////*************************************************************************************************
// Replace API and implemented services with your own if you don't want to use the included API here
// 
builder.Services.AddUDSApiClient(configuration.GetValue<string>("DownStreamApis:UDSNetApi:BaseUrl"));

builder.Services.AddSingleton<IParticipationService, ParticipationService>();
builder.Services.AddSingleton<IVisitService, VisitService>();
////*************************************************************************************************

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var mvcBuilder = builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

#if DEBUG
    mvcBuilder.AddRazorRuntimeCompilation();
#endif

// Uncomment to enforce authentication
//builder.Services.AddAuthorization(options =>
//{
//    options.FallbackPolicy = new AuthorizationPolicyBuilder()
//        .RequireAuthenticatedUser()
//        .Build();
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    using (var scope = app.Services.CreateScope())
    {
        var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        db.Database.Migrate();
    }
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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

app.Run();

