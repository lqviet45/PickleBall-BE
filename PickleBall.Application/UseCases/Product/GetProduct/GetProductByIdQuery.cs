using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.Product;

namespace PickleBall.Application.UseCases.Product.GetProduct;

public sealed class GetProductByIdQuery : IRequest<Result<ProductResponse>>
{
    public Guid ProductId { get; set; }
}