using web_service.Services.Auth;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IAuthService, AuthService>();
var app = builder.Build();

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=index}/{id?}");

app.Run();
