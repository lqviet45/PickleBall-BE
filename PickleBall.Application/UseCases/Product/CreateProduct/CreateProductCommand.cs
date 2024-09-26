using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.Product;

namespace PickleBall.Application.UseCases.Product.CreateProduct;

public sealed class CreateProductCommand : IRequest<Result<ProductResponse>>
{
    public string ProductName { get; set; } = string.Empty;
    public string? Description { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public Guid CourtGroupId { get; set; }
}