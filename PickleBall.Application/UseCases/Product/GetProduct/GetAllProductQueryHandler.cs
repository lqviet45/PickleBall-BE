using Ardalis.Result;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.DTOs.Product;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.Product.GetProduct;

public sealed class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, Result<PagedList<ProductResponse>>>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetAllProductQueryHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<Result<PagedList<ProductResponse>>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
    {
        var productQuery = _productRepository.GetQueryable();
        
        var productResponses = await productQuery
            .Where(p => p.ProductName!.Contains(request.Search) 
                        && p.IsDeleted == false
                        && p.CourtGroup.IsDeleted == false)
            .Select(p => _mapper.Map<ProductResponse>(p))
            .ToListAsync(cancellationToken: cancellationToken);

        return Result<PagedList<ProductResponse>>.Success(PagedList<ProductResponse>
            .ToPagedList(productResponses, request.PageNumber, request.PageSize));
    }
}