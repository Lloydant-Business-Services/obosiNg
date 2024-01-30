using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Application.Services;
using Obosi.ng.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services
    .AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString
    ("DataContext")),
    ServiceLifetime.Transient);
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddTransient<IBlog, BlogService>();
builder.Services.AddTransient<ICalender, CalenderService>();
builder.Services.AddTransient<INews, NewsService>();
builder.Services.AddTransient<IExecutive,ExecutiveService>();
builder.Services.AddTransient<IMedia,MediaService>();
builder.Services.AddTransient<IUnit, UnitService>();
builder.Services.AddTransient<IUser,UserService>();

builder.Services.Configure<CookiePolicyOptions>(options =>
{
    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
    options.CheckConsentNeeded = context => false;
    options.MinimumSameSitePolicy = SameSiteMode.None;
});
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options => {
    options.AccessDeniedPath = "/Account/Enter"; //Replace with Error page for Access Denied
    options.LoginPath = "/Account/Enter"; //Replace with Error Page for Not Logged in
    options.LogoutPath = "/Account/Logout";
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        var context = services.GetRequiredService<DataContext>();
        context.Database.Migrate();
    }
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}





app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseDefaultFiles();


app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
                  Path.Combine(Directory.GetCurrentDirectory(), @"Images")),
    RequestPath = "/Images"

});

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
