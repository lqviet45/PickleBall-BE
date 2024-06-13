using Google.Cloud.Storage.V1;
using Microsoft.AspNetCore.Http;
using PickleBall.Contract.Abstractions.Services;

namespace PickleBall.Infrastructure.Services.UploadFile;

public class FirebaseStorageService : IFirebaseStorageService
{
    private readonly StorageClient _storageClient;

    // the bucketName the sava on firebase
    private const string BucketName = "pickleball-991d5.appspot.com";

    public FirebaseStorageService(StorageClient storageClient)
    {
        _storageClient = storageClient;
    }

    public async Task<string> UploadFile(string name, IFormFile file)
    {
        // Create the Guid to make the name of image unique
        var randomGuid = Guid.NewGuid();

        using var stream = new MemoryStream();
        await file.CopyToAsync(stream);

        // Uploading image to FireBase
        var image = await _storageClient.UploadObjectAsync(
            BucketName,
            $"images/ticket/{name}-{randomGuid}",
            file.ContentType,
            stream
        );

        //Get the image URI to get on the client the img
        var photoUri = image.MediaLink;

        return photoUri;
    }

    //This is the test method please note this when you use
    public async Task<string> UploadFile(string name, IFormFile file, string folderSave)
    {
        // Create the Guid to make the name of image unique
        var randomGuid = Guid.NewGuid();

        using var stream = new MemoryStream();
        await file.CopyToAsync(stream);

        // Uploading image to FireBase
        var image = await _storageClient.UploadObjectAsync(
            BucketName,
            $"images/{folderSave}/{name}-{randomGuid}",
            file.ContentType,
            stream
        );

        //Get the image URI to get on the client the img
        var photoUri = image.MediaLink;

        return photoUri;
    }
}
