using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.DTOs.Product;

namespace PickleBall.Application.UseCases.Product.CreateProduct;

public sealed class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Result<ProductResponse>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public CreateProductCommandHandler(IUnitOfWork unitOfWork, IProductRepository productRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<Result<ProductResponse>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Domain.Entities.Product()
        {
            ProductName = request.ProductName,
            Description = request.Description,
            Quantity = request.Quantity,
            Price = request.Price,
            CourtGroupId = request.CourtGroupId
        };
        
        _productRepository.AddAsync(product);
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        
        var productResponse = _mapper.Map<ProductResponse>(product);
        
        return Result<ProductResponse>.Success(productResponse);
    }
}