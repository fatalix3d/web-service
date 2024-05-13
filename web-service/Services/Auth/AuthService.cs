namespace web_service.Services.Auth
{
    public class AuthService : IAuthService
    {
        public Task<bool> AuthenticateAsync(string email, string password)
        {
            if (email == "luckytima@gmail.com" && password == "222")
                return Task.FromResult(true);
            else
                return  Task.FromResult(false); 
        }
    }
}
