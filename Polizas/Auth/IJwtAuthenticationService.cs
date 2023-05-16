namespace Polizas.Auth
{
    public interface IJwtAuthenticationService
    {
        string Authenticate(string id);
    }
}
