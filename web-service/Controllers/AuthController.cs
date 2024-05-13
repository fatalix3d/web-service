using Microsoft.AspNetCore.Mvc;
using web_service.Services.Auth;

namespace web_service.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task Login([FromServices] IAuthService authService, string email, string password)
        {
            var loginStatus = await authService.AuthenticateAsync(email, password);

            if (loginStatus)
                await Response.WriteAsync($"Access granted");
            else
                await Response.WriteAsync($"Access denied");

        }
    }
}
