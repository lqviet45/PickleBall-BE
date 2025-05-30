using FirebaseAdmin.Auth;
using PickleBall.Application.Abstractions;

namespace PickleBall.Application.Authentication;

internal sealed class AuthenticationService : IAuthenticationService
{
    public async Task<string> Register(string email, string password)
    {
        var userArgs = new UserRecordArgs { Email = email, Password = password };

        var userRecord = await FirebaseAuth.DefaultInstance.CreateUserAsync(userArgs);

        return userRecord.Uid;
    }

    public async Task DeleteUser(string userId)
    {
        await FirebaseAuth.DefaultInstance.DeleteUserAsync(userId);
    }

    public async Task SetCustomClaims(string userId, Dictionary<string, object> claims)
    {
        await FirebaseAuth.DefaultInstance.SetCustomUserClaimsAsync(userId, claims);
    }
}
