using Ardalis.Result;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.DTOs.Product;

namespace PickleBall.Application.UseCases.Product.GetProduct;

public sealed class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Result<GetProductByIdResponse>>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetProductByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<Result<GetProductByIdResponse>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var product = await _productRepository.GetEntityByConditionAsync(
            p => p.Id == request.ProductId,
            false,
            cancellationToken,
            p => p.Include(pd => pd.CourtGroup)
        );
        
        if (product is null)
        {
            return Result<GetProductByIdResponse>.NotFound();
        }
        
        var productResponse = _mapper.Map<GetProductByIdResponse>(product);
        
        return Result<GetProductByIdResponse>.Success(productResponse);
    }
}