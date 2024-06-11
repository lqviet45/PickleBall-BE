using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using Microsoft.Extensions.DependencyInjection;
using PickleBall.Application.Abstractions;
using PickleBall.Application.Authentication;
using PickleBall.Contract.Abstractions.Services;
using PickleBall.Infrastructure.Services.UploadFile;

namespace PickleBall.Infrastructure;

public static class DependencyInjection
{
    public static void AddFireBase(this IServiceCollection services)
    {
        services.AddSingleton<IFirebaseStorageService>(s => new FirebaseStorageService(
            StorageClient.Create()
        ));

        FirebaseApp.Create(
            new AppOptions { Credential = GoogleCredential.FromFile("firebase.json") }
        );

        var fileName = "firebase.json";
        Environment.SetEnvironmentVariable(
            "GOOGLE_APPLICATION_CREDENTIALS",
            @Path.Combine(Environment.CurrentDirectory, fileName)
        );

        services.AddSingleton<IAuthenticationService, AuthenticationService>();
    }
}
