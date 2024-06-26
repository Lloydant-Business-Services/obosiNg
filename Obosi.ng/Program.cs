using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Application.Services;
using Obosi.ng.Data;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.MSSqlServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services
    .AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString
    ("DataContext")),
    ServiceLifetime.Transient);
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddTransient<IBlog, BlogService>();
builder.Services.AddTransient<ICalender, CalenderService>();
builder.Services.AddTransient<INews, NewsService>();
builder.Services.AddTransient<IExecutive, ExecutiveService>();
builder.Services.AddTransient<IMedia, MediaService>();
builder.Services.AddTransient<IUnit, UnitService>();
builder.Services.AddTransient<IUser, UserService>();
builder.Services.AddTransient<IBoulevard, BoulevardService>();
builder.Services.AddTransient<IMenuService, MenuService>();
builder.Services.AddTransient<IMenuInRoleService, MenuInRoleService>();
builder.Services.AddTransient<IAboutService, AboutService>();
builder.Services.AddTransient<IAka, AkaService>();
builder.Services.AddTransient<IImenne, ImenneService>();
builder.Services.AddTransient<IUmunna, UmunnaService>();
builder.Services.AddTransient<IVillage, VillageService>();
builder.Services.AddTransient<IPostService,PostService>();
builder.Services.AddTransient<INotification,NotificationService>();
builder.Services.AddTransient<IForum, ForumService>();



builder.Services.Configure<CookiePolicyOptions>(options =>
{
    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
    options.CheckConsentNeeded = context => false;
    options.MinimumSameSitePolicy = SameSiteMode.None;
});
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.AccessDeniedPath = "/Account/Enter"; //Replace with Error page for Access Denied
    options.LoginPath = "/Account/Enter"; //Replace with Error Page for Not Logged in
    options.LogoutPath = "/Account/Logout";
});

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
    .MinimumLevel.Override("System", LogEventLevel.Warning)
    .WriteTo.Console()
    .WriteTo.MSSqlServer(
        connectionString: builder.Configuration.GetConnectionString
    ("DataContext_log"),
        sinkOptions: new MSSqlServerSinkOptions
        {
            TableName = "Logs",
            AutoCreateSqlDatabase = true,
            AutoCreateSqlTable = true,
        },
        columnOptions: new Serilog.Sinks.MSSqlServer.ColumnOptions
        {

            //AdditionalColumns = new Collection<SqlColumn>
            //{
            //    new SqlColumn { ColumnName = "MyCustomColumn", DataType = SqlDbType.NVarChar, DataLength = 1000 }
            //}
        })
    .CreateLogger();

builder.Host.UseSerilog();

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
else
{
    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        var context = services.GetRequiredService<DataContext>();
        context.Database.Migrate();
    }
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
//app.PrepareDatabase().GetAwaiter().GetResult();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
