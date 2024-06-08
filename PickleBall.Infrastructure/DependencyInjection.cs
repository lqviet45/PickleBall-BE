using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Microsoft.Extensions.DependencyInjection;
using PickleBall.Application.Abstractions;
using PickleBall.Application.Authentication;

namespace PickleBall.Infrastructure;

public static class DependencyInjection
{
    public static void AddFireBase(this IServiceCollection services)
    {
        FirebaseApp.Create(
            new AppOptions { Credential = GoogleCredential.FromFile("firebase.json") }
        );

        services.AddSingleton<IAuthenticationService, AuthenticationService>();
    }
}
