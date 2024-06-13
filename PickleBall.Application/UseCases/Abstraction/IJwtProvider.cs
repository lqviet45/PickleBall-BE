namespace PickleBall.Application.UseCases.Abstraction;

public interface IJwtProvider
{
    Task<string> GetForCredentialsAsync(string email, string password);
}
