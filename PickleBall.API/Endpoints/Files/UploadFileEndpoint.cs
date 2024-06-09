using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Contract.Abstractions.Services;

namespace PickleBall.API.Endpoints.Files
{
    public record UploadFileRequest(string Name, IFormFile File);

    public class UploadFileEndpoint : EndpointBaseAsync.WithRequest<UploadFileRequest>.WithActionResult
    {
        private readonly IFirebaseStorageService _firebaseStorageService;

        public UploadFileEndpoint(IFirebaseStorageService firebaseStorageService)
        {
            _firebaseStorageService = firebaseStorageService;
        }
        [HttpPost]
        [Route("/api/files/upload")]
        public override async Task<ActionResult> HandleAsync([FromForm] UploadFileRequest request, CancellationToken cancellationToken = default)
        {
            string uri = await _firebaseStorageService.UploadFile(request.Name, request.File);
            return Ok(uri);
        }
    }
}
