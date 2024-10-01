using Ardalis.Result;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.DTOs.Product;

namespace PickleBall.Application.UseCases.Product.GetProduct;

public sealed class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Result<ProductResponse>>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetProductByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<Result<ProductResponse>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var product = await _productRepository.GetEntityByConditionAsync(
            p => p.Id == request.ProductId,
            false,
            cancellationToken,
            p => p.Include(p => p.CourtGroup)
        );
        
        if (product is null)
        {
            return Result<ProductResponse>.NotFound();
        }
        
        var productResponse = _mapper.Map<ProductResponse>(product);
        
        return Result<ProductResponse>.Success(productResponse);
    }
}