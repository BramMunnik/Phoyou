namespace Phoyou.Services;

public class AuthService
{
    public bool Login(string email, string password)
    {
        return email == "test@phoyou.com" && password == "password";
    }
}
