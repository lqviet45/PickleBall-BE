using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.Product;

namespace PickleBall.Application.UseCases.Product.UpdateProduct;

public class UpdateProductCommand : IRequest<Result<ProductResponse>>
{
    public Guid Id { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
    public string? Description { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}