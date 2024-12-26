namespace CustomAuth.Services
{
    public interface IJwtAuthenticationService
    {
        string Authenticate(string email, string password);
    }
}
