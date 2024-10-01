using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.Product;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.Product.GetProduct;

public sealed record GetAllProductQuery(
    int PageNumber = 1,
    int PageSize = 10,
    string Search = ""
) : IRequest<Result<PagedList<ProductResponse>>>;
