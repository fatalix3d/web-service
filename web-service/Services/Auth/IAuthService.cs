namespace web_service.Services.Auth
{
    public interface IAuthService
    {
        Task<bool> AuthenticateAsync(string email, string password);
    }
}
