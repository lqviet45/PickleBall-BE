using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.Product;

namespace PickleBall.Application.UseCases.Product.GetProduct;

public sealed class GetProductByCourtGroupIdQuery : IRequest<Result<List<ProductResponse>>>
{
    public Guid CourtGroupId { get; set; }
    public string Search { get; set; } = "";
}