namespace PickleBall.Application.Abstractions;

public interface IAuthenticationService
{
    Task<string> Register(string email, string password);

    Task SetCustomClaims(string userId, Dictionary<string, object> claims);
}
