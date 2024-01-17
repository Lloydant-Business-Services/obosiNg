using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Obosi.ng.Data;
using Obosi.ng.Services.Implementation;
using Obosi.ng.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services
    .AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString
    ("DataContext")),
    ServiceLifetime.Transient);

//Services
builder.Services.AddTransient<IBlogService, BlogService>();
builder.Services.AddTransient<IExecutiveService, ExecutiveService>();
builder.Services.AddTransient<IMediaService, MediaService>();
builder.Services.AddTransient<IUnitTypeService, UnitTypeService>();
builder.Services.AddTransient<IUnitService, UnitService>();
builder.Services.AddTransient<IEventService, EventService>();
builder.Services.AddTransient<INewsService, NewsService>();
builder.Services.AddTransient<IPostService, PostService>(); 
builder.Services.AddTransient<IUserService, UserService>();


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
