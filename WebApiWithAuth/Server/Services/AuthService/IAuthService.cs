namespace WebApiWithAuth.Server.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> RegisterAsync(User user, string password);
        Task<bool> UserExists(string email);
        Task<ServiceResponse<string>> LoginAsync(string email, string password);
        Task<ServiceResponse<bool>> ChangePasswordAsync(int userId, string newPassword);
    }
}
