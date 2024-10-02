using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetTotalUser;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.ApplicationUser.GetTotalUser;

public class GetTotalUserEndPoint 
    : EndpointBaseAsync.WithRequest<GetTotalUserQuery>.WithActionResult
{
    private readonly ISender _sender;

    public GetTotalUserEndPoint(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    [Route("/api/total-user")]
    [SwaggerOperation(
        Summary = "Get total user",
        Description = "Get total user",
        Tags = new[] { "ApplicationUser" }
    )]
    public override async Task<ActionResult> HandleAsync([FromQuery] GetTotalUserQuery request, CancellationToken cancellationToken = new CancellationToken())
    {
        var result = await _sender.Send(request, cancellationToken);
        
        return result.IsSuccess
            ? Ok(result)
            : BadRequest(result);
    }
}