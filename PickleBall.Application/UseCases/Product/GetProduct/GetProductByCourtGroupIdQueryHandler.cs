using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.DTOs.Product;

namespace PickleBall.Application.UseCases.Product.GetProduct;

public sealed class GetProductByCourtGroupIdQueryHandler
    : IRequestHandler<GetProductByCourtGroupIdQuery, Result<List<ProductResponse>>>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetProductByCourtGroupIdQueryHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<Result<List<ProductResponse>>> Handle(GetProductByCourtGroupIdQuery request, CancellationToken cancellationToken)
    {
        var products = await _productRepository.GetEntitiesByConditionAsync(
            p => p.CourtGroupId == request.CourtGroupId,
            false,
            cancellationToken
        );
        
        var productResponses = _mapper.Map<List<ProductResponse>>(products);
        
        return Result<List<ProductResponse>>.Success(productResponses);
    }
}