using System.IdentityModel.Tokens.Jwt;
using System.Text;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using PickleBall.Application.Abstractions;
using PickleBall.Application.Authentication;
using PickleBall.Application.UseCases.Abstraction;
using PickleBall.Contract.Abstractions.Services;
using PickleBall.Infrastructure.Authentication;
using PickleBall.Infrastructure.Services.UploadFile;

namespace PickleBall.Infrastructure;

public static class DependencyInjection
{
    public static void AddFireBase(this IServiceCollection services, IConfiguration configuration)
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

        services.AddHttpClient<IJwtProvider, JwtProvider>(
            (sp, httpClient) =>
            {
                var config = sp.GetRequiredService<IConfiguration>();

                httpClient.BaseAddress = new Uri(config["Authentication:TokenUri"]);
            }
        );

        services
            .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, o =>
            {
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = configuration["Authentication:ValidIssuer"],
                    ValidAudience = configuration["Authentication:Audience"],
                    ValidateIssuerSigningKey = false
                };
            });
    }
}
